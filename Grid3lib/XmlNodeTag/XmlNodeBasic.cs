using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using Grid3lib;
using System.Runtime.InteropServices;
using Grid3lib.XmlNodeTag;

namespace XmlParsing
{
    /// <summary>
    /// A basic node class which can be instantiated to represent an XML node, or extended to support custom XML tags
    /// </summary>
    public class XmlNodeBasic : IXmlNode
    {
        internal bool __Parsed = false;
        internal string? __TagName = null;
        internal string? __TagString = null;
        internal Dictionary<string, string> __Attributes = new Dictionary<string, string>();
        internal List<RawXml> __InnerXml = new List<RawXml>();
        internal IXmlNode? __Parent = null;
        internal List<IXmlNode> __Children = new List<IXmlNode>();

        // TODO - test lazy loading (implemented in theory!)
        // TODO - Make sure that this node is populated before trying to return any properties (as it can now be lazy-loaded)
        //      This code is in place for Children property, but may be needed elsewhere?
        // TODO - Think about ChildrenPopulated event firing on lazy-load

        /// <summary>
        /// Creates an empty node
        /// </summary>
        public XmlNodeBasic() { }

        // TODO - check that this event fires at the right time now that we're doing lazy loading
        /// <summary>
        /// Fires when child nodes have been populated
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnChildrenPopulated(EventArgs e)
        {
            ChildrenPopulated?.Invoke(this, e);
        }

        /// <summary>
        /// Whether or not the XML of this node (not necessarily its contents) has been parsed
        /// </summary>
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

        /// <summary>
        /// The XML tag name without angle-brackets
        /// </summary>
        public string? TagName
        {
            get
            {
                if (__TagName == null)
                {
                    if (this.GetType().Name != "XmlNodeBasic") { __TagName = this.GetType().Name; }
                    return __TagName;
                }
                else
                {
                    return __TagName;
                }
            }
        }

        /// <summary>
        /// The opening and closing tags, with angle-brackets and any attributes
        /// </summary>
        public string? TagString { get { return __TagString; } }

        /// <summary>
        /// The closing tag syntax, with angle-brackets
        /// </summary>
        public string? TagClosure
        {
            get
            {
                return String.Format("</{0}>", TagName);
            }
        }

