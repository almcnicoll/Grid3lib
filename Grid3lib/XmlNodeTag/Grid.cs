using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a Grid within a <see cref="Gridset"/>
    /// </summary>
    public class Grid : XmlNodeBasic
    {
        /// <summary>
        /// Returns the parent node as a strongly-typed GridSet rather than as an IXmlNode
        /// </summary>
        public GridSet? ParentGridSet
        {
            get
            {
                return (Parent as GridSet);
            }
            set
            {
                Parent = value;
            }
        }

        public String Name { get; set; }
        public Guid? GridId { get; set; } = null;
        public string RelativePath { get; set; } = null;

        public List<Command> StartupCommands { get; set; } = new List<Command>();
        public List<ScanBlockAudioDescription> ScanBlockAudioDescriptions { get; set; } = new List<ScanBlockAudioDescription>();

        /// <summary>
        /// Returns the number of columns in the Grid
        /// </summary>
        public int ColumnCount { get; set; }

        /// <summary>
        /// Returns the number of rows in the Grid
        /// </summary>
        public int RowCount { get; set; }

        /// <summary>
        /// Constructor if creating programmatically
        /// </summary>
        public Grid(bool GenerateGuid = true)
        {
            if (GenerateGuid) { GridId = Guid.NewGuid(); }
        }

        /// <summary>
        /// Fills the XML node from the specified XML markup
        /// </summary>
        /// <param name="Xml">The source XML</param>
        /// <param name="PopulateChildren">Whether to populate the child nodes also</param>
        public override void PopulateFromXml(string Xml, bool PopulateChildren = true)
        {
            // Always call base method to populate basic properties
            base.PopulateFromXml(Xml, PopulateChildren);

            //TODO - extra property setting here
        }
    }
}
