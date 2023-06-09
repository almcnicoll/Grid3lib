using System;
using System.Collections.Generic;
using Grid3lib;
using XmlParsing;
using System.IO;

namespace Grid3LibTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test XML parsing code
            string[] fileLines = File.ReadAllLines(@"C:\Users\GZYBK12\AppData\Local\Temp\test.xml");
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
                foreach (Grid page in gs.Grids)
                {
                    Console.WriteLine("********");
                    Console.WriteLine(page.Name);
                    int x, y;
                    for (y = 0; y < page.RowCount; y++)
                    {
                        for (x = 0; x < page.ColumnCount; x++)
                        {
                            Cell cell = page.GetCell(x, y);
                            if (cell == null) { Console.WriteLine(String.Format("Null cell {0},{1}", x, y)); continue; } // Don't process null cells
                            foreach (Command command in cell.Commands)
                            {
                                Console.WriteLine(command.Action);
                            }
                        }
                    }
                }
            }
        }
    }
}
