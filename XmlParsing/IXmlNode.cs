using System;
using System.Collections.Generic;

namespace XmlParsing
{
    public interface IXmlNode
    {
        /// <summary>
        /// Whether or not the Xml specifying the node has been parsed
        /// </summary>
        public bool Parsed { get; }

        /// <summary>
        /// The tag name
        /// </summary>
        public string? TagName { get; }

        /// <summary>
        /// The string describing the opening tag and any attributes
        /// </summary>
        public string? TagString { get; }

        /// <summary>
        /// The string describing the closing tag
        /// </summary>
        public string? TagClosure { get; }

        /// <summary>
        /// A <see cref="Dictionary{string, string}"/> of tag attributes
        /// </summary>
        public Dictionary<string, string> Attributes { get; }

        /// <summary>
        /// A string containing any XML contained within the tag
        /// </summary>
        public string? InnerXmlString { get; }

        /// <summary>
        /// A string containing any XML contained within the tag
        /// </summary>
        public List<RawXml> InnerXml { get; set; }

        /// <summary>
        /// This node's parent node
        /// </summary>
        public IXmlNode? Parent { get; set; }

        /// <summary>
        /// A <see cref="List{IXmlNode}"/> of child nodes
        /// </summary>
        public List<IXmlNode> Children { get; }

        /// <summary>
        /// Returns a list of all child nodes of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The type of node to look for</typeparam>
        /// <param name="Depth">The number of levels below the immediate children in which to search</param>
        /// <returns>A list of <see cref="IXmlNode"/> child nodes of type <typeparamref name="T"/></returns>
        public List<T> ChildrenOfType<T>(int Depth) where T : IXmlNode;

        /// <summary>
        /// Parses the specified XML and returns the node object
        /// </summary>
        /// <param name="Xml">The XML from which to populate the object</param>
        /// <returns>A node object implementing <see cref="IXmlNode"/></returns>
        public void PopulateFromXml(string Xml, int PopulateToDepth);

        /// <summary>
        /// Sets the attributes of the specified node
        /// </summary>
        /// <param name="Attributes">A <see cref="Dictionary{string,string}"/> of attributes</param>
        public void SetAttributes(Dictionary<string, string> Attributes);

        /// <summary>
        /// Sets the attributes of the specified node
        /// </summary>
        /// <param name="Contents">The contents of the node, as a list of <see cref="RawXml"/> objects</param>
        public void SetContents(List<RawXml> Contents);

        public event EventHandler ChildrenPopulated;

        /// <summary>
        /// Returns a string of the XML for this node and any child nodes
        /// </summary>
        /// <returns></returns>
        public string ToString();

        /// <summary>
        /// Sets the tag name
        /// </summary>
        /// <param name="TagName">The name of the Xml tag</param>
        public void SetTagName(string? TagName);
    }
}
