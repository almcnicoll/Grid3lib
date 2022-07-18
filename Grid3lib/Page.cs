using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Grid3lib
{
    /// <summary>
    /// Represents a page of a GridSet
    /// </summary>
    public class Page
    {
        public GridSet Parent { get; set; }
        public String Name { get; set; }
        public Guid? PageId { get; set; } = null;
        public string RelativePath { get; set; } = null;
        private bool __XmlParsed = false;
        private int __ColumnCount;
        private int __RowCount;
        public int ColumnCount
        {
            get
            {
                if (__XmlParsed) { return __ColumnCount; }
                throw new Exception("Cannot return column count without processing grid.xml");
            }
            set
            {
                __ColumnCount = value;
            }
        }
        public int RowCount
        {
            get
            {
                if (__XmlParsed) { return __RowCount; }
                throw new Exception("Cannot return row count without processing grid.xml");
            }
            set
            {
                __RowCount = value;
            }
        }
        public List<Command> StartupCommands { get; set; } = new List<Command>();
        private readonly List<PageColumn> Columns = new List<PageColumn>();
        private readonly List<PageRow> Rows = new List<PageRow>();

        /// <summary>
        /// Creates a new Page in the specified parent GridSet
        /// </summary>
        /// <param name="parent">The GridSet to which the page should be attached</param>
        /// <param name="isHomePage">Whether this grid is the home page of the parent</param>
        public Page(GridSet parent, bool isHomePage = false, bool generateGuid = false)
        {
            if (generateGuid) { this.PageId = Guid.NewGuid(); }
            this.Parent = parent; parent.Pages.Add(this);
            if (isHomePage) { this.Parent.Homepage = this; }
        }

        /// <summary>
        /// Creates a new Page in the specified parent GridSet
        /// </summary>
        /// <param name="parent">The GridSet to which the page should be attached</param>
        /// <param name="name">The name of the Page</param>
        /// <param name="isHomePage">Whether this grid is the home page of the parent</param>
        public Page(GridSet parent, String name, bool isHomePage = false, bool generateGuid = false)
        {
            if (generateGuid) { this.PageId = Guid.NewGuid(); }
            this.Parent = parent; parent.Pages.Add(this);
            this.Name = name;
            if (isHomePage) { this.Parent.Homepage = this; }
        }

        public void Load(Stream fs)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportClasses.Grid));
            ImportClasses.Grid importGrid = (xmlSerializer.Deserialize(fs) as ImportClasses.Grid);
            // TODO - copy that import object to this Page object
            CopyFromImportGrid(importGrid);
        }

        private void CopyFromImportGrid(ImportClasses.Grid importGrid)
        {
            this.PageId = new Guid(importGrid.GridGuid);
            this.__ColumnCount = importGrid.ColumnDefinitions.Length;
            this.__RowCount = importGrid.RowDefinitions.Length;
            if (importGrid.AutoContentCommands != null)
            {
                // TODO - port import sub-objects too (e.g. commands)
                this.StartupCommands = new List<object>(importGrid.AutoContentCommands);
            }
            
        }

        /// <summary>
        /// Populates the Page with the right number of blank cells
        /// </summary>
        public void SetUpGrid(bool CountAsXmlParsed = true)
        {
            __XmlParsed = CountAsXmlParsed;
            if (!__XmlParsed)
            {
                throw new Exception("Cannot populate rows and columns without processing grid.xml");
            }
            for (int c = 0; c < this.ColumnCount; c++)
            {
                for (int r = 0; r < this.RowCount; r++)
                {
                    Cell cell = new Cell(this, c, r, "");
                    if (Columns.Count <= c) { Columns.Add(new PageColumn()); }
                    if (Rows.Count <= r) { Rows.Add(new PageRow()); }
                    Columns[c].Cells.Add(cell);
                    Rows[r].Cells.Add(cell);
                }
            }
        }

        /// <summary>
        /// Returns a single cell from the page
        /// </summary>
        /// <param name="Column">The column from which to retrieve</param>
        /// <param name="Row">The row from which to retrieve</param>
        /// <returns></returns>
        public Cell GetCell(int Column, int Row)
        {
            return Columns[Column].Cells[Row];
        }

        /// <summary>
        /// Returns the XML for this page, ready for compression into the GridSet file
        /// </summary>
        /// <returns></returns>
        public string GetXml()
        {
            // TODO - Try producing this from serializing an ImportClass instead of manual generation?

            string colDefs = "\n" + "<ColumnDefinition />\n".Repeat(ColumnCount);
            string rowDefs = "\n" + "<RowDefinition />\n".Repeat(RowCount);
            string cellDefs = "";
            for (int c = 0; c < this.ColumnCount; c++)
            {
                for (int r = 0; r < this.RowCount; r++)
                {
                    Cell cell = this.GetCell(c, r);
                    cellDefs += "\n" + cell.GetXml();
                }
            }
            string xml = $@"
            <Grid xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
            <GridGuid>{PageId}</GridGuid>
            <ColumnDefinitions>{colDefs}</ColumnDefinitions>
            <RowDefinitions>{rowDefs}</RowDefinitions>
            <AutoContentCommands />
            <Cells>{cellDefs}</Cells>           
            <ScanBlockAudioDescriptions />
            <WordList>
                <Items />
            </WordList>
            </Grid>
          ";
            return xml;
        }
    }
}

