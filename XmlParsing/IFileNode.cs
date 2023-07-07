using System;
using System.Collections.Generic;
using System.Text;

namespace XmlParsing
{
    public interface IFileNode
    {
        public string? filePath { get; set; }

        public bool sourceIsArchive { get; set; }
    }
}
