using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Grid3lib.ImportClasses
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCellContentCommandsCommandParameter
    {
        //TODO - Parameters can contain rich text elements (RichTextPSR etc.)
        // so we can't simply have a value text field alone

        private string[] dataField;

        private RichText textField;

        private string keyField;

        private string valueField;

        /// <remarks/>
        [XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [XmlArrayItemAttribute("data", IsNullable = false)]
        public string[] data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }

        /// <summary>
        /// Contains the value, including any rich text subitems
        /// </summary>
        [XmlTextAttribute()]
        public RichText Text
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
        /*[XmlAttributeAttribute()]*/
        [XmlIgnore]
        public string Key
        {
            get
            {
                //return this.keyField;
                return this.textField.ToString();
            }
            /*set
            {
                this.keyField = value;
            }*/
        }
    }

}
