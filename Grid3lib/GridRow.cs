using System;
using System.Collections.Generic;
using System.Text;
using Grid3lib.XmlNodeTag;

namespace Grid3lib.ToConvert
{
    /// <summary>
    /// Holds a row of <see cref="Cell"/>
    /// </summary>
    public class GridRow
    {
        public Dictionary<int,Cell> Cells = new Dictionary<int, Cell>();
    }
}
