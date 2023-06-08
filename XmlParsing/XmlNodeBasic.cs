using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace XmlParsing
{
    public class XmlNodeBasic : IXmlNode
    {
        private bool __Parsed = false;
        private string? __TagName = null;
        private string? __TagString = null;
        private Dictionary<string, string> __Attributes = new Dictionary<string, string>();
        private string? __InnerXml = null;
        private IXmlNode? __Parent = null;
        private List<IXmlNode> __Children = new List<IXmlNode>();

        /// <summary>
        /// Creates an empty node
        /// </summary>
        public XmlNodeBasic() { }

        /// <summary>
        /// Fills the XML node from the specified XML markup
        /// </summary>
        /// <param name="Xml">The source XML</param>
        /// <param name="PopulateChildren">Whether to populate the child nodes also</param>
        public virtual void PopulateFromXml(string Xml, bool PopulateChildren = true)
        {
            // TODO - parse and process XML

            // Parse the first XML layer
            XmlParseResult xpr = XmlParseFunctions.ParseSingleXmlLevel(Xml);

            __TagName = xpr.BaseTagName;
            // TODO - TagString, TagClosure

            // Set attributes dictionary
            if (xpr.BaseTagAttributes.Length > 0)
            {
                MatchCollection mc = XmlParseFunctions.rxAttributes.Matches(xpr.BaseTagAttributes);
                if (mc != null)
                {
                    foreach (Match m in mc)
                    {
                        __Attributes.Add(m.Groups["Key"].Value, m.Groups["Value"].Value);
                    }
                }
            }

            __InnerXml = String.Join("", xpr.BaseTagContents); // It's a flat string

            // Now populate children if appropriate
            if (PopulateChildren)
            {
                foreach (string childXml in xpr.BaseTagContents)
                {
                    IXmlNode child = XmlNodeBasic.CreateFromXml(childXml, PopulateChildren);
                    child.Parent = this;
                    __Children.Add(child);
                }
            }

            // Set node as parsed
            __Parsed = true;
        }

        public bool Parsed
        {
            get
            {
                return __Parsed;
            }
            set
            {
                __Parsed = value;
            }
        }

        public string? TagName
        {
            get
            {
                return __TagName;
            }
        }

        public string? TagString { get { return __TagString; } }

        public string? TagClosure
        {
            get
            {
                return String.Format("</{0}>", TagName);
            }
        }

        public Dictionary<string, string> Attributes
        {
            get { return __Attributes; }
        }

        public string? InnerXml
        {
            get
            {
                return __InnerXml;
            }
            set
            {
                __InnerXml = value;
            }
        }

        public IXmlNode? Parent
        {
            get
            {
                return __Parent;
            }
            set
            {
                __Parent = value;
            }
        }

        public List<IXmlNode> Children
        {
            get
            {
                return __Children;
            }
        }


        public static IXmlNode CreateFromXml(string Xml, bool PopulateChildren = true)
        {
            IXmlNode node;

            // Parse the first XML layer and get the tag name
            XmlParseResult xpr = XmlParseFunctions.ParseSingleXmlLevel(Xml);

            if (xpr.IsCDATA)
            {
                // TODO - check if CDATA, and if so return a special type of IXmlNode perhaps?
                // Certainly don't keep parsing
            }

            // Now check if we have a specific node class for this tag
            Type tagNodeType = Type.GetType("Grid3lib.XmlNodeTag." + xpr.BaseTagName);

            if (tagNodeType == null)
            {
                // No - create generic node
                // Actual serious parsing of Xml will happen here
                node = new XmlNodeBasic();
            }
            else
            {
                node = (IXmlNode)Activator.CreateInstance(tagNodeType);
            }

            // Actual serious parsing of Xml will happen here
            node.PopulateFromXml(Xml, PopulateChildren);

            throw new NotImplementedException();
        }

        public string ToString()
        {
            string Opener = String.Format("<{0} {1}>", TagName,
                (from KeyValuePair<string, string> kvp in Attributes select String.Format(" {0}=\"{1}\" ", kvp.Key, kvp.Value.Replace("\"", "\\" + "\"")))
                );
            string Contents = String.Join(Environment.NewLine, (from IXmlNode child in Children select child.ToString()));
            return Opener + Environment.NewLine + Contents + Environment.NewLine + this.TagClosure;
        }
    }
}
