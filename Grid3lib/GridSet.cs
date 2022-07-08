#nullable enable
using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib
{
    public class GridSet
    {
        public string? Name = null;
        public int ColumnCount = 8;
        public int RowCount = 6;
        public Guid? GridSetId = null;
        public Page? Homepage = null;

        public GridSet()
        {
            this.GridSetId = Guid.NewGuid();
        }
    }


}
