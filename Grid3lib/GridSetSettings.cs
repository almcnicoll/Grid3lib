using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ToConvert
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class GridSetSettings
    {

        private GridSetSettingsPictureSearch pictureSearchField;

        private object appearanceField;

        private string startGridField;

        private string thumbnailBackgroundField;

        private string thumbnailField;

        private byte gridSetFileFormatVersionField;

        /// <remarks/>
        public GridSetSettingsPictureSearch PictureSearch
        {
            get
            {
                return this.pictureSearchField;
            }
            set
            {
                this.pictureSearchField = value;
            }
        }

        /// <remarks/>
        public object Appearance
        {
            get
            {
                return this.appearanceField;
            }
            set
            {
                this.appearanceField = value;
            }
        }

        /// <remarks/>
        public string StartGrid
        {
            get
            {
                return this.startGridField;
            }
            set
            {
                this.startGridField = value;
            }
        }

        /// <remarks/>
        public string ThumbnailBackground
        {
            get
            {
                return this.thumbnailBackgroundField;
            }
            set
            {
                this.thumbnailBackgroundField = value;
            }
        }

        /// <remarks/>
        public string Thumbnail
        {
            get
            {
                return this.thumbnailField;
            }
            set
            {
                this.thumbnailField = value;
            }
        }

        /// <remarks/>
        public byte GridSetFileFormatVersion
        {
            get
            {
                return this.gridSetFileFormatVersionField;
            }
            set
            {
                this.gridSetFileFormatVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridSetSettingsPictureSearch
    {

        private string[] pictureSearchKeysField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PictureSearchKey", IsNullable = false)]
        public string[] PictureSearchKeys
        {
            get
            {
                return this.pictureSearchKeysField;
            }
            set
            {
                this.pictureSearchKeysField = value;
            }
        }
    }


}
