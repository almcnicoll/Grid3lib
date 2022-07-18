using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCell : IImportClass
    {

        private string visibilityField;

        private GridCellContent contentField;

        private byte xField;

        private bool xFieldSpecified;

        private byte yField;

        private bool yFieldSpecified;

        private byte scanBlockField;

        private bool scanBlockFieldSpecified;

        private byte columnSpanField;

        private bool columnSpanFieldSpecified;

        /// <remarks/>
        public string Visibility
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
            }
        }

        /// <remarks/>
        public GridCellContent Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool XSpecified
        {
            get
            {
                return this.xFieldSpecified;
            }
            set
            {
                this.xFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YSpecified
        {
            get
            {
                return this.yFieldSpecified;
            }
            set
            {
                this.yFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScanBlockSpecified
        {
            get
            {
                return this.scanBlockFieldSpecified;
            }
            set
            {
                this.scanBlockFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ColumnSpan
        {
            get
            {
                return this.columnSpanField;
            }
            set
            {
                this.columnSpanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColumnSpanSpecified
        {
            get
            {
                return this.columnSpanFieldSpecified;
            }
            set
            {
                this.columnSpanFieldSpecified = value;
            }
        }
    }


}
