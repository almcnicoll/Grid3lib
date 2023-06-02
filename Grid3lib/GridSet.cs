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
        public Guid? GridSetId { get; set; } = null;
        public Page? Homepage { get; set; } = null;
        public ZipArchive? Archive { get; set; } = null;
        public GridSetSettings? Settings { get; set; } = null;
        public FileMap? Map { get; set; } = null;
        public HashSet<Page> Pages { get; set; } = new HashSet<Page>();

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
            XmlSerializer xmlSerializer;

            // Retrieve and parse settings.xml
            ZipArchiveEntry? settingsFile = (from ZipArchiveEntry e in gridFile.Entries
                                             where e.Name == "settings.xml"
                                             select e).First();
            if (settingsFile == null) { debugInfo.Add("No settings.xml found"); return null; }
            xmlSerializer = new XmlSerializer(typeof(GridSetSettings));
            using (Stream fsSettingsFile = settingsFile.Open())
            {
                gridSet.Settings = (xmlSerializer.Deserialize(fsSettingsFile) as GridSetSettings);
                if (gridSet.Settings == null)
                {
                    debugInfo.Add("Could not deserialize settings.xml");
                    return null;
                }
            }

            // Retrieve and parse filemap.xml
            ZipArchiveEntry? fileMapFile = (from ZipArchiveEntry e in gridFile.Entries
                                            where e.FullName == "FileMap.xml"
                                            select e).First();
            if (fileMapFile == null) { debugInfo.Add("No FileMap.xml found"); return null; }
            xmlSerializer = new XmlSerializer(typeof(FileMap));
            using (Stream fsMapFile = fileMapFile.Open())
            {
                gridSet.Map = (xmlSerializer.Deserialize(fsMapFile) as FileMap);
                if (gridSet.Map == null)
                {
                    debugInfo.Add("Could not deserialize FileMap.xml");
                    return null;
                }
            }

            // Use FileMap to populate Pages
            foreach (FileMapEntry fme in gridSet.Map.Entries)
            {
                debugInfo.Add(String.Format("File map entry: {0}", fme.StaticFile));
                if (fme.StaticFile.ToPathParts().Last() == "grid.xml")
                {
                    String pageName = fme.StaticFile.ToPathParts().SkipLast(1).Last();
                    Page p = new Page(gridSet, pageName, (pageName == gridSet.Settings.StartGrid));
                    p.RelativePath = fme.StaticFile;
                }
            }

            // Loop through grid pages, reading grid.xml files as we go
            foreach (Page p in gridSet.Pages)
            {
                ZipArchiveEntry? pageGridFile = (from ZipArchiveEntry e in gridFile.Entries
                                                 where e.FullName == p.RelativePath.Replace("\\","/")
                                                 select e).First();
                using (Stream fsGridFile = pageGridFile.Open())
                {
                    p.Load(fsGridFile);
                }
            }

            // Loop through all entries
            foreach (ZipArchiveEntry entry in gridFile.Entries)
            {
                string[] folders = entry.FullName.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar });
                //debugInfo.Add(entry.FullName);
                debugInfo.Add(String.Join(" / ", folders));
            }

            return gridSet;
        }
    }


}
