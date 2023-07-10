using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;
using SixLabors.ImageSharp;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Contains the thumbnail of a <see cref="GridSet"/>
    /// </summary>
    public class Thumbnail : Grid3lib.XmlNodeTag.File
    {
        /// <summary>
        /// Sets or returns an <see cref="Image"/> object if thumbnail is not based on a file or archive entry
        /// </summary>
        public Image? image { get; set; }
    }
}
