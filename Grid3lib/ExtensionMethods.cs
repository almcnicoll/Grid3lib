using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
