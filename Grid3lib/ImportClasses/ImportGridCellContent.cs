using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCellContent
    {

        private string contentTypeField;

        private string contentSubTypeField;

        private GridCellContentCommand[] commandsField;

        private GridCellContentCaptionAndImage captionAndImageField;

        private GridCellContentStyle styleField;

        /// <remarks/>
        public string ContentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }

        /// <remarks/>
        public string ContentSubType
        {
            get
            {
                return this.contentSubTypeField;
            }
            set
            {
                this.contentSubTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Command", IsNullable = false)]
        public GridCellContentCommand[] Commands
        {
            get
            {
                return this.commandsField;
            }
            set
            {
                this.commandsField = value;
            }
        }

        /// <remarks/>
        public GridCellContentCaptionAndImage CaptionAndImage
        {
            get
            {
                return this.captionAndImageField;
            }
            set
            {
                this.captionAndImageField = value;
            }
        }

        /// <remarks/>
        public GridCellContentStyle Style
        {
            get
            {
                return this.styleField;
            }
            set
            {
                this.styleField = value;
            }
        }
    }


}
