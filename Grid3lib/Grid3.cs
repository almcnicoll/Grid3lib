using System;
using System.Text.RegularExpressions;

namespace Grid3lib
{
    /// <summary>
    /// Container class for Grid3 utility functions and constants
    /// </summary>
    public static class Grid3
    {
        // TODO - enums or constants for common actions, icons, ...
        /// <summary>
        /// Contains commonly-used regular expressions
        /// </summary>
        public static class RegularExpressions
        {
            /// <summary>
            /// Filename pattern for a gridset thumbnail
            /// </summary>
            public static Regex ThumbnailFile = new Regex(@"^thumbnail\.(png|jpg|bmp)$", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Contains common cell and grid actions
        /// </summary>
        public static class Actions
        {
            /// <summary>
            /// Represents the Write action
            /// </summary>
            public const string Write = "Action.InsertText";
            /// <summary>
            /// Represents the Speak Now action
            /// </summary>
            public const string SpeakNow = "Speech.SpeakNow";
        }
    }
}
