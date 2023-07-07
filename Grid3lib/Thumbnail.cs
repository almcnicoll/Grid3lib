using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;
using SixLabors.ImageSharp;
using Grid3lib.XmlNodeTag;

namespace Grid3lib
{
    /// <summary>
    /// Contains the thumbnail of a <see cref="XmlNodeTag.GridSet"/>
    /// </summary>
    public class Thumbnail : Grid3lib.XmlNodeTag.File
    {
        /// <summary>
        /// Sets or returns the path contained within the <see cref="File"/> node.
        /// If setting this to a value, it is assumed that the path refers to the local filesystem, not to the archive
        /// </summary>
        public string? filePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        /// <summary>
        /// Returns whether the source of this file is the associated Zip archive (otherwise it is the local filesystem)
        /// </summary>
        public bool sourceIsArchive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Sets or returns an <see cref="Image"/> object if thumbnail is not based on a file or archive entry
        /// </summary>
        public Image? image { get; set; }
    }
}
