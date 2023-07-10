﻿using System;
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


            /* TODO - Still to implement
            /// <summary>
/// Represents the Action.Clear action
/// </summary>
public const string Action.Clear = "Action.Clear";

/// <summary>
/// Represents the Action.Copy action
/// </summary>
public const string Action.Copy = "Action.Copy";

/// <summary>
/// Represents the Action.DeleteLetter action
/// </summary>
public const string Action.DeleteLetter = "Action.DeleteLetter";

/// <summary>
/// Represents the Action.DeleteSpace action
/// </summary>
public const string Action.DeleteSpace = "Action.DeleteSpace";

/// <summary>
/// Represents the Action.DeleteWord action
/// </summary>
public const string Action.DeleteWord = "Action.DeleteWord";

/// <summary>
/// Represents the Action.Enter action
/// </summary>
public const string Action.Enter = "Action.Enter";

/// <summary>
/// Represents the Action.FindWord action
/// </summary>
public const string Action.FindWord = "Action.FindWord";

/// <summary>
/// Represents the Action.InsertCellText action
/// </summary>
public const string Action.InsertCellText = "Action.InsertCellText";

<Command ID="Action.InsertText">
<Command ID="Action.Letter">
/// <summary>
/// Represents the Action.NextLetter action
/// </summary>
public const string Action.NextLetter = "Action.NextLetter";

<Command ID="Action.Number">
/// <summary>
/// Represents the Action.Paste action
/// </summary>
public const string Action.Paste = "Action.Paste";

/// <summary>
/// Represents the Action.PreviousLetter action
/// </summary>
public const string Action.PreviousLetter = "Action.PreviousLetter";

/// <summary>
/// Represents the Action.Print action
/// </summary>
public const string Action.Print = "Action.Print";

<Command ID="Action.Punctuation">
/// <summary>
/// Represents the Action.Space action
/// </summary>
public const string Action.Space = "Action.Space";

<Command ID="Action.Speak">
/// <summary>
/// Represents the Action.UndoClear action
/// </summary>
public const string Action.UndoClear = "Action.UndoClear";

<Command ID="AutoContent.Activate">
/// <summary>
/// Represents the Calculator.Add action
/// </summary>
public const string Calculator.Add = "Calculator.Add";

/// <summary>
/// Represents the Calculator.Clear action
/// </summary>
public const string Calculator.Clear = "Calculator.Clear";

/// <summary>
/// Represents the Calculator.Divide action
/// </summary>
public const string Calculator.Divide = "Calculator.Divide";

/// <summary>
/// Represents the Calculator.Eight action
/// </summary>
public const string Calculator.Eight = "Calculator.Eight";

/// <summary>
/// Represents the Calculator.Equals action
/// </summary>
public const string Calculator.Equals = "Calculator.Equals";

/// <summary>
/// Represents the Calculator.Five action
/// </summary>
public const string Calculator.Five = "Calculator.Five";

/// <summary>
/// Represents the Calculator.Four action
/// </summary>
public const string Calculator.Four = "Calculator.Four";

/// <summary>
/// Represents the Calculator.Multiply action
/// </summary>
public const string Calculator.Multiply = "Calculator.Multiply";

/// <summary>
/// Represents the Calculator.Nine action
/// </summary>
public const string Calculator.Nine = "Calculator.Nine";

/// <summary>
/// Represents the Calculator.One action
/// </summary>
public const string Calculator.One = "Calculator.One";

/// <summary>
/// Represents the Calculator.Seven action
/// </summary>
public const string Calculator.Seven = "Calculator.Seven";

/// <summary>
/// Represents the Calculator.Six action
/// </summary>
public const string Calculator.Six = "Calculator.Six";

/// <summary>
/// Represents the Calculator.Subtract action
/// </summary>
public const string Calculator.Subtract = "Calculator.Subtract";

/// <summary>
/// Represents the Calculator.Three action
/// </summary>
public const string Calculator.Three = "Calculator.Three";

/// <summary>
/// Represents the Calculator.Two action
/// </summary>
public const string Calculator.Two = "Calculator.Two";

/// <summary>
/// Represents the Calculator.Zero action
/// </summary>
public const string Calculator.Zero = "Calculator.Zero";

/// <summary>
/// Represents the ClockSpeakTime action
/// </summary>
public const string ClockSpeakTime = "ClockSpeakTime";

/// <summary>
/// Represents the ClockWriteTime action
/// </summary>
public const string ClockWriteTime = "ClockWriteTime";

<Command ID="CommandExecution.Wait">
/// <summary>
/// Represents the ComputerControl.Dock action
/// </summary>
public const string ComputerControl.Dock = "ComputerControl.Dock";

<Command ID="ComputerControl.Keyboard">
/// <summary>
/// Represents the ComputerControl.MouseClick action
/// </summary>
public const string ComputerControl.MouseClick = "ComputerControl.MouseClick";

<Command ID="ComputerControl.MouseClickOnDwell">
<Command ID="ComputerControl.MouseDragPointerOnDwell">
<Command ID="ComputerControl.MoveMouseTo">
<Command ID="ComputerControl.Run">
<Command ID="ComputerControl.Shift">
/// <summary>
/// Represents the Email.AttachPhoto action
/// </summary>
public const string Email.AttachPhoto = "Email.AttachPhoto";

/// <summary>
/// Represents the Email.Back action
/// </summary>
public const string Email.Back = "Email.Back";

/// <summary>
/// Represents the Email.ClearAttachments action
/// </summary>
public const string Email.ClearAttachments = "Email.ClearAttachments";

/// <summary>
/// Represents the Email.Delete action
/// </summary>
public const string Email.Delete = "Email.Delete";

/// <summary>
/// Represents the Email.New action
/// </summary>
public const string Email.New = "Email.New";

/// <summary>
/// Represents the Email.Next action
/// </summary>
public const string Email.Next = "Email.Next";

/// <summary>
/// Represents the Email.Open action
/// </summary>
public const string Email.Open = "Email.Open";

/// <summary>
/// Represents the Email.Previous action
/// </summary>
public const string Email.Previous = "Email.Previous";

<Command ID="Email.Reply">
/// <summary>
/// Represents the Email.Send action
/// </summary>
public const string Email.Send = "Email.Send";

/// <summary>
/// Represents the Email.Speak action
/// </summary>
public const string Email.Speak = "Email.Speak";

<Command ID="Interactive.Action">
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
