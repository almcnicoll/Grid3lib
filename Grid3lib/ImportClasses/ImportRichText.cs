using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses
{
    /// <summary>
    /// Used as a base class for the many import classes which can contain <![CDATA[<p><s><r></r></s></p>]]> content
    /// </summary>
    public abstract class ImportRichTextSR
    {
        public abstract string[] r { get; set; }
        public abstract string Image { get; set; }
    }

    /// <summary>
    /// Used as a base class for the many import classes which can contain <![CDATA[<s><r></r></s>]]> content
    /// </summary>
    public abstract class ImportRichTextPSR
    {
        public abstract ImportRichTextSR[] s { get; set; }
    }
}