        /// <summary>
        /// Represents all attributes associated with the node
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return __Attributes; }
        }

        /// <summary>
        /// A list of XML strings representing the node's contents
        /// </summary>
        public List<RawXml> InnerXml
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

        /// <summary>
        /// The raw XML of the node's contents
        /// </summary>
        public string? InnerXmlString
        {
            get
            {
                return String.Join("", __InnerXml);
            }
        }

        /// <summary>
        /// The parent XML node
        /// </summary>
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

        /// <summary>
        /// A <see cref="List{IXmlNode}"/> of child nodes
        /// </summary>
        public List<IXmlNode> Children
        {
            get
            {
                // Make sure all our children are parsed
                List<RawXml> unparsed = (from RawXml rawChild in __InnerXml where rawChild.Parsed == false select rawChild).ToList();
                foreach (RawXml rawChild in unparsed)
                {
                    // Populate this child node if it's XML
                    if (XmlParseFunctions.rxOpeningTag.IsMatch(rawChild.Markup.Trim()))
                    {
                        IXmlNode xmlNode = AddChildFromXml(rawChild.Markup, 0);
                    }
                    rawChild.Parsed = true;
                }
                // __Children.Sort(XmlUtility.SortTagNameAscending()); // No longer desirable
                return __Children;
            }
        }

        /// <summary>
        /// Raised when all child nodes have been populated
        /// </summary>
        public event EventHandler? ChildrenPopulated;

        /// <summary>
        /// Fills the XML node from the specified XML markup
        /// </summary>
        /// <param name="Xml">The source XML</param>
        /// <param name="PopulateToDepth">The depth of child nodes to populate</param>
        public virtual void PopulateFromXml(string Xml, int PopulateToDepth = 0)
        {
            // Parse the first XML layer
            XmlParseResult xpr = XmlParseFunctions.ParseSingleXmlLevel(Xml);

            __TagName = xpr.BaseTagName;

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

            string AllAttributes = String.Join(" ", (from KeyValuePair<string, string> kvp in AttributesDictionary select String.Format("{0}=\"{1}\"", kvp.Key, kvp.Value.Replace("\"", "&quot;"))));
            if (AllAttributes.Trim().Length > 0) { AllAttributes = " " + AllAttributes.Trim(); }
            __TagString = String.Format("<{0}{1}></{0}>", TagName, AllAttributes);

            // Set contents
            SetContents(xpr.BaseTagContents);

            // Now populate children if appropriate

            foreach (RawXml childXml in xpr.BaseTagContents)
            {
                if (!XmlParseFunctions.rxOpeningTag.IsMatch(childXml.Markup)) { childXml.Parsed = true; continue; } // Don't parse text nodes - leave them as contents

                if (PopulateToDepth == 0)
                {
                    // We don't want to parse this now (lazy loading)
                }
                else
                {
                    // Parse away!
                    AddChildFromXml(childXml.Markup, PopulateToDepth - 1);
                    childXml.Parsed = true;
                }
            }
            OnChildrenPopulated(new EventArgs());


            // Set node as parsed
            __Parsed = true;
        }

        /// <summary>
        /// Sets the tag name
        /// </summary>
        /// <param name="TagName">The name of the Xml tag</param>
        public void SetTagName(string? TagName)
        {
            __TagName = TagName;
        }

        /// <summary>
        /// Creates an <see cref="IXmlNode"/> from XML markup
        /// </summary>
        /// <param name="Xml">The XML to parse</param>
        /// <param name="PopulateToDepth">The depth of child nodes to populate</param>
        /// <returns>An object implementing <see cref="IXmlNode"/>, either generic or tag-specific depending on the base tag</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static IXmlNode CreateFromXml(string Xml, int PopulateToDepth = 0)
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
                if (tagNodeType.GetConstructor(Type.EmptyTypes) == null)
                {
                    // We can only use parameterless constructors here
                    node = (IXmlNode)(new XmlNodeBasic());
                }
                else
                {
                    node = (IXmlNode)Activator.CreateInstance(tagNodeType);
                }
            }

            // Actual serious parsing of Xml will happen here
            node.PopulateFromXml(Xml, PopulateToDepth);

            node.SetTagName(xpr.BaseTagName);

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
        public virtual void SetContents(List<RawXml> Contents)
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
                foreach (IXmlNode childNode in Children)
                {
                    thisLevelAndBelow.AddRange(childNode.ChildrenOfType<T>(Depth - 1));
                }
            }

            return thisLevelAndBelow;
        }

        /// <summary>
        /// Returns the node's XML markup, including the markup of any child nodes
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string AttributesString = String.Join(" ",
                    from KeyValuePair<string, string> kvp in Attributes select String.Format(" {0}=\"{1}\" ", kvp.Key, kvp.Value.Replace("\"", "\\" + "\""))
                ).Trim();
            if (AttributesString.Length > 0) { AttributesString = " " + AttributesString; }
            string Opener = String.Format("<{0}{1}>", TagName, AttributesString);
            string Contents;
            if (Children.Count == 0)
            {
                Contents = InnerXmlString.BlankIfNull();
            }
            else
            {
                //Contents = String.Join(Environment.NewLine, (from IXmlNode child in Children select child.ToString()));
                Contents = String.Join("", (from IXmlNode child in Children select child.ToString()));
            }
            // Now allow for self-closing
            if (String.IsNullOrWhiteSpace(Contents))
            {
                return String.Format("<{0}{1} />", TagName, AttributesString);
            }
            //return Opener + Environment.NewLine + Contents + Environment.NewLine + this.TagClosure;
            return Opener + Contents + this.TagClosure;
        }

        /// <summary>
        ///  Returns the value of the specified attribute if set, otherwise null
        /// </summary>
        /// <param name="Key">The attribute to search for</param>
        /// <returns>A <see cref="string"/> of the attribute value, or null if the attribute is not set</returns>
        public string? GetAttributeValueOrNull(string Key)
        {
            if (Attributes.ContainsKey(Key))
            {
                return Attributes[Key];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///  Sets the value of the specified attribute, by either creating or editing
        /// </summary>
        /// <param name="Key">The attribute to set</param>
        /// <param name="Value">The desired value of that attribute</param>
        public void SetAttributeValue(string Key, string? Value)
        {
            if (Value == null)
            {
                if (Attributes.ContainsKey(Key)) { Attributes.Remove(Key); }
            }
            else
            {
                Attributes.AddOrEdit(Key, Value);
            }
        }

        /// <summary>
        /// Adds an empty child <see cref="IXmlNode"/> to the current one, of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of child node to create</typeparam>
        /// <returns>The created <see cref="IXmlNode"/></returns>
        public T AddChildOfType<T>(bool selfClosing = false) where T : IXmlNode
        {
            IXmlNode child;
            string tagName = typeof(T).Name;
            string xml;
            if (selfClosing)
            {
                xml = String.Format(@"<{0} />", tagName);
            }
            else
            {
                xml = String.Format(@"<{0}></{0}>", tagName);
            }
            child = AddChildFromXml(xml, 0);
            return (T)child;
        }

        /// <summary>
        /// Adds a child <see cref="IXmlNode"/> to the current one, using the supplied Xml
        /// </summary>
        /// <param name="childXml">The XML from which to populate the node</param>
        /// <param name="populateToDepth">How many layers deep to populate subnodes (0 will populate all layers)</param>
        /// <returns>The created <see cref="IXmlNode"/></returns>
        public IXmlNode AddChildFromXml(string childXml, int populateToDepth)
        {
            IXmlNode child = XmlNodeBasic.CreateFromXml(childXml, populateToDepth);
            child.Parent = this;
            __Children.Add(child);
            return child;
        }

        /// <summary>
        /// Gets or creates an immediate child node of the specified <see cref="IXmlNode"/>-implementing type. If there are fewer than <paramref name="index"/> nodes of the relevant type, a new one will be created.
        /// </summary>
        /// <typeparam name="T">The type of child node to create</typeparam>
        /// <param name="index">The index of the node to return, if there are multiple nodes</param>
        /// <returns>The found or created node</returns>
        public T GetOrCreateImmediateChild<T>(int index = 0) where T : IXmlNode, new()
        {
            if (Children.Count > 0)
            {
                // Check for valid children
                List<T> validChildren = ChildrenOfType<T>().ToList();
                if (validChildren.Count >= index + 1)
                {
                    return validChildren[index];
                }
            }
            T newNode = new T();
            newNode.Parent = this;
            this.__Children.Add(newNode);
            return newNode;
        }
    }
}
