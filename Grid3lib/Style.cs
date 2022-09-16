#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Diagnostics.Tracing;

namespace Grid3lib
{
    public enum Shape
    {
        Unknown = 0
    }

    public class Style
    {
        public string? Name;
        public Color? BackColour;
        public Color? BorderColour;
        public Color? TileColour;
        public Color? FontColour;
        public string? FontName;
        public int? FontSize;
        public Shape? BackgroundShape;

        public Style(ImportClasses.StyleDataStyle source)
        {
            if (source.Name != null) { this.Name = source.Name; }
            if (source.BackColour != null) { this.BackColour = source.BackColour.ToColor(); }
            if (source.BorderColour != null) { this.BorderColour = source.BorderColour.ToColor(); }
            if (source.TileColour != null) { this.TileColour = source.TileColour.ToColor(); }
            if (source.FontColour != null) { this.FontColour = source.FontColour.ToColor(); }
            if (source.FontName != null) { this.FontName = source.FontName; }
            if (source.FontSizeSpecified) { this.FontSize = source.FontSize; }
            if (source.BackgroundShapeSpecified) { this.BackgroundShape = (Shape)source.BackgroundShape; }
        }
    }

}
