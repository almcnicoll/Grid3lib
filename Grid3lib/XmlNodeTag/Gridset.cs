#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Serialization;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a Gridset
    /// NB - there is not actually a GridSet node, but by making this an XmlNodeTag class, we can make it a parent of <see cref="Grid"/> objects
    /// </summary>
    public class GridSet : XmlNodeBasic
    {
        /// <summary>
        /// The user-facing name of the GridSet
        /// </summary>
        public string? Name { get; set; } = null;

        /// <summary>
        /// The unique <see cref="Guid"/> of the GridSet
        /// </summary>
        public Guid? GridSetId { get; set; } = null;

        /// <summary>
        /// Which <see cref="Grid"/> is the "home page" for this GridSet
        /// </summary>
        public Grid? Homepage { get; set; } = null;

        /// <summary>
        /// A reference to the Zip archive from which the GridSet was loaded
        /// </summary>
        public ZipArchive? Archive { get; set; } = null;

        /// <summary>
        /// The settings loaded from the GridSet's settings.xml
        /// </summary>
        public GridSetSettings? Settings { get; set; } = null;

        /// <summary>
        /// The file map loaded from the GridSet's FileMap.xml
        /// </summary>
        public FileMap? Map { get; set; } = null;

        /// <summary>
        /// A set of all the Grids within the GridSet
        /// </summary>
        public HashSet<Grid> Grids { get; set; } = new HashSet<Grid>();


        /// <summary>
        /// Creates a new GridSet
        /// </summary>
        public GridSet()
        {
            this.GridSetId = Guid.NewGuid();
        }
        /// <summary>
        /// Creates a new GridSet with the specified name
        /// <paramref name="name">The name of the GridSet</paramref>
        /// </summary>
        public GridSet(string name)
        {
            this.GridSetId = Guid.NewGuid();
            this.Name = name;
        }
    }
}
