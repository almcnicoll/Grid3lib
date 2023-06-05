using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace XmlParsing
{
    internal static class XmlParseFunctions
    {
        // NB - special characters requiring escaping:      . $ ^ { [ ( | ) * + ? \

        internal static Regex rxSelfClosingTag = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*/>$",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxOpeningTag = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*>",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxOpeningAndClosingTagsOnly = new Regex(@"^<(?<TagName>[A-Za-z][\w\d]*)\\s*[^>]*>(?<TagContents>.*?)</\1>$",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxOpeningAndClosingTags = new Regex(@"^(<(?<TagName>[A-Za-z][\w\d]*)\s*[^>]*>(?<TagContents>.*?)</\1>\s*)+",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);
        internal static Regex rxCDATA = new Regex(@"^<!\[CDATA\[(?<CharacterData>.*)]]>",
            RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Singleline);

        /// <summary>
        /// Check whether the specified XML is valid
        /// <paramref name="Xml">The XML string to parse</param>
        /// </summary>
        /// <returns>A list of all errors encountered, or null if the validation was successful</returns>
        internal static List<Exception>? ValidateXml(string Xml)
        {
            if (String.IsNullOrWhiteSpace(Xml)) { return null; }

            // Ignore leading / trailing whitespace
            Xml = Xml.Trim();

            if (rxCDATA.IsMatch(Xml)) { return null; }
            if (rxSelfClosingTag.IsMatch(Xml)) { return null; } // Self-closing tag: simples
            if (rxOpeningAndClosingTagsOnly.IsMatch(Xml))
            {
                // TODO - check contained XML - NB might contain multiple nodes, so can't just validate them all in one
                // Check whether contained Xml is valid
                Match m = rxOpeningAndClosingTagsOnly.Match(Xml);
                String TagContents = m.Groups["TagContents"].Value;

            }
            else
            {
                List<Exception> errors = new List<Exception>();
                // TODO - check if we have a valid opening tag but no matching closing tag
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
                return errors;
            }
            return null;
        }
    }
}
