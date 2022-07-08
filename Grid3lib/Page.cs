using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib
{
    public class Page
    {
        public GridSet Parent;
        private List<Cell> Columns = new List<Cell>();
        private List<Cell> Rows = new List<Cell>();
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
            for (int c = 0; c < this.Parent.ColumnCount; c++) {
                for (int r = 0; r < this.Parent.RowCount; r++) {

					//this.Cells[c][r] = new Cell(this, c, r, '');
                }
            }
        }

        public Cell GetCell(int Column, int Row)
        {
        }

        public string GetXml()
        {

        }
    }
}
