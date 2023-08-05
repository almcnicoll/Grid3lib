using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text.RegularExpressions;

namespace Grid3lib
{
    /// <summary>
    ///  Contains Extension Methods for use throughout the library
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Produces a repeating string
        /// </summary>
        /// <param name="input">The string to repeat</param>
        /// <param name="count">The number of times to repeat it</param>
        /// <returns>The resulting composite string</returns>
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

        /// <summary>
        /// Breaks a path string apart into folders
        /// </summary>
        /// <param name="input">The path with backslash or forward-slash separators</param>
        /// <returns>An array of <see cref="string"/> containing the path elements in order</returns>
        public static string[] ToPathParts(this string input)
        {
            return input.Split(new[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar });
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

        /// <summary>
        /// Adds an item to a dictionary or edits the current entry if the key exists
        /// </summary>
        /// <typeparam name="TKey">The type of the dictionary key</typeparam>
        /// <typeparam name="TValue">The type of the dictionary value</typeparam>
        /// <param name="dictionary">The dictionary on which to perform the add or edit</param>
        /// <param name="key">The key to find or insert in the <see cref="Dictionary{TKey, TValue}"/></param>
        /// <param name="value">The value to insert into the <see cref="Dictionary{TKey, TValue}"/></param>
        /// <exception cref="ArgumentNullException">Returned if either <paramref name="dictionary"/> or <paramref name="key"/> is null.</exception>
        public static void AddOrEdit<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
        {
            if (dictionary == null) { throw new ArgumentNullException(nameof(dictionary)); }
            if (key == null) { throw new ArgumentNullException(nameof(key)); }
            if (dictionary.ContainsKey(key))
            {
                dictionary[key] = value;
            }
            else
            {
                dictionary.Add(key, value);
            }
        }

        /// <summary>
        /// Breaks a string into chunks of the specified length
        /// </summary>
        /// <param name="str">The original string</param>
        /// <param name="chunkLength">The length of each chunk</param>
        /// <returns>An <see cref="IEnumerable{String}" /> of the string chunks</returns>
        /// <exception cref="ArgumentException"></exception>
        public static IEnumerable<string> SplitBy(this string str, int chunkLength)
        {
            if (String.IsNullOrEmpty(str)) throw new ArgumentException();
            if (chunkLength < 1) throw new ArgumentException();

            for (int i = 0; i < str.Length; i += chunkLength)
            {
                if (chunkLength + i > str.Length)
                    chunkLength = str.Length - i;

                yield return str.Substring(i, chunkLength);
            }
        }

        /// <summary>
        /// Converts a hex (A)RGB colour to a <see cref="Color"/>
        /// </summary>
        /// <param name="source">The colour in RGB or ARGB format, with or without a leading #</param>
        /// <returns>A <see cref="Color"/> object, or null if the string could not be parsed</returns>
        public static Color? ToColor(this string source)
        {
            if (string.IsNullOrEmpty(source)) { return null; }
            if (source.Substring(0, 1) == "#") { source = source.Substring(1); } // Lop off any leading hash symbol

            string[] pairs = source.SplitBy(2).ToArray();
            switch (pairs.Length)
            {
                case 3: // RGB
                    try
                    {
                        int r = int.Parse(pairs[0], System.Globalization.NumberStyles.HexNumber);
                        int g = int.Parse(pairs[1], System.Globalization.NumberStyles.HexNumber);
                        int b = int.Parse(pairs[2], System.Globalization.NumberStyles.HexNumber);
                        return Color.FromArgb(r, g, b);
                    }
                    catch
                    {
                        return null;
                    }
                case 4: // ARGB
                    try
                    {
                        int a = int.Parse(pairs[0], System.Globalization.NumberStyles.HexNumber);
                        int r = int.Parse(pairs[1], System.Globalization.NumberStyles.HexNumber);
                        int g = int.Parse(pairs[2], System.Globalization.NumberStyles.HexNumber);
                        int b = int.Parse(pairs[3], System.Globalization.NumberStyles.HexNumber);
                        return Color.FromArgb(a, r, g, b);
                    }
                    catch
                    {
                        return null;
                    }
                default: // Who knows?
                    return null;
            }
        }

        /// <summary>
        /// Makes a nullable string safe for use in non-nullable contexts
        /// </summary>
        /// <param name="value">The string to evaluate</param>
        /// <returns>The original string if not null, otherwise an empty string</returns>
        public static string BlankIfNull(this string? value)
        {
            if (value == null) { return ""; }
            return value;
        }

    }
}