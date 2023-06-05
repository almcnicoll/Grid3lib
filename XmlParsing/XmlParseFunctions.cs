using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace XmlParsing
{
    public static class XmlParseFunctions
    {
        // NB - special characters requiring escaping:      . $ ^ { [ ( | ) * + ? \

        internal static Regex rxDocType = new Regex(@"^<\?xml\s+version=""1.0""\?>\s*",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxSelfClosingTag = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*/>$",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxOpeningTag = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*>",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxOpeningAndClosingTagsOnly = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*>(?<TagContents>.*?)</\k<TagName>>$",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxOpeningAndClosingTagsMultiple = new Regex(@"^(?<WholeString><(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*>(?<TagContents>.*?)</\k<TagName>>\s*)",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxCDATA = new Regex(@"^<!\[CDATA\[(?<CharacterData>.*)]]>",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);

        /// <summary>
        /// Check whether the specified XML is valid
        /// <paramref name="Xml">The XML string to parse</param>
        /// </summary>
        /// <returns>A list of all errors encountered, or null if the validation was successful</returns>
        public static List<Exception>? ValidateXml(string Xml)
        {
            List<Exception> errors = new List<Exception>(); // If needed

            if (String.IsNullOrWhiteSpace(Xml)) { return null; }

            // Ignore leading / trailing whitespace
            Xml = Xml.Trim();

            // Check for opening declaration - eg <?xml version="1.0"?> - and strip it
            if (rxDocType.IsMatch(Xml))
            {
                Xml = rxDocType.Replace(Xml, "");
            }

            if (rxCDATA.IsMatch(Xml)) { return null; }
            if (rxSelfClosingTag.IsMatch(Xml)) { return null; } // Self-closing tag: simples
            if (rxOpeningAndClosingTagsOnly.IsMatch(Xml))
            {
                // NB might contain multiple nodes, so can't just validate them all in one
                // Check whether contained Xml is valid
                Match m = rxOpeningAndClosingTagsOnly.Match(Xml);
                string TagContents = m.Groups["TagContents"].Value;

                MatchCollection mc = rxOpeningAndClosingTagsMultiple.Matches(TagContents.Trim());
                foreach (Match m2 in mc)
                {
                    List<Exception>? newErrors = ValidateXml(m2.Groups["WholeString"].Value);
                    if (newErrors != null) { errors.AddRange(newErrors); }
                }
                // Check whether there's any invalid Xml between
                string junk = rxOpeningAndClosingTagsMultiple.Replace(TagContents, "");
                if (String.IsNullOrWhiteSpace(junk))
                {
                    string TagName = m.Groups["TagName"].Value;
                    errors.Add(new Exception(String.Format("Found invalid Xml inside {0} tag: {1}", TagName, junk.Substring(0, 20) + "...")));
                }
                return (errors.Count == 0) ? null : errors;
            }
            else
            {
                if (rxOpeningTag.IsMatch(Xml))
                {
                    Match m = rxOpeningTag.Match(Xml);
                    string TagName = m.Groups["TagName"].Value;
                    errors.Add(new Exception(String.Format("Could not find a closing tag for <{0}>", TagName)));
                }
                else
                {
                    errors.Add(new Exception("Could not find a valid opening tag in XML beginning " + Xml.Substring(0, 20) + "..."));
                }
                return (errors.Count == 0) ? null : errors;
            }
        }
    }
}
