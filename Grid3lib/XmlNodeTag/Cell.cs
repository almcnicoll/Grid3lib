#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
using XmlParsing;

namespace Grid3lib.XmlNodeTag
{
    /// <summary>
    /// Represents a cell on a <see cref="Grid"/>
    /// </summary>
    public class Cell : XmlNodeBasic
    {
        /// <summary>
        /// Returns the parent node as a strongly-typed Grid rather than as an IXmlNode
        /// </summary>
        public Grid? ParentGrid
        {
            get
            {
                return (Parent as Grid);
            }
            set
            {
                Parent = value;
            }
        }

        /// <summary>
        /// Gets or sets the cell label
        /// </summary>
        public string? Label
        {
            get
            {
                // Look for any <Caption> descendant node - return its InnerXmlString, or null if not found
                List<Caption> captions = ChildrenOfType<Caption>(-1);
                if (captions.Count == 0) { return null; }
                return captions[0].InnerXmlString;
            }
            set
            {
                // Look for any <Caption> descendant node - set or clear its InnerXml if found
                List<Caption> captions = ChildrenOfType<Caption>(-1);
                if (captions.Count == 0)
                {
                    // Create a Content -> CaptionAndImage -> Caption node chain, then set or clear the Caption's InnerXml
                    if (value == null) { return; }
                    Content content = GetOrCreateImmediateChild<Content>();
                    CaptionAndImage captionAndImage = content.GetOrCreateImmediateChild<CaptionAndImage>();
                    Caption caption = captionAndImage.GetOrCreateImmediateChild<Caption>();
                    caption.InnerXml.Add(new RawXml(value));
                }
                else
                {
                    // Set or clear the Caption's InnerXml
                    captions[0].InnerXml.Clear();
                    if (value != null)
                    {
                        captions[0].InnerXml.Add(new RawXml(value));
                    }
                }
            }
        }

        /// <summary>
        /// The cell's horizontal positioning in the <see cref="Grid"/>
        /// </summary>
        public int Column { get; set; } = 0;
        /// <summary>
        /// The cell's vertical positioning in the <see cref="Grid"/>
        /// </summary>
        public int Row { get; set; } = 0;
        /// <summary>
        /// The number of columns spanned by the cell
        /// </summary>
        public int ColumnSpan { get; set; } = 1;
        /// <summary>
        /// The number of rows spanned by the cell
        /// </summary>
        public int RowSpan { get; set; } = 1;

        /// <summary>
        /// Synonym for <see cref="Column"/>
        /// </summary>
        public int Left
        {
            get
            {
                return Column;
            }
            set
            {
                Column = value;
            }
        }
        /// <summary>
        /// Returns the rightmost column of the cell
        /// </summary>
        public int Right
        {
            get
            {
                return Column + ColumnSpan;
            }
        }
        /// <summary>
        /// Synonym for <see cref="Row"/>
        /// </summary>
        public int Top
        {
            get
            {
                return Row;
            }
            set
            {
                Row = value;
            }
        }
        /// <summary>
        /// Returns the lowest row of the cell
        /// </summary>
        public int Bottom
        {
            get
            {
                return Row + RowSpan;
            }
        }

        /// <summary>
        /// Convenience property that returns the grid coordinates of the cell in a single string
        /// </summary>
        public string CoordsString
        {
            get
            {
                return String.Format("({0},{1})-({2},{3})", Column, Row, Column + ColumnSpan, Row + RowSpan);
            }
        }

