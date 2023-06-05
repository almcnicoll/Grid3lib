using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        /// Creates an XML node from the specified XML markup
        /// </summary>
        /// <param name="Xml"></param>
        public XmlNodeBasic(string Xml, bool PopulateChildren = true) { 

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


        public IXmlNode Parse(string Xml)
        {
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
