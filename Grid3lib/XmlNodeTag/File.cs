using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a File node in a FileMap
    /// </summary>
    public class File : XmlNodeBasic, IFileNode
    {
        private bool __sourceIsArchive = true;

        /// <summary>
        /// Sets or returns the path contained within the <see cref="File"/> node.
        /// If setting this to a value, it is assumed that the path refers to the local filesystem, not to the archive
        /// </summary>
        public string? filePath
        {
            get
            {
                return this.InnerXmlString;
            }
            set
            {
                if (value == null)
                {
                    this.InnerXml = new List<RawXml>();
                }
                else
                {
                    this.InnerXml = new List<RawXml>() { new RawXml(value, false) };
                }
                __sourceIsArchive = false;
            }
        }

        /// <summary>
        /// Returns whether the source of this file is the associated Zip archive (otherwise it is the local filesystem)
        /// </summary>
        public bool sourceIsArchive { get { return __sourceIsArchive; } set { __sourceIsArchive = value; } }
    }
}
