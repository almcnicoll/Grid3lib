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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class StyleData
    {

        private StyleDataStyle[] stylesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Style", IsNullable = false)]
        public StyleDataStyle[] Styles
        {
            get
            {
                return this.stylesField;
            }
            set
            {
                this.stylesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class StyleDataStyle
    {

        private string nameField;

        private string backColourField;

        private string tileColourField;

        private string borderColourField;

        private string fontColourField;

        private string fontNameField;

        private byte fontSizeField;

        private bool fontSizeFieldSpecified;

        private byte backgroundShapeField;

        private bool backgroundShapeFieldSpecified;

        private string keyField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
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
        public string TileColour
        {
            get
            {
                return this.tileColourField;
            }
            set
            {
                this.tileColourField = value;
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

        /// <remarks/>
        public byte BackgroundShape
        {
            get
            {
                return this.backgroundShapeField;
            }
            set
            {
                this.backgroundShapeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BackgroundShapeSpecified
        {
            get
            {
                return this.backgroundShapeFieldSpecified;
            }
            set
            {
                this.backgroundShapeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
    }


}
