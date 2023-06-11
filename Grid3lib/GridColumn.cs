using System;
using System.Collections.Generic;
using System.Text;
using Grid3lib.XmlNodeTag;

namespace Grid3lib
{
    /// <summary>
    /// Holds a column of <see cref="Cell"/>
    /// </summary>
    class GridColumn
    {
        public Dictionary<int, Cell> Cells = new Dictionary<int, Cell>();
    }
}
