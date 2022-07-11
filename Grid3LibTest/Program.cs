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
        }
    }
}
