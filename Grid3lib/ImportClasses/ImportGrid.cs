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

        private GridCommand[] commandsField;

        private object autoContentCommandsField;

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

    

    

}
