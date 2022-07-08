using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib
{
    public class Page
    {
        public GridSet Parent;
        private List<PageColumn> Columns = new List<PageColumn>();
        private List<PageRow> Rows = new List<PageRow>();
        public Guid? PageId = null;

        /// <summary>
        /// Creates a new Page in the specified parent GridSet
        /// </summary>
        /// <param name="parent">The GridSet to which the page should be attached</param>
        /// <param name="isHomePage">Whether this grid is the home page of the parent</param>
        public Page(GridSet parent, bool isHomePage = false)
        {
            this.PageId = Guid.NewGuid();
            this.Parent = parent;
            this.Populate();
            if (isHomePage) { this.Parent.Homepage = this; }
        }

        /// <summary>
        /// Populates the Page with the right number of blank cells
        /// </summary>
        void Populate()
        {
            for (int c = 0; c < this.Parent.ColumnCount; c++)
            {
                for (int r = 0; r < this.Parent.RowCount; r++)
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
            string colDefs = "\n" + "<ColumnDefinition />\n".Repeat(Parent.ColumnCount);
            string rowDefs = "\n" + "<RowDefinition />\n".Repeat(Parent.RowCount);
            string cellDefs = "";
            for (int c = 0; c < this.Parent.ColumnCount; c++)
            {
                for (int r = 0; r < this.Parent.RowCount; r++)
                {
                    Cell cell = this.GetCell(c, r);
                    cellDefs += "\n" + cell.getXml();
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
}
