using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Describes the filemap for a <see cref="GridSet"/>.
    /// </summary>
    public class FileMap : XmlNodeBasic
    {

        public void Write(string filename)
        {
            if (filename == null) { throw new Exception("No filename specified"); }
            String filemapContents = this.ToString();
            System.IO.File.WriteAllText(filemapContents, filename);
        }
    }
}
