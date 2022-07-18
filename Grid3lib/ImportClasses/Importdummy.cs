using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib.ImportClasses.Pastebin
{
    


}

// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Grid
{

    private string gridGuidField;

    private object[] columnDefinitionsField;

    private object[] rowDefinitionsField;

    private object autoContentCommandsField;

    private GridCommand[] commandsField;

    private GridCell[] cellsField;

    private object scanBlockAudioDescriptionsField;

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
    public object AutoContentCommands
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
    [System.Xml.Serialization.XmlArrayItemAttribute("Command", IsNullable = false)]
    public GridCommand[] Commands
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
    public object ScanBlockAudioDescriptions
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
public partial class GridCommand
{

    private GridCommandParameter[] parameterField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Parameter")]
    public GridCommandParameter[] Parameter
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
public partial class GridCommandParameter
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

    private GridCellContent contentField;

    private byte columnSpanField;

    private byte rowSpanField;

    private byte xField;

    private bool xFieldSpecified;

    private byte yField;

    private bool yFieldSpecified;

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
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte RowSpan
    {
        get
        {
            return this.rowSpanField;
        }
        set
        {
            this.rowSpanField = value;
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
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class GridCellContent
{

    private GridCellContentCommands commandsField;

    private GridCellContentCaptionAndImage captionAndImageField;

    private GridCellContentStyle styleField;

    /// <remarks/>
    public GridCellContentCommands Commands
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
public partial class GridCellContentCommands
{

    private GridCellContentCommandsCommand commandField;

    /// <remarks/>
    public GridCellContentCommandsCommand Command
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
public partial class GridCellContentCommandsCommand
{

    private GridCellContentCommandsCommandParameter[] parameterField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Parameter")]
    public GridCellContentCommandsCommandParameter[] Parameter
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
public partial class GridCellContentCommandsCommandParameter
{

    private string[] dataField;

    private string[] textField;

    private string keyField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("data", IsNullable = false)]
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
public partial class GridCellContentCaptionAndImage
{

    private string captionField;

    private string imageField;

    /// <remarks/>
    public string Caption
    {
        get
        {
            return this.captionField;
        }
        set
        {
            this.captionField = value;
        }
    }

    /// <remarks/>
    public string Image
    {
        get
        {
            return this.imageField;
        }
        set
        {
            this.imageField = value;
        }
    }
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

    private string fontColourField;

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

