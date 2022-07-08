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

        public Page(GridSet parent, bool isHomePage = false)
        {
            this.PageId = Guid.NewGuid();
            this.Parent = parent;
            this.Populate();
            if (isHomePage) { this.Parent.Homepage = this; }
        }

        public void Populate()
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

        public Cell GetCell(int Column, int Row)
        {
            return Columns[Column].Cells[Row];
        }

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
