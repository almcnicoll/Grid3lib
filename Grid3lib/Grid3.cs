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
        ///  Contains common paths within a <see cref="Grid3lib.XmlNodeTag.GridSet"/>
        /// </summary>
        public static class Paths
        {
            /// <summary>
            /// The default root folder for <see cref="XmlNodeTag.GridSet"/> folders
            /// </summary>
            public static string GridsFolder = @"Grids";
            /// <summary>
            /// The default folder for the <see cref="Grid3lib.XmlNodeTag.GridSet"/>'s <see cref="XmlNodeTag.GridSetSettings"/>
            /// </summary>
            public static string SettingsFolder = @"Settings0";
            /// <summary>
            /// The default location of the settings.xml file containing <see cref="XmlNodeTag.GridSetSettings"/>
            /// </summary>
            public static string SettingsXml = @"Settings0\settings.xml";
            /// <summary>
            /// The default location of the settings.xml file
            /// </summary>
            public static string StylesFolder = @"Settings0\Styles";
            /// <summary>
            /// The default location of the styles.xml
            /// </summary>
            public static string StylesXml = @"Settings0\Styles\styles.xml";
        }

        /// <summary>
        /// Contains common cell and grid actions
        /// </summary>
        public static class Actions
        {
            /// <summary>
            /// Represents the Grid Explorer action
            /// </summary>
            public const string GridExplorer = "Settings.GridExplorer";
            /// <summary>
            /// Represents the Write action
            /// </summary>
            public const string Write = "Action.InsertText";
            /// <summary>
            /// Represents the Speak Now action
            /// </summary>
            public const string SpeakNow = "Speech.SpeakNow";
            /// <summary>
            /// Represents the Jump Back action
            /// </summary>
            public const string JumpBack = "Jump.Back";
            /// <summary>
            /// Represents the Jump To action
            /// </summary>
            public const string JumpTo = "Jump.To";
            /// <summary>
            /// Represents the Play Sound action
            /// </summary>
            public const string PlaySound = "SpeechPlaySound";
            /// <summary>
            /// Represents the Open Music File action
            /// </summary>
            public const string OpenMusicFile = "MusicVideo.OpenMusicFile";
            /// <summary>
            /// Represents the Wait action
            /// </summary>
            public const string Wait = "CommandExecution.Wait";
        }
    }
}
