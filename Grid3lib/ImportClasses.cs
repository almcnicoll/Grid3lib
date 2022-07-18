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
    public partial class Grid
    {

        private string gridGuidField;

        private string predictionSourceField;

        private object[] columnDefinitionsField;

        private object[] rowDefinitionsField;

        private GridCommands commandsField;

        private GridCommands[] autoContentCommandsField;

        private GridCell[] cellsField;

        private GridScanBlockAudioDescription[] scanBlockAudioDescriptionsField;

        private GridWordList wordListField;

        /// <remarks/>
        public string GridGuid
        {
            get
            {
                return this.gridGuidField;
            }
            set
            {
                this.gridGuidField = value;
            }
        }

        /// <remarks/>
        public string PredictionSource
        {
            get
            {
                return this.predictionSourceField;
            }
            set
            {
                this.predictionSourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ColumnDefinition", IsNullable = false)]
        public object[] ColumnDefinitions
        {
            get
            {
                return this.columnDefinitionsField;
            }
            set
            {
                this.columnDefinitionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RowDefinition", IsNullable = false)]
        public object[] RowDefinitions
        {
            get
            {
                return this.rowDefinitionsField;
            }
            set
            {
                this.rowDefinitionsField = value;
            }
        }

        /// <remarks/>
        public GridCommands Commands
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
        public GridCommands[] AutoContentCommands
        {
            get
            {
                return this.autoContentCommandsField;
            }
            set
            {
                this.autoContentCommandsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Cell", IsNullable = false)]
        public GridCell[] Cells
        {
            get
            {
                return this.cellsField;
            }
            set
            {
                this.cellsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ScanBlockAudioDescription", IsNullable = false)]
        public GridScanBlockAudioDescription[] ScanBlockAudioDescriptions
        {
            get
            {
                return this.scanBlockAudioDescriptionsField;
            }
            set
            {
                this.scanBlockAudioDescriptionsField = value;
            }
        }

        /// <remarks/>
        public GridWordList WordList
        {
            get
            {
                return this.wordListField;
            }
            set
            {
                this.wordListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCommands
    {

        private GridCommandsCommand commandField;

        /// <remarks/>
        public GridCommandsCommand Command
        {
            get
            {
                return this.commandField;
            }
            set
            {
                this.commandField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCommandsCommand
    {

        private GridCommandsCommandParameter[] parameterField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public GridCommandsCommandParameter[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCommandsCommandParameter
    {

        private string keyField;

        private string valueField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCell
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCellContentCommand
    {

        private GridCellContentCommandParameter[] parameterField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public GridCellContentCommandParameter[] Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCellContentCommandParameter
    {

        private GridCellContentCommandParameterS[] pField;

        private string[] textField;

        private string keyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("s", IsNullable = false)]
        public GridCellContentCommandParameterS[] p
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCellContentCommandParameterS
    {

        private string rField;

        /// <remarks/>
        public string r
        {
            get
            {
                return this.rField;
            }
            set
            {
                this.rField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridCellContentCaptionAndImage
    {

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        AudioDescription,

        /// <remarks/>
        Caption,

        /// <remarks/>
        Image,
    }

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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class GridWordList
    {

        private object itemsField;

        /// <remarks/>
        public object Items
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
    }

}
