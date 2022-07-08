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

        /// <summary>
        /// Creates a new cell with the specified attributes
        /// </summary>
        /// <param name="parent">The page to which the cell belongs</param>
        /// <param name="column">The column on which the cell is located</param>
        /// <param name="row">The row on which the cell is located</param>
        /// <param name="label">The cell's label</param>
        /// <param name="icon">The cell's icon</param>
        public Cell(Page parent, int column, int row, string label, string? icon = null)
        {
            this.Parent = parent;
            this.Label = label;
            if (icon != null)
            {
                this.Icon = icon;
            }
        }

        /// <summary>
        /// Returns the XML for this cell, ready for compression into the GridSet file
        /// </summary>
        /// <returns></returns>
        public string getXml()
        {
            // Commands
            $commands = '';
            if (!empty($this->commands)) {
                $commands.= "<Commands>\n";
                foreach ($this->commands as $command) {
                    if (empty($command->parameters)) {
                        $commands.= "<Command ID=\"{$command->action}\" />\n";
                    } else {
                        $commands.= "<Command ID=\"{$command->action}\">\n";
                        foreach ($command->parameters as $parameter) {
                            $commands.= "<Parameter Key=\"{$parameter->key}\">{$parameter->value}</Parameter>\n";
                        }
                    }
                }
                $commands.= "</Commands>\n";
            }

            // Image
            $image = '';
if (empty($this->image))
{
    if (!empty($this->icon))
    {
                    $image = "<Image>{$this->icon}</Image>";
    }
}
else
{
                $image = "<Image>{$this->image}</Image>";
}

            // Style
            $style = '';
if (empty($this->baseStyle))
{
$style = "<BasedOnStyle>Default</BasedOnStyle>";
}
else
{
                $style = "<BasedOnStyle>{$this->baseStyle}</BasedOnStyle>";
}

            $xml = <<< END_XML
            < Cell X = "{$this->col}" Y = "{$this->row}" >


               < Content >
              {$commands}
              < CaptionAndImage >
                < Caption >{$this->label}</ Caption >
                {$image}
              </ CaptionAndImage >
              < Style >
                < BasedOnStyle > Default </ BasedOnStyle >
                < TileColour >{$this->backColor}</ TileColour >


                </ Style >


              </ Content >


            </ Cell >
  END_XML;
return $xml;
        }
    }
}