        /*
        public CellImage? Image { get; set; } = null;

        public Style? CellStyle { get; set; } = null;

        private Color? __BackColor = null;
        private Color? __TextColor = null;
        private Color? __BorderColor = null;
        public Color BackColor
        {
            get
            {
                if (__BackColor.HasValue)
                {
                    return __BackColor.Value;
                }
                else
                {
                    if (CellStyle != null && CellStyle.BackColour.HasValue)
                    {
                        return CellStyle.BackColour.Value;
                    }
                    else { return Color.FromArgb(255, Color.White); }
                }
            }
            set
            {
                __BackColor = value;
            }
        }
        public Color TextColor
        {
            get
            {
                if (__TextColor.HasValue)
                {
                    return __TextColor.Value;
                }
                else
                {
                    if (CellStyle != null && CellStyle.FontColour.HasValue)
                    {
                        return CellStyle.FontColour.Value;
                    }
                    else { return Color.FromArgb(255, Color.Black); }
                }
            }
            set
            {
                __TextColor = value;
            }
        }
        public Color BorderColor
        {
            get
            {
                if (__BorderColor.HasValue)
                {
                    return __BorderColor.Value;
                }
                else
                {
                    if (CellStyle != null && CellStyle.BorderColour.HasValue)
                    {
                        return CellStyle.BorderColour.Value;
                    }
                    else { return Color.FromArgb(255, Color.Black); }
                }
            }
            set
            {
                __BorderColor = value;
            }
        }
        public string BaseStyle { get; set; } = "";
        public List<Command> Commands = new List<Command>();
        public List<string> Speech
        {
            get
            {
                // Look through commands for "speak now" commands
                return (from Command cmd in Commands
                        from CommandParameter param in cmd.Parameters
                        where cmd.Action == "Speech.SpeakNow" && param.Key == "text"
                        select param.Value).ToList();

            }
        }
        public List<string> Writing
        {
            get
            {
                // Look through commands for "insert text" commands
                return (from Command cmd in Commands
                        from CommandParameter param in cmd.Parameters
                        where cmd.Action == "Action.InsertText" && param.Key == "text"
                        select param.Value).ToList();

            }
        }
        public int? ScanBlock { get; set; }

        /// <summary>
        /// Creates a new cell with the specified attributes
        /// </summary>
        /// <param name="parent">The page to which the cell belongs</param>
        /// <param name="column">The column on which the cell is located</param>
        /// <param name="row">The row on which the cell is located</param>
        /// <param name="label">The cell's label</param>
        /// <param name="imageString">The cell's icon</param>
        public Cell(Grid parent, int column, int row, string label, string? imageString = null)
        {
            Parent = parent;
            Label = label;
            if (imageString != null)
            {
                Image = new CellImage(this, imageString);
            }
        }

        public Cell(Grid parent, ImportClasses.GridCell importCell)
        {
            Parent = parent;

            // Size & position
            Column = importCell.X;
            Row = importCell.Y;
            if (importCell.ColumnSpanSpecified) { ColumnSpan = importCell.ColumnSpan; }
            if (importCell.RowSpanSpecified) { RowSpan = importCell.RowSpan; }

            if (importCell.Content != null)
            {
                ImportClasses.GridCellContent content = importCell.Content;

                // Caption & image
                if (content.CaptionAndImage != null)
                {
                    ImportClasses.GridCellContentCaptionAndImage captionAndImage = content.CaptionAndImage;
                    if (captionAndImage.Caption != null) { Label = captionAndImage.Caption; }
                    if (captionAndImage.Image != null) { Image = new CellImage(this, captionAndImage.Image); }
                }

                // Commands
                if (content.Commands.Length > 0)
                {
                    foreach (ImportClasses.GridCellContentCommand command in content.Commands)
                    {
                        Commands.Add(new Command(command));
                    }
                }

                if (content.Style != null)
                {
                    // TODO LOW PRIORITY - import cell - styles (classes now exist)
                    CellStyle = new Style(content.Style);
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
            string commandsXml = "";
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
            if (Image != null)
            {
                imageXml = $"<Image>{Image.EntryString}</Image>";
            }
            //if (String.IsNullOrEmpty(Picture))
            //{
            //    if (String.IsNullOrEmpty(Icon))
            //    {
            //        imageXml = $"<Image>{Icon}</Image>";
            //    }
            //}
            //else
            //{
            //    imageXml = $"<Image>{Picture}</Image>";
            //}

        // Style
        string styleXml;
            // TODO LOW PRIORITY - see where Style info is used and output it in XML
            if (string.IsNullOrEmpty(BaseStyle))
            {
                styleXml = "<BasedOnStyle>Default</BasedOnStyle>";
            }
            else
            {
                styleXml = $"<BasedOnStyle>{BaseStyle}</BasedOnStyle>";
            }

string xml = $@"            <Cell X=""{Column}"" Y=""{Row}"">
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
*/
    }

    /// <summary>
    /// An exception thrown when a <see cref="Cell"/> is placed overlapping an existing <see cref="Cell"/>
    /// </summary>
    public class CellOverlapException : Exception
    {
        /// <summary>
        /// The <see cref="Cell"/> causing the overlap conflict
        /// </summary>
        public Cell? ConflictCell { get; set; }

        /// <summary>
        /// Creates a new <see cref="CellOverlapException"/>
        /// </summary>
        /// <param name="message">The error message associated with the exception</param>
        /// <param name="conflictCell">The <see cref="Cell"/> causing the conflict</param>
        public CellOverlapException(String message, Cell conflictCell) : base(message)
        {
            ConflictCell = conflictCell;
        }

        /// <summary>
        /// Creates a new <see cref="CellOverlapException"/>
        /// </summary>
        /// <param name="message">The error message associated with the exception</param>
        /// <param name="conflictCell">The <see cref="Cell"/> causing the conflict</param>
        /// <param name="inner">An <see cref="Exception"/> that is the cause of the current <see cref="CellOverlapException"/></param>
        public CellOverlapException(String message, Cell conflictCell, Exception inner) : base(message, inner)
        {
            ConflictCell = conflictCell;
        }
    }
}
