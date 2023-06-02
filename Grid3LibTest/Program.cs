using System;
using System.Collections.Generic;
using Grid3lib;

namespace Grid3LibTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> output = new List<string>();
            //GridSet gs = GridSet.Load(@"G:\My Drive\Florence\Grid3\backup\grids\Super Core PCS (Florence McNicoll's conflicted copy) (1).gridset", out output);
            GridSet gs = GridSet.Load(@"G:\My Drive\Florence\Grid3\backup\grids\Dear Zoo.gridset", out output);

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
                foreach (Page page in gs.Pages)
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
