using System;
using System.Collections.Generic;
//using Grid3lib;
using XmlParsing;
using System.IO;
//using Grid3lib.XmlNodeTag;

namespace Grid3LibTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test XML parsing code
            string[] fileLines;
            if (File.Exists(@"C:\Users\GZYBK12\AppData\Local\Temp\test.xml"))
            {
                fileLines = File.ReadAllLines(@"C:\Users\GZYBK12\AppData\Local\Temp\test.xml");
            } else
            {
                fileLines = File.ReadAllLines(@"C:\Users\almcn\AppData\Local\Temp\test.xml");
            }
            string testXml = String.Join("",fileLines);

            List<Exception> exceptions = new List<Exception>();
            exceptions = XmlParseFunctions.ValidateXml(testXml);
            if (exceptions == null)
            {
                Console.WriteLine("Test Xml validated OK");
            } else { 
                foreach (Exception ex in exceptions)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //return;

            // Test gridset load and read
            List<string> output = new List<string>();
            //GridSet gs = GridSet.Load(@"G:\My Drive\Florence\Grid3\backup\grids\Super Core PCS (Florence McNicoll's conflicted copy) (1).gridset", out output);
            Grid3lib.XmlNodeTag.GridSet gs = Grid3lib.XmlNodeTag.GridSet.Load(@"G:\My Drive\Florence\Grid3\backup\grids\Dear Zoo.gridset", out output);

            foreach (string s in output)
            {
                Console.WriteLine(s);
            }

            if (gs == null)
            {
                Console.WriteLine("GridSet not loaded");
            }
            else
            {

                // Try converting all speaks to writes
                foreach (Grid3lib.XmlNodeTag.Grid grid in gs.Grids)
                {
                    Console.WriteLine("********");
                    Console.WriteLine(grid.Name);
                    int x, y;
                    for (y = 0; y < grid.RowCount; y++)
                    {
                        for (x = 0; x < grid.ColumnCount; x++)
                        {
                            //TODO - uncomment this
                            /*Grid3lib.Cell cell = grid.GetCell(x, y);
                            if (cell == null) { Console.WriteLine(String.Format("Null cell {0},{1}", x, y)); continue; } // Don't process null cells
                            foreach (Grid3lib.Command command in cell.Commands)
                            {
                                Console.WriteLine(command.Action);
                            }
                            */
                        }
                    }
                }
            }
        }
    }
}
