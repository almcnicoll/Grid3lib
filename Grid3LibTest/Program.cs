using System;
using System.Collections.Generic;
//using Grid3lib;
using XmlParsing;
using System.IO;
using Grid3lib.XmlNodeTag;
//using Grid3lib.XmlNodeTag;

namespace Grid3LibTest
{
    internal class Program
    {
        static void TestXmlParsing()
        {
            // Test XML parsing code
            string[] fileLines;
            if (File.Exists(@"C:\Users\GZYBK12\AppData\Local\Temp\test.xml"))
            {
                fileLines = File.ReadAllLines(@"C:\Users\GZYBK12\AppData\Local\Temp\test.xml");
            }
            else
            {
                fileLines = File.ReadAllLines(@"C:\Users\almcn\AppData\Local\Temp\test.xml");
            }
            string testXml = String.Join("", fileLines);

            List<Exception> exceptions = new List<Exception>();
            exceptions = XmlParseFunctions.ValidateXml(testXml);
            if (exceptions == null)
            {
                Console.WriteLine("Test Xml validated OK");
            }
            else
            {
                foreach (Exception ex in exceptions)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static GridSet TestLoadGridset(string path)
        {
            // Test gridset load and read
            List<string> output = new List<string>();
            //GridSet gs = GridSet.Load(@"G:\My Drive\Florence\Grid3\backup\grids\Super Core PCS (Florence McNicoll's conflicted copy) (1).gridset", out output);
            Grid3lib.XmlNodeTag.GridSet gs = Grid3lib.XmlNodeTag.GridSet.Load(path, out output);

            // Output debug info
            foreach (string s in output)
            {
                Console.WriteLine(s);
            }
        }

        static void TestWriteXmlMetadata(GridSet gs)
        {
            // Test XML writing by outputting the Settings and FileMap files to temp files
            string tempDir = Path.Combine(Path.GetTempPath(), System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            Directory.CreateDirectory(tempDir);

            string tempXmlSettings = Path.Combine(tempDir, "settings.xml");
            string tempXmlFileMap = Path.Combine(tempDir, "FileMap.xml");

            if (gs.Settings == null) { File.WriteAllText(tempXmlSettings, ""); } else { File.WriteAllText(tempXmlSettings, gs.Settings.ToString()); }
            if (gs.Map == null) { File.WriteAllText(tempXmlFileMap, ""); } else { File.WriteAllText(tempXmlFileMap, gs.Map.ToString()); }
        }

        static void Main(string[] args)
        {
            // TestXmlParsing();

            GridSet gs = TestLoadGridset(@"G:\My Drive\Florence\Grid3\backup\grids\Dear Zoo.gridset");

            if (gs == null)
            {
                Console.WriteLine("GridSet not loaded");
            }
            else
            {
                TestWriteXmlMetadata(gs);

                // Try converting all speaks to writes
                foreach (Grid3lib.XmlNodeTag.Grid grid in gs.Grids)
                {
                    Console.WriteLine("********");
                    Console.WriteLine(grid.Name);
                    List<Grid3lib.XmlNodeTag.Command> AllCommands = gs.ChildrenOfType<Command>(-1);

                    foreach (Command command in AllCommands)
                    {
                        if (command.ID!= null && command.ID == "Action.InsertText")
                        {
                            command.ID = "Speech.SpeakNow";

                        }
                    }
                    /*
                    int x, y;
                    for (y = 0; y < grid.RowCount; y++)
                    {
                        for (x = 0; x < grid.ColumnCount; x++)
                        {
                            //TODO - uncomment this
                            //Grid3lib.Cell cell = grid.GetCell(x, y);
                            //if (cell == null) { Console.WriteLine(String.Format("Null cell {0},{1}", x, y)); continue; } // Don't process null cells
                            //foreach (Grid3lib.Command command in cell.Commands)
                            //{
                                //Console.WriteLine(command.Action);
                            //}
                        }
                    }
                    */
                }
            }
        }
    }
}
