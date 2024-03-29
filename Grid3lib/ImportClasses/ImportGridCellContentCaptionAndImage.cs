﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCellContentCaptionAndImage
    {

        //private string[] itemsField;

        //private ItemsChoiceType[] itemsElementNameField;

        [System.Xml.Serialization.XmlElementAttribute("AudioDescription", typeof(string))]
        public string AudioDescription { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Caption", typeof(string))]
        public string Caption { get; set; }

        [System.Xml.Serialization.XmlElementAttribute("Image", typeof(string))]
        public string Image { get; set; }

        /*
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AudioDescription", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Caption", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("Image", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        */
    }


}
