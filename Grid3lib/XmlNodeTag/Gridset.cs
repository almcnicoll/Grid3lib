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
    /// Represents a GridSet
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

        internal List<String> __fileNames = new List<String>();

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

            // Retrieve and parse settings.xml
            // Get file
            ZipArchiveEntry? settingsFile = (from ZipArchiveEntry zipEntry in gridFile.Entries
                                             where zipEntry.Name == "settings.xml"
                                             select zipEntry).First();
            if (settingsFile == null) { debugInfo.Add("No settings.xml found"); return null; }
            // Read XML
            using (Stream settingsStream = settingsFile.Open())
            {
                using (StreamReader settingsReader = new StreamReader(settingsStream))
                {
                    IXmlNode ixnSettings;
                    string settingsXml = settingsReader.ReadToEnd();
                    try
                    {
                        ixnSettings = XmlNodeBasic.CreateFromXml(settingsXml);
                    }
                    catch (Exception ex)
                    {
                        debugInfo.Add("Could not parse settings.xml: " + ex.Message);
                        return null;
                    }
                    if (ixnSettings != null && (ixnSettings is XmlNodeTag.GridSetSettings))
                    {
                        gridSet.Settings = ixnSettings as XmlNodeTag.GridSetSettings;
                    }
                    else
                    {
                        debugInfo.Add("Parsing settings.xml did not result in a valid GridSetSettings object");
                        return null;
                    }
                }
                settingsStream.Close();
            }

            if (gridSet.Settings == null)
            {
                debugInfo.Add("No Settings loaded");
                return null;
            }


            // Retrieve and parse FileMap.xml
            // Get file
            ZipArchiveEntry? fileMapFile = (from ZipArchiveEntry zipEntry in gridFile.Entries
                                            where zipEntry.FullName == "FileMap.xml"
                                            select zipEntry).First();
            if (fileMapFile == null) { debugInfo.Add("No FileMap.xml found"); return null; }
            // Read XML
            using (Stream fileMapStream = fileMapFile.Open())
            {
                using (StreamReader fileMapReader = new StreamReader(fileMapStream))
                {
                    IXmlNode ixnFileMap;
                    string fileMapXml = fileMapReader.ReadToEnd();
                    try
                    {
                        ixnFileMap = XmlNodeBasic.CreateFromXml(fileMapXml);
                    }
                    catch (Exception ex)
                    {
                        debugInfo.Add("Could not parse FileMap.xml: " + ex.Message);
                        return null;
                    }
                    if (ixnFileMap != null && (ixnFileMap is XmlNodeTag.FileMap))
                    {
                        gridSet.Map = ixnFileMap as XmlNodeTag.FileMap;
                    }
                    else
                    {
                        debugInfo.Add("Parsing FileMap.xml did not result in a valid FileMap object");
                        return null;
                    }
                }
                fileMapStream.Close();
            }

            if (gridSet.Map == null)
            {
                debugInfo.Add("No FileMap loaded");
                return null;
            }

            // Use FileMap to populate 
            foreach (Entry entry in gridSet.Map.ChildrenOfType<Entry>(1))
            {
                debugInfo.Add(String.Format("File map entry: {0}", entry.StaticFile));
                if (entry.StaticFile != null && entry.StaticFile.ToPathParts().Last() == "grid.xml")
                {
                    gridSet.__fileNames.Add(entry.StaticFile);
                }
            }

            // Loop through fileNames, reading grid.xml files into Grid objects as we go
            foreach (string gridFileName in gridSet.__fileNames)
            {
                ZipArchiveEntry? pageGridFile = (from ZipArchiveEntry e in gridFile.Entries
                                                 where e.FullName == gridFileName.Replace("\\", "/")
                                                 select e).First();
                using (Stream fsGridFile = pageGridFile.Open())
                {
                    using (StreamReader gridFileReader = new StreamReader(fsGridFile))
                    {
                        IXmlNode ixnGrid;
                        string gridXml = gridFileReader.ReadToEnd();
                        ixnGrid = XmlNodeBasic.CreateFromXml(gridXml);
                        if (ixnGrid != null && (ixnGrid is XmlNodeTag.Grid))
                        {
                            Grid? g = ixnGrid as Grid;
                            if (g != null)
                            {
                                g.Name = gridFileName.ToPathParts().SkipLast(1).Last();
                                g.RelativePath = gridFileName;
                                g.Parent = gridSet;
                                gridSet.Grids.Add(g);
                            }
                        }
                        else
                        {
                            debugInfo.Add("Parsing Grid.xml did not result in a valid Grid object");
                            return null;
                        }
                    }
                }
            }

            /*
            // Loop through all entries
            foreach (ZipArchiveEntry entry in gridFile.Entries)
            {
                string[] folders = entry.FullName.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar });
                //debugInfo.Add(entry.FullName);
                debugInfo.Add(String.Join(" / ", folders));
            }
            */

            return gridSet;
        }

    }
}
