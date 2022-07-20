using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses
{
    /// <summary>
    /// Grids are divided into Scan Blocks. GridScanBlockAudioDescription entries contain the custom audio feedback given when a Scan Block is selected.
    /// </summary>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridScanBlockAudioDescription
    {

        private int scanBlockField;

        private string audioDescriptionField;
        /*
         * These fields were populated by Paste-as-XML at some point, but I can find no sample XML where they are present
                private string borderColourField;

                private string fontColourField;

                private int fontSizeField;

                private bool fontSizeFieldSpecified;
        */
        /// <remarks/>
        public int ScanBlock
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

        /*
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
                public int FontSize
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
        */

    }

}
