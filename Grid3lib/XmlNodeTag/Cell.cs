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

        /// <summary>
        /// Returns a <see cref="Content"/> object, representing the content node of the cell. Creates this node if it does not exist.
        /// </summary>
        public Content Content
        {
            get
            {
                List<Content> contents = ChildrenOfType<Content>().ToList();
                Content content;
                if (contents == null || contents.Count == 0)
                {
                    content = this.AddChildOfType<Content>();
                }
                else
                {
                    content = contents.First();
                }
                return content;
            }
        }

        /// <summary>
        /// Adds a <see cref="Command"/> to the <see cref="Cell"/>
        /// </summary>
        /// <param name="command">The <see cref="Command"/> object to add</param>
        /// <returns>The same <see cref="Command"/> object (for chaining)</returns>
        public Command AddCommand(Command command)
        {
            Commands commands = Content.GetOrCreateImmediateChild<Commands>();
            commands.AddChildFromXml(command.ToString(), 0);
            return command;
        }

        /// <summary>
        /// Adds a <see cref="Command"/> to the <see cref="Cell"/>
        /// </summary>
        /// <param name="command">The <see cref="Command"/> object to add</param>
        /// <param name="parameters">A set of parameters to add</param>
        /// <returns>The same <see cref="Command"/> object (for chaining)</returns>
        public Command AddCommand(Command command, IEnumerable<Parameter> parameters)
        {
            Commands commands = Content.GetOrCreateImmediateChild<Commands>();
            Command cmd = (Command)commands.AddChildFromXml(command.ToString(), 0);
            foreach (Parameter param in parameters)
            {
                cmd.AddChildFromXml(param.ToString(), 0);
            }
            return cmd;
        }


        /// <summary>
        /// Ensure that the Cell has its positional attributes set before serializing to string
        /// </summary>
        public override void UpdateAttributesAndChildren()
        {
            __Attributes.AddOrEdit("X", Left.ToString());
            __Attributes.AddOrEdit("Y", Top.ToString());
            __Attributes.AddOrEdit("ColumnSpan", ColumnSpan.ToString());
            __Attributes.AddOrEdit("RowSpan", RowSpan.ToString());
            // TODO - look at use of Label and whether it need to look through child nodes for a label entry
            base.UpdateAttributesAndChildren();
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
