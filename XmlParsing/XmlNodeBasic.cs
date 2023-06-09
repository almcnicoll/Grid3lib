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
        private List<string> __InnerXml = new List<string>();
        private IXmlNode? __Parent = null;
        private List<IXmlNode> __Children = new List<IXmlNode>();

        /// <summary>
        /// Creates an empty node
        /// </summary>
        public XmlNodeBasic() { }

        protected virtual void OnChildrenPopulated(EventArgs e)
        {
            ChildrenPopulated?.Invoke(this, e);
        }

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
            Dictionary<string, string> AttributesDictionary = new Dictionary<string, string>();
            if (xpr.BaseTagAttributes.Length > 0)
            {
                MatchCollection mc = XmlParseFunctions.rxAttributes.Matches(xpr.BaseTagAttributes);
                if (mc != null)
                {
                    foreach (Match m in mc)
                    {
                        AttributesDictionary.Add(m.Groups["Key"].Value, m.Groups["Value"].Value);
                    }
                    if (AttributesDictionary.Count > 0) { SetAttributes(AttributesDictionary); } // TODO - check that this will call subclass function on subclass nodes
                }
            }

            // Set contents
            SetContents(xpr.BaseTagContents);

            // Now populate children if appropriate
            if (PopulateChildren)
            {
                foreach (string childXml in xpr.BaseTagContents)
                {
                    IXmlNode child = XmlNodeBasic.CreateFromXml(childXml, PopulateChildren);
                    child.Parent = this;
                    __Children.Add(child);
                }
                OnChildrenPopulated(new EventArgs());
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

        public List<string> InnerXml
        {
            get
            {
                return __InnerXml;
            }
            set
            {
                __InnerXml = value.ToList();
            }
        }

        public string? InnerXmlString
        {
            get
            {
                return String.Join("", __InnerXml);
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

        public event EventHandler ChildrenPopulated;

        /// <summary>
        /// Creates an <see cref="IXmlNode"/> from XML markup
        /// </summary>
        /// <param name="Xml">The XML to parse</param>
        /// <param name="PopulateChildren">Whether to populate child nodes as well as the base node</param>
        /// <returns>An object implementing <see cref="IXmlNode"/>, either generic or tag-specific depending on the base tag</returns>
        /// <exception cref="NotImplementedException"></exception>
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

            return node;
        }

        /// <summary>
        /// Sets the attributes of the node from the string KVPs, and runs any resulting processes
        /// </summary>
        /// <param name="Attributes">A dictionary of attribute keys and values</param>
        public virtual void SetAttributes(Dictionary<string, string> Attributes)
        {
            // Clone the passed dictionary
            __Attributes = Attributes.ToDictionary(entry => entry.Key, entry => entry.Value);
        }

        /// <summary>
        /// Sets the content of the node from the list of XML strings, and runs any resulting processes
        /// </summary>
        /// <param name="Contents">A list of valid XML strings</param>
        public virtual void SetContents(List<string> Contents)
        {
            // Create the InnerXml list
            __InnerXml = Contents.ToList();
        }

        /// <summary>
        /// Returns a list of all child nodes of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of node to look for</typeparam>
        /// <param name="Depth">The number of levels below the immediate children in which to search. If Depth is negative, all levels will be evaluated.</param>
        /// <returns>A list of <see cref="IXmlNode"/> child nodes of type <typeparamref name="T"/></returns>
        public List<T> ChildrenOfType<T>(int Depth = 0) where T : IXmlNode
        {
            List<T> thisLevelAndBelow = Children.OfType<T>().ToList();
            // If Depth is positive, recurse another level; if Depth is negative, recurse until there are no more child nodes
            if (Depth != 0 && Children.Count > 0)
            {
                thisLevelAndBelow.AddRange(ChildrenOfType<T>(Depth - 1));
            }

            return thisLevelAndBelow;
        }

        /// <summary>
        /// Returns the node's XML markup, including the markup of any child nodes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string Opener = String.Format("<{0} {1}>", TagName,
                (from KeyValuePair<string, string> kvp in Attributes select String.Format(" {0}=\"{1}\" ", kvp.Key, kvp.Value.Replace("\"", "\\" + "\"")))
                );
            string Contents = String.Join(Environment.NewLine, (from IXmlNode child in Children select child.ToString()));
            return Opener + Environment.NewLine + Contents + Environment.NewLine + this.TagClosure;
        }
    }
}
