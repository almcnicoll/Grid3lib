#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Serialization;

namespace Grid3lib
{
    /// <summary>
    /// Represents a GridSet
    /// </summary>
    public class GridSet
    {
        public string? Name { get; set; } = null;
        public int ColumnCount { get; set; } = 8;
        public int RowCount { get; set; } = 6;
        public Guid? GridSetId {get;set;} = null;
        public Page? Homepage {get;set;} = null;
        public ZipArchive? Archive { get; set; } = null;
        public FileMap? Map { get; set; } = null;

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

        /// <summary>
        /// Loads a GridSet from a .gridset file
        /// </summary>
        /// <param name="filePath">The full path of the GridSet file</param>
        /// <returns>A <see cref="GridSet"/> object loaded from the file, or null on failure</returns>
        public static GridSet? Load(String filePath, out List<string> debugInfo)
        {
            GridSet gridSet = new GridSet();
            debugInfo = new List<string>();
            ZipArchive gridFile = ZipFile.OpenRead(filePath);
            gridSet.Archive = gridFile;

            // Retrieve and parse filemap
            ZipArchiveEntry? fileMapFile = (from ZipArchiveEntry e in gridFile.Entries
                                            where e.FullName == "FileMap.xml"
                                            select e).First();
            if (fileMapFile == null) { debugInfo.Add("No FileMap.xml found"); return null; }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(FileMap));
            using (Stream fsMapFile = fileMapFile.Open())
            {
                gridSet.Map = (xmlSerializer.Deserialize(fsMapFile) as FileMap);
                if (gridSet.Map == null)
                {
                    debugInfo.Add("Could not deserialize FileMap.xml");
                    return null;
                }
            }
            // TODO - get homepage
            // Use FileMap to populate Pages
            foreach (FileMapEntry fme in gridSet.Map.Entries)
            {
                debugInfo.Add(String.Format("File map entry: {0}",fme.StaticFile));
                if(fme.StaticFile.ToPathParts().Last() == "grid.xml")
                {
                    Page p = new Page(gridSet);

                }
            }

            // Loop through all entries
            foreach (ZipArchiveEntry entry in gridFile.Entries)
            {
                string[] folders = entry.FullName.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar });
                //debugInfo.Add(entry.FullName);
                debugInfo.Add(String.Join(" / ", folders));
            }

            return null;
        }
    }


}
