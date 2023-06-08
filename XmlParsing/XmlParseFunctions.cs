using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace XmlParsing
{
    public static class XmlParseFunctions
    {
        // NB - special characters requiring escaping:      . $ ^ { [ ( | ) * + ? \

        public static Regex rxDocType = new Regex(@"^<\?xml\s+version=""1.0""\?>\s*",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        public static Regex rxSelfClosingTag = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\s*(?<TagAttributes>[^>]*)/>$",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        public static Regex rxOpeningTag = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*>",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        public static Regex rxOpeningAndClosingTagsOnly = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\s*(?<TagAttributes>[^>]*)>(?<TagContents>.*?)</\k<TagName>>$",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        public static Regex rxOpeningAndClosingTagsMultiple = new Regex(@"(?<WholeString><(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*>(?<TagContents>.*?)</\k<TagName>>\s*)|(?<WholeString><!\[(?<TagName>CDATA)\[(?<CharacterData>.*)]]>\s*)",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        public static Regex rxCDATA = new Regex(@" ^<!\[CDATA\[(?<CharacterData>.*)]]>",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        public static Regex rxAttributes = new Regex(@"\s*(?<Key>[\w_][\w\d_\-.:]+)=""(?<Value>[^""]*?)""\s*",
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


        /// <summary>
        /// Parses the first level of the XML provided, returning metadata and contents
        /// <paramref name="Xml">The XML string to parse</param>
        /// </summary>
        /// <returns>An <see cref="XmlParseResult"/> containing the metadata and contents</returns>
        public static XmlParseResult ParseSingleXmlLevel(string Xml)
        {
            XmlParseResult result;
            string BaseTagName = "";

            if (String.IsNullOrWhiteSpace(Xml)) { throw new Exception("String was null, empty or whitespace only"); }

            // Ignore leading / trailing whitespace
            Xml = Xml.Trim();

            // Check for opening declaration - eg <?xml version="1.0"?> - and strip it
            if (rxDocType.IsMatch(Xml))
            {
                Xml = rxDocType.Replace(Xml, "");
            }

            if (rxCDATA.IsMatch(Xml))
            {
                // CDATA node: simples
                result = new XmlParseResult("");
                result.IsCDATA = true;
                return result;
            }
            if (rxSelfClosingTag.IsMatch(Xml))
            {
                // Self-closing tag: simples
                Match m = rxSelfClosingTag.Match(Xml);
                BaseTagName = m.Groups["TagName"].Value;
                result = new XmlParseResult(BaseTagName);
                result.BaseTagAttributes = m.Groups["TagAttributes"].Value;
                result.SelfClosing = true;
                return result;
            }
            if (rxOpeningAndClosingTagsOnly.IsMatch(Xml))
            {
                // Retrieve base tag info
                Match m = rxOpeningAndClosingTagsOnly.Match(Xml);
                BaseTagName = m.Groups["TagName"].Value;
                result = new XmlParseResult(BaseTagName);
                result.BaseTagAttributes = m.Groups["TagAttributes"].Value;

                // Retrieve contained nodes / strings as list
                string TagContents = m.Groups["TagContents"].Value;
                List<string> BaseTagContents = new List<string>();

                MatchCollection mc = rxOpeningAndClosingTagsMultiple.Matches(TagContents.Trim());
                foreach (Match m2 in mc)
                {
                    BaseTagContents.Add(m2.Groups["WholeString"].Value);
                    if (BaseTagContents.Count > 0) { result.BaseTagContents.AddRange(BaseTagContents); }
                }
                return result;
            }
            else
            {
                if (rxOpeningTag.IsMatch(Xml))
                {
                    Match m = rxOpeningTag.Match(Xml);
                    string TagName = m.Groups["TagName"].Value;
                    throw new Exception(String.Format("XML provided does not validate - cannot find closure for base tag {0}", TagName));
                }
                else
                {
                    throw new Exception("XML provided does not validate - cannot find a valid base tag");
                }

            }
        }
    }
}
