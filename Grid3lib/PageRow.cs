using System;
using System.Collections.Generic;
using System.Text;

namespace Grid3lib
{
    /// <summary>
    /// Holds a row of <see cref="Cell"/>
    /// </summary>
    public class PageRow
    {
        public Dictionary<int,Cell> Cells = new Dictionary<int, Cell>();
    }
}
