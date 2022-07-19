﻿#nullable enable
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
        public List<Command> Commands = new List<Command>(); //string Action = "";
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

        public Cell(Page parent, ImportClasses.GridCell importCell)
        {
            // TODO - write importer here
            this.Parent = parent;
            this.Column = importCell.X;
            this.Row = importCell.Y;
            if (importCell.Content != null)
            {
                ImportClasses.GridCellContent content = importCell.Content;
                if (content.CaptionAndImage != null)
                {
                    ImportClasses.GridCellContentCaptionAndImage captionAndImage = content.CaptionAndImage;
                    if (captionAndImage.Caption != null) { this.Label = captionAndImage.Caption; }
                    if (captionAndImage.Image != null) { this.Icon = captionAndImage.Image; }
                }
            }
            // TODO - commands
            // TODO - styles
        }

        /// <summary>
        /// Returns the XML for this cell, ready for compression into the GridSet file
        /// </summary>
        /// <returns></returns>
        public string GetXml()
        {
            // Commands
            String commandsXml = "";
            if (Commands.Count > 0)
            {
                commandsXml += "<Commands>\n";
                foreach (Command command in Commands)
                {
                    if (command.Parameters.Count == 0)
                    {
                        commandsXml += $"<Command ID=\"{command.Action}\" />\n";
                    }
                    else
                    {
                        commandsXml += $"<Command ID=\"{command.Action}\">\n";
                        foreach (CommandParameter parameter in command.Parameters)
                        {
                            commandsXml += $"<Parameter Key=\"{parameter.Key}\">{parameter.Value}</Parameter>\n";
                        }
                    }
                }
                commandsXml += "</Commands>\n";
            }

            // Image
            string imageXml = "";
            if (String.IsNullOrEmpty(Picture))
            {
                if (String.IsNullOrEmpty(Icon))
                {
                    imageXml = $"<Image>{Icon}</Image>";
                }
            }
            else
            {
                imageXml = $"<Image>{Picture}</Image>";
            }

            // Style
            String styleXml;
            // TODO - see where Style info is used and output it in XML
            if (String.IsNullOrEmpty(BaseStyle))
            {
                styleXml = "<BasedOnStyle>Default</BasedOnStyle>";
            }
            else
            {
                styleXml = $"<BasedOnStyle>{BaseStyle}</BasedOnStyle>";
            }

            String xml = $@"            <Cell X=""{Column}"" Y=""{Row}"">
            <Content>
              {commandsXml}
              <CaptionAndImage>
                <Caption>{Label}</Caption>
                {imageXml}
              </CaptionAndImage>
              <Style>
                <BasedOnStyle>Default</BasedOnStyle>
                <TileColour>{BackColor.ToHexRGBA()}</TileColour>
              </Style>
            </Content>
          </Cell>
";
            return xml;
        }
    }
}
