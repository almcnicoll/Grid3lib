using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using Grid3lib.ToConvert;

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

        [XmlAttribute]
        public string Key
        {
            get
            {
                return keyField;
            }
            set
            {
                keyField = value;
            }
        }

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
        // TODO #1 - this is not yet pulling data correctly. Suggest we use XmlElement as in https://stackoverflow.com/a/38913372/356256
        // and then parse and deserialize that on conversion to the main CommandParameter class
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

    }

}
