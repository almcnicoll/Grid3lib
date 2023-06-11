using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Grid3lib.ToConvert
{

    [Serializable]
    public class RichTextR
    {
        private string __value;
        public System.Xml.XmlCDataSection Value
        {
            get { return new System.Xml.XmlDocument().CreateCDataSection(__value); }
            set { __value = value.Value; }
        }

        public RichTextR() { }
        public RichTextR(string str)
        {
            __value = str;
        }

        public override string ToString()
        {
            return Value.Value;
        }
    }

    [Serializable]
    public class RichTextSR
    {
        [XmlAttributeAttribute("Image")]
        public string Image { get; set; }

        public List<RichTextR> r { get; set; } = new List<RichTextR>();

        public RichTextSR() { }
        public RichTextSR(ImportClasses.ImportRichTextSR importRichTextSR)
        {
            foreach (string str in importRichTextSR.r)
            {
                r.Add(new RichTextR(str));
            }
            this.Image = importRichTextSR.Image;
        }

        public override string ToString()
        {
            string output = "";
            foreach (RichTextR rObj in r) { output += rObj.ToString(); }
            return output;
        }
    }

    [Serializable]
    public class RichTextPSR
    {
        public List<RichTextSR> s { get; set; } = new List<RichTextSR>();

        public RichTextPSR() { }
        public RichTextPSR(ImportClasses.ImportRichTextPSR importRichTextPSR)
        {
            foreach (ImportClasses.ImportRichTextSR importRichTextSR in importRichTextPSR.s)
            {
                this.s.Add(new RichTextSR(importRichTextSR));
            }
        }

        public override string ToString()
        {
            string output = "";
            foreach (RichTextSR sr in s) { output += s.ToString(); }
            return output;
        }
    }

    /// <summary>
    /// Contains any number of <![CDATA[<p>]]> or <![CDATA[<s>]]> entries
    /// </summary>
    [Serializable]
    public class RichText
    {
        [XmlElementAttribute("p")]
        public List<RichTextPSR> p { get; set; } = new List<RichTextPSR>();

        [XmlElementAttribute("s")]
        public List<RichTextSR> s { get; set; } = new List<RichTextSR>();

        [XmlTextAttribute()]
        public string PlainValue { get; set; } = "";

        public RichText() { }
        public RichText(string plainValue)
        {
            PlainValue = plainValue;
        }

        public override string ToString()
        {
            string output = "";
            foreach (RichTextPSR psr in p) { output += p.ToString(); }
            foreach (RichTextSR sr in s) { output += s.ToString(); }
            if (p.Count + s.Count == 0) { output = PlainValue; }
            return output;
        }
    }
}
