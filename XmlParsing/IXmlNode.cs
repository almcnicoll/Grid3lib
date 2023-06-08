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
        public string? InnerXml { get; set; }

        /// <summary>
        /// This node's parent node
        /// </summary>
        public IXmlNode? Parent { get; set; }

        /// <summary>
        /// A <see cref="List{IXmlNode}"/> of child nodes
        /// </summary>
        public List<IXmlNode> Children { get; }

        /// <summary>
        /// Parses the specified XML and returns the node object
        /// </summary>
        /// <param name="Xml">The XML from which to populate the object</param>
        /// <returns>A node object implementing <see cref="IXmlNode"/></returns>
        public void PopulateFromXml(string Xml,bool PopulateChildren);
        
        /// <summary>
        /// Returns a string of the XML for this node and any child nodes
        /// </summary>
        /// <returns></returns>
        public string ToString();
    }
}
