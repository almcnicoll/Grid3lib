#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Grid3lib
{
    public class Cell
    {
        public Page Parent;

        public String Label { get; set; } = "";
        public String Icon { get; set; } = ""; // Format is [symbolset]filename.wmf
        public String Picture { get; set; } = "";
        public Color BackColor { get; set; } = Color.FromArgb(255, Color.White); //'#FFFFFFFF'; // #AARRGGBB
        public Color TextColor { get; set; } = Color.FromArgb(255, Color.Black); //'#FF000000'; // #AARRGGBB
        public Color BorderColor = Color.FromArgb(255, Color.Black); //'#FF000000'; // #AARRGGBB
        public String BaseStyle { get; set; } = "";
        public List<Command> Commands = new List<Command>();
        public string SpeakText { get; set; } = ""; // TODO - consider whether to make this readonly, populated by commands
        public string WriteText { get; set; } = ""; // TODO - consider whether to make this readonly, populated by commands
        public int Column { get; set; } = 0;
        public int Row { get; set; } = 0;
        public int ColumnSpan { get; set; } = 1;
        public int RowSpan { get; set; } = 1;
        public int? ScanBlock { get; set; }

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
            this.Parent = parent;

            // Size & position
            this.Column = importCell.X;
            this.Row = importCell.Y;
            if (importCell.ColumnSpanSpecified) { this.ColumnSpan = importCell.ColumnSpan; }
            if (importCell.RowSpanSpecified) { this.RowSpan = importCell.RowSpan; }

            if (importCell.Content != null)
            {
                ImportClasses.GridCellContent content = importCell.Content;

                // Caption & image
                if (content.CaptionAndImage != null)
                {
                    ImportClasses.GridCellContentCaptionAndImage captionAndImage = content.CaptionAndImage;
                    if (captionAndImage.Caption != null) { this.Label = captionAndImage.Caption; }
                    if (captionAndImage.Image != null) { this.Icon = captionAndImage.Image; }
                    // TODO - check if custom JPGs/PNGs are stored differently in XML (if not, it may be appropriate to lose the Picture property altogether)
                }

                // Commands
                if (content.Commands.Length > 0)
                {
                    foreach (ImportClasses.GridCellContentCommand command in content.Commands)
                    {
                        this.Commands.Add(new Command(command));
                    }
                }

                if (content.Style != null)
                {
                    // TODO - import cell - styles

                }
            }
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
