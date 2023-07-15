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
            /// <summary>
            /// Represents the Activate AutoContent action
            /// </summary>
            public const string AutoContentActivate = "AutoContent.Activate";
            /// <summary>
            /// Represents the Clear action
            /// </summary>
            public const string Clear = "Action.Clear";
            /// <summary>
            /// Represents the Copy action
            /// </summary>
            public const string Copy = "Action.Copy";
            /// <summary>
            /// Represents the DeleteLetter action
            /// </summary>
            public const string DeleteLetter = "Action.DeleteLetter";
            /// <summary>
            /// Represents the DeleteSpace action
            /// </summary>
            public const string DeleteSpace = "Action.DeleteSpace";
            /// <summary>
            /// Represents the DeleteWord action
            /// </summary>
            public const string DeleteWord = "Action.DeleteWord";
            /// <summary>
            /// Represents the Enter action
            /// </summary>
            public const string Enter = "Action.Enter";
            /// <summary>
            /// Represents the FindWord action
            /// </summary>
            public const string FindWord = "Action.FindWord";
            /// <summary>
            /// Represents the InsertCellText action
            /// </summary>
            public const string InsertCellText = "Action.InsertCellText";
            /// <summary>
            /// Represents the InsertText action
            /// </summary>
            public const string InsertText = "Action.InsertText";
            /// <summary>
            /// Represents the Letter action
            /// </summary>
            public const string Letter = "Action.Letter";
            /// <summary>
            /// Represents the NextLetter action
            /// </summary>
            public const string NextLetter = "Action.NextLetter";
            /// <summary>
            /// Represents the Number action
            /// </summary>
            public const string Number = "Action.Number";
            /// <summary>
            /// Represents the Paste action
            /// </summary>
            public const string Paste = "Action.Paste";
            /// <summary>
            /// Represents the PreviousLetter action
            /// </summary>
            public const string PreviousLetter = "Action.PreviousLetter";
            /// <summary>
            /// Represents the Print action
            /// </summary>
            public const string Print = "Action.Print";
            /// <summary>
            /// Represents the Punctuation action
            /// </summary>
            public const string Punctuation = "Action.Punctuation";
            /// <summary>
            /// Represents the Space action
            /// </summary>
            public const string Space = "Action.Space";
            /// <summary>
            /// Represents the Speak action
            /// </summary>
            public const string Speak = "Action.Speak";
            /// <summary>
            /// Represents the UndoClear action
            /// </summary>
            public const string UndoClear = "Action.UndoClear";
            /// <summary>
            /// Represents the Calculator.Add action
            /// </summary>
            public const string Calculator_Add = "Calculator.Add";
            /// <summary>
            /// Represents the Calculator.Clear action
            /// </summary>
            public const string Calculator_Clear = "Calculator.Clear";
            /// <summary>
            /// Represents the Calculator.Divide action
            /// </summary>
            public const string Calculator_Divide = "Calculator.Divide";
            /// <summary>
            /// Represents the Calculator.Eight action
            /// </summary>
            public const string Calculator_Eight = "Calculator.Eight";
            /// <summary>
            /// Represents the Calculator.Equals action
            /// </summary>
            public const string Calculator_Equals = "Calculator.Equals";
            /// <summary>
            /// Represents the Calculator.Five action
            /// </summary>
            public const string Calculator_Five = "Calculator.Five";
            /// <summary>
            /// Represents the Calculator.Four action
            /// </summary>
            public const string Calculator_Four = "Calculator.Four";
            /// <summary>
            /// Represents the Calculator.Multiply action
            /// </summary>
            public const string Calculator_Multiply = "Calculator.Multiply";
            /// <summary>
            /// Represents the Calculator.Nine action
            /// </summary>
            public const string Calculator_Nine = "Calculator.Nine";
            /// <summary>
            /// Represents the Calculator.One action
            /// </summary>
            public const string Calculator_One = "Calculator.One";
            /// <summary>
            /// Represents the Calculator.Seven action
            /// </summary>
            public const string Calculator_Seven = "Calculator.Seven";
            /// <summary>
            /// Represents the Calculator.Six action
            /// </summary>
            public const string Calculator_Six = "Calculator.Six";
            /// <summary>
            /// Represents the Calculator.Subtract action
            /// </summary>
            public const string Calculator_Subtract = "Calculator.Subtract";
            /// <summary>
            /// Represents the Calculator.Three action
            /// </summary>
            public const string Calculator_Three = "Calculator.Three";
            /// <summary>
            /// Represents the Calculator.Two action
            /// </summary>
            public const string Calculator_Two = "Calculator.Two";
            /// <summary>
            /// Represents the Calculator.Zero action
            /// </summary>
            public const string Calculator_Zero = "Calculator.Zero";
            /// <summary>
            /// Represents the ClockSpeakTime action
            /// </summary>
            public const string ClockSpeakTime = "ClockSpeakTime";
            /// <summary>
            /// Represents the ClockWriteTime action
            /// </summary>
            public const string ClockWriteTime = "ClockWriteTime";
            /// <summary>
            /// Represents the ComputerControl.Dock action
            /// </summary>
            public const string ComputerControl_Dock = "ComputerControl.Dock";
            /// <summary>
            /// Represents the ComputerControl.Keyboard action
            /// </summary>
            public const string ComputerControl_Keyboard = "ComputerControl.Keyboard";
            /// <summary>
            /// Represents the ComputerControl.MouseClick action
            /// </summary>
            public const string ComputerControl_MouseClick = "ComputerControl.MouseClick";
            /// <summary>
            /// Represents the ComputerControl.MouseClickOnDwell action
            /// </summary>
            public const string ComputerControl_MouseClickOnDwell = "ComputerControl.MouseClickOnDwell";
            /// <summary>
            /// Represents the ComputerControl.MouseDragPointerOnDwell action
            /// </summary>
            public const string ComputerControl_MouseDragPointerOnDwell = "ComputerControl.MouseDragPointerOnDwell";
            /// <summary>
            /// Represents the ComputerControl.MoveMouseTo action
            /// </summary>
            public const string ComputerControl_MoveMouseTo = "ComputerControl.MoveMouseTo";
            /// <summary>
            /// Represents the ComputerControl.Run action
            /// </summary>
            public const string ComputerControl_Run = "ComputerControl.Run";
            /// <summary>
            /// Represents the ComputerControl.Shift action
            /// </summary>
            public const string ComputerControl_Shift= "ComputerControl.Shift";
            /// <summary>
            /// Represents the Email.AttachPhoto action
            /// </summary>
            public const string Email_AttachPhoto = "Email.AttachPhoto";
            /// <summary>
            /// Represents the Email.Back action
            /// </summary>
            public const string Email_Back = "Email.Back";
            /// <summary>
            /// Represents the Email.ClearAttachments action
            /// </summary>
            public const string Email_ClearAttachments = "Email.ClearAttachments";
            /// <summary>
            /// Represents the Email.Delete action
            /// </summary>
            public const string Email_Delete = "Email.Delete";
            /// <summary>
            /// Represents the Email.New action
            /// </summary>
            public const string Email_New = "Email.New";
            /// <summary>
            /// Represents the Email.Next action
            /// </summary>
            public const string Email_Next = "Email.Next";
            /// <summary>
            /// Represents the Email.Open action
            /// </summary>
            public const string Email_Open = "Email.Open";
            /// <summary>
            /// Represents the Email.Previous action
            /// </summary>
            public const string Email_Previous = "Email.Previous";
            /// <summary>
            /// Represents the Email.Reply action
            /// </summary>
            public const string Email_Reply= "Email.Reply";
            /// <summary>
            /// Represents the Email.Send action
            /// </summary>
            public const string Email_Send = "Email.Send";
            /// <summary>
            /// Represents the Email.Speak action
            /// </summary>
            public const string Email_Speak = "Email.Speak";
            /* TODO - Still to implement

        <Command ID = "Interactive.Action" >
            /// <summary>
        /// Represents the Interactive.Restart action
        /// </summary>
        public const string Interactive.Restart = "Interactive.Restart";

        /// <summary>
        /// Represents the Jump.Back action
        /// </summary>
        public const string Jump.Back = "Jump.Back";

        /// <summary>
        /// Represents the Jump.Home action
        /// </summary>
        public const string Jump.Home = "Jump.Home";

        /// <summary>
        /// Represents the Jump.PreventSelfClosing action
        /// </summary>
        public const string Jump.PreventSelfClosing = "Jump.PreventSelfClosing";

        <Command ID="Jump.SetBookmark">
        <Command ID="Jump.To">
        <Command ID="Jump.ToggleSelfClosing">
        <Command ID="MusicVideo.OpenMusicFile">
        <Command ID="MusicVideo.OpenVideoFile">
        <Command ID="Photos.MorePhotos">
        <Command ID="Photos.OpenFile">
        /// <summary>
        /// Represents the Photos.Snapshot action
        /// </summary>
        public const string Photos.Snapshot = "Photos.Snapshot";

        /// <summary>
        /// Represents the Photos.SnapshotsFolder action
        /// </summary>
        public const string Photos.SnapshotsFolder = "Photos.SnapshotsFolder";

        <Command ID="Prediction.MoreWords">
        <Command ID="Prediction.PredictThis">
        <Command ID="Settings.ChangeGridSet">
        /// <summary>
        /// Represents the Settings.GridExplorer action
        /// </summary>
        public const string Settings.GridExplorer = "Settings.GridExplorer";

        <Command ID="Settings.Notify">
        /// <summary>
        /// Represents the Settings.PointerDwellLonger action
        /// </summary>
        public const string Settings.PointerDwellLonger = "Settings.PointerDwellLonger";

        /// <summary>
        /// Represents the Settings.PointerDwellShorter action
        /// </summary>
        public const string Settings.PointerDwellShorter = "Settings.PointerDwellShorter";

        <Command ID="Settings.RequiredFeature">
        <Command ID="Settings.RestAll">
        <Command ID="Settings.RestEyeGaze">
        <Command ID="Settings.RestPointer">
        <Command ID="Settings.RestSwitch">
        /// <summary>
        /// Represents the Settings.ScanspeedFaster action
        /// </summary>
        public const string Settings.ScanspeedFaster = "Settings.ScanspeedFaster";

        /// <summary>
        /// Represents the Settings.ScanspeedSlower action
        /// </summary>
        public const string Settings.ScanspeedSlower = "Settings.ScanspeedSlower";

        /// <summary>
        /// Represents the Settings.TouchDwellLonger action
        /// </summary>
        public const string Settings.TouchDwellLonger = "Settings.TouchDwellLonger";

        /// <summary>
        /// Represents the Settings.TouchDwellShorter action
        /// </summary>
        public const string Settings.TouchDwellShorter = "Settings.TouchDwellShorter";

        <Command ID="Speech.ReadCell">
        <Command ID="Speech.SpeakNow">
        <Command ID="Speech.SpeechMute">
        <Command ID="Speech.SpeechVolume">
        /// <summary>
        /// Represents the Speech.Stop action
        /// </summary>
        public const string Speech.Stop = "Speech.Stop";

        <Command ID="SpeechPlaySound">
        <Command ID="Verbs.Morphology">
        /// <summary>
        /// Represents the Verbs.SetVerbCellState action
        /// </summary>
        public const string Verbs.SetVerbCellState = "Verbs.SetVerbCellState";

        <Command ID="Verbs.SetVerbCellState">
                     */
        }
    }
}
