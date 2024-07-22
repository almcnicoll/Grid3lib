#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using XmlParsing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;
using Grid3lib.ToConvert;

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
                                // TODO TOP PRIORITY - what if this is an in-memory thumbnail rather than a file reference? What if it's a local file rather than an archive reference.
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
            // TODO HIGH PRIORITY - Add other grids that aren't in the FileMap - FileMap seems to mainly contain grids with media files
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

                // Now add any other grids that aren't in the FileMap
                if (gridSet.Map == null) { throw new Exception("Map not created successfully"); }
                Entries fileMapEntries = gridSet.Map.ChildrenOfType<Entries>(-1).FirstOrDefault();
                // Find all grids in Zip - this populates "Entries"
                List<ZipArchiveEntry> gridEntries = (from ZipArchiveEntry zipEntry in gridsetZipFile.Entries where zipEntry.Name == "grid.xml" select zipEntry).ToList();
                foreach (ZipArchiveEntry gridEntry in gridEntries)
                {
                    string gridEntryPath = Path.GetDirectoryName(gridEntry.FullName); // e.g. Grids\Test
                    string gridsOnlyPath = Path.GetDirectoryName(gridEntryPath); // e.g. Grids
                    string thisGridName = gridEntryPath.Substring(gridsOnlyPath.Length + 1); // e.g. Test
                    // Don't add if already added
                    if ((from Entry e in gridSet.Map.ChildrenOfType<Entry>(-1) where (e.StaticFile == gridEntry.FullName + @"\grid.xml") select e).Count() > 0) { continue; }
                    Entry newEntry = fileMapEntries.AddChildOfType<Entry>();
                    newEntry.SetAttributeValue("StaticFile", gridEntry.FullName);
                    // Now check for any dependent files ("dynamic files")
                    List<ZipArchiveEntry> dynamicEntries = (from ZipArchiveEntry zipEntry in gridsetZipFile.Entries where (zipEntry.FullName.Length >= gridEntryPath.Length && zipEntry.FullName.Substring(0, gridEntryPath.Length) == gridEntryPath) select zipEntry).ToList();
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
                                                where e.FullName == WebUtility.HtmlDecode(gridFileName.Replace("\\", "/"))
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
            // TODO HIGH PRIORITY - FileMap.xml not saving at the moment
            // TODO HIGH PRIORITY - styles.xml not saving at the moment
            // TODO HIGH PRIORITY - media files not saving
            // TODO HIGH PRIORITY - At least one <Command> not saving (standard Command tag, following self-closing Command tag) - <Command ID="Prediction.PredictThis">, <Command ID="ComputerControl.Shift">
            // TODO HIGH PRIORITY - folders saving with html entities encoded
            // TODO MED PRIORITY - thumbnail not saving
            // TODO MED PRIORITY - webbrowserextensions.xml not saving (in Settings0 folder)
            // TODO MED PRIORITY - autoreplacements.xml not saving (in Settings0 folder)
            // TODO LOW PRIORITY - if some grids aren't loaded due to lazy-loading, could they be copied over rather than loaded and then serialized?
            debugInfo = new List<string>();
            // Create temporary storage area
            Guid tempID = Guid.NewGuid();
            string tempFolder = Path.Combine(Path.GetTempPath(), System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            string workingFolder = Path.Combine(tempFolder, tempID.ToString("D"));
            Directory.CreateDirectory(workingFolder);

            Dictionary<string, string> files = new Dictionary<string, string>(); // Use to log all files that need to be saved to archive (as we're not using Zip-whole-folder functionality)

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
                files.Add(destinationFile, Utility.makeRelativePath(Grid3.Paths.SettingsXml));
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
                files.Add(destinationFile, Utility.makeRelativePath(sourceFile));
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
                files.Add(destinationFile, Utility.makeRelativePath(sourceFile));
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
                string gridFileName = Path.Combine(workingFolder, gridFolder, "grid.xml");
                System.IO.File.WriteAllText(gridFileName, gridXml);
                files.Add(gridFileName, Utility.makeRelativePath(gridFileName, workingFolder));

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
                        files.Add(destinationFile, Utility.makeRelativePath(destinationFile, workingFolder));
                    }
                }
            }

            // Write the filemap
            fileMap.Write(Path.Combine(tempFolder, "FileMap.xml"));
            // Zip up folder into a .gridset file
            // NB paths must be relative/forward-slash NOT absolute\backslash - wrong slashes will cause Grid3 to crash
            // at time of writing, ZipFile.CreateFromDirectory creates relative paths
            // TODO - replace this code - ZipFile seems to include something which crashes Grid3 - perhaps desktop.ini files?
            string tempOutputFileName = Path.Combine(tempFolder, (this.Name == null ? "temp" : this.Name) + ".gridset");
            if (System.IO.File.Exists(tempOutputFileName)) { System.IO.File.Delete(tempOutputFileName); }
            // ZipFile.CreateFromDirectory(workingFolder, tempOutputFileName, CompressionLevel.Optimal, false);
            // Method 2
            Stream tempOutputStream = new FileStream(Path.Combine(workingFolder, tempOutputFileName), FileMode.Create, FileAccess.Write);
            ZipArchive tempOutputArchive = new ZipArchive(tempOutputStream, ZipArchiveMode.Create);
            foreach (KeyValuePair<string, string> file in files)
            {
                ZipArchiveEntry tempArchiveEntry = tempOutputArchive.CreateEntryFromFile(file.Key, file.Value);
            }
            tempOutputArchive.Dispose();
            // Method 3
            Stream tempOutputStream = new FileStream(Path.Combine(workingFolder, tempOutputFileName), FileMode.Create, FileAccess.Write);
            
			foreach (KeyValuePair<string, string> file in files)
            {
                
            }
            
            // And now save to final destination
            System.IO.File.Copy(tempOutputFileName, filePath, overwrite: true);

        }

        /// <summary>
        /// Searches for a grid by name
        /// </summary>
        /// <param name="gridName">The name of the grid to search for</param>
        /// <returns>A <see cref="Grid"/> object, or null if the name cannot be found</returns>
        public Grid? getGrid(string gridName)
        {
            List<Grid> matches = (from Grid g in Grids where g.Name == gridName select g).ToList();
            if (matches.Count > 0) { return matches[0]; }
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

        /// <summary>
        /// Removes the specified grid from the GridSet
        /// </summary>
        /// <param name="grid">The grid to remove</param>
        public void removeGrid(Grid grid)
        {
            Grids.Remove(grid);
        }

        /// <summary>
        /// Removes the grid with the specified id from the GridSet
        /// </summary>
        /// <param name="id">The id of the grid to remove</param>
        public void removeGrid(Guid id)
        {
            Grid? gridLookup = getGrid(id);
            if (gridLookup == null)
            {
                throw new Exception(String.Format("Cannot find grid with id {0}", id));
            }
            Grids.Remove(gridLookup);
        }

        /// <summary>
        /// Applies a function to each matching file in the specified GridSet
        /// </summary>
        /// <param name="gridsetFile">The path of the .gridset file</param>
        /// <param name="filePattern">The pattern to match within the gridset</param>
        /// <param name="processingFunction">The function to apply to each matching file - taking the full filename as a string, an input stream and returning an output stream</param>
        public static void processFiles(string gridsetFile, Regex filePattern, Func<string, Stream, Stream> processingFunction)
        {
            if (gridsetFile == null) { throw new ArgumentNullException(nameof(gridsetFile)); }
            if (filePattern == null) { throw new ArgumentNullException(nameof(filePattern)); }
            if (processingFunction == null) { throw new ArgumentNullException(nameof(processingFunction)); }

            // Get files in gridset
            using (ZipArchive zipArchive = ZipFile.Open(gridsetFile, ZipArchiveMode.Update))
            {

                // Filter them by pattern
                List<ZipArchiveEntry> entries = (from ZipArchiveEntry entry in zipArchive.Entries
                                                 where filePattern.IsMatch(entry.FullName)
                                                 select entry).ToList();

                // For each file, read, process, write
                foreach (ZipArchiveEntry entry in entries)
                {
                    // Get the contents of the file
                    using (Stream zipSource = entry.Open())
                    {
                        using (MemoryStream original = new MemoryStream())
                        {
                            // Copy zip archive entry to MemoryStream
                            zipSource.CopyTo(original);
                            zipSource.Seek(0, SeekOrigin.Begin);
                            original.Seek(0, SeekOrigin.Begin);
                            // Process the file using the supplied functions
                            Stream output = processingFunction(entry.FullName, original);
                            // So long as output isn't null, write it to the ZipArchiveEntry
                            if (output != null)
                            {
                                /*contents.Position = 0;
                                contents.SetLength(0);
                                using (StreamWriter writer = new StreamWriter(contents))
                                {
                                    writer.Write(output);
                                }*/
                                zipSource.Seek(0, SeekOrigin.Begin);
                                output.Seek(0, SeekOrigin.Begin);
                                zipSource.SetLength(0);

                                string fullPath = entry.FullName;
                                output.CopyTo(zipSource);
                                zipSource.Dispose();
                                /*
                                entry.Delete();
                                ZipArchiveEntry newEntry = zipArchive.CreateEntry(fullPath);
                                Stream zipDestination = newEntry.Open();
                                output.CopyTo(zipDestination);
                                zipDestination.Dispose();
                                */
                                //zipDestination.Seek(0, SeekOrigin.Begin);                            
                            }
                        }
                    }
                }
            }
            return;
        }
        /// <summary>
        /// Applies a function to each matching file in the specified GridSet
        /// </summary>
        /// <param name="gridsetFile">The path of the .gridset file</param>
        /// <param name="wildcard">The filename wildcard to match within the gridset</param>
        /// <param name="processingFunction">The function to apply to each matching file - taking the full filename as a string, an input stream and returning an output stream</param>
        public static void processFiles(string gridsetFile, string wildcard, Func<string, Stream, Stream> processingFunction)
        {
            GridSet.processFiles(gridsetFile, Utility.RegexFromWildcard(wildcard), processingFunction);
            return;
        }

        /// <summary>
        /// Returns all files in the specified Gridset which match the given pattern and are larger than the specified size
        /// </summary>
        /// <param name="gridsetFile">The full file path of the .gridset file</param>
        /// <param name="largerThan">The minimum size in bytes of the files to return</param>
        /// <param name="filePattern">A <see cref="Regex"/> to filter the results, or null to leave unfiltered</param>
        /// <returns>A dictionary of relative paths and (uncompressed) sizes</returns>
        public static Dictionary<string, long> listFiles(string gridsetFile, long largerThan = 0, Regex? filePattern = null)
        {
            List<ZipArchiveEntry> entries;
            // Get files in gridset
            using (ZipArchive zipArchive = ZipFile.Open(gridsetFile, ZipArchiveMode.Read))
            {
                if (filePattern == null)
                {
                    entries = (from ZipArchiveEntry entry in zipArchive.Entries
                               where entry.Length > largerThan
                               select entry).ToList();
                }
                else
                {
                    // Filter them by pattern
                    entries = (from ZipArchiveEntry entry in zipArchive.Entries
                               where filePattern.IsMatch(entry.FullName)
                                && entry.Length > largerThan
                               select entry).ToList();
                }
            }
            return (from ZipArchiveEntry entry in entries
                    select new KeyValuePair<string, long>(entry.FullName, entry.Length)).ToDictionary(t => t.Key, t => t.Value);
        }
    }
}
