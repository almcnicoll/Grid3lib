using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCellContentStyle 
    {

        private string basedOnStyleField;

        private string backColourField;

        private string borderColourField;

        private string fontNameField;

        private string fontColourField;

        private byte fontSizeField;

        private bool fontSizeFieldSpecified;

        /// <remarks/>
        public string BasedOnStyle
        {
            get
            {
                return this.basedOnStyleField;
            }
            set
            {
                this.basedOnStyleField = value;
            }
        }

        /// <remarks/>
        public string BackColour
        {
            get
            {
                return this.backColourField;
            }
            set
            {
                this.backColourField = value;
            }
        }

        /// <remarks/>
        public string FontName
        {
            get
            {
                return this.fontNameField;
            }
            set
            {
                this.fontNameField = value;
            }
        }
    }


}
