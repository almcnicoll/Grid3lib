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
    public class Grid
    {
        public XmlNodeTag.GridSet Parent { get; set; }
        public String Name { get; set; }
        public Guid? GridId { get; set; } = null;
        public string RelativePath { get; set; } = null;
        private bool __XmlParsed = false;
        public List<Command> StartupCommands { get; set; } = new List<Command>();
        public List<ScanBlockAudioDescription> ScanBlockAudioDescriptions { get; set; } = new List<ScanBlockAudioDescription>();
        // NB In file and library, rows and columns are zero-based
        private Dictionary<int, GridColumn> Columns = new Dictionary<int, GridColumn>();
        private Dictionary<int, GridRow> Rows = new Dictionary<int, GridRow>();

        private int? __ColumnCount;
        private int? __RowCount;
        public int ColumnCount
        {
            get
            {
                if (__XmlParsed) { return __ColumnCount.Value; }
                throw new Exception("Cannot return column count without processing grid.xml");
            }
            set
            {
                __ColumnCount = value;
                // If we have RowCount and ColumnCount and we're not planning to load from XML, populate the grid
                if (!__forLoading && __RowCount.HasValue) { SetUpGrid(true); }
            }
        }
        public int RowCount
        {
            get
            {
                if (__XmlParsed) { return __RowCount.Value; }
                throw new Exception("Cannot return row count without processing grid.xml");
            }
            set
            {
                __RowCount = value;
                // If we have RowCount and ColumnCount and we're not planning to load from XML, populate the grid
                if (!__forLoading && __ColumnCount.HasValue) { SetUpGrid(true); }
            }
        }

        private bool __forLoading = false;


        /// <summary>
        /// Creates a new Page in the specified parent GridSet
        /// </summary>
        /// <param name="parent">The GridSet to which the page should be attached</param>
        /// <param name="isHomePage">Whether this grid is the home page of the parent</param>
        /// <param name="generateGuid">Whether to auto-generate a new Guid for this <see cref="Grid"/> (recommended if creating a page from scratch)</param>
        /// <param name="forLoading">Whether this <see cref="Grid"/> is expected to be populated from XML (true) or using code (false)</param>
        public Grid(XmlNodeTag.GridSet parent, bool isHomePage = false, bool generateGuid = false, bool forLoading = true)
        {
            if (generateGuid) { this.GridId = Guid.NewGuid(); }
            this.Parent = parent; parent.Grids.Add(this);
            if (isHomePage) { this.Parent.Homepage = this; }
            __forLoading = forLoading;
        }

        /// <summary>
        /// Creates a new Page in the specified parent GridSet
        /// </summary>
        /// <param name="parent">The GridSet to which the page should be attached</param>
        /// <param name="name">The name of the Page</param>
        /// <param name="isHomePage">Whether this grid is the home page of the parent</param>
        /// <param name="generateGuid">Whether to auto-generate a new Guid for this <see cref="Grid"/> (recommended if creating a page from scratch)</param>
        /// <param name="forLoading">Whether this <see cref="Grid"/> is expected to be populated from XML (true) or using code (false)</param>
        public Grid(XmlNodeTag.GridSet parent, String name, bool isHomePage = false, bool generateGuid = false, bool forLoading = true)
        {
            if (generateGuid) { this.GridId = Guid.NewGuid(); }
            this.Parent = parent; parent.Grids.Add(this);
            this.Name = name;
            if (isHomePage) { this.Parent.Homepage = this; }
            __forLoading = forLoading;
        }

        /// <summary>
        /// Populates a <see cref="Grid"/> object from its XML definition
        /// </summary>
        /// <param name="fs">The <see cref="Stream"/> containing the XML definition</param>
        public void Load(Stream fs)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportClasses.Grid));
            ImportClasses.Grid importGrid = (xmlSerializer.Deserialize(fs) as ImportClasses.Grid);
            CopyFromImportGrid(importGrid);
            __XmlParsed = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cell">The <see cref="Cell"/> to add</param>
        /// <param name="Column">The column at which to add the cell</param>
        /// <param name="Row">The row at which to add the cell</param>
        public void AddCell(Cell cell, int Column, int Row)
        {
            // Set up cell
            cell.Parent = this;
            cell.Column = Column;
            cell.Row = Row;
            // Ensure containers are ready
            if (!Columns.ContainsKey(Column)) { Columns.Add(Column, new GridColumn()); }
            if (Column >= __ColumnCount) { __ColumnCount = Column + 1; }
            if (!Rows.ContainsKey(Row)) { Rows.Add(Row, new GridRow()); }
            if (Row >= __RowCount) { __RowCount = Row + 1; }
            // Add or insert to sub-containers
            Columns[Column].Cells.AddOrEdit(Row, cell);
            Rows[Row].Cells.AddOrEdit(Column, cell);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="importGrid"></param>
        private void CopyFromImportGrid(ImportClasses.Grid importGrid)
        {
            this.GridId = new Guid(importGrid.GridGuid);
            this.__ColumnCount = importGrid.ColumnDefinitions.Length;
            this.__RowCount = importGrid.RowDefinitions.Length;

            // TODO - import other sub-objects from importclasses too (as with commands below)
            if (importGrid.Commands != null)
            {
                // Startup Commands
                this.StartupCommands = new List<Command>();
                foreach (ImportClasses.GridCommand gridCommand in importGrid.Commands)
                {
                    this.StartupCommands.Add(new Command(gridCommand));
                }

                // Cells
                foreach (ImportClasses.GridCell gridCell in importGrid.Cells)
                {
                    this.AddCell(new Cell(this, gridCell), gridCell.X, gridCell.Y);
                }

                // Ignore Autocommands (not sure what these are - currently unsupported!)

                foreach (ImportClasses.GridScanBlockAudioDescription gridScanBlockAudioDescription in importGrid.ScanBlockAudioDescriptions)
                {
                    this.ScanBlockAudioDescriptions.Add(new ScanBlockAudioDescription(gridScanBlockAudioDescription));
                }
            }

        }

        /// <summary>
        /// Populates the Page with the right number of blank cells
        /// <param name="CountAsXmlParsed">Whether to count the Page as having been loaded from XML</param>
        /// </summary>
        private void SetUpGrid(bool CountAsXmlParsed = true)
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
                    if (Columns.Count <= c) { Columns.Add(c, new GridColumn()); }
                    if (Rows.Count <= r) { Rows.Add(r, new GridRow()); }
                    Columns[c].Cells.Add(r, cell);
                    Rows[r].Cells.Add(c, cell);
                }
            }
        }

        /// <summary>
        /// Returns a single cell from the page
        /// </summary>
        /// <param name="Column">The column from which to retrieve</param>
        /// <param name="Row">The row from which to retrieve</param>
        /// <returns>The matching <see cref="Cell"/> or null if there is no cell at the specified coordinates</returns>
        /// <exception cref="ArgumentOutOfRangeException">Returned if Column or Row is out of bounds</exception>
        public Cell GetCell(int Column, int Row)
        {
            if (Column >= __ColumnCount) { throw new ArgumentOutOfRangeException("Column", String.Format("Requested column {0} but column count is only {1}", Column, __ColumnCount)); }
            if (Row >= __RowCount) { throw new ArgumentOutOfRangeException("Row", String.Format("Requested row {0} but row count is only {1}", Row, __RowCount)); }
            if (!Columns.ContainsKey(Column) || (Columns[Column] == null)) { return null; } // Not yet populated, therefore no cell
            if (!Columns[Column].Cells.ContainsKey(Row) || (Columns[Column].Cells[Row] == null)) { return null; } // Not yet populated, therefore no cell
            return Columns[Column].Cells[Row]; // Shouldn't fail now
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
            <GridGuid>{GridId}</GridGuid>
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

