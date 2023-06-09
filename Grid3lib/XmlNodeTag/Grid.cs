using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a Grid within a <see cref="GridSet"/>
    /// </summary>
    public class Grid : XmlNodeBasic
    {
        public String Name { get; set; }
        public Guid? PageId { get; set; } = null;
        public string RelativePath { get; set; } = null;

        public List<Command> StartupCommands { get; set; } = new List<Command>();
        public List<ScanBlockAudioDescription> ScanBlockAudioDescriptions { get; set; } = new List<ScanBlockAudioDescription>();

        /// <summary>
        /// Returns the number of columns in the Grid
        /// </summary>
        public int ColumnCount
        {
            get
            {
                return ChildrenOfType<ColumnDefinition>().Count;
            }
        }

        /// <summary>
        /// Returns the number of rows in the Grid
        /// </summary>
        public int RowCount
        {
            get
            {
                return ChildrenOfType<RowDefinition>().Count;
            }
        }

        /// <summary>
        /// Constructor if creating programmatically rather than parsing XML
        /// </summary>
        public Grid(GridSet parent, bool isHomePage = false, bool GenerateGuid = true)
        {
            if (GenerateGuid) { PageId = Guid.NewGuid(); }
            if (isHomePage)
            {
                (this.Parent as GridSet).Homepage = this;
            }
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
