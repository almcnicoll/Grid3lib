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
    }
}
