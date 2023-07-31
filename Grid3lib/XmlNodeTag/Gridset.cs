#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Serialization;
using Grid3lib.ImportClasses;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a GridSet
    /// NB - there is not actually a GridSet node, but by making this an XmlNodeTag class, we can make it a parent of <see cref="Grid"/> objects
    /// </summary>
    public class GridSet : XmlNodeBasic
    {
        /// <summary>
        /// The user-facing name of the <see cref="GridSet">GridSet</see>
        /// </summary>
        public string? Name { get; set; } = null;

        /// <summary>
        /// The unique <see cref="Guid"/> of the <see cref="GridSet">GridSet</see>
        /// </summary>
        public Guid? GridSetId { get; set; } = null;

        /// <summary>
        /// Which <see cref="Grid"/> is the "home page" for this GridSet
        /// </summary>
        public Grid? Homepage { get; set; } = null;

        /// <summary>
        /// A reference to the Zip archive from which the <see cref="GridSet">GridSet</see> was loaded
        /// </summary>
        public ZipArchive? Archive { get; set; } = null;

        /// <summary>
        /// The settings loaded from the <see cref="GridSet">GridSet</see>'s settings.xml
        /// </summary>
        public GridSetSettings? Settings { get; set; } = null;

        /// <summary>
        ///  Contains a reference to the <see cref="GridSet"/>'s thumbnail image
        /// </summary>
        public Thumbnail? Thumbnail
        {
            get
            {
                if (this.Map == null) { return null; }

                foreach (Entry entry in Map.ChildrenOfType<Entry>(1))
                {
                    if (entry.StaticFile != null && entry.StaticFile.ToPathParts().Last() == "settings.xml")
                    {
                        List<File> dynamicFiles = entry.ChildrenOfType<File>();
                        foreach (File df in dynamicFiles)
                        {
                            if (df.filePath == null) { continue; }
                            if (Grid3.RegularExpressions.ThumbnailFile.IsMatch(df.filePath.ToPathParts().Last()))
                            {
                                return df as Thumbnail;
                            }
                        }
                    }
                }
                return null;
            }
            set
            {
                if (this.Map == null) { throw new Exception("Cannot find a FileMap to which the thumbnail can be added"); }

                foreach (Entry entry in Map.ChildrenOfType<Entry>(1))
                {
                    if (entry.StaticFile != null && entry.StaticFile.ToPathParts().Last() == "settings.xml")
                    {
                        List<File> dynamicFiles = entry.ChildrenOfType<File>();
                        foreach (File df in dynamicFiles)
                        {
                            if (df.filePath == null) { continue; }
                            if (Grid3.RegularExpressions.ThumbnailFile.IsMatch(df.filePath.ToPathParts().Last()))
                            {
                                // TODO - what if this is an in-memory thumbnail rather than a file reference? What if it's a local file rather than an archive reference.
                                if (value == null) { df.Parent?.Children.Remove(df); return; }
                                df.filePath = value.filePath; return;
                            }
                        }
                    }
                }
                // TODO HIGH PRIORITY - Need to check for / add the right Settings entry to FileMap, then add a dynamic file for its thumbnail
            }
        }

        /// <summary>
        /// Contains style data for the <see cref="GridSet">GridSet</see>
        /// </summary>
        public Styles? Styles { get; set; } = null;

        /// <summary>
        /// The file map loaded from the <see cref="GridSet">GridSet</see>'s FileMap.xml
        /// </summary>
        public FileMap? Map { get; set; } = null;

        internal List<String> __fileNames = new List<String>();

        /// <summary>
        /// A set of all the Grids within the GridSet
        /// </summary>
        public HashSet<Grid> Grids { get; set; } = new HashSet<Grid>();
        // TODO - some way of keeping FileMap.xml up-to-date
        // OR just regenerate from Grids if we're _certain_ that we know all the possible tags and attributes that FileMaps can contain
        // The latter is going to be tidier if we're going to be adding and removing grids and media within grids

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
        public static GridSet? Load(string filePath)
        {
            List<string> discard = new List<string>();
            return GridSet.Load(filePath, out discard);
        }

        /// <summary>
        /// Loads a GridSet from a .gridset file
        /// </summary>
        /// <param name="filePath">The full path of the GridSet file</param>
        /// <param name="debugInfo">Debugging info outputted during loading</param>
        /// <returns>A <see cref="GridSet"/> object loaded from the file, or null on failure</returns>
        public static GridSet? Load(String filePath, out List<string> debugInfo)
        {
            GridSet gridSet = new GridSet();
            debugInfo = new List<string>();
            ZipArchive gridsetZipFile = ZipFile.OpenRead(filePath);
            gridSet.Archive = gridsetZipFile;

            // Retrieve and parse settings.xml
            // Get file
            ZipArchiveEntry? settingsFile = (from ZipArchiveEntry zipEntry in gridsetZipFile.Entries
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
            ZipArchiveEntry? fileMapFile = null;
            try
            {
                fileMapFile = (from ZipArchiveEntry zipEntry in gridsetZipFile.Entries
                               where zipEntry.FullName == "FileMap.xml"
                               select zipEntry).First();
            }
            catch
            {
                // It's OK to have a GridSet with no FileMap.xml - it appears to be valid (see for example "Ancient Egypt") - handle below
            }
            if (fileMapFile == null)
            {
                debugInfo.Add("No FileMap.xml found - creating one from the directory structure");
                // Create object
                FileMap fileMap = new FileMap();
                Entries fileMapEntries = fileMap.GetOrCreateImmediateChild<Entries>();

                // Find all grids in Zip - this populates "Entries"
                List<ZipArchiveEntry> gridEntries = (from ZipArchiveEntry zipEntry in gridsetZipFile.Entries where zipEntry.Name == "grid.xml" select zipEntry).ToList();
                foreach (ZipArchiveEntry gridEntry in gridEntries)
                {
                    string gridEntryPath = Path.GetDirectoryName(gridEntry.FullName); // e.g. Grids\Test
                    string gridsOnlyPath = Path.GetDirectoryName(gridEntryPath); // e.g. Grids
                    string thisGridName = gridEntryPath.Substring(gridsOnlyPath.Length + 1); // e.g. Test
                    Entry newEntry = fileMapEntries.AddChildOfType<Entry>();
                    newEntry.SetAttributeValue("StaticFile", gridEntry.FullName);
                    // Now check for any dependent files ("dynamic files")
                    List<ZipArchiveEntry> dynamicEntries = (from ZipArchiveEntry zipEntry in gridsetZipFile.Entries where zipEntry.FullName.Substring(0, gridEntryPath.Length) == gridEntryPath select zipEntry).ToList();
                    if (dynamicEntries.Count > 0)
                    {
                        DynamicFiles dynamicFileEntries = newEntry.GetOrCreateImmediateChild<DynamicFiles>();
                        foreach (ZipArchiveEntry dynamicEntry in dynamicEntries)
                        {
                            File newFile = dynamicFileEntries.AddChildOfType<File>();
                            newFile.InnerXml.Add(new RawXml(dynamicEntry.FullName, true));
                        }
                    }
                }

                // Assign to Gridset
                gridSet.Map = fileMap;
            }
            else
            {
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
            }

            if (gridSet.Map == null)
            {
                debugInfo.Add("No FileMap loaded");
                return null;
            }

            // Use FileMap to populate GridSet with grid "headers"
            foreach (Entry entry in gridSet.Map.ChildrenOfType<Entry>(1))
            {
                debugInfo.Add(String.Format("File map entry: {0}", entry.StaticFile));
                if (entry.StaticFile != null && entry.StaticFile.ToPathParts().Last() == "grid.xml")
                {
                    gridSet.__fileNames.Add(entry.StaticFile);
                }
                else if (entry.StaticFile != null && entry.StaticFile.ToPathParts().Last() == "settings.xml")
                {
                    List<File> dynamicFiles = entry.ChildrenOfType<File>();
                    foreach (File df in dynamicFiles)
                    {
                        if (df.filePath == null) { continue; }
                        if (Grid3.RegularExpressions.ThumbnailFile.IsMatch(df.filePath.ToPathParts().Last()))
                        {
                            gridSet.Thumbnail = df as Thumbnail;
                        }
                    }
                }
            }

            // Read in styles.xml (not in FileMap for some reason)
            ZipArchiveEntry? stylesXmlFile = null;
            try
            {
                stylesXmlFile = (from ZipArchiveEntry zipEntry in gridsetZipFile.Entries
                                 where zipEntry.FullName == "styles.xml"
                                 select zipEntry).First();
            }
            catch
            {
                // Nothing here - it's OK to have no style
            }
            if (stylesXmlFile != null)
            {
                using (Stream fsStylesFile = stylesXmlFile.Open())
                {
                    using (StreamReader styleFileReader = new StreamReader(fsStylesFile))
                    {
                        IXmlNode ixnStyles;
                        string stylesXml = styleFileReader.ReadToEnd();
                        ixnStyles = XmlNodeBasic.CreateFromXml(stylesXml);
                        if (ixnStyles != null && (ixnStyles is XmlNodeTag.Styles))
                        {
                            Styles? s = ixnStyles as Styles;
                            if (s != null)
                            {
                                s.Parent = gridSet;
                                gridSet.Styles = s;
                                gridSet.Children.Add(s);
                                s.filePath = stylesXmlFile.FullName;
                                s.sourceIsArchive = true;
                            }
                        }
                    }
                }
            }

            // Loop through fileNames, reading grid.xml files into Grid objects as we go
            foreach (string gridFileName in gridSet.__fileNames)
            {
                ZipArchiveEntry? gridXmlFile = (from ZipArchiveEntry e in gridsetZipFile.Entries
                                                where e.FullName == gridFileName.Replace("\\", "/")
                                                select e).First();
                using (Stream fsGridFile = gridXmlFile.Open())
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
                                // TODO HIGH PRIORITY - handle DynamicFiles and attach these to the grid
                                gridSet.Grids.Add(g);
                                gridSet.Children.Add(g);
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

        /// <summary>
        /// Saves a GridSet to a .gridset file
        /// </summary>
        /// <param name="filePath">The full path of the GridSet file to write</param>
        public void SaveAs(String filePath)
        {
            List<string> discard = new List<string>();
            SaveAs(filePath, out discard);
        }

        /// <summary>
        /// Saves a GridSet to a .gridset file
        /// </summary>
        /// <param name="filePath">The full path of the GridSet file</param>
        /// <param name="debugInfo">Debugging info outputted during loading</param>
        /// <returns>A <see cref="GridSet"/> object loaded from the file, or null on failure</returns>
        public void SaveAs(String filePath, out List<string> debugInfo)
        {
            // TODO LOW PRIORITY - if some grids aren't loaded due to lazy-loading, could they be copied over rather than loaded and then serialized?
            debugInfo = new List<string>();
            // Create temporary storage area
            Guid tempID = Guid.NewGuid();
            string tempFolder = Path.Combine(Path.GetTempPath(), System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            string workingFolder = Path.Combine(tempFolder, tempID.ToString("D"));
            Directory.CreateDirectory(workingFolder);

            // Create primary folder structure
            Utility.CreateSubFolder(workingFolder, Grid3.Paths.GridsFolder);
            Utility.CreateSubFolder(workingFolder, Grid3.Paths.SettingsFolder);
            Utility.CreateSubFolder(workingFolder, Grid3.Paths.StylesFolder);
            debugInfo.Add(String.Format("Created primary folder structure in {0}", workingFolder));

            // Create a blank FileMap and populate as we go
            FileMap fileMap = new FileMap();

            // Write settings.xml
            if (Settings != null)
            {
                string SettingsXml = Settings.ToString();
                string destinationFile = Path.Combine(workingFolder, Grid3.Paths.SettingsXml);
                System.IO.File.WriteAllText(destinationFile, SettingsXml);
            }

            // Write thumbnail
            if (Thumbnail != null)
            {
                string? sourceFile = Thumbnail.filePath;
                string destinationFile = Path.Combine(workingFolder, sourceFile);
                if (Thumbnail.sourceIsArchive)
                {
                    if (this.Archive == null)
                    {
                        throw new FileNotFoundException("Thumbnail listed as being in archive, but no GridSet archive present");
                    }
                    else
                    {
                        this.Archive.GetEntry(sourceFile).ExtractToFile(destinationFile, true);
                    }
                }
                else
                {
                    System.IO.File.Copy(sourceFile, destinationFile, true);
                }
            }

            // Write Styles/styles.xml
            if (Styles != null)
            {
                string? sourceFile = Styles.filePath; if (sourceFile == null) { sourceFile = Grid3.Paths.StylesXml; }
                string destinationFile = Path.Combine(workingFolder, sourceFile);
                if (Styles.sourceIsArchive)
                {
                    if (this.Archive == null)
                    {
                        throw new FileNotFoundException("Styles file listed as being in archive, but no GridSet archive present");
                    }
                    else
                    {
                        this.Archive.GetEntry(sourceFile).ExtractToFile(destinationFile, true);
                    }
                }
                else
                {
                    System.IO.File.Copy(sourceFile, destinationFile, true);
                }
            }

            // Create folder structure of grids, also writing out grid.xml files and any associated media files
            foreach (Grid grid in this.Grids)
            {
                // Create grid folder
                string gridFolder = "Grids/" + grid.Name;
                Utility.CreateSubFolder(workingFolder, gridFolder);
                debugInfo.Add("Created folder " + gridFolder);

                // Generate and write grid.xml
                string gridXml = grid.ToString();
                debugInfo.Add(String.Format("Grid {0} has grid.xml of length {1} characters", grid.Name, gridXml.Length));
                System.IO.File.WriteAllText(Path.Combine(workingFolder, gridFolder, "grid.xml"), gridXml);

                if (grid.FileMapEntry != null)
                {
                    Entry entry = grid.FileMapEntry;
                    foreach (XmlNodeTag.File file in entry.ChildrenOfType<XmlNodeTag.File>(2))
                    {
                        string? sourceFile = file.filePath;
                        if (sourceFile == null) { throw new FileNotFoundException("Could not find dynamic file"); }
                        string destinationFile = Path.Combine(workingFolder, sourceFile);
                        if (file.sourceIsArchive)
                        {
                            if (this.Archive == null)
                            {
                                throw new FileNotFoundException("File listed as being in archive, but no GridSet archive present");
                            }
                            else
                            {
                                this.Archive.GetEntry(sourceFile).ExtractToFile(destinationFile, true);
                            }
                        }
                        else
                        {
                            System.IO.File.Copy(sourceFile, destinationFile, true);
                        }
                    }
                }
            }

            // TODO HIGH PRIORITY - Write FileMap.xml
            // Zip up folder into a .gridset file
            string tempOutputFileName = Path.Combine(tempFolder, (this.Name == null ? "temp" : this.Name) + ".gridset");
            if (System.IO.File.Exists(tempOutputFileName)) { System.IO.File.Delete(tempOutputFileName); }
            ZipFile.CreateFromDirectory(workingFolder, tempOutputFileName, CompressionLevel.Optimal, false);
            System.IO.File.Copy(tempOutputFileName, filePath, overwrite: true);
            // TODO HIGH PRIORITY - check whether paths use absolute\backslash or relative/forward-slash - wrong slashes will apparently cause Grid3 to crash

        }

        /// <summary>
        /// Searches for a grid by name
        /// </summary>
        /// <param name="gridName">The name of the grid to search for</param>
        /// <returns>A <see cref="Grid"/> object, or null if the name cannot be found</returns>
        public Grid? getGrid(string gridName)
        {
            List<Grid> matches = (from Grid g in Grids where g.Name == gridName select g).ToList();
            if (matches.Count > 0) { return matches[1]; }
            return null;
        }

        /// <summary>
        /// Searches for a grid by ID
        /// </summary>
        /// <param name="id">The ID of the grid to search for</param>
        /// <returns>A <see cref="Grid"/> object, or null if the name cannot be found</returns>
        public Grid? getGrid(Guid id)
        {
            List<Grid> matches = (from Grid g in Grids where g.GridId.Equals(id) select g).ToList();
            if (matches.Count > 0) { return matches[1]; }
            return null;
        }
    }
}
