using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Grid3lib
{
    public class Cell
    {
        public Page Parent;

        public String Label = "";
        public String Icon = ""; // Format is [symbolset]filename.wmf
        public String Picture = "";
        public Color BackColor = Color.FromArgb(255, Color.White); //'#FFFFFFFF'; // #AARRGGBB
        public Color TextColor = Color.FromArgb(255, Color.Black); //'#FF000000'; // #AARRGGBB
        public Color BorderColor = Color.FromArgb(255, Color.Black); //'#FF000000'; // #AARRGGBB
        public String BaseStyle = "";
        public string Action = "";
        public string SpeakText = "";
        public string WriteText = "";
        public int Column = 0;
        public int Row = 0;

    }
}
