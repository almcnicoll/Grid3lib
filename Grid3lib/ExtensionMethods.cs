using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace Grid3lib
{
    public static class ExtensionMethods
    {
        public static string Repeat(this string input, int count)
        {
            if (String.IsNullOrEmpty(input) || count <= 1)
            {
                return input;
            }

            var builder = new StringBuilder(input.Length * count);

            for (var i = 0; i < count; i++) builder.Append(input);

            return builder.ToString();
        }

        public static string[] ToPathParts(this string input)
        {
            return input.Split(new [] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar });
        }

        /// <summary>
        /// Returns the RGB value of the colour as a hex string
        /// </summary>
        /// <param name="color">The colour to convert</param>
        /// <param name="includeHashSymbol">Whether to include the leading "#" symbol</param>
        /// <returns></returns>
        public static string ToHexRGB(this Color color, bool includeHashSymbol = true)
        {
            return ((includeHashSymbol) ? "#" : "") + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        /// <summary>
        /// Returns the RGBA value of the colour as a hex string
        /// </summary>
        /// <param name="color">The colour to convert</param>
        /// <param name="includeHashSymbol">Whether to include the leading "#" symbol</param>
        /// <returns></returns>
        public static string ToHexRGBA(this Color color, bool includeHashSymbol = true)
        {
            return ((includeHashSymbol) ? "#" : "") + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + color.A.ToString("X2");
        }
    }
}
