using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Grid3lib
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
    }

    [Serializable]
    public class RichTextSR
    {
        [XmlAttributeAttribute("Image")]
        public string Image { get; set; }

        public RichTextR[] R { get; set; }

        public RichTextSR(ImportClasses.ImportRichTextSR importRichTextSR)
        {
            // TODO - copy from import class here
        }
    }

    [Serializable]
    public class RichTextPSR
    {
        public RichTextSR[] S { get; set; }

        public RichTextPSR(ImportClasses.ImportRichTextPSR importRichTextPSR)
        {
            // TODO - copy from import class here
        }
    }
}
