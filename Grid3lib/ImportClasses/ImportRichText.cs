using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Grid3lib.ImportClasses
{
    /// <summary>
    /// Used as a base class for the many import classes which can contain <![CDATA[<p><s><r></r></s></p>]]> content
    /// </summary>
    [Serializable]
    public abstract class ImportRichTextSR
    {
        [XmlIgnore]
        public abstract string[] r { get; set; }
        
        [XmlIgnore]
        public abstract string Image { get; set; }
    }

    /// <summary>
    /// Used as a base class for the many import classes which can contain <![CDATA[<s><r></r></s>]]> content
    /// </summary>
    [Serializable]
    public abstract class ImportRichTextPSR
    {
        [XmlIgnore]
        public abstract ImportRichTextSR[] s { get; set; }
    }
}
