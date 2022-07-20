using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridWordList
    {

        private GridWordListWordListItem[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WordListItem", IsNullable = false)]
        public GridWordListWordListItem[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridWordListWordListItem
    {

        private GridWordListWordListItemText textField;

        private string imageField;

        private string partOfSpeechField;

        /// <remarks/>
        public GridWordListWordListItemText Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public string Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }

        /// <remarks/>
        public string PartOfSpeech
        {
            get
            {
                return this.partOfSpeechField;
            }
            set
            {
                this.partOfSpeechField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridWordListWordListItemText
    {

        private GridWordListWordListItemTextS[] sField;

        /// <remarks/>
        /// [System.Xml.Serialization.XmlElementAttribute("s")]
        public GridWordListWordListItemTextS[] s
        {
            get
            {
                return this.sField;
            }
            set
            {
                this.sField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridWordListWordListItemTextS : ImportRichTextSR
    {

        private string[] rField;

        private string imageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("r")]
        public override string[] r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public override string Image
        {
            get
            {
                return this.imageField;
            }
            set
            {
                this.imageField = value;
            }
        }
    }
}
