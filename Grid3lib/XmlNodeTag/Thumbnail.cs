using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;
using SixLabors.ImageSharp;
using System.IO.Compression;
using System.IO;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Contains the thumbnail of a <see cref="GridSet"/>
    /// </summary>
    public class Thumbnail : Grid3lib.XmlNodeTag.File
    {
        /// <summary>
        /// Represents the possible sources of a thumbnail
        /// </summary>
        public enum SourceType
        {
            /// <summary>
            /// We don't know where the thumbnail is stored (not ideal!)
            /// </summary>
            Unknown = 0,
            /// <summary>
            /// The thumbnail is stored in a <see cref="System.IO.Compression.ZipArchiveEntry"/> (default)
            /// </summary>
            Archive = 1,
            /// <summary>
            /// The thumbnail is currently stored in a local file
            /// </summary>
            File = 2,
            /// <summary>
            /// The thumbnail data is stored in the <see cref="Image"/> property of the <see cref="Thumbnail"/> object
            /// </summary>
            Memory = 3
        }

        private Image? __image;

        /// <summary>
        /// Sets or returns an <see cref="Image"/> object if thumbnail is not based on a file or archive entry
        /// </summary>
        public Image? image
        {
            get
            {
                return __image;
            }
            set
            {
                __image = value;
                sourceType = SourceType.Memory;
            }
        }

        /// <summary>
        /// Defines where the data for the thumbnail is currently stored
        /// </summary>
        public SourceType sourceType { get; set; } = SourceType.Archive; // Default value

        /// <summary>
        /// Loads the thumbnail data into memory (the <see cref="Thumbnail.image"/> property)
        /// </summary>
        /// <param name="NewSourceType">If specified, sets the <see cref="Thumbnail.sourceType"/> property on successful completion</param>
        /// <exception cref="Exception">Thrown if current sourceType is <see cref="Thumbnail.SourceType.Unknown"/></exception>
        public void loadIntoMemory(SourceType? NewSourceType = null)
        {
            switch (sourceType)
            {
                case SourceType.Archive:
                    // Find GridSet node to retrieve archive
                    GridSet? gridSet = AncestorOfType<GridSet>();
                    if (gridSet == null)
                    {
                        throw new Exception("Cannot trace back from this node to GridSet node, therefore cannot access the source archive.");
                    }
                    else
                    {
                        // Ensure that archive isn't null
                        ZipArchive? zipArchive = gridSet.Archive;
                        if (zipArchive == null)
                        {
                            throw new Exception("Source archive linked to GridSet node is null, therefore thumbnail cannot be retrieved.");
                        }
                        else
                        {
                            // Look up thumbnail path in archive
                            ZipArchiveEntry? zipArchiveEntry = zipArchive.GetEntry(filePath);
                            if (zipArchiveEntry == null)
                            {
                                throw new FileNotFoundException(String.Format("Cannot find path {0} in GridSet's archive.", filePath), filePath);
                            }
                            else
                            {
                                // Load from entry into image object
                                using (Stream s = zipArchiveEntry.Open())
                                {
                                    __image = Image.Load(s);
                                }
                            }
                        }
                    }
                    // TODO - finish this when we can find ParentOfType or Root
                    break;
                case SourceType.File:
                    __image = Image.Load(filePath);
                    break;
                case SourceType.Memory:
                    // Nothing to do here
                    break;
                default:
                    throw new Exception("Cannot load thumbnail into memory when source type is Unknown");
            }
            if (NewSourceType != null)
            {
                sourceType = NewSourceType.Value;
            }
        }
    }
}
