using System;
using System.Collections.Generic;
using System.Text;

namespace XmlParsing
{
    public class XmlParseResult
    {
        public string BaseTagName { get; set; }
        public string BaseTagAttributes { get; set; } = "";
        public List<string> BaseTagContents { get; set; } = new List<string>();
        public bool SelfClosing { get; set; } = false;
        public bool IsCDATA { get; set; } = false;

        public XmlParseResult(string baseTagName)
        {
            BaseTagName = baseTagName;
        }
    }
}
