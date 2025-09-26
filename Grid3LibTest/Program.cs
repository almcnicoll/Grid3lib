using System;
using System.Collections.Generic;
using G3L = Grid3lib;
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
            if (System.IO.File.Exists(@"C:\Users\GZYBK12\AppData\Local\Temp\test.xml"))
            {
                fileLines = System.IO.File.ReadAllLines(@"C:\Users\GZYBK12\AppData\Local\Temp\test.xml");
            }
            else
            {
                fileLines = System.IO.File.ReadAllLines(@"C:\Users\almcn\AppData\Local\Temp\test.xml");
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
            return gs;
        }

        static void TestWriteXmlMetadata(GridSet gs)
        {
            // Test XML writing by outputting the Settings and FileMap files to temp files
            string tempDir = Path.Combine(Path.GetTempPath(), System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            Directory.CreateDirectory(tempDir);

            string tempXmlSettings = Path.Combine(tempDir, "settings.xml");
            string tempXmlFileMap = Path.Combine(tempDir, "FileMap.xml");

            if (gs.Settings == null) { System.IO.File.WriteAllText(tempXmlSettings, ""); } else { System.IO.File.WriteAllText(tempXmlSettings, gs.Settings.ToString()); }
            if (gs.Map == null) { System.IO.File.WriteAllText(tempXmlFileMap, ""); } else { System.IO.File.WriteAllText(tempXmlFileMap, gs.Map.ToString()); }
        }

        static void TryDearZooCopy()
        {
            GridSet gs = TestLoadGridset(@"G:\My Drive\Florence\Grid3\backup\grids\Dear Zoo.gridset");
            Grid? g = null;

            if (gs == null)
            {
                Console.WriteLine("GridSet not loaded");
            }
            else
            {
                TestWriteXmlMetadata(gs);

                // Try converting all writes to speaknows
                Console.WriteLine("********");
                foreach (Grid3lib.XmlNodeTag.Grid grid in gs.Grids)
                {
                    Console.WriteLine(grid.Name);
                    /*
                    int x, y;
                    for (y = 0; y < grid.RowCount; y++)
                    {
                        for (x = 0; x < grid.ColumnCount; x++)
                        {
                            //Grid3lib.Cell cell = grid.GetCell(x, y);
                            //if (cell == null) { Console.WriteLine(String.Format("Null cell {0},{1}", x, y)); continue; } // Don't process null cells
                            //foreach (Grid3lib.Command command in cell.Commands)
                            //{
                                //Console.WriteLine(command.Action);
                            //}
                        }
                    }
                    */
                    g = grid;
                }
                if (g != null)
                {
                    List<Grid3lib.XmlNodeTag.Command> AllCommands = gs.ChildrenOfType<Command>(-1);

                    foreach (Command command in AllCommands)
                    {
                        if (command.ID != null && command.ID == Grid3lib.Grid3.Actions.Write)
                        {
                            command.ID = Grid3lib.Grid3.Actions.SpeakNow;
                            // TODO - contents of these commands are stored differently - conversion prob needed
                        }
                    }
                }

                gs.SaveAs(@"G:\My Drive\Florence\Grid3\backup\grids\Dear Zoo grid3lib.gridset");
            }
        }

        static void TrySchoolNewsMake()
        {
            // Create gridset
            GridSet gs = new GridSet("G3L School News");
            // Create and populate grid
            Grid g = new Grid();
            g.Name = "Start";
            for (int i = 0; i < 5; i++) { g.AddChildOfType<ColumnDefinition>(true); }
            for (int i = 0; i < 5; i++) { g.AddChildOfType<RowDefinition>(true); }
            Cell cGE = g.AddCell(0, 0, 1, 1, "Home");
            Content content = cGE.GetOrCreateImmediateChild<Content>(); //.AddChildOfType<Content>();
            Commands cmds = content.AddChildOfType<Commands>();
            Command cmd = cmds.AddChildOfType<Command>();
            cmd.ID = G3L.Grid3.Actions.Settings_ChangeGridSet;
            Parameter param = cmd.AddChildOfType<Parameter>();
            param.Key = "gridsetname"; param.Value = "SuperDuperCore";

            string[] dayNames = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            for (int day = 0; day < 5; day++)
            {
                Cell dayCell = g.AddCell(day, 3, 1, 1, dayNames[day]);
                dayCell.AddCommand(
                    new Command(G3L.Grid3.Actions.SpeakNow)
                    , new Parameter[]
                    {
                        new("text",$"News from {dayNames[day]}"),
                        new("wait","2"),
                        new("useauditoryvoice","0"),
                    }
                );
                /*Content dayContent = dayCell.GetOrCreateImmediateChild<Content>(); //.AddChildOfType<Content>();
                Commands dayCmds = dayContent.AddChildOfType<Commands>();
                Command dayCmd = dayCmds.AddChildOfType<Command>();
                dayCmd.ID = G3L.Grid3.Actions.SpeakNow;
                Parameter dayParamTxt = dayCmd.AddChildOfType<Parameter>();
                dayParamTxt.Key = "text"; dayParamTxt.Value = $"News from {dayNames[day]}.";
                Parameter dayParamWait = dayCmd.AddChildOfType<Parameter>();
                dayParamWait.Key = "wait"; dayParamWait.Value = "2";
                Parameter dayParamVoice = dayCmd.AddChildOfType<Parameter>();
                dayParamVoice.Key = "useauditoryvoice"; dayParamVoice.Value = "0";*/
            }

            // Create settings
            GridSetSettings s = new GridSetSettings();
            s.StartGrid = "Start";
            //s.ThumbnailBackground = "#EB6B56FF";
            gs.Settings = s;

            // Add grid to gridset
            gs.Grids.Add(g);
            // Save
            gs.SaveAs(@"C:\Users\Public\Documents\Smartbox\Grid 3\Remote Editors\florence@almcnicoll.co.uk\Grid Sets\G3L-school-news.gridset");
        }

        static void Main(string[] args)
        {
            // TestXmlParsing();
            //TryDearZooCopy();

            TrySchoolNewsMake();
        }
    }
}
