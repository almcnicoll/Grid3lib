using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridScanBlockAudioDescription
    {

        private byte scanBlockField;

        private string audioDescriptionField;

        private string borderColourField;

        private string fontColourField;

        private byte fontSizeField;

        private bool fontSizeFieldSpecified;

        /// <remarks/>
        public byte ScanBlock
        {
            get
            {
                return this.scanBlockField;
            }
            set
            {
                this.scanBlockField = value;
            }
        }

        /// <remarks/>
        public string AudioDescription
        {
            get
            {
                return this.audioDescriptionField;
            }
            set
            {
                this.audioDescriptionField = value;
            }
        }

        /// <remarks/>
        public string BorderColour
        {
            get
            {
                return this.borderColourField;
            }
            set
            {
                this.borderColourField = value;
            }
        }

        /// <remarks/>
        public string FontColour
        {
            get
            {
                return this.fontColourField;
            }
            set
            {
                this.fontColourField = value;
            }
        }

        /// <remarks/>
        public byte FontSize
        {
            get
            {
                return this.fontSizeField;
            }
            set
            {
                this.fontSizeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FontSizeSpecified
        {
            get
            {
                return this.fontSizeFieldSpecified;
            }
            set
            {
                this.fontSizeFieldSpecified = value;
            }
        }
    }

}
