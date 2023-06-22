using System;
using System.Collections.Generic;
using System.Text;

namespace XmlParsing
{
    public class XmlParseResult
    {
        public string BaseTagName { get; set; }
        public string BaseTagAttributes { get; set; } = "";
        public List<RawXml> BaseTagContents { get; set; } = new List<RawXml>();
        public bool SelfClosing { get; set; } = false;
        public bool IsCDATA { get; set; } = false;

        public XmlParseResult(string baseTagName)
        {
            BaseTagName = baseTagName;
        }
    }
}
