using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a File node in a FileMap
    /// </summary>
    public class File : XmlNodeBasic
    {
        /// <summary>
        /// Returns the path contained within the <see cref="File"/>
        /// </summary>
        public string? filePath
        {
            get
            {
                return this.InnerXmlString;
            }
        }
    }
}
