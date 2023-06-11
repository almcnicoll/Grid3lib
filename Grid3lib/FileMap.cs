using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ToConvert
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class FileMap
    {

        private FileMapEntry[] entriesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Entry", IsNullable = false)]
        public FileMapEntry[] Entries
        {
            get
            {
                return this.entriesField;
            }
            set
            {
                this.entriesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class FileMapEntry
    {

        private string[] dynamicFilesField;

        private string staticFileField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("File", IsNullable = false)]
        public string[] DynamicFiles
        {
            get
            {
                return this.dynamicFilesField;
            }
            set
            {
                this.dynamicFilesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StaticFile
        {
            get
            {
                return this.staticFileField;
            }
            set
            {
                this.staticFileField = value;
            }
        }
    }


}
