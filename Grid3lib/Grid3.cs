using Grid3lib.XmlNodeTag;
using System;
using System.Text.RegularExpressions;

namespace Grid3lib
{
    /// <summary>
    /// Container class for Grid3 utility functions and constants
    /// </summary>
    public static class Grid3
    {
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
            public const string ComputerControl_Shift = "ComputerControl.Shift";
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
            public const string Email_Reply = "Email.Reply";
            /// <summary>
            /// Represents the Email.Send action
            /// </summary>
            public const string Email_Send = "Email.Send";
            /// <summary>
            /// Represents the Email.Speak action
            /// </summary>
            public const string Email_Speak = "Email.Speak";
            /// <summary>
            /// Represents the Interactive.Action action
            /// </summary>
            public const string Interactive_Action = "Interactive.Action";
            /// Represents the Interactive.Restart action
            /// </summary>
            public const string Interactive_Restart = "Interactive.Restart";
            /// <summary>
            /// Represents the Jump.Back action
            /// </summary>
            public const string Jump_Back = "Jump.Back";
            /// <summary>
            /// Represents the Jump.Home action
            /// </summary>
            public const string Jump_Home = "Jump.Home";
            /// <summary>
            /// Represents the Jump.PreventSelfClosing action
            /// </summary>
            public const string Jump_PreventSelfClosing = "Jump.PreventSelfClosing";
            /// <summary>
            /// Represents the Photos.MorePhotos action
            /// </summary>
            public const string Photos_MorePhotos = "Photos.MorePhotos";
            /// <summary>
            /// Represents the Photos.OpenFile action
            /// </summary>
            public const string Photos_OpenFile = "Photos.OpenFile";
            /// <summary>
            /// Represents the Jump.SetBookmark action
            /// </summary>
            public const string Jump_SetBookmark = "Jump.SetBookmark";
            /// <summary>
            /// Represents the Jump.To action
            /// </summary>
            public const string Jump_To = "Jump.To";
            /// <summary>
            /// Represents the Jump.ToggleSelfClosing action
            /// </summary>
            public const string Jump_ToggleSelfClosing = "Jump.ToggleSelfClosing";
            /// <summary>
            /// Represents the MusicVideo.OpenVideoFile action
            /// </summary>
            public const string OpenVideoFile = "MusicVideo.OpenVideoFile";
            /// <summary>
            /// Represents the Photos.Snapshot action
            /// </summary>
            public const string Photos_Snapshot = "Photos.Snapshot";
            /// <summary>
            /// Represents the Photos.SnapshotsFolder action
            /// </summary>
            public const string Photos_SnapshotsFolder = "Photos.SnapshotsFolder";
            /// <summary>
            /// Represents the Prediction.MoreWords action
            /// </summary>
            public const string Prediction_MoreWords = "Prediction.MoreWords";
            /// <summary>
            /// Represents the Prediction.PredictThis action
            /// </summary>
            public const string Prediction_PredictThis = "Prediction.PredictThis";
            /// <summary>
            /// Represents the Settings.ChangeGridSet action
            /// </summary>
            public const string Settings_ChangeGridSet = "Settings.ChangeGridSet";
            /// <summary>
            /// Represents the Settings.GridExplorer action
            /// </summary>
            public const string Settings_GridExplorer = "Settings.GridExplorer";
            /// <summary>
            /// Represents the Settings.PointerDwellLonger action
            /// </summary>
            public const string Settings_PointerDwellLonger = "Settings.PointerDwellLonger";
            /// <summary>
            /// Represents the Settings.PointerDwellShorter action
            /// </summary>
            public const string Settings_PointerDwellShorter = "Settings.PointerDwellShorter";


            /// <summary>
            /// Represents the Settings.ScanspeedFaster action
            /// </summary>
            public const string Settings_ScanspeedFaster = "Settings.ScanspeedFaster";

            /// <summary>
            /// Represents the Settings.ScanspeedSlower action
            /// </summary>
            public const string Settings_ScanspeedSlower = "Settings.ScanspeedSlower";

            /// <summary>
            /// Represents the Settings.TouchDwellLonger action
            /// </summary>
            public const string Settings_TouchDwellLonger = "Settings.TouchDwellLonger";

            /// <summary>
            /// Represents the Settings.TouchDwellShorter action
            /// </summary>
            public const string Settings_TouchDwellShorter = "Settings.TouchDwellShorter";


            /// <summary>
            /// Represents the Speech.Stop action
            /// </summary>
            public const string Speech_Stop = "Speech.Stop";


            /// <summary>
            /// Represents the Verbs.SetVerbCellState action
            /// </summary>
            public const string Verbs_SetVerbCellState = "Verbs.SetVerbCellState";

            /// <summary>
            /// Represents the Settings.Notify action
            /// </summary>
            public const string Settings_Notify = "Settings.Notify";
            /// <summary>
            /// Represents the Settings.RequiredFeature action
            /// </summary>
            public const string Settings_RequiredFeature = "Settings.RequiredFeature";
            /// <summary>
            /// Represents the Settings.RestAll action
            /// </summary>
            public const string Settings_RestAll = "Settings.RestAll";
            /// <summary>
            /// Represents the Settings.RestEyeGaze action
            /// </summary>
            public const string Settings_RestEyeGaze = "Settings.RestEyeGaze";
            /// <summary>
            /// Represents the Settings.RestPointer action
            /// </summary>
            public const string Settings_RestPointer = "Settings.RestPointer";
            /// <summary>
            /// Represents the Settings.RestSwitch action
            /// </summary>
            public const string Settings_RestSwitch = "Settings.RestSwitch";
            /// <summary>
            /// Represents the Speech.ReadCell action
            /// </summary>
            public const string Speech_ReadCell = "Speech.ReadCell";
            /// <summary>
            /// Represents the Speech.SpeakNow action
            /// </summary>
            public const string Speech_SpeakNow = "Speech.SpeakNow";
            /// <summary>
            /// Represents the Speech.SpeechMute action
            /// </summary>
            public const string Speech_SpeechMute = "Speech.SpeechMute";
            /// <summary>
            /// Represents the Speech.SpeechVolume action
            /// </summary>
            public const string Speech_SpeechVolume = "Speech.SpeechVolume";
            /// <summary>
            /// Represents the SpeechPlaySound action
            /// </summary>
            public const string SpeechPlaySound = "SpeechPlaySound";
            /// <summary>
            /// Represents the Verbs.Morphology action
            /// </summary>
            public const string Verbs_Morphology = "Verbs.Morphology";
        }

        /// <summary>
        /// Contains common symbols from the Grid2x symbol library
        /// </summary>
        public static class Grid2xSymbols
        {
            /// <summary>
            /// Represents the [grid2x]a symbol
            /// </summary>
            public const string a = @"[grid2x]a";
            /// <summary>
            /// Represents the [grid2x]a1 symbol
            /// </summary>
            public const string a1 = @"[grid2x]a1";
            /// <summary>
            /// Represents the [grid2x]a2 symbol
            /// </summary>
            public const string a2 = @"[grid2x]a2";
            /// <summary>
            /// Represents the [grid2x]action.clear_1 symbol
            /// </summary>
            public const string action_clear_1 = @"[grid2x]action.clear_1";
            /// <summary>
            /// Represents the [grid2x]action.clear symbol
            /// </summary>
            public const string action_clear = @"[grid2x]action.clear";
            /// <summary>
            /// Represents the [grid2x]action.clearsuggestion symbol
            /// </summary>
            public const string action_clearsuggestion = @"[grid2x]action.clearsuggestion";
            /// <summary>
            /// Represents the [grid2x]action.clearsymbol_1 symbol
            /// </summary>
            public const string action_clearsymbol_1 = @"[grid2x]action.clearsymbol_1";
            /// <summary>
            /// Represents the [grid2x]action.clearsymbol symbol
            /// </summary>
            public const string action_clearsymbol = @"[grid2x]action.clearsymbol";
            /// <summary>
            /// Represents the [grid2x]action.delete symbol
            /// </summary>
            public const string action_delete = @"[grid2x]action.delete";
            /// <summary>
            /// Represents the [grid2x]action.documentend symbol
            /// </summary>
            public const string action_documentend = @"[grid2x]action.documentend";
            /// <summary>
            /// Represents the [grid2x]action.documentstart symbol
            /// </summary>
            public const string action_documentstart = @"[grid2x]action.documentstart";
            /// <summary>
            /// Represents the [grid2x]action.down symbol
            /// </summary>
            public const string action_down = @"[grid2x]action.down";
            /// <summary>
            /// Represents the [grid2x]action.mute symbol
            /// </summary>
            public const string action_mute = @"[grid2x]action.mute";
            /// <summary>
            /// Represents the [grid2x]action.mute2 symbol
            /// </summary>
            public const string action_mute2 = @"[grid2x]action.mute2";
            /// <summary>
            /// Represents the [grid2x]action.mute3 symbol
            /// </summary>
            public const string action_mute3 = @"[grid2x]action.mute3";
            /// <summary>
            /// Represents the [grid2x]action.new_1 symbol
            /// </summary>
            public const string action_new_1 = @"[grid2x]action.new_1";
            /// <summary>
            /// Represents the [grid2x]action.new symbol
            /// </summary>
            public const string action_new = @"[grid2x]action.new";
            /// <summary>
            /// Represents the [grid2x]action.nextparagraph symbol
            /// </summary>
            public const string action_nextparagraph = @"[grid2x]action.nextparagraph";
            /// <summary>
            /// Represents the [grid2x]action.nextsentence symbol
            /// </summary>
            public const string action_nextsentence = @"[grid2x]action.nextsentence";
            /// <summary>
            /// Represents the [grid2x]action.nextsuggestion symbol
            /// </summary>
            public const string action_nextsuggestion = @"[grid2x]action.nextsuggestion";
            /// <summary>
            /// Represents the [grid2x]action.nextsymbol symbol
            /// </summary>
            public const string action_nextsymbol = @"[grid2x]action.nextsymbol";
            /// <summary>
            /// Represents the [grid2x]action.nextword symbol
            /// </summary>
            public const string action_nextword = @"[grid2x]action.nextword";
            /// <summary>
            /// Represents the [grid2x]action.open symbol
            /// </summary>
            public const string action_open = @"[grid2x]action.open";
            /// <summary>
            /// Represents the [grid2x]action.prevparagraph symbol
            /// </summary>
            public const string action_prevparagraph = @"[grid2x]action.prevparagraph";
            /// <summary>
            /// Represents the [grid2x]action.prevsentence symbol
            /// </summary>
            public const string action_prevsentence = @"[grid2x]action.prevsentence";
            /// <summary>
            /// Represents the [grid2x]action.prevword symbol
            /// </summary>
            public const string action_prevword = @"[grid2x]action.prevword";
            /// <summary>
            /// Represents the [grid2x]action.print_1 symbol
            /// </summary>
            public const string action_print_1 = @"[grid2x]action.print_1";
            /// <summary>
            /// Represents the [grid2x]action.print symbol
            /// </summary>
            public const string action_print = @"[grid2x]action.print";
            /// <summary>
            /// Represents the [grid2x]action.reply symbol
            /// </summary>
            public const string action_reply = @"[grid2x]action.reply";
            /// <summary>
            /// Represents the [grid2x]action.save_1 symbol
            /// </summary>
            public const string action_save_1 = @"[grid2x]action.save_1";
            /// <summary>
            /// Represents the [grid2x]action.save symbol
            /// </summary>
            public const string action_save = @"[grid2x]action.save";
            /// <summary>
            /// Represents the [grid2x]action.savephrase_1 symbol
            /// </summary>
            public const string action_savephrase_1 = @"[grid2x]action.savephrase_1";
            /// <summary>
            /// Represents the [grid2x]action.savephrase symbol
            /// </summary>
            public const string action_savephrase = @"[grid2x]action.savephrase";
            /// <summary>
            /// Represents the [grid2x]action.send symbol
            /// </summary>
            public const string action_send = @"[grid2x]action.send";
            /// <summary>
            /// Represents the [grid2x]action.setphrase_1 symbol
            /// </summary>
            public const string action_setphrase_1 = @"[grid2x]action.setphrase_1";
            /// <summary>
            /// Represents the [grid2x]action.setphrase symbol
            /// </summary>
            public const string action_setphrase = @"[grid2x]action.setphrase";
            /// <summary>
            /// Represents the [grid2x]action.showlist symbol
            /// </summary>
            public const string action_showlist = @"[grid2x]action.showlist";
            /// <summary>
            /// Represents the [grid2x]action.speakall_1 symbol
            /// </summary>
            public const string action_speakall_1 = @"[grid2x]action.speakall_1";
            /// <summary>
            /// Represents the [grid2x]action.speakall symbol
            /// </summary>
            public const string action_speakall = @"[grid2x]action.speakall";
            /// <summary>
            /// Represents the [grid2x]action.speakclipboard symbol
            /// </summary>
            public const string action_speakclipboard = @"[grid2x]action.speakclipboard";
            /// <summary>
            /// Represents the [grid2x]action.speakparagraph symbol
            /// </summary>
            public const string action_speakparagraph = @"[grid2x]action.speakparagraph";
            /// <summary>
            /// Represents the [grid2x]action.speakselection symbol
            /// </summary>
            public const string action_speakselection = @"[grid2x]action.speakselection";
            /// <summary>
            /// Represents the [grid2x]action.speaksentence_1 symbol
            /// </summary>
            public const string action_speaksentence_1 = @"[grid2x]action.speaksentence_1";
            /// <summary>
            /// Represents the [grid2x]action.speaksentence symbol
            /// </summary>
            public const string action_speaksentence = @"[grid2x]action.speaksentence";
            /// <summary>
            /// Represents the [grid2x]action.speakword symbol
            /// </summary>
            public const string action_speakword = @"[grid2x]action.speakword";
            /// <summary>
            /// Represents the [grid2x]action.stopspeaking symbol
            /// </summary>
            public const string action_stopspeaking = @"[grid2x]action.stopspeaking";
            /// <summary>
            /// Represents the [grid2x]action.storephrase_1 symbol
            /// </summary>
            public const string action_storephrase_1 = @"[grid2x]action.storephrase_1";
            /// <summary>
            /// Represents the [grid2x]action.storephrase symbol
            /// </summary>
            public const string action_storephrase = @"[grid2x]action.storephrase";
            /// <summary>
            /// Represents the [grid2x]action.undo_1 symbol
            /// </summary>
            public const string action_undo_1 = @"[grid2x]action.undo_1";
            /// <summary>
            /// Represents the [grid2x]action.undo symbol
            /// </summary>
            public const string action_undo = @"[grid2x]action.undo";
            /// <summary>
            /// Represents the [grid2x]action.up symbol
            /// </summary>
            public const string action_up = @"[grid2x]action.up";
            /// <summary>
            /// Represents the [grid2x]action.voldown symbol
            /// </summary>
            public const string action_voldown = @"[grid2x]action.voldown";
            /// <summary>
            /// Represents the [grid2x]action.voldown2 symbol
            /// </summary>
            public const string action_voldown2 = @"[grid2x]action.voldown2";
            /// <summary>
            /// Represents the [grid2x]action.volume symbol
            /// </summary>
            public const string action_volume = @"[grid2x]action.volume";
            /// <summary>
            /// Represents the [grid2x]action.volume2 symbol
            /// </summary>
            public const string action_volume2 = @"[grid2x]action.volume2";
            /// <summary>
            /// Represents the [grid2x]action.volup symbol
            /// </summary>
            public const string action_volup = @"[grid2x]action.volup";
            /// <summary>
            /// Represents the [grid2x]action.volup2 symbol
            /// </summary>
            public const string action_volup2 = @"[grid2x]action.volup2";
            /// <summary>
            /// Represents the [grid2x]application menu key symbol
            /// </summary>
            public const string application_menu_key = @"[grid2x]application menu key";
            /// <summary>
            /// Represents the [grid2x]arrow 1 down right symbol
            /// </summary>
            public const string arrow_1_down_right = @"[grid2x]arrow 1 down right";
            /// <summary>
            /// Represents the [grid2x]arrow 1 down symbol
            /// </summary>
            public const string arrow_1_down = @"[grid2x]arrow 1 down";
            /// <summary>
            /// Represents the [grid2x]arrow 1 left symbol
            /// </summary>
            public const string arrow_1_left = @"[grid2x]arrow 1 left";
            /// <summary>
            /// Represents the [grid2x]arrow 1 right symbol
            /// </summary>
            public const string arrow_1_right = @"[grid2x]arrow 1 right";
            /// <summary>
            /// Represents the [grid2x]arrow 1 up left symbol
            /// </summary>
            public const string arrow_1_up_left = @"[grid2x]arrow 1 up left";
            /// <summary>
            /// Represents the [grid2x]arrow 1 up right symbol
            /// </summary>
            public const string arrow_1_up_right = @"[grid2x]arrow 1 up right";
            /// <summary>
            /// Represents the [grid2x]arrow 1 up symbol
            /// </summary>
            public const string arrow_1_up = @"[grid2x]arrow 1 up";
            /// <summary>
            /// Represents the [grid2x]arrow 2 down left symbol
            /// </summary>
            public const string arrow_2_down_left = @"[grid2x]arrow 2 down left";
            /// <summary>
            /// Represents the [grid2x]arrow 2 down symbol
            /// </summary>
            public const string arrow_2_down = @"[grid2x]arrow 2 down";
            /// <summary>
            /// Represents the [grid2x]arrow 2 left symbol
            /// </summary>
            public const string arrow_2_left = @"[grid2x]arrow 2 left";
            /// <summary>
            /// Represents the [grid2x]arrow 2 right symbol
            /// </summary>
            public const string arrow_2_right = @"[grid2x]arrow 2 right";
            /// <summary>
            /// Represents the [grid2x]arrow 2 up symbol
            /// </summary>
            public const string arrow_2_up = @"[grid2x]arrow 2 up";
            /// <summary>
            /// Represents the [grid2x]arrow 3 down symbol
            /// </summary>
            public const string arrow_3_down = @"[grid2x]arrow 3 down";
            /// <summary>
            /// Represents the [grid2x]arrow 3 left symbol
            /// </summary>
            public const string arrow_3_left = @"[grid2x]arrow 3 left";
            /// <summary>
            /// Represents the [grid2x]arrow 3 right symbol
            /// </summary>
            public const string arrow_3_right = @"[grid2x]arrow 3 right";
            /// <summary>
            /// Represents the [grid2x]arrow 3 up symbol
            /// </summary>
            public const string arrow_3_up = @"[grid2x]arrow 3 up";
            /// <summary>
            /// Represents the [grid2x]arrow 4 down symbol
            /// </summary>
            public const string arrow_4_down = @"[grid2x]arrow 4 down";
            /// <summary>
            /// Represents the [grid2x]arrow 4 left symbol
            /// </summary>
            public const string arrow_4_left = @"[grid2x]arrow 4 left";
            /// <summary>
            /// Represents the [grid2x]arrow 4 right symbol
            /// </summary>
            public const string arrow_4_right = @"[grid2x]arrow 4 right";
            /// <summary>
            /// Represents the [grid2x]arrow 4 up symbol
            /// </summary>
            public const string arrow_4_up = @"[grid2x]arrow 4 up";
            /// <summary>
            /// Represents the [grid2x]arrow 5 down symbol
            /// </summary>
            public const string arrow_5_down = @"[grid2x]arrow 5 down";
            /// <summary>
            /// Represents the [grid2x]arrow 5 left symbol
            /// </summary>
            public const string arrow_5_left = @"[grid2x]arrow 5 left";
            /// <summary>
            /// Represents the [grid2x]arrow 5 right symbol
            /// </summary>
            public const string arrow_5_right = @"[grid2x]arrow 5 right";
            /// <summary>
            /// Represents the [grid2x]arrow 5 up symbol
            /// </summary>
            public const string arrow_5_up = @"[grid2x]arrow 5 up";
            /// <summary>
            /// Represents the [grid2x]auto content contacts symbol
            /// </summary>
            public const string auto_content_contacts = @"[grid2x]auto content contacts";
            /// <summary>
            /// Represents the [grid2x]auto content favourites symbol
            /// </summary>
            public const string auto_content_favourites = @"[grid2x]auto content favourites";
            /// <summary>
            /// Represents the [grid2x]auto content none symbol
            /// </summary>
            public const string auto_content_none = @"[grid2x]auto content none";
            /// <summary>
            /// Represents the [grid2x]auto content prediction symbol
            /// </summary>
            public const string auto_content_prediction = @"[grid2x]auto content prediction";
            /// <summary>
            /// Represents the [grid2x]auto content savephrase symbol
            /// </summary>
            public const string auto_content_savephrase = @"[grid2x]auto content savephrase";
            /// <summary>
            /// Represents the [grid2x]auto content score symbol
            /// </summary>
            public const string auto_content_score = @"[grid2x]auto content score";
            /// <summary>
            /// Represents the [grid2x]auto content web links symbol
            /// </summary>
            public const string auto_content_web_links = @"[grid2x]auto content web links";
            /// <summary>
            /// Represents the [grid2x]auto content word list symbol
            /// </summary>
            public const string auto_content_word_list = @"[grid2x]auto content word list";
            /// <summary>
            /// Represents the [grid2x]autocells.nextpage symbol
            /// </summary>
            public const string autocells_nextpage = @"[grid2x]autocells.nextpage";
            /// <summary>
            /// Represents the [grid2x]autocells.previouspage symbol
            /// </summary>
            public const string autocells_previouspage = @"[grid2x]autocells.previouspage";
            /// <summary>
            /// Represents the [grid2x]b symbol
            /// </summary>
            public const string b = @"[grid2x]b";
            /// <summary>
            /// Represents the [grid2x]b1 symbol
            /// </summary>
            public const string b1 = @"[grid2x]b1";
            /// <summary>
            /// Represents the [grid2x]back symbol
            /// </summary>
            public const string back = @"[grid2x]back";
            /// <summary>
            /// Represents the [grid2x]beep symbol
            /// </summary>
            public const string beep = @"[grid2x]beep";
            /// <summary>
            /// Represents the [grid2x]blank symbol
            /// </summary>
            public const string blank = @"[grid2x]blank";
            /// <summary>
            /// Represents the [grid2x]bookmark.clear symbol
            /// </summary>
            public const string bookmark_clear = @"[grid2x]bookmark.clear";
            /// <summary>
            /// Represents the [grid2x]bookmark.set symbol
            /// </summary>
            public const string bookmark_set = @"[grid2x]bookmark.set";
            /// <summary>
            /// Represents the [grid2x]browser.addressbarfocus symbol
            /// </summary>
            public const string browser_addressbarfocus = @"[grid2x]browser.addressbarfocus";
            /// <summary>
            /// Represents the [grid2x]browser.back symbol
            /// </summary>
            public const string browser_back = @"[grid2x]browser.back";
            /// <summary>
            /// Represents the [grid2x]browser.down symbol
            /// </summary>
            public const string browser_down = @"[grid2x]browser.down";
            /// <summary>
            /// Represents the [grid2x]browser.executelink symbol
            /// </summary>
            public const string browser_executelink = @"[grid2x]browser.executelink";
            /// <summary>
            /// Represents the [grid2x]browser.favourite_1 symbol
            /// </summary>
            public const string browser_favourite_1 = @"[grid2x]browser.favourite_1";
            /// <summary>
            /// Represents the [grid2x]browser.favourite symbol
            /// </summary>
            public const string browser_favourite = @"[grid2x]browser.favourite";
            /// <summary>
            /// Represents the [grid2x]browser.forward symbol
            /// </summary>
            public const string browser_forward = @"[grid2x]browser.forward";
            /// <summary>
            /// Represents the [grid2x]browser.home symbol
            /// </summary>
            public const string browser_home = @"[grid2x]browser.home";
            /// <summary>
            /// Represents the [grid2x]browser.left symbol
            /// </summary>
            public const string browser_left = @"[grid2x]browser.left";
            /// <summary>
            /// Represents the [grid2x]browser.nextlink symbol
            /// </summary>
            public const string browser_nextlink = @"[grid2x]browser.nextlink";
            /// <summary>
            /// Represents the [grid2x]browser.pagedown symbol
            /// </summary>
            public const string browser_pagedown = @"[grid2x]browser.pagedown";
            /// <summary>
            /// Represents the [grid2x]browser.pageleft symbol
            /// </summary>
            public const string browser_pageleft = @"[grid2x]browser.pageleft";
            /// <summary>
            /// Represents the [grid2x]browser.pageright symbol
            /// </summary>
            public const string browser_pageright = @"[grid2x]browser.pageright";
            /// <summary>
            /// Represents the [grid2x]browser.pageup symbol
            /// </summary>
            public const string browser_pageup = @"[grid2x]browser.pageup";
            /// <summary>
            /// Represents the [grid2x]browser.previouslink symbol
            /// </summary>
            public const string browser_previouslink = @"[grid2x]browser.previouslink";
            /// <summary>
            /// Represents the [grid2x]browser.reload symbol
            /// </summary>
            public const string browser_reload = @"[grid2x]browser.reload";
            /// <summary>
            /// Represents the [grid2x]browser.right symbol
            /// </summary>
            public const string browser_right = @"[grid2x]browser.right";
            /// <summary>
            /// Represents the [grid2x]browser.stop symbol
            /// </summary>
            public const string browser_stop = @"[grid2x]browser.stop";
            /// <summary>
            /// Represents the [grid2x]browser.up symbol
            /// </summary>
            public const string browser_up = @"[grid2x]browser.up";
            /// <summary>
            /// Represents the [grid2x]browser.url symbol
            /// </summary>
            public const string browser_url = @"[grid2x]browser.url";
            /// <summary>
            /// Represents the [grid2x]browser.webpagefocus symbol
            /// </summary>
            public const string browser_webpagefocus = @"[grid2x]browser.webpagefocus";
            /// <summary>
            /// Represents the [grid2x]browser.zoom symbol
            /// </summary>
            public const string browser_zoom = @"[grid2x]browser.zoom";
            /// <summary>
            /// Represents the [grid2x]browser.zoomin symbol
            /// </summary>
            public const string browser_zoomin = @"[grid2x]browser.zoomin";
            /// <summary>
            /// Represents the [grid2x]browser.zoomout symbol
            /// </summary>
            public const string browser_zoomout = @"[grid2x]browser.zoomout";
            /// <summary>
            /// Represents the [grid2x]c symbol
            /// </summary>
            public const string c = @"[grid2x]c";
            /// <summary>
            /// Represents the [grid2x]c1 symbol
            /// </summary>
            public const string c1 = @"[grid2x]c1";
            /// <summary>
            /// Represents the [grid2x]calc.add symbol
            /// </summary>
            public const string calc_add = @"[grid2x]calc.add";
            /// <summary>
            /// Represents the [grid2x]calc.divide symbol
            /// </summary>
            public const string calc_divide = @"[grid2x]calc.divide";
            /// <summary>
            /// Represents the [grid2x]calc.equals symbol
            /// </summary>
            public const string calc_equals = @"[grid2x]calc.equals";
            /// <summary>
            /// Represents the [grid2x]calc.multiply symbol
            /// </summary>
            public const string calc_multiply = @"[grid2x]calc.multiply";
            /// <summary>
            /// Represents the [grid2x]calc.subtract symbol
            /// </summary>
            public const string calc_subtract = @"[grid2x]calc.subtract";
            /// <summary>
            /// Represents the [grid2x]calendar.add symbol
            /// </summary>
            public const string calendar_add = @"[grid2x]calendar.add";
            /// <summary>
            /// Represents the [grid2x]calendar.delete symbol
            /// </summary>
            public const string calendar_delete = @"[grid2x]calendar.delete";
            /// <summary>
            /// Represents the [grid2x]calendar.down symbol
            /// </summary>
            public const string calendar_down = @"[grid2x]calendar.down";
            /// <summary>
            /// Represents the [grid2x]calendar.edit symbol
            /// </summary>
            public const string calendar_edit = @"[grid2x]calendar.edit";
            /// <summary>
            /// Represents the [grid2x]calendar.left symbol
            /// </summary>
            public const string calendar_left = @"[grid2x]calendar.left";
            /// <summary>
            /// Represents the [grid2x]calendar.next symbol
            /// </summary>
            public const string calendar_next = @"[grid2x]calendar.next";
            /// <summary>
            /// Represents the [grid2x]calendar.open symbol
            /// </summary>
            public const string calendar_open = @"[grid2x]calendar.open";
            /// <summary>
            /// Represents the [grid2x]calendar.previous symbol
            /// </summary>
            public const string calendar_previous = @"[grid2x]calendar.previous";
            /// <summary>
            /// Represents the [grid2x]calendar.right symbol
            /// </summary>
            public const string calendar_right = @"[grid2x]calendar.right";
            /// <summary>
            /// Represents the [grid2x]calendar.save symbol
            /// </summary>
            public const string calendar_save = @"[grid2x]calendar.save";
            /// <summary>
            /// Represents the [grid2x]calendar.settings symbol
            /// </summary>
            public const string calendar_settings = @"[grid2x]calendar.settings";
            /// <summary>
            /// Represents the [grid2x]calendar.up symbol
            /// </summary>
            public const string calendar_up = @"[grid2x]calendar.up";
            /// <summary>
            /// Represents the [grid2x]changeuser symbol
            /// </summary>
            public const string changeuser = @"[grid2x]changeuser";
            /// <summary>
            /// Represents the [grid2x]chat.delete symbol
            /// </summary>
            public const string chat_delete = @"[grid2x]chat.delete";
            /// <summary>
            /// Represents the [grid2x]chat.down symbol
            /// </summary>
            public const string chat_down = @"[grid2x]chat.down";
            /// <summary>
            /// Represents the [grid2x]chat.messagelist symbol
            /// </summary>
            public const string chat_messagelist = @"[grid2x]chat.messagelist";
            /// <summary>
            /// Represents the [grid2x]chat.new_1 symbol
            /// </summary>
            public const string chat_new_1 = @"[grid2x]chat.new_1";
            /// <summary>
            /// Represents the [grid2x]chat.new symbol
            /// </summary>
            public const string chat_new = @"[grid2x]chat.new";
            /// <summary>
            /// Represents the [grid2x]chat.open_1 symbol
            /// </summary>
            public const string chat_open_1 = @"[grid2x]chat.open_1";
            /// <summary>
            /// Represents the [grid2x]chat.open symbol
            /// </summary>
            public const string chat_open = @"[grid2x]chat.open";
            /// <summary>
            /// Represents the [grid2x]chat.save symbol
            /// </summary>
            public const string chat_save = @"[grid2x]chat.save";
            /// <summary>
            /// Represents the [grid2x]chat.up symbol
            /// </summary>
            public const string chat_up = @"[grid2x]chat.up";
            /// <summary>
            /// Represents the [grid2x]clear symbol
            /// </summary>
            public const string clear = @"[grid2x]clear";
            /// <summary>
            /// Represents the [grid2x]clipboard.copy symbol
            /// </summary>
            public const string clipboard_copy = @"[grid2x]clipboard.copy";
            /// <summary>
            /// Represents the [grid2x]clipboard.paste symbol
            /// </summary>
            public const string clipboard_paste = @"[grid2x]clipboard.paste";
            /// <summary>
            /// Represents the [grid2x]computer control _ alphabet symbol
            /// </summary>
            public const string computer_control_alphabet = @"[grid2x]computer control _ alphabet";
            /// <summary>
            /// Represents the [grid2x]computer control _ cursors symbol
            /// </summary>
            public const string computer_control_cursors = @"[grid2x]computer control _ cursors";
            /// <summary>
            /// Represents the [grid2x]computer control _ mouse symbol
            /// </summary>
            public const string computer_control_mouse = @"[grid2x]computer control _ mouse";
            /// <summary>
            /// Represents the [grid2x]computer control _ numbers symbol
            /// </summary>
            public const string computer_control_numbers = @"[grid2x]computer control _ numbers";
            /// <summary>
            /// Represents the [grid2x]computer control _ punctuation symbol
            /// </summary>
            public const string computer_control_punctuation = @"[grid2x]computer control _ punctuation";
            /// <summary>
            /// Represents the [grid2x]computer control _ settings symbol
            /// </summary>
            public const string computer_control_settings = @"[grid2x]computer control _ settings";
            /// <summary>
            /// Represents the [grid2x]computer control _ windows 2 symbol
            /// </summary>
            public const string computer_control_windows_2 = @"[grid2x]computer control _ windows 2";
            /// <summary>
            /// Represents the [grid2x]computer control _ windows symbol
            /// </summary>
            public const string computer_control_windows = @"[grid2x]computer control _ windows";
            /// <summary>
            /// Represents the [grid2x]contact_1 symbol
            /// </summary>
            public const string contact_1 = @"[grid2x]contact_1";
            /// <summary>
            /// Represents the [grid2x]contact.addnew_1 symbol
            /// </summary>
            public const string contact_addnew_1 = @"[grid2x]contact.addnew_1";
            /// <summary>
            /// Represents the [grid2x]contact.addnew symbol
            /// </summary>
            public const string contact_addnew = @"[grid2x]contact.addnew";
            /// <summary>
            /// Represents the [grid2x]contact.ecu symbol
            /// </summary>
            public const string contact_ecu = @"[grid2x]contact.ecu";
            /// <summary>
            /// Represents the [grid2x]contact.email symbol
            /// </summary>
            public const string contact_email = @"[grid2x]contact.email";
            /// <summary>
            /// Represents the [grid2x]contact.name symbol
            /// </summary>
            public const string contact_name = @"[grid2x]contact.name";
            /// <summary>
            /// Represents the [grid2x]contact.phone symbol
            /// </summary>
            public const string contact_phone = @"[grid2x]contact.phone";
            /// <summary>
            /// Represents the [grid2x]contact.sendto symbol
            /// </summary>
            public const string contact_sendto = @"[grid2x]contact.sendto";
            /// <summary>
            /// Represents the [grid2x]contact symbol
            /// </summary>
            public const string contact = @"[grid2x]contact";
            /// <summary>
            /// Represents the [grid2x]contacts.delete symbol
            /// </summary>
            public const string contacts_delete = @"[grid2x]contacts.delete";
            /// <summary>
            /// Represents the [grid2x]contacts.down symbol
            /// </summary>
            public const string contacts_down = @"[grid2x]contacts.down";
            /// <summary>
            /// Represents the [grid2x]contacts.new_1 symbol
            /// </summary>
            public const string contacts_new_1 = @"[grid2x]contacts.new_1";
            /// <summary>
            /// Represents the [grid2x]contacts.new symbol
            /// </summary>
            public const string contacts_new = @"[grid2x]contacts.new";
            /// <summary>
            /// Represents the [grid2x]contacts.open symbol
            /// </summary>
            public const string contacts_open = @"[grid2x]contacts.open";
            /// <summary>
            /// Represents the [grid2x]contacts.save symbol
            /// </summary>
            public const string contacts_save = @"[grid2x]contacts.save";
            /// <summary>
            /// Represents the [grid2x]contacts.showlist symbol
            /// </summary>
            public const string contacts_showlist = @"[grid2x]contacts.showlist";
            /// <summary>
            /// Represents the [grid2x]contacts.up symbol
            /// </summary>
            public const string contacts_up = @"[grid2x]contacts.up";
            /// <summary>
            /// Represents the [grid2x]d symbol
            /// </summary>
            public const string d = @"[grid2x]d";
            /// <summary>
            /// Represents the [grid2x]d1 symbol
            /// </summary>
            public const string d1 = @"[grid2x]d1";
            /// <summary>
            /// Represents the [grid2x]datalog.off symbol
            /// </summary>
            public const string datalog_off = @"[grid2x]datalog.off";
            /// <summary>
            /// Represents the [grid2x]datalog.on symbol
            /// </summary>
            public const string datalog_on = @"[grid2x]datalog.on";
            /// <summary>
            /// Represents the [grid2x]datalog.toggle symbol
            /// </summary>
            public const string datalog_toggle = @"[grid2x]datalog.toggle";
            /// <summary>
            /// Represents the [grid2x]dice_1 symbol
            /// </summary>
            public const string dice_1 = @"[grid2x]dice_1";
            /// <summary>
            /// Represents the [grid2x]dice_2 symbol
            /// </summary>
            public const string dice_2 = @"[grid2x]dice_2";
            /// <summary>
            /// Represents the [grid2x]dice_3 symbol
            /// </summary>
            public const string dice_3 = @"[grid2x]dice_3";
            /// <summary>
            /// Represents the [grid2x]dice_4 symbol
            /// </summary>
            public const string dice_4 = @"[grid2x]dice_4";
            /// <summary>
            /// Represents the [grid2x]dice_5 symbol
            /// </summary>
            public const string dice_5 = @"[grid2x]dice_5";
            /// <summary>
            /// Represents the [grid2x]dice_6 symbol
            /// </summary>
            public const string dice_6 = @"[grid2x]dice_6";
            /// <summary>
            /// Represents the [grid2x]dice symbol
            /// </summary>
            public const string dice = @"[grid2x]dice";
            /// <summary>
            /// Represents the [grid2x]e symbol
            /// </summary>
            public const string e = @"[grid2x]e";
            /// <summary>
            /// Represents the [grid2x]e1 symbol
            /// </summary>
            public const string e1 = @"[grid2x]e1";
            /// <summary>
            /// Represents the [grid2x]ecu.bjperseo.glide symbol
            /// </summary>
            public const string ecu_bjperseo_glide = @"[grid2x]ecu.bjperseo.glide";
            /// <summary>
            /// Represents the [grid2x]ecu.bjperseo.hold symbol
            /// </summary>
            public const string ecu_bjperseo_hold = @"[grid2x]ecu.bjperseo.hold";
            /// <summary>
            /// Represents the [grid2x]ecu.bjperseo.press symbol
            /// </summary>
            public const string ecu_bjperseo_press = @"[grid2x]ecu.bjperseo.press";
            /// <summary>
            /// Represents the [grid2x]ecu.custom symbol
            /// </summary>
            public const string ecu_custom = @"[grid2x]ecu.custom";
            /// <summary>
            /// Represents the [grid2x]ecu.easywave symbol
            /// </summary>
            public const string ecu_easywave = @"[grid2x]ecu.easywave";
            /// <summary>
            /// Represents the [grid2x]ecu.evoassist symbol
            /// </summary>
            public const string ecu_evoassist = @"[grid2x]ecu.evoassist";
            /// <summary>
            /// Represents the [grid2x]ecu.gewa.glide symbol
            /// </summary>
            public const string ecu_gewa_glide = @"[grid2x]ecu.gewa.glide";
            /// <summary>
            /// Represents the [grid2x]ecu.gewa.press symbol
            /// </summary>
            public const string ecu_gewa_press = @"[grid2x]ecu.gewa.press";
            /// <summary>
            /// Represents the [grid2x]ecu.gewalinkglide symbol
            /// </summary>
            public const string ecu_gewalinkglide = @"[grid2x]ecu.gewalinkglide";
            /// <summary>
            /// Represents the [grid2x]ecu.gewalinkhold symbol
            /// </summary>
            public const string ecu_gewalinkhold = @"[grid2x]ecu.gewalinkhold";
            /// <summary>
            /// Represents the [grid2x]ecu.gewalinkpress symbol
            /// </summary>
            public const string ecu_gewalinkpress = @"[grid2x]ecu.gewalinkpress";
            /// <summary>
            /// Represents the [grid2x]ecu.glide symbol
            /// </summary>
            public const string ecu_glide = @"[grid2x]ecu.glide";
            /// <summary>
            /// Represents the [grid2x]ecu.hold symbol
            /// </summary>
            public const string ecu_hold = @"[grid2x]ecu.hold";
            /// <summary>
            /// Represents the [grid2x]ecu.irtrans symbol
            /// </summary>
            public const string ecu_irtrans = @"[grid2x]ecu.irtrans";
            /// <summary>
            /// Represents the [grid2x]ecu.press symbol
            /// </summary>
            public const string ecu_press = @"[grid2x]ecu.press";
            /// <summary>
            /// Represents the [grid2x]ecu.tira symbol
            /// </summary>
            public const string ecu_tira = @"[grid2x]ecu.tira";
            /// <summary>
            /// Represents the [grid2x]ecu.tirahold symbol
            /// </summary>
            public const string ecu_tirahold = @"[grid2x]ecu.tirahold";
            /// <summary>
            /// Represents the [grid2x]ecu.uuirt symbol
            /// </summary>
            public const string ecu_uuirt = @"[grid2x]ecu.uuirt";
            /// <summary>
            /// Represents the [grid2x]ecu.uuirthold symbol
            /// </summary>
            public const string ecu_uuirthold = @"[grid2x]ecu.uuirthold";
            /// <summary>
            /// Represents the [grid2x]ecu.zwave.alloff symbol
            /// </summary>
            public const string ecu_zwave_alloff = @"[grid2x]ecu.zwave.alloff";
            /// <summary>
            /// Represents the [grid2x]ecu.zwave.allon symbol
            /// </summary>
            public const string ecu_zwave_allon = @"[grid2x]ecu.zwave.allon";
            /// <summary>
            /// Represents the [grid2x]ecu.zwave.devicelevel symbol
            /// </summary>
            public const string ecu_zwave_devicelevel = @"[grid2x]ecu.zwave.devicelevel";
            /// <summary>
            /// Represents the [grid2x]ecu.zwave.deviceoff symbol
            /// </summary>
            public const string ecu_zwave_deviceoff = @"[grid2x]ecu.zwave.deviceoff";
            /// <summary>
            /// Represents the [grid2x]ecu.zwave.deviceon symbol
            /// </summary>
            public const string ecu_zwave_deviceon = @"[grid2x]ecu.zwave.deviceon";
            /// <summary>
            /// Represents the [grid2x]edit symbol
            /// </summary>
            public const string edit = @"[grid2x]edit";
            /// <summary>
            /// Represents the [grid2x]editmode symbol
            /// </summary>
            public const string editmode = @"[grid2x]editmode";
            /// <summary>
            /// Represents the [grid2x]email.contacts symbol
            /// </summary>
            public const string email_contacts = @"[grid2x]email.contacts";
            /// <summary>
            /// Represents the [grid2x]email.delete symbol
            /// </summary>
            public const string email_delete = @"[grid2x]email.delete";
            /// <summary>
            /// Represents the [grid2x]email.down symbol
            /// </summary>
            public const string email_down = @"[grid2x]email.down";
            /// <summary>
            /// Represents the [grid2x]email.edit symbol
            /// </summary>
            public const string email_edit = @"[grid2x]email.edit";
            /// <summary>
            /// Represents the [grid2x]email.new_1 symbol
            /// </summary>
            public const string email_new_1 = @"[grid2x]email.new_1";
            /// <summary>
            /// Represents the [grid2x]email.new symbol
            /// </summary>
            public const string email_new = @"[grid2x]email.new";
            /// <summary>
            /// Represents the [grid2x]email.open symbol
            /// </summary>
            public const string email_open = @"[grid2x]email.open";
            /// <summary>
            /// Represents the [grid2x]email.reply symbol
            /// </summary>
            public const string email_reply = @"[grid2x]email.reply";
            /// <summary>
            /// Represents the [grid2x]email.send symbol
            /// </summary>
            public const string email_send = @"[grid2x]email.send";
            /// <summary>
            /// Represents the [grid2x]email.showlist symbol
            /// </summary>
            public const string email_showlist = @"[grid2x]email.showlist";
            /// <summary>
            /// Represents the [grid2x]email.up symbol
            /// </summary>
            public const string email_up = @"[grid2x]email.up";
            /// <summary>
            /// Represents the [grid2x]environmentcontrol.add symbol
            /// </summary>
            public const string environmentcontrol_add = @"[grid2x]environmentcontrol.add";
            /// <summary>
            /// Represents the [grid2x]environmentcontrol.clear symbol
            /// </summary>
            public const string environmentcontrol_clear = @"[grid2x]environmentcontrol.clear";
            /// <summary>
            /// Represents the [grid2x]environmentcontrol.newcontact symbol
            /// </summary>
            public const string environmentcontrol_newcontact = @"[grid2x]environmentcontrol.newcontact";
            /// <summary>
            /// Represents the [grid2x]environmentcontrol.receiver symbol
            /// </summary>
            public const string environmentcontrol_receiver = @"[grid2x]environmentcontrol.receiver";
            /// <summary>
            /// Represents the [grid2x]environmentcontrol.remove symbol
            /// </summary>
            public const string environmentcontrol_remove = @"[grid2x]environmentcontrol.remove";
            /// <summary>
            /// Represents the [grid2x]environmentcontrol.send symbol
            /// </summary>
            public const string environmentcontrol_send = @"[grid2x]environmentcontrol.send";
            /// <summary>
            /// Represents the [grid2x]environmentcontrol.sendnow symbol
            /// </summary>
            public const string environmentcontrol_sendnow = @"[grid2x]environmentcontrol.sendnow";
            /// <summary>
            /// Represents the [grid2x]exit symbol
            /// </summary>
            public const string exit = @"[grid2x]exit";
            /// <summary>
            /// Represents the [grid2x]eyedwell.longer symbol
            /// </summary>
            public const string eyedwell_longer = @"[grid2x]eyedwell.longer";
            /// <summary>
            /// Represents the [grid2x]eyedwell.shorter symbol
            /// </summary>
            public const string eyedwell_shorter = @"[grid2x]eyedwell.shorter";
            /// <summary>
            /// Represents the [grid2x]eyegaze.calibrate symbol
            /// </summary>
            public const string eyegaze_calibrate = @"[grid2x]eyegaze.calibrate";
            /// <summary>
            /// Represents the [grid2x]eyegaze.calibrateimprove symbol
            /// </summary>
            public const string eyegaze_calibrateimprove = @"[grid2x]eyegaze.calibrateimprove";
            /// <summary>
            /// Represents the [grid2x]eyegaze.monitor_1 symbol
            /// </summary>
            public const string eyegaze_monitor_1 = @"[grid2x]eyegaze.monitor_1";
            /// <summary>
            /// Represents the [grid2x]eyegaze.monitor_2 symbol
            /// </summary>
            public const string eyegaze_monitor_2 = @"[grid2x]eyegaze.monitor_2";
            /// <summary>
            /// Represents the [grid2x]eyegaze.monitor_3 symbol
            /// </summary>
            public const string eyegaze_monitor_3 = @"[grid2x]eyegaze.monitor_3";
            /// <summary>
            /// Represents the [grid2x]eyegaze.monitor_4 symbol
            /// </summary>
            public const string eyegaze_monitor_4 = @"[grid2x]eyegaze.monitor_4";
            /// <summary>
            /// Represents the [grid2x]eyegaze.monitor_5 symbol
            /// </summary>
            public const string eyegaze_monitor_5 = @"[grid2x]eyegaze.monitor_5";
            /// <summary>
            /// Represents the [grid2x]eyegaze.monitor symbol
            /// </summary>
            public const string eyegaze_monitor = @"[grid2x]eyegaze.monitor";
            /// <summary>
            /// Represents the [grid2x]f symbol
            /// </summary>
            public const string f = @"[grid2x]f";
            /// <summary>
            /// Represents the [grid2x]f1 symbol
            /// </summary>
            public const string f1 = @"[grid2x]f1";
            /// <summary>
            /// Represents the [grid2x]g symbol
            /// </summary>
            public const string g = @"[grid2x]g";
            /// <summary>
            /// Represents the [grid2x]g1 symbol
            /// </summary>
            public const string g1 = @"[grid2x]g1";
            /// <summary>
            /// Represents the [grid2x]g2 symbol
            /// </summary>
            public const string g2 = @"[grid2x]g2";
            /// <summary>
            /// Represents the [grid2x]grid.align_1 symbol
            /// </summary>
            public const string grid_align_1 = @"[grid2x]grid.align_1";
            /// <summary>
            /// Represents the [grid2x]grid.align_2 symbol
            /// </summary>
            public const string grid_align_2 = @"[grid2x]grid.align_2";
            /// <summary>
            /// Represents the [grid2x]grid.align_3 symbol
            /// </summary>
            public const string grid_align_3 = @"[grid2x]grid.align_3";
            /// <summary>
            /// Represents the [grid2x]grid.align_4 symbol
            /// </summary>
            public const string grid_align_4 = @"[grid2x]grid.align_4";
            /// <summary>
            /// Represents the [grid2x]grid.align symbol
            /// </summary>
            public const string grid_align = @"[grid2x]grid.align";
            /// <summary>
            /// Represents the [grid2x]grid.windowmove_1 symbol
            /// </summary>
            public const string grid_windowmove_1 = @"[grid2x]grid.windowmove_1";
            /// <summary>
            /// Represents the [grid2x]grid.windowmove_2 symbol
            /// </summary>
            public const string grid_windowmove_2 = @"[grid2x]grid.windowmove_2";
            /// <summary>
            /// Represents the [grid2x]grid.windowmove_3 symbol
            /// </summary>
            public const string grid_windowmove_3 = @"[grid2x]grid.windowmove_3";
            /// <summary>
            /// Represents the [grid2x]grid.windowmove_4 symbol
            /// </summary>
            public const string grid_windowmove_4 = @"[grid2x]grid.windowmove_4";
            /// <summary>
            /// Represents the [grid2x]grid.windowmove symbol
            /// </summary>
            public const string grid_windowmove = @"[grid2x]grid.windowmove";
            /// <summary>
            /// Represents the [grid2x]grid.windowsize_1 symbol
            /// </summary>
            public const string grid_windowsize_1 = @"[grid2x]grid.windowsize_1";
            /// <summary>
            /// Represents the [grid2x]grid.windowsize_2 symbol
            /// </summary>
            public const string grid_windowsize_2 = @"[grid2x]grid.windowsize_2";
            /// <summary>
            /// Represents the [grid2x]grid.windowsize_3 symbol
            /// </summary>
            public const string grid_windowsize_3 = @"[grid2x]grid.windowsize_3";
            /// <summary>
            /// Represents the [grid2x]grid.windowsize_4 symbol
            /// </summary>
            public const string grid_windowsize_4 = @"[grid2x]grid.windowsize_4";
            /// <summary>
            /// Represents the [grid2x]grid.windowsize symbol
            /// </summary>
            public const string grid_windowsize = @"[grid2x]grid.windowsize";
            /// <summary>
            /// Represents the [grid2x]gridexplorer symbol
            /// </summary>
            public const string gridexplorer = @"[grid2x]gridexplorer";
            /// <summary>
            /// Represents the [grid2x]h symbol
            /// </summary>
            public const string h = @"[grid2x]h";
            /// <summary>
            /// Represents the [grid2x]h1 symbol
            /// </summary>
            public const string h1 = @"[grid2x]h1";
            /// <summary>
            /// Represents the [grid2x]i symbol
            /// </summary>
            public const string i = @"[grid2x]i";
            /// <summary>
            /// Represents the [grid2x]i1 symbol
            /// </summary>
            public const string i1 = @"[grid2x]i1";
            /// <summary>
            /// Represents the [grid2x]information message symbol
            /// </summary>
            public const string information_message = @"[grid2x]information message";
            /// <summary>
            /// Represents the [grid2x]j symbol
            /// </summary>
            public const string j = @"[grid2x]j";
            /// <summary>
            /// Represents the [grid2x]j1 symbol
            /// </summary>
            public const string j1 = @"[grid2x]j1";
            /// <summary>
            /// Represents the [grid2x]jump.back_1 symbol
            /// </summary>
            public const string jump_back_1 = @"[grid2x]jump.back_1";
            /// <summary>
            /// Represents the [grid2x]jump.back symbol
            /// </summary>
            public const string jump_back = @"[grid2x]jump.back";
            /// <summary>
            /// Represents the [grid2x]jump.home_1 symbol
            /// </summary>
            public const string jump_home_1 = @"[grid2x]jump.home_1";
            /// <summary>
            /// Represents the [grid2x]jump.home symbol
            /// </summary>
            public const string jump_home = @"[grid2x]jump.home";
            /// <summary>
            /// Represents the [grid2x]jump.pin symbol
            /// </summary>
            public const string jump_pin = @"[grid2x]jump.pin";
            /// <summary>
            /// Represents the [grid2x]jump.sticky symbol
            /// </summary>
            public const string jump_sticky = @"[grid2x]jump.sticky";
            /// <summary>
            /// Represents the [grid2x]jump.to symbol
            /// </summary>
            public const string jump_to = @"[grid2x]jump.to";
            /// <summary>
            /// Represents the [grid2x]k symbol
            /// </summary>
            public const string k = @"[grid2x]k";
            /// <summary>
            /// Represents the [grid2x]k1 symbol
            /// </summary>
            public const string k1 = @"[grid2x]k1";
            /// <summary>
            /// Represents the [grid2x]keyboard  enter symbol
            /// </summary>
            public const string keyboard_enter = @"[grid2x]keyboard  enter";
            /// <summary>
            /// Represents the [grid2x]keyboard arrow down symbol
            /// </summary>
            public const string keyboard_arrow_down = @"[grid2x]keyboard arrow down";
            /// <summary>
            /// Represents the [grid2x]keyboard arrow left symbol
            /// </summary>
            public const string keyboard_arrow_left = @"[grid2x]keyboard arrow left";
            /// <summary>
            /// Represents the [grid2x]keyboard arrow right symbol
            /// </summary>
            public const string keyboard_arrow_right = @"[grid2x]keyboard arrow right";
            /// <summary>
            /// Represents the [grid2x]keyboard arrow up symbol
            /// </summary>
            public const string keyboard_arrow_up = @"[grid2x]keyboard arrow up";
            /// <summary>
            /// Represents the [grid2x]keyboard backspace symbol
            /// </summary>
            public const string keyboard_backspace = @"[grid2x]keyboard backspace";
            /// <summary>
            /// Represents the [grid2x]keyboard del symbol
            /// </summary>
            public const string keyboard_del = @"[grid2x]keyboard del";
            /// <summary>
            /// Represents the [grid2x]keyboard delete word symbol
            /// </summary>
            public const string keyboard_delete_word = @"[grid2x]keyboard delete word";
            /// <summary>
            /// Represents the [grid2x]keyboard insert symbol
            /// </summary>
            public const string keyboard_insert = @"[grid2x]keyboard insert";
            /// <summary>
            /// Represents the [grid2x]keyboard shift 2 symbol
            /// </summary>
            public const string keyboard_shift_2 = @"[grid2x]keyboard shift 2";
            /// <summary>
            /// Represents the [grid2x]keyboard shift symbol
            /// </summary>
            public const string keyboard_shift = @"[grid2x]keyboard shift";
            /// <summary>
            /// Represents the [grid2x]keyboard space 2 symbol
            /// </summary>
            public const string keyboard_space_2 = @"[grid2x]keyboard space 2";
            /// <summary>
            /// Represents the [grid2x]keyboard space 3 symbol
            /// </summary>
            public const string keyboard_space_3 = @"[grid2x]keyboard space 3";
            /// <summary>
            /// Represents the [grid2x]keyboard space symbol
            /// </summary>
            public const string keyboard_space = @"[grid2x]keyboard space";
            /// <summary>
            /// Represents the [grid2x]keyboard tab symbol
            /// </summary>
            public const string keyboard_tab = @"[grid2x]keyboard tab";
            /// <summary>
            /// Represents the [grid2x]keyboard.next symbol
            /// </summary>
            public const string keyboard_next = @"[grid2x]keyboard.next";
            /// <summary>
            /// Represents the [grid2x]keyboard.select symbol
            /// </summary>
            public const string keyboard_select = @"[grid2x]keyboard.select";
            /// <summary>
            /// Represents the [grid2x]keys _ tab symbol
            /// </summary>
            public const string keys_tab = @"[grid2x]keys _ tab";
            /// <summary>
            /// Represents the [grid2x]l symbol
            /// </summary>
            public const string l = @"[grid2x]l";
            /// <summary>
            /// Represents the [grid2x]l1 symbol
            /// </summary>
            public const string l1 = @"[grid2x]l1";
            /// <summary>
            /// Represents the [grid2x]m symbol
            /// </summary>
            public const string m = @"[grid2x]m";
            /// <summary>
            /// Represents the [grid2x]m1 symbol
            /// </summary>
            public const string m1 = @"[grid2x]m1";
            /// <summary>
            /// Represents the [grid2x]media.back symbol
            /// </summary>
            public const string media_back = @"[grid2x]media.back";
            /// <summary>
            /// Represents the [grid2x]media.down symbol
            /// </summary>
            public const string media_down = @"[grid2x]media.down";
            /// <summary>
            /// Represents the [grid2x]media.ffwd symbol
            /// </summary>
            public const string media_ffwd = @"[grid2x]media.ffwd";
            /// <summary>
            /// Represents the [grid2x]media.left symbol
            /// </summary>
            public const string media_left = @"[grid2x]media.left";
            /// <summary>
            /// Represents the [grid2x]media.listalbums symbol
            /// </summary>
            public const string media_listalbums = @"[grid2x]media.listalbums";
            /// <summary>
            /// Represents the [grid2x]media.listall symbol
            /// </summary>
            public const string media_listall = @"[grid2x]media.listall";
            /// <summary>
            /// Represents the [grid2x]media.listartists symbol
            /// </summary>
            public const string media_listartists = @"[grid2x]media.listartists";
            /// <summary>
            /// Represents the [grid2x]media.listcd symbol
            /// </summary>
            public const string media_listcd = @"[grid2x]media.listcd";
            /// <summary>
            /// Represents the [grid2x]media.listplaylists symbol
            /// </summary>
            public const string media_listplaylists = @"[grid2x]media.listplaylists";
            /// <summary>
            /// Represents the [grid2x]media.mute symbol
            /// </summary>
            public const string media_mute = @"[grid2x]media.mute";
            /// <summary>
            /// Represents the [grid2x]media.mutemedia symbol
            /// </summary>
            public const string media_mutemedia = @"[grid2x]media.mutemedia";
            /// <summary>
            /// Represents the [grid2x]media.next symbol
            /// </summary>
            public const string media_next = @"[grid2x]media.next";
            /// <summary>
            /// Represents the [grid2x]media.openfile_1 symbol
            /// </summary>
            public const string media_openfile_1 = @"[grid2x]media.openfile_1";
            /// <summary>
            /// Represents the [grid2x]media.openfile symbol
            /// </summary>
            public const string media_openfile = @"[grid2x]media.openfile";
            /// <summary>
            /// Represents the [grid2x]media.pause symbol
            /// </summary>
            public const string media_pause = @"[grid2x]media.pause";
            /// <summary>
            /// Represents the [grid2x]media.play_1 symbol
            /// </summary>
            public const string media_play_1 = @"[grid2x]media.play_1";
            /// <summary>
            /// Represents the [grid2x]media.play symbol
            /// </summary>
            public const string media_play = @"[grid2x]media.play";
            /// <summary>
            /// Represents the [grid2x]media.rewind symbol
            /// </summary>
            public const string media_rewind = @"[grid2x]media.rewind";
            /// <summary>
            /// Represents the [grid2x]media.right symbol
            /// </summary>
            public const string media_right = @"[grid2x]media.right";
            /// <summary>
            /// Represents the [grid2x]media.select symbol
            /// </summary>
            public const string media_select = @"[grid2x]media.select";
            /// <summary>
            /// Represents the [grid2x]media.shuffle symbol
            /// </summary>
            public const string media_shuffle = @"[grid2x]media.shuffle";
            /// <summary>
            /// Represents the [grid2x]media.stop symbol
            /// </summary>
            public const string media_stop = @"[grid2x]media.stop";
            /// <summary>
            /// Represents the [grid2x]media.titlemenu symbol
            /// </summary>
            public const string media_titlemenu = @"[grid2x]media.titlemenu";
            /// <summary>
            /// Represents the [grid2x]media.topmenu symbol
            /// </summary>
            public const string media_topmenu = @"[grid2x]media.topmenu";
            /// <summary>
            /// Represents the [grid2x]media.up symbol
            /// </summary>
            public const string media_up = @"[grid2x]media.up";
            /// <summary>
            /// Represents the [grid2x]media.upmedia symbol
            /// </summary>
            public const string media_upmedia = @"[grid2x]media.upmedia";
            /// <summary>
            /// Represents the [grid2x]media.voldown symbol
            /// </summary>
            public const string media_voldown = @"[grid2x]media.voldown";
            /// <summary>
            /// Represents the [grid2x]media.voldownmedia symbol
            /// </summary>
            public const string media_voldownmedia = @"[grid2x]media.voldownmedia";
            /// <summary>
            /// Represents the [grid2x]media.volume symbol
            /// </summary>
            public const string media_volume = @"[grid2x]media.volume";
            /// <summary>
            /// Represents the [grid2x]media.volumemedia symbol
            /// </summary>
            public const string media_volumemedia = @"[grid2x]media.volumemedia";
            /// <summary>
            /// Represents the [grid2x]media.volup symbol
            /// </summary>
            public const string media_volup = @"[grid2x]media.volup";
            /// <summary>
            /// Represents the [grid2x]media.volupmedia symbol
            /// </summary>
            public const string media_volupmedia = @"[grid2x]media.volupmedia";
            /// <summary>
            /// Represents the [grid2x]message.contacts symbol
            /// </summary>
            public const string message_contacts = @"[grid2x]message.contacts";
            /// <summary>
            /// Represents the [grid2x]message.edit symbol
            /// </summary>
            public const string message_edit = @"[grid2x]message.edit";
            /// <summary>
            /// Represents the [grid2x]message.showlist symbol
            /// </summary>
            public const string message_showlist = @"[grid2x]message.showlist";
            /// <summary>
            /// Represents the [grid2x]midi.aftertouch symbol
            /// </summary>
            public const string midi_aftertouch = @"[grid2x]midi.aftertouch";
            /// <summary>
            /// Represents the [grid2x]midi.controller symbol
            /// </summary>
            public const string midi_controller = @"[grid2x]midi.controller";
            /// <summary>
            /// Represents the [grid2x]midi.note symbol
            /// </summary>
            public const string midi_note = @"[grid2x]midi.note";
            /// <summary>
            /// Represents the [grid2x]midi.noteoff symbol
            /// </summary>
            public const string midi_noteoff = @"[grid2x]midi.noteoff";
            /// <summary>
            /// Represents the [grid2x]midi.noteon symbol
            /// </summary>
            public const string midi_noteon = @"[grid2x]midi.noteon";
            /// <summary>
            /// Represents the [grid2x]midi.out symbol
            /// </summary>
            public const string midi_out = @"[grid2x]midi.out";
            /// <summary>
            /// Represents the [grid2x]midi.pressure symbol
            /// </summary>
            public const string midi_pressure = @"[grid2x]midi.pressure";
            /// <summary>
            /// Represents the [grid2x]midi.program symbol
            /// </summary>
            public const string midi_program = @"[grid2x]midi.program";
            /// <summary>
            /// Represents the [grid2x]mouse pointer symbol
            /// </summary>
            public const string mouse_pointer = @"[grid2x]mouse pointer";
            /// <summary>
            /// Represents the [grid2x]mouse.click symbol
            /// </summary>
            public const string mouse_click = @"[grid2x]mouse.click";
            /// <summary>
            /// Represents the [grid2x]mouse.doubleclick_1 symbol
            /// </summary>
            public const string mouse_doubleclick_1 = @"[grid2x]mouse.doubleclick_1";
            /// <summary>
            /// Represents the [grid2x]mouse.doubleclick_2 symbol
            /// </summary>
            public const string mouse_doubleclick_2 = @"[grid2x]mouse.doubleclick_2";
            /// <summary>
            /// Represents the [grid2x]mouse.doubleclick symbol
            /// </summary>
            public const string mouse_doubleclick = @"[grid2x]mouse.doubleclick";
            /// <summary>
            /// Represents the [grid2x]mouse.drag_1 symbol
            /// </summary>
            public const string mouse_drag_1 = @"[grid2x]mouse.drag_1";
            /// <summary>
            /// Represents the [grid2x]mouse.drag symbol
            /// </summary>
            public const string mouse_drag = @"[grid2x]mouse.drag";
            /// <summary>
            /// Represents the [grid2x]mouse.leftclick_1 symbol
            /// </summary>
            public const string mouse_leftclick_1 = @"[grid2x]mouse.leftclick_1";
            /// <summary>
            /// Represents the [grid2x]mouse.leftclick_2 symbol
            /// </summary>
            public const string mouse_leftclick_2 = @"[grid2x]mouse.leftclick_2";
            /// <summary>
            /// Represents the [grid2x]mouse.leftclick symbol
            /// </summary>
            public const string mouse_leftclick = @"[grid2x]mouse.leftclick";
            /// <summary>
            /// Represents the [grid2x]mouse.move symbol
            /// </summary>
            public const string mouse_move = @"[grid2x]mouse.move";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_1 symbol
            /// </summary>
            public const string mouse_radar_1 = @"[grid2x]mouse.radar_1";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_2 symbol
            /// </summary>
            public const string mouse_radar_2 = @"[grid2x]mouse.radar_2";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_3 symbol
            /// </summary>
            public const string mouse_radar_3 = @"[grid2x]mouse.radar_3";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_4 symbol
            /// </summary>
            public const string mouse_radar_4 = @"[grid2x]mouse.radar_4";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_5 symbol
            /// </summary>
            public const string mouse_radar_5 = @"[grid2x]mouse.radar_5";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_6 symbol
            /// </summary>
            public const string mouse_radar_6 = @"[grid2x]mouse.radar_6";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_7 symbol
            /// </summary>
            public const string mouse_radar_7 = @"[grid2x]mouse.radar_7";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_8 symbol
            /// </summary>
            public const string mouse_radar_8 = @"[grid2x]mouse.radar_8";
            /// <summary>
            /// Represents the [grid2x]mouse.radar_9 symbol
            /// </summary>
            public const string mouse_radar_9 = @"[grid2x]mouse.radar_9";
            /// <summary>
            /// Represents the [grid2x]mouse.radar symbol
            /// </summary>
            public const string mouse_radar = @"[grid2x]mouse.radar";
            /// <summary>
            /// Represents the [grid2x]mouse.restdwell_1 symbol
            /// </summary>
            public const string mouse_restdwell_1 = @"[grid2x]mouse.restdwell_1";
            /// <summary>
            /// Represents the [grid2x]mouse.restdwell_2 symbol
            /// </summary>
            public const string mouse_restdwell_2 = @"[grid2x]mouse.restdwell_2";
            /// <summary>
            /// Represents the [grid2x]mouse.restdwell_3 symbol
            /// </summary>
            public const string mouse_restdwell_3 = @"[grid2x]mouse.restdwell_3";
            /// <summary>
            /// Represents the [grid2x]mouse.restdwell_4 symbol
            /// </summary>
            public const string mouse_restdwell_4 = @"[grid2x]mouse.restdwell_4";
            /// <summary>
            /// Represents the [grid2x]mouse.restdwell symbol
            /// </summary>
            public const string mouse_restdwell = @"[grid2x]mouse.restdwell";
            /// <summary>
            /// Represents the [grid2x]mouse.rightclick_1 symbol
            /// </summary>
            public const string mouse_rightclick_1 = @"[grid2x]mouse.rightclick_1";
            /// <summary>
            /// Represents the [grid2x]mouse.rightclick_2 symbol
            /// </summary>
            public const string mouse_rightclick_2 = @"[grid2x]mouse.rightclick_2";
            /// <summary>
            /// Represents the [grid2x]mouse.rightclick symbol
            /// </summary>
            public const string mouse_rightclick = @"[grid2x]mouse.rightclick";
            /// <summary>
            /// Represents the [grid2x]mouse.scan_1 symbol
            /// </summary>
            public const string mouse_scan_1 = @"[grid2x]mouse.scan_1";
            /// <summary>
            /// Represents the [grid2x]mouse.scan_2 symbol
            /// </summary>
            public const string mouse_scan_2 = @"[grid2x]mouse.scan_2";
            /// <summary>
            /// Represents the [grid2x]mouse.scan_3 symbol
            /// </summary>
            public const string mouse_scan_3 = @"[grid2x]mouse.scan_3";
            /// <summary>
            /// Represents the [grid2x]mouse.scan symbol
            /// </summary>
            public const string mouse_scan = @"[grid2x]mouse.scan";
            /// <summary>
            /// Represents the [grid2x]mouse symbol
            /// </summary>
            public const string mouse = @"[grid2x]mouse";
            /// <summary>
            /// Represents the [grid2x]mousedwell.longer symbol
            /// </summary>
            public const string mousedwell_longer = @"[grid2x]mousedwell.longer";
            /// <summary>
            /// Represents the [grid2x]mousedwell.shorter symbol
            /// </summary>
            public const string mousedwell_shorter = @"[grid2x]mousedwell.shorter";
            /// <summary>
            /// Represents the [grid2x]mousespeed.faster symbol
            /// </summary>
            public const string mousespeed_faster = @"[grid2x]mousespeed.faster";
            /// <summary>
            /// Represents the [grid2x]mousespeed.slower symbol
            /// </summary>
            public const string mousespeed_slower = @"[grid2x]mousespeed.slower";
            /// <summary>
            /// Represents the [grid2x]n symbol
            /// </summary>
            public const string n = @"[grid2x]n";
            /// <summary>
            /// Represents the [grid2x]n1 symbol
            /// </summary>
            public const string n1 = @"[grid2x]n1";
            /// <summary>
            /// Represents the [grid2x]nudge.start symbol
            /// </summary>
            public const string nudge_start = @"[grid2x]nudge.start";
            /// <summary>
            /// Represents the [grid2x]o symbol
            /// </summary>
            public const string o = @"[grid2x]o";
            /// <summary>
            /// Represents the [grid2x]o1 symbol
            /// </summary>
            public const string o1 = @"[grid2x]o1";
            /// <summary>
            /// Represents the [grid2x]osk.changewindow symbol
            /// </summary>
            public const string osk_changewindow = @"[grid2x]osk.changewindow";
            /// <summary>
            /// Represents the [grid2x]osk.closewindow symbol
            /// </summary>
            public const string osk_closewindow = @"[grid2x]osk.closewindow";
            /// <summary>
            /// Represents the [grid2x]osk.dock symbol
            /// </summary>
            public const string osk_dock = @"[grid2x]osk.dock";
            /// <summary>
            /// Represents the [grid2x]osk.hide_1 symbol
            /// </summary>
            public const string osk_hide_1 = @"[grid2x]osk.hide_1";
            /// <summary>
            /// Represents the [grid2x]osk.hide_2 symbol
            /// </summary>
            public const string osk_hide_2 = @"[grid2x]osk.hide_2";
            /// <summary>
            /// Represents the [grid2x]osk.hide_3 symbol
            /// </summary>
            public const string osk_hide_3 = @"[grid2x]osk.hide_3";
            /// <summary>
            /// Represents the [grid2x]osk.hide symbol
            /// </summary>
            public const string osk_hide = @"[grid2x]osk.hide";
            /// <summary>
            /// Represents the [grid2x]osk.maximise symbol
            /// </summary>
            public const string osk_maximise = @"[grid2x]osk.maximise";
            /// <summary>
            /// Represents the [grid2x]osk.minimise symbol
            /// </summary>
            public const string osk_minimise = @"[grid2x]osk.minimise";
            /// <summary>
            /// Represents the [grid2x]osk.nextwindow symbol
            /// </summary>
            public const string osk_nextwindow = @"[grid2x]osk.nextwindow";
            /// <summary>
            /// Represents the [grid2x]osk.previouswindow symbol
            /// </summary>
            public const string osk_previouswindow = @"[grid2x]osk.previouswindow";
            /// <summary>
            /// Represents the [grid2x]osk.restore symbol
            /// </summary>
            public const string osk_restore = @"[grid2x]osk.restore";
            /// <summary>
            /// Represents the [grid2x]osk.setfocus symbol
            /// </summary>
            public const string osk_setfocus = @"[grid2x]osk.setfocus";
            /// <summary>
            /// Represents the [grid2x]osk.unhide symbol
            /// </summary>
            public const string osk_unhide = @"[grid2x]osk.unhide";
            /// <summary>
            /// Represents the [grid2x]osk.windowmove_1 symbol
            /// </summary>
            public const string osk_windowmove_1 = @"[grid2x]osk.windowmove_1";
            /// <summary>
            /// Represents the [grid2x]osk.windowmove_2 symbol
            /// </summary>
            public const string osk_windowmove_2 = @"[grid2x]osk.windowmove_2";
            /// <summary>
            /// Represents the [grid2x]osk.windowmove_3 symbol
            /// </summary>
            public const string osk_windowmove_3 = @"[grid2x]osk.windowmove_3";
            /// <summary>
            /// Represents the [grid2x]osk.windowmove_4 symbol
            /// </summary>
            public const string osk_windowmove_4 = @"[grid2x]osk.windowmove_4";
            /// <summary>
            /// Represents the [grid2x]osk.windowmove symbol
            /// </summary>
            public const string osk_windowmove = @"[grid2x]osk.windowmove";
            /// <summary>
            /// Represents the [grid2x]osk.windowsize_1 symbol
            /// </summary>
            public const string osk_windowsize_1 = @"[grid2x]osk.windowsize_1";
            /// <summary>
            /// Represents the [grid2x]osk.windowsize_2 symbol
            /// </summary>
            public const string osk_windowsize_2 = @"[grid2x]osk.windowsize_2";
            /// <summary>
            /// Represents the [grid2x]osk.windowsize_3 symbol
            /// </summary>
            public const string osk_windowsize_3 = @"[grid2x]osk.windowsize_3";
            /// <summary>
            /// Represents the [grid2x]osk.windowsize_4 symbol
            /// </summary>
            public const string osk_windowsize_4 = @"[grid2x]osk.windowsize_4";
            /// <summary>
            /// Represents the [grid2x]osk.windowsize symbol
            /// </summary>
            public const string osk_windowsize = @"[grid2x]osk.windowsize";
            /// <summary>
            /// Represents the [grid2x]p symbol
            /// </summary>
            public const string p = @"[grid2x]p";
            /// <summary>
            /// Represents the [grid2x]p1 symbol
            /// </summary>
            public const string p1 = @"[grid2x]p1";
            /// <summary>
            /// Represents the [grid2x]padlock symbol
            /// </summary>
            public const string padlock = @"[grid2x]padlock";
            /// <summary>
            /// Represents the [grid2x]photos.next symbol
            /// </summary>
            public const string photos_next = @"[grid2x]photos.next";
            /// <summary>
            /// Represents the [grid2x]photos.previous symbol
            /// </summary>
            public const string photos_previous = @"[grid2x]photos.previous";
            /// <summary>
            /// Represents the [grid2x]photos.setfolder symbol
            /// </summary>
            public const string photos_setfolder = @"[grid2x]photos.setfolder";
            /// <summary>
            /// Represents the [grid2x]playnow symbol
            /// </summary>
            public const string playnow = @"[grid2x]playnow";
            /// <summary>
            /// Represents the [grid2x]postinfo symbol
            /// </summary>
            public const string postinfo = @"[grid2x]postinfo";
            /// <summary>
            /// Represents the [grid2x]preview_1 symbol
            /// </summary>
            public const string preview_1 = @"[grid2x]preview_1";
            /// <summary>
            /// Represents the [grid2x]preview symbol
            /// </summary>
            public const string preview = @"[grid2x]preview";
            /// <summary>
            /// Represents the [grid2x]primaryspeech_pitch.higher symbol
            /// </summary>
            public const string primaryspeech_pitch_higher = @"[grid2x]primaryspeech_pitch.higher";
            /// <summary>
            /// Represents the [grid2x]primaryspeech_pitch.lower symbol
            /// </summary>
            public const string primaryspeech_pitch_lower = @"[grid2x]primaryspeech_pitch.lower";
            /// <summary>
            /// Represents the [grid2x]primaryspeech_speed.faster symbol
            /// </summary>
            public const string primaryspeech_speed_faster = @"[grid2x]primaryspeech_speed.faster";
            /// <summary>
            /// Represents the [grid2x]primaryspeech_speed.slower symbol
            /// </summary>
            public const string primaryspeech_speed_slower = @"[grid2x]primaryspeech_speed.slower";
            /// <summary>
            /// Represents the [grid2x]primaryspeech_voice symbol
            /// </summary>
            public const string primaryspeech_voice = @"[grid2x]primaryspeech_voice";
            /// <summary>
            /// Represents the [grid2x]q symbol
            /// </summary>
            public const string q = @"[grid2x]q";
            /// <summary>
            /// Represents the [grid2x]q1 symbol
            /// </summary>
            public const string q1 = @"[grid2x]q1";
            /// <summary>
            /// Represents the [grid2x]r symbol
            /// </summary>
            public const string r = @"[grid2x]r";
            /// <summary>
            /// Represents the [grid2x]r1 symbol
            /// </summary>
            public const string r1 = @"[grid2x]r1";
            /// <summary>
            /// Represents the [grid2x]record symbol
            /// </summary>
            public const string record = @"[grid2x]record";
            /// <summary>
            /// Represents the [grid2x]remote control symbol
            /// </summary>
            public const string remote_control = @"[grid2x]remote control";
            /// <summary>
            /// Represents the [grid2x]run.extension symbol
            /// </summary>
            public const string run_extension = @"[grid2x]run.extension";
            /// <summary>
            /// Represents the [grid2x]run symbol
            /// </summary>
            public const string run = @"[grid2x]run";
            /// <summary>
            /// Represents the [grid2x]s symbol
            /// </summary>
            public const string s = @"[grid2x]s";
            /// <summary>
            /// Represents the [grid2x]s1 symbol
            /// </summary>
            public const string s1 = @"[grid2x]s1";
            /// <summary>
            /// Represents the [grid2x]scanspeed.faster symbol
            /// </summary>
            public const string scanspeed_faster = @"[grid2x]scanspeed.faster";
            /// <summary>
            /// Represents the [grid2x]scanspeed.slower symbol
            /// </summary>
            public const string scanspeed_slower = @"[grid2x]scanspeed.slower";
            /// <summary>
            /// Represents the [grid2x]score_add symbol
            /// </summary>
            public const string score_add = @"[grid2x]score_add";
            /// <summary>
            /// Represents the [grid2x]score_compare.start symbol
            /// </summary>
            public const string score_compare_start = @"[grid2x]score_compare.start";
            /// <summary>
            /// Represents the [grid2x]score_date symbol
            /// </summary>
            public const string score_date = @"[grid2x]score_date";
            /// <summary>
            /// Represents the [grid2x]score_equals symbol
            /// </summary>
            public const string score_equals = @"[grid2x]score_equals";
            /// <summary>
            /// Represents the [grid2x]score_if.start symbol
            /// </summary>
            public const string score_if_start = @"[grid2x]score_if.start";
            /// <summary>
            /// Represents the [grid2x]score_random symbol
            /// </summary>
            public const string score_random = @"[grid2x]score_random";
            /// <summary>
            /// Represents the [grid2x]secondaryspeech_pitch.higher symbol
            /// </summary>
            public const string secondaryspeech_pitch_higher = @"[grid2x]secondaryspeech_pitch.higher";
            /// <summary>
            /// Represents the [grid2x]secondaryspeech_pitch.lower symbol
            /// </summary>
            public const string secondaryspeech_pitch_lower = @"[grid2x]secondaryspeech_pitch.lower";
            /// <summary>
            /// Represents the [grid2x]secondaryspeech_speed.faster symbol
            /// </summary>
            public const string secondaryspeech_speed_faster = @"[grid2x]secondaryspeech_speed.faster";
            /// <summary>
            /// Represents the [grid2x]secondaryspeech_speed.slower symbol
            /// </summary>
            public const string secondaryspeech_speed_slower = @"[grid2x]secondaryspeech_speed.slower";
            /// <summary>
            /// Represents the [grid2x]secondaryspeech_voice symbol
            /// </summary>
            public const string secondaryspeech_voice = @"[grid2x]secondaryspeech_voice";
            /// <summary>
            /// Represents the [grid2x]shutdown.logoff symbol
            /// </summary>
            public const string shutdown_logoff = @"[grid2x]shutdown.logoff";
            /// <summary>
            /// Represents the [grid2x]shutdown.restart symbol
            /// </summary>
            public const string shutdown_restart = @"[grid2x]shutdown.restart";
            /// <summary>
            /// Represents the [grid2x]shutdown.shutdown symbol
            /// </summary>
            public const string shutdown_shutdown = @"[grid2x]shutdown.shutdown";
            /// <summary>
            /// Represents the [grid2x]shutdown.standby symbol
            /// </summary>
            public const string shutdown_standby = @"[grid2x]shutdown.standby";
            /// <summary>
            /// Represents the [grid2x]skype_call symbol
            /// </summary>
            public const string skype_call = @"[grid2x]skype_call";
            /// <summary>
            /// Represents the [grid2x]skype_down symbol
            /// </summary>
            public const string skype_down = @"[grid2x]skype_down";
            /// <summary>
            /// Represents the [grid2x]skype_hangup symbol
            /// </summary>
            public const string skype_hangup = @"[grid2x]skype_hangup";
            /// <summary>
            /// Represents the [grid2x]skype_open symbol
            /// </summary>
            public const string skype_open = @"[grid2x]skype_open";
            /// <summary>
            /// Represents the [grid2x]skype_send symbol
            /// </summary>
            public const string skype_send = @"[grid2x]skype_send";
            /// <summary>
            /// Represents the [grid2x]skype_showlist symbol
            /// </summary>
            public const string skype_showlist = @"[grid2x]skype_showlist";
            /// <summary>
            /// Represents the [grid2x]skype_up symbol
            /// </summary>
            public const string skype_up = @"[grid2x]skype_up";
            /// <summary>
            /// Represents the [grid2x]sms.atcommand symbol
            /// </summary>
            public const string sms_atcommand = @"[grid2x]sms.atcommand";
            /// <summary>
            /// Represents the [grid2x]sms.call symbol
            /// </summary>
            public const string sms_call = @"[grid2x]sms.call";
            /// <summary>
            /// Represents the [grid2x]sms.connect symbol
            /// </summary>
            public const string sms_connect = @"[grid2x]sms.connect";
            /// <summary>
            /// Represents the [grid2x]sms.delete symbol
            /// </summary>
            public const string sms_delete = @"[grid2x]sms.delete";
            /// <summary>
            /// Represents the [grid2x]sms.disconnect symbol
            /// </summary>
            public const string sms_disconnect = @"[grid2x]sms.disconnect";
            /// <summary>
            /// Represents the [grid2x]sms.down symbol
            /// </summary>
            public const string sms_down = @"[grid2x]sms.down";
            /// <summary>
            /// Represents the [grid2x]sms.dtmf symbol
            /// </summary>
            public const string sms_dtmf = @"[grid2x]sms.dtmf";
            /// <summary>
            /// Represents the [grid2x]sms.hangup symbol
            /// </summary>
            public const string sms_hangup = @"[grid2x]sms.hangup";
            /// <summary>
            /// Represents the [grid2x]sms.new_1 symbol
            /// </summary>
            public const string sms_new_1 = @"[grid2x]sms.new_1";
            /// <summary>
            /// Represents the [grid2x]sms.new symbol
            /// </summary>
            public const string sms_new = @"[grid2x]sms.new";
            /// <summary>
            /// Represents the [grid2x]sms.number symbol
            /// </summary>
            public const string sms_number = @"[grid2x]sms.number";
            /// <summary>
            /// Represents the [grid2x]sms.open symbol
            /// </summary>
            public const string sms_open = @"[grid2x]sms.open";
            /// <summary>
            /// Represents the [grid2x]sms.reply symbol
            /// </summary>
            public const string sms_reply = @"[grid2x]sms.reply";
            /// <summary>
            /// Represents the [grid2x]sms.send symbol
            /// </summary>
            public const string sms_send = @"[grid2x]sms.send";
            /// <summary>
            /// Represents the [grid2x]sms.showlist symbol
            /// </summary>
            public const string sms_showlist = @"[grid2x]sms.showlist";
            /// <summary>
            /// Represents the [grid2x]sms.up symbol
            /// </summary>
            public const string sms_up = @"[grid2x]sms.up";
            /// <summary>
            /// Represents the [grid2x]speaknow symbol
            /// </summary>
            public const string speaknow = @"[grid2x]speaknow";
            /// <summary>
            /// Represents the [grid2x]symbolchat.delete symbol
            /// </summary>
            public const string symbolchat_delete = @"[grid2x]symbolchat.delete";
            /// <summary>
            /// Represents the [grid2x]symbolchat.down symbol
            /// </summary>
            public const string symbolchat_down = @"[grid2x]symbolchat.down";
            /// <summary>
            /// Represents the [grid2x]symbolchat.new_1 symbol
            /// </summary>
            public const string symbolchat_new_1 = @"[grid2x]symbolchat.new_1";
            /// <summary>
            /// Represents the [grid2x]symbolchat.new symbol
            /// </summary>
            public const string symbolchat_new = @"[grid2x]symbolchat.new";
            /// <summary>
            /// Represents the [grid2x]symbolchat.open symbol
            /// </summary>
            public const string symbolchat_open = @"[grid2x]symbolchat.open";
            /// <summary>
            /// Represents the [grid2x]symbolchat.save symbol
            /// </summary>
            public const string symbolchat_save = @"[grid2x]symbolchat.save";
            /// <summary>
            /// Represents the [grid2x]symbolchat.showlist symbol
            /// </summary>
            public const string symbolchat_showlist = @"[grid2x]symbolchat.showlist";
            /// <summary>
            /// Represents the [grid2x]symbolchat.up symbol
            /// </summary>
            public const string symbolchat_up = @"[grid2x]symbolchat.up";
            /// <summary>
            /// Represents the [grid2x]t symbol
            /// </summary>
            public const string t = @"[grid2x]t";
            /// <summary>
            /// Represents the [grid2x]t1 symbol
            /// </summary>
            public const string t1 = @"[grid2x]t1";
            /// <summary>
            /// Represents the [grid2x]text.aligncentre symbol
            /// </summary>
            public const string text_aligncentre = @"[grid2x]text.aligncentre";
            /// <summary>
            /// Represents the [grid2x]text.alignleft symbol
            /// </summary>
            public const string text_alignleft = @"[grid2x]text.alignleft";
            /// <summary>
            /// Represents the [grid2x]text.alignright symbol
            /// </summary>
            public const string text_alignright = @"[grid2x]text.alignright";
            /// <summary>
            /// Represents the [grid2x]text.bold symbol
            /// </summary>
            public const string text_bold = @"[grid2x]text.bold";
            /// <summary>
            /// Represents the [grid2x]text.delete symbol
            /// </summary>
            public const string text_delete = @"[grid2x]text.delete";
            /// <summary>
            /// Represents the [grid2x]text.down symbol
            /// </summary>
            public const string text_down = @"[grid2x]text.down";
            /// <summary>
            /// Represents the [grid2x]text.italic symbol
            /// </summary>
            public const string text_italic = @"[grid2x]text.italic";
            /// <summary>
            /// Represents the [grid2x]text.new_1 symbol
            /// </summary>
            public const string text_new_1 = @"[grid2x]text.new_1";
            /// <summary>
            /// Represents the [grid2x]text.new symbol
            /// </summary>
            public const string text_new = @"[grid2x]text.new";
            /// <summary>
            /// Represents the [grid2x]text.open symbol
            /// </summary>
            public const string text_open = @"[grid2x]text.open";
            /// <summary>
            /// Represents the [grid2x]text.save symbol
            /// </summary>
            public const string text_save = @"[grid2x]text.save";
            /// <summary>
            /// Represents the [grid2x]text.showlist symbol
            /// </summary>
            public const string text_showlist = @"[grid2x]text.showlist";
            /// <summary>
            /// Represents the [grid2x]text.size symbol
            /// </summary>
            public const string text_size = @"[grid2x]text.size";
            /// <summary>
            /// Represents the [grid2x]text.underline symbol
            /// </summary>
            public const string text_underline = @"[grid2x]text.underline";
            /// <summary>
            /// Represents the [grid2x]text.up symbol
            /// </summary>
            public const string text_up = @"[grid2x]text.up";
            /// <summary>
            /// Represents the [grid2x]tv blue button symbol
            /// </summary>
            public const string tv_blue_button = @"[grid2x]tv blue button";
            /// <summary>
            /// Represents the [grid2x]tv green button symbol
            /// </summary>
            public const string tv_green_button = @"[grid2x]tv green button";
            /// <summary>
            /// Represents the [grid2x]tv red button symbol
            /// </summary>
            public const string tv_red_button = @"[grid2x]tv red button";
            /// <summary>
            /// Represents the [grid2x]tv yellow button symbol
            /// </summary>
            public const string tv_yellow_button = @"[grid2x]tv yellow button";
            /// <summary>
            /// Represents the [grid2x]type.addword symbol
            /// </summary>
            public const string type_addword = @"[grid2x]type.addword";
            /// <summary>
            /// Represents the [grid2x]type.alt symbol
            /// </summary>
            public const string type_alt = @"[grid2x]type.alt";
            /// <summary>
            /// Represents the [grid2x]type.capslock symbol
            /// </summary>
            public const string type_capslock = @"[grid2x]type.capslock";
            /// <summary>
            /// Represents the [grid2x]type.clearshift symbol
            /// </summary>
            public const string type_clearshift = @"[grid2x]type.clearshift";
            /// <summary>
            /// Represents the [grid2x]type.conjugate symbol
            /// </summary>
            public const string type_conjugate = @"[grid2x]type.conjugate";
            /// <summary>
            /// Represents the [grid2x]type.conjugatenow_1 symbol
            /// </summary>
            public const string type_conjugatenow_1 = @"[grid2x]type.conjugatenow_1";
            /// <summary>
            /// Represents the [grid2x]type.conjugatenow_2 symbol
            /// </summary>
            public const string type_conjugatenow_2 = @"[grid2x]type.conjugatenow_2";
            /// <summary>
            /// Represents the [grid2x]type.conjugatenow_3 symbol
            /// </summary>
            public const string type_conjugatenow_3 = @"[grid2x]type.conjugatenow_3";
            /// <summary>
            /// Represents the [grid2x]type.conjugatenow_4 symbol
            /// </summary>
            public const string type_conjugatenow_4 = @"[grid2x]type.conjugatenow_4";
            /// <summary>
            /// Represents the [grid2x]type.conjugatenow_5 symbol
            /// </summary>
            public const string type_conjugatenow_5 = @"[grid2x]type.conjugatenow_5";
            /// <summary>
            /// Represents the [grid2x]type.conjugatenow_6 symbol
            /// </summary>
            public const string type_conjugatenow_6 = @"[grid2x]type.conjugatenow_6";
            /// <summary>
            /// Represents the [grid2x]type.conjugatenow symbol
            /// </summary>
            public const string type_conjugatenow = @"[grid2x]type.conjugatenow";
            /// <summary>
            /// Represents the [grid2x]type.ctrl symbol
            /// </summary>
            public const string type_ctrl = @"[grid2x]type.ctrl";
            /// <summary>
            /// Represents the [grid2x]type.deleteword_1 symbol
            /// </summary>
            public const string type_deleteword_1 = @"[grid2x]type.deleteword_1";
            /// <summary>
            /// Represents the [grid2x]type.deleteword symbol
            /// </summary>
            public const string type_deleteword = @"[grid2x]type.deleteword";
            /// <summary>
            /// Represents the [grid2x]type.keydown symbol
            /// </summary>
            public const string type_keydown = @"[grid2x]type.keydown";
            /// <summary>
            /// Represents the [grid2x]type.keypress symbol
            /// </summary>
            public const string type_keypress = @"[grid2x]type.keypress";
            /// <summary>
            /// Represents the [grid2x]type.keyup symbol
            /// </summary>
            public const string type_keyup = @"[grid2x]type.keyup";
            /// <summary>
            /// Represents the [grid2x]type.predictfuzzy symbol
            /// </summary>
            public const string type_predictfuzzy = @"[grid2x]type.predictfuzzy";
            /// <summary>
            /// Represents the [grid2x]type.predictspelling symbol
            /// </summary>
            public const string type_predictspelling = @"[grid2x]type.predictspelling";
            /// <summary>
            /// Represents the [grid2x]type.predictthis symbol
            /// </summary>
            public const string type_predictthis = @"[grid2x]type.predictthis";
            /// <summary>
            /// Represents the [grid2x]type.predictthis2 symbol
            /// </summary>
            public const string type_predictthis2 = @"[grid2x]type.predictthis2";
            /// <summary>
            /// Represents the [grid2x]type.random symbol
            /// </summary>
            public const string type_random = @"[grid2x]type.random";
            /// <summary>
            /// Represents the [grid2x]type.removeword symbol
            /// </summary>
            public const string type_removeword = @"[grid2x]type.removeword";
            /// <summary>
            /// Represents the [grid2x]type.shift_1 symbol
            /// </summary>
            public const string type_shift_1 = @"[grid2x]type.shift_1";
            /// <summary>
            /// Represents the [grid2x]type.shift symbol
            /// </summary>
            public const string type_shift = @"[grid2x]type.shift";
            /// <summary>
            /// Represents the [grid2x]type.shiftlock_1 symbol
            /// </summary>
            public const string type_shiftlock_1 = @"[grid2x]type.shiftlock_1";
            /// <summary>
            /// Represents the [grid2x]type.shiftlock symbol
            /// </summary>
            public const string type_shiftlock = @"[grid2x]type.shiftlock";
            /// <summary>
            /// Represents the [grid2x]type.unicodekeydown symbol
            /// </summary>
            public const string type_unicodekeydown = @"[grid2x]type.unicodekeydown";
            /// <summary>
            /// Represents the [grid2x]type.unicodekeypress symbol
            /// </summary>
            public const string type_unicodekeypress = @"[grid2x]type.unicodekeypress";
            /// <summary>
            /// Represents the [grid2x]type.unicodekeyup symbol
            /// </summary>
            public const string type_unicodekeyup = @"[grid2x]type.unicodekeyup";
            /// <summary>
            /// Represents the [grid2x]type symbol
            /// </summary>
            public const string type = @"[grid2x]type";
            /// <summary>
            /// Represents the [grid2x]type.wordlist symbol
            /// </summary>
            public const string type_wordlist = @"[grid2x]type.wordlist";
            /// <summary>
            /// Represents the [grid2x]u symbol
            /// </summary>
            public const string u = @"[grid2x]u";
            /// <summary>
            /// Represents the [grid2x]u1 symbol
            /// </summary>
            public const string u1 = @"[grid2x]u1";
            /// <summary>
            /// Represents the [grid2x]unknown symbol
            /// </summary>
            public const string unknown = @"[grid2x]unknown";
            /// <summary>
            /// Represents the [grid2x]v symbol
            /// </summary>
            public const string v = @"[grid2x]v";
            /// <summary>
            /// Represents the [grid2x]v1 symbol
            /// </summary>
            public const string v1 = @"[grid2x]v1";
            /// <summary>
            /// Represents the [grid2x]verb0 symbol
            /// </summary>
            public const string verb0 = @"[grid2x]verb0";
            /// <summary>
            /// Represents the [grid2x]verb1 symbol
            /// </summary>
            public const string verb1 = @"[grid2x]verb1";
            /// <summary>
            /// Represents the [grid2x]verb2 symbol
            /// </summary>
            public const string verb2 = @"[grid2x]verb2";
            /// <summary>
            /// Represents the [grid2x]verb3 symbol
            /// </summary>
            public const string verb3 = @"[grid2x]verb3";
            /// <summary>
            /// Represents the [grid2x]verb4 symbol
            /// </summary>
            public const string verb4 = @"[grid2x]verb4";
            /// <summary>
            /// Represents the [grid2x]verb5 symbol
            /// </summary>
            public const string verb5 = @"[grid2x]verb5";
            /// <summary>
            /// Represents the [grid2x]verb6 symbol
            /// </summary>
            public const string verb6 = @"[grid2x]verb6";
            /// <summary>
            /// Represents the [grid2x]w symbol
            /// </summary>
            public const string w = @"[grid2x]w";
            /// <summary>
            /// Represents the [grid2x]w1 symbol
            /// </summary>
            public const string w1 = @"[grid2x]w1";
            /// <summary>
            /// Represents the [grid2x]wait message symbol
            /// </summary>
            public const string wait_message = @"[grid2x]wait message";
            /// <summary>
            /// Represents the [grid2x]wait symbol
            /// </summary>
            public const string wait = @"[grid2x]wait";
            /// <summary>
            /// Represents the [grid2x]warning message symbol
            /// </summary>
            public const string warning_message = @"[grid2x]warning message";
            /// <summary>
            /// Represents the [grid2x]webcam.snapshot symbol
            /// </summary>
            public const string webcam_snapshot = @"[grid2x]webcam.snapshot";
            /// <summary>
            /// Represents the [grid2x]windows key symbol
            /// </summary>
            public const string windows_key = @"[grid2x]windows key";
            /// <summary>
            /// Represents the [grid2x]windowsdwell.longer symbol
            /// </summary>
            public const string windowsdwell_longer = @"[grid2x]windowsdwell.longer";
            /// <summary>
            /// Represents the [grid2x]windowsdwell.shorter symbol
            /// </summary>
            public const string windowsdwell_shorter = @"[grid2x]windowsdwell.shorter";
            /// <summary>
            /// Represents the [grid2x]word documents symbol
            /// </summary>
            public const string word_documents = @"[grid2x]word documents";
            /// <summary>
            /// Represents the [grid2x]word format symbol
            /// </summary>
            public const string word_format = @"[grid2x]word format";
            /// <summary>
            /// Represents the [grid2x]word keyboard symbol
            /// </summary>
            public const string word_keyboard = @"[grid2x]word keyboard";
            /// <summary>
            /// Represents the [grid2x]word spelling symbol
            /// </summary>
            public const string word_spelling = @"[grid2x]word spelling";
            /// <summary>
            /// Represents the [grid2x]workspace_calculator symbol
            /// </summary>
            public const string workspace_calculator = @"[grid2x]workspace_calculator";
            /// <summary>
            /// Represents the [grid2x]workspace_calendar symbol
            /// </summary>
            public const string workspace_calendar = @"[grid2x]workspace_calendar";
            /// <summary>
            /// Represents the [grid2x]workspace_chat symbol
            /// </summary>
            public const string workspace_chat = @"[grid2x]workspace_chat";
            /// <summary>
            /// Represents the [grid2x]workspace_clock symbol
            /// </summary>
            public const string workspace_clock = @"[grid2x]workspace_clock";
            /// <summary>
            /// Represents the [grid2x]workspace_contacts symbol
            /// </summary>
            public const string workspace_contacts = @"[grid2x]workspace_contacts";
            /// <summary>
            /// Represents the [grid2x]workspace_default symbol
            /// </summary>
            public const string workspace_default = @"[grid2x]workspace_default";
            /// <summary>
            /// Represents the [grid2x]workspace_dvd symbol
            /// </summary>
            public const string workspace_dvd = @"[grid2x]workspace_dvd";
            /// <summary>
            /// Represents the [grid2x]workspace_email symbol
            /// </summary>
            public const string workspace_email = @"[grid2x]workspace_email";
            /// <summary>
            /// Represents the [grid2x]workspace_environmentcontrol symbol
            /// </summary>
            public const string workspace_environmentcontrol = @"[grid2x]workspace_environmentcontrol";
            /// <summary>
            /// Represents the [grid2x]workspace_music symbol
            /// </summary>
            public const string workspace_music = @"[grid2x]workspace_music";
            /// <summary>
            /// Represents the [grid2x]workspace_osk symbol
            /// </summary>
            public const string workspace_osk = @"[grid2x]workspace_osk";
            /// <summary>
            /// Represents the [grid2x]workspace_photos symbol
            /// </summary>
            public const string workspace_photos = @"[grid2x]workspace_photos";
            /// <summary>
            /// Represents the [grid2x]workspace_programcontrol symbol
            /// </summary>
            public const string workspace_programcontrol = @"[grid2x]workspace_programcontrol";
            /// <summary>
            /// Represents the [grid2x]workspace_settings symbol
            /// </summary>
            public const string workspace_settings = @"[grid2x]workspace_settings";
            /// <summary>
            /// Represents the [grid2x]workspace_skype symbol
            /// </summary>
            public const string workspace_skype = @"[grid2x]workspace_skype";
            /// <summary>
            /// Represents the [grid2x]workspace_sms symbol
            /// </summary>
            public const string workspace_sms = @"[grid2x]workspace_sms";
            /// <summary>
            /// Represents the [grid2x]workspace_symbolgrid symbol
            /// </summary>
            public const string workspace_symbolgrid = @"[grid2x]workspace_symbolgrid";
            /// <summary>
            /// Represents the [grid2x]workspace_symbolwriter symbol
            /// </summary>
            public const string workspace_symbolwriter = @"[grid2x]workspace_symbolwriter";
            /// <summary>
            /// Represents the [grid2x]workspace_text symbol
            /// </summary>
            public const string workspace_text = @"[grid2x]workspace_text";
            /// <summary>
            /// Represents the [grid2x]workspace_web symbol
            /// </summary>
            public const string workspace_web = @"[grid2x]workspace_web";
            /// <summary>
            /// Represents the [grid2x]workspace_webcam symbol
            /// </summary>
            public const string workspace_webcam = @"[grid2x]workspace_webcam";
            /// <summary>
            /// Represents the [grid2x]workspace_wordprocessor symbol
            /// </summary>
            public const string workspace_wordprocessor = @"[grid2x]workspace_wordprocessor";
            /// <summary>
            /// Represents the [grid2x]x symbol
            /// </summary>
            public const string x = @"[grid2x]x";
            /// <summary>
            /// Represents the [grid2x]x1 symbol
            /// </summary>
            public const string x1 = @"[grid2x]x1";
            /// <summary>
            /// Represents the [grid2x]y symbol
            /// </summary>
            public const string y = @"[grid2x]y";
            /// <summary>
            /// Represents the [grid2x]y1 symbol
            /// </summary>
            public const string y1 = @"[grid2x]y1";
            /// <summary>
            /// Represents the [grid2x]z symbol
            /// </summary>
            public const string z = @"[grid2x]z";
            /// <summary>
            /// Represents the [grid2x]z1 symbol
            /// </summary>
            public const string z1 = @"[grid2x]z1";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_down symbol
            /// </summary>
            public const string environment_control_bed_down = @"[grid2x]environment control\bed_down";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_feet_down symbol
            /// </summary>
            public const string environment_control_bed_feet_down = @"[grid2x]environment control\bed_feet_down";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_feet_up symbol
            /// </summary>
            public const string environment_control_bed_feet_up = @"[grid2x]environment control\bed_feet_up";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_head_down symbol
            /// </summary>
            public const string environment_control_bed_head_down = @"[grid2x]environment control\bed_head_down";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_head_up symbol
            /// </summary>
            public const string environment_control_bed_head_up = @"[grid2x]environment control\bed_head_up";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_knees_down symbol
            /// </summary>
            public const string environment_control_bed_knees_down = @"[grid2x]environment control\bed_knees_down";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_knees_up symbol
            /// </summary>
            public const string environment_control_bed_knees_up = @"[grid2x]environment control\bed_knees_up";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_tilt_down symbol
            /// </summary>
            public const string environment_control_bed_tilt_down = @"[grid2x]environment control\bed_tilt_down";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_tilt_up symbol
            /// </summary>
            public const string environment_control_bed_tilt_up = @"[grid2x]environment control\bed_tilt_up";
            /// <summary>
            /// Represents the [grid2x]environment control\bed_up symbol
            /// </summary>
            public const string environment_control_bed_up = @"[grid2x]environment control\bed_up";
            /// <summary>
            /// Represents the [grid2x]environment control\bed symbol
            /// </summary>
            public const string environment_control_bed = @"[grid2x]environment control\bed";
            /// <summary>
            /// Represents the [grid2x]environment control\cassette symbol
            /// </summary>
            public const string environment_control_cassette = @"[grid2x]environment control\cassette";
            /// <summary>
            /// Represents the [grid2x]environment control\cd symbol
            /// </summary>
            public const string environment_control_cd = @"[grid2x]environment control\cd";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_down symbol
            /// </summary>
            public const string environment_control_chair_down = @"[grid2x]environment control\chair_down";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_feet_down symbol
            /// </summary>
            public const string environment_control_chair_feet_down = @"[grid2x]environment control\chair_feet_down";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_feet_up symbol
            /// </summary>
            public const string environment_control_chair_feet_up = @"[grid2x]environment control\chair_feet_up";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_head_down symbol
            /// </summary>
            public const string environment_control_chair_head_down = @"[grid2x]environment control\chair_head_down";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_head_up symbol
            /// </summary>
            public const string environment_control_chair_head_up = @"[grid2x]environment control\chair_head_up";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_knees_down symbol
            /// </summary>
            public const string environment_control_chair_knees_down = @"[grid2x]environment control\chair_knees_down";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_knees_up symbol
            /// </summary>
            public const string environment_control_chair_knees_up = @"[grid2x]environment control\chair_knees_up";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_tilt_down symbol
            /// </summary>
            public const string environment_control_chair_tilt_down = @"[grid2x]environment control\chair_tilt_down";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_tilt_up symbol
            /// </summary>
            public const string environment_control_chair_tilt_up = @"[grid2x]environment control\chair_tilt_up";
            /// <summary>
            /// Represents the [grid2x]environment control\chair_up symbol
            /// </summary>
            public const string environment_control_chair_up = @"[grid2x]environment control\chair_up";
            /// <summary>
            /// Represents the [grid2x]environment control\chair symbol
            /// </summary>
            public const string environment_control_chair = @"[grid2x]environment control\chair";
            /// <summary>
            /// Represents the [grid2x]environment control\contact symbol
            /// </summary>
            public const string environment_control_contact = @"[grid2x]environment control\contact";
            /// <summary>
            /// Represents the [grid2x]environment control\curtains closed symbol
            /// </summary>
            public const string environment_control_curtains_closed = @"[grid2x]environment control\curtains closed";
            /// <summary>
            /// Represents the [grid2x]environment control\curtains open symbol
            /// </summary>
            public const string environment_control_curtains_open = @"[grid2x]environment control\curtains open";
            /// <summary>
            /// Represents the [grid2x]environment control\curtains symbol
            /// </summary>
            public const string environment_control_curtains = @"[grid2x]environment control\curtains";
            /// <summary>
            /// Represents the [grid2x]environment control\door symbol
            /// </summary>
            public const string environment_control_door = @"[grid2x]environment control\door";
            /// <summary>
            /// Represents the [grid2x]environment control\fan symbol
            /// </summary>
            public const string environment_control_fan = @"[grid2x]environment control\fan";
            /// <summary>
            /// Represents the [grid2x]environment control\keypad symbol
            /// </summary>
            public const string environment_control_keypad = @"[grid2x]environment control\keypad";
            /// <summary>
            /// Represents the [grid2x]environment control\lamp symbol
            /// </summary>
            public const string environment_control_lamp = @"[grid2x]environment control\lamp";
            /// <summary>
            /// Represents the [grid2x]environment control\light_bulb symbol
            /// </summary>
            public const string environment_control_light_bulb = @"[grid2x]environment control\light_bulb";
            /// <summary>
            /// Represents the [grid2x]environment control\music symbol
            /// </summary>
            public const string environment_control_music = @"[grid2x]environment control\music";
            /// <summary>
            /// Represents the [grid2x]environment control\phone symbol
            /// </summary>
            public const string environment_control_phone = @"[grid2x]environment control\phone";
            /// <summary>
            /// Represents the [grid2x]environment control\phone2 symbol
            /// </summary>
            public const string environment_control_phone2 = @"[grid2x]environment control\phone2";
            /// <summary>
            /// Represents the [grid2x]environment control\radio symbol
            /// </summary>
            public const string environment_control_radio = @"[grid2x]environment control\radio";
            /// <summary>
            /// Represents the [grid2x]environment control\satellite symbol
            /// </summary>
            public const string environment_control_satellite = @"[grid2x]environment control\satellite";
            /// <summary>
            /// Represents the [grid2x]environment control\satellite2 symbol
            /// </summary>
            public const string environment_control_satellite2 = @"[grid2x]environment control\satellite2";
            /// <summary>
            /// Represents the [grid2x]environment control\stereo symbol
            /// </summary>
            public const string environment_control_stereo = @"[grid2x]environment control\stereo";
            /// <summary>
            /// Represents the [grid2x]environment control\tv_box symbol
            /// </summary>
            public const string environment_control_tv_box = @"[grid2x]environment control\tv_box";
            /// <summary>
            /// Represents the [grid2x]environment control\tv symbol
            /// </summary>
            public const string environment_control_tv = @"[grid2x]environment control\tv";
            /// <summary>
            /// Represents the [grid2x]environment control\window_blind_down symbol
            /// </summary>
            public const string environment_control_window_blind_down = @"[grid2x]environment control\window_blind_down";
            /// <summary>
            /// Represents the [grid2x]environment control\window_blind_up symbol
            /// </summary>
            public const string environment_control_window_blind_up = @"[grid2x]environment control\window_blind_up";
            /// <summary>
            /// Represents the [grid2x]environment control\window_open symbol
            /// </summary>
            public const string environment_control_window_open = @"[grid2x]environment control\window_open";
            /// <summary>
            /// Represents the [grid2x]environment control\window symbol
            /// </summary>
            public const string environment_control_window = @"[grid2x]environment control\window";
            /// <summary>
            /// Represents the [grid2x]metro\add symbol
            /// </summary>
            public const string metro_add = @"[grid2x]metro\add";
            /// <summary>
            /// Represents the [grid2x]metro\alarm symbol
            /// </summary>
            public const string metro_alarm = @"[grid2x]metro\alarm";
            /// <summary>
            /// Represents the [grid2x]metro\apps symbol
            /// </summary>
            public const string metro_apps = @"[grid2x]metro\apps";
            /// <summary>
            /// Represents the [grid2x]metro\arrows symbol
            /// </summary>
            public const string metro_arrows = @"[grid2x]metro\arrows";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_anticlockwise symbol
            /// </summary>
            public const string metro_arrow_anticlockwise = @"[grid2x]metro\arrow_anticlockwise";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_clockwise symbol
            /// </summary>
            public const string metro_arrow_clockwise = @"[grid2x]metro\arrow_clockwise";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_down symbol
            /// </summary>
            public const string metro_arrow_down = @"[grid2x]metro\arrow_down";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_down_left symbol
            /// </summary>
            public const string metro_arrow_down_left = @"[grid2x]metro\arrow_down_left";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_down_right symbol
            /// </summary>
            public const string metro_arrow_down_right = @"[grid2x]metro\arrow_down_right";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_left symbol
            /// </summary>
            public const string metro_arrow_left = @"[grid2x]metro\arrow_left";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_right symbol
            /// </summary>
            public const string metro_arrow_right = @"[grid2x]metro\arrow_right";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_up symbol
            /// </summary>
            public const string metro_arrow_up = @"[grid2x]metro\arrow_up";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_up_left symbol
            /// </summary>
            public const string metro_arrow_up_left = @"[grid2x]metro\arrow_up_left";
            /// <summary>
            /// Represents the [grid2x]metro\arrow_up_right symbol
            /// </summary>
            public const string metro_arrow_up_right = @"[grid2x]metro\arrow_up_right";
            /// <summary>
            /// Represents the [grid2x]metro\autocells_next symbol
            /// </summary>
            public const string metro_autocells_next = @"[grid2x]metro\autocells_next";
            /// <summary>
            /// Represents the [grid2x]metro\autocells_previous symbol
            /// </summary>
            public const string metro_autocells_previous = @"[grid2x]metro\autocells_previous";
            /// <summary>
            /// Represents the [grid2x]metro\back symbol
            /// </summary>
            public const string metro_back = @"[grid2x]metro\back";
            /// <summary>
            /// Represents the [grid2x]metro\bed_down symbol
            /// </summary>
            public const string metro_bed_down = @"[grid2x]metro\bed_down";
            /// <summary>
            /// Represents the [grid2x]metro\bed_feet_down symbol
            /// </summary>
            public const string metro_bed_feet_down = @"[grid2x]metro\bed_feet_down";
            /// <summary>
            /// Represents the [grid2x]metro\bed_feet_up symbol
            /// </summary>
            public const string metro_bed_feet_up = @"[grid2x]metro\bed_feet_up";
            /// <summary>
            /// Represents the [grid2x]metro\bed_head_down symbol
            /// </summary>
            public const string metro_bed_head_down = @"[grid2x]metro\bed_head_down";
            /// <summary>
            /// Represents the [grid2x]metro\bed_head_up symbol
            /// </summary>
            public const string metro_bed_head_up = @"[grid2x]metro\bed_head_up";
            /// <summary>
            /// Represents the [grid2x]metro\bed_knees_down symbol
            /// </summary>
            public const string metro_bed_knees_down = @"[grid2x]metro\bed_knees_down";
            /// <summary>
            /// Represents the [grid2x]metro\bed_knees_up symbol
            /// </summary>
            public const string metro_bed_knees_up = @"[grid2x]metro\bed_knees_up";
            /// <summary>
            /// Represents the [grid2x]metro\bed_tilt_down symbol
            /// </summary>
            public const string metro_bed_tilt_down = @"[grid2x]metro\bed_tilt_down";
            /// <summary>
            /// Represents the [grid2x]metro\bed_tilt_up symbol
            /// </summary>
            public const string metro_bed_tilt_up = @"[grid2x]metro\bed_tilt_up";
            /// <summary>
            /// Represents the [grid2x]metro\bed_up symbol
            /// </summary>
            public const string metro_bed_up = @"[grid2x]metro\bed_up";
            /// <summary>
            /// Represents the [grid2x]metro\bed symbol
            /// </summary>
            public const string metro_bed = @"[grid2x]metro\bed";
            /// <summary>
            /// Represents the [grid2x]metro\beep symbol
            /// </summary>
            public const string metro_beep = @"[grid2x]metro\beep";
            /// <summary>
            /// Represents the [grid2x]metro\blind symbol
            /// </summary>
            public const string metro_blind = @"[grid2x]metro\blind";
            /// <summary>
            /// Represents the [grid2x]metro\blind_close symbol
            /// </summary>
            public const string metro_blind_close = @"[grid2x]metro\blind_close";
            /// <summary>
            /// Represents the [grid2x]metro\blind_open symbol
            /// </summary>
            public const string metro_blind_open = @"[grid2x]metro\blind_open";
            /// <summary>
            /// Represents the [grid2x]metro\blu_ray symbol
            /// </summary>
            public const string metro_blu_ray = @"[grid2x]metro\blu_ray";
            /// <summary>
            /// Represents the [grid2x]metro\bookmark symbol
            /// </summary>
            public const string metro_bookmark = @"[grid2x]metro\bookmark";
            /// <summary>
            /// Represents the [grid2x]metro\bookmark_clear symbol
            /// </summary>
            public const string metro_bookmark_clear = @"[grid2x]metro\bookmark_clear";
            /// <summary>
            /// Represents the [grid2x]metro\calculator symbol
            /// </summary>
            public const string metro_calculator = @"[grid2x]metro\calculator";
            /// <summary>
            /// Represents the [grid2x]metro\camera symbol
            /// </summary>
            public const string metro_camera = @"[grid2x]metro\camera";
            /// <summary>
            /// Represents the [grid2x]metro\chair_down symbol
            /// </summary>
            public const string metro_chair_down = @"[grid2x]metro\chair_down";
            /// <summary>
            /// Represents the [grid2x]metro\chair_feet_down symbol
            /// </summary>
            public const string metro_chair_feet_down = @"[grid2x]metro\chair_feet_down";
            /// <summary>
            /// Represents the [grid2x]metro\chair_feet_up symbol
            /// </summary>
            public const string metro_chair_feet_up = @"[grid2x]metro\chair_feet_up";
            /// <summary>
            /// Represents the [grid2x]metro\chair_head_down symbol
            /// </summary>
            public const string metro_chair_head_down = @"[grid2x]metro\chair_head_down";
            /// <summary>
            /// Represents the [grid2x]metro\chair_head_up symbol
            /// </summary>
            public const string metro_chair_head_up = @"[grid2x]metro\chair_head_up";
            /// <summary>
            /// Represents the [grid2x]metro\chair_knees_down symbol
            /// </summary>
            public const string metro_chair_knees_down = @"[grid2x]metro\chair_knees_down";
            /// <summary>
            /// Represents the [grid2x]metro\chair_knees_up symbol
            /// </summary>
            public const string metro_chair_knees_up = @"[grid2x]metro\chair_knees_up";
            /// <summary>
            /// Represents the [grid2x]metro\chair_tilt_down symbol
            /// </summary>
            public const string metro_chair_tilt_down = @"[grid2x]metro\chair_tilt_down";
            /// <summary>
            /// Represents the [grid2x]metro\chair_tilt_up symbol
            /// </summary>
            public const string metro_chair_tilt_up = @"[grid2x]metro\chair_tilt_up";
            /// <summary>
            /// Represents the [grid2x]metro\chair_up symbol
            /// </summary>
            public const string metro_chair_up = @"[grid2x]metro\chair_up";
            /// <summary>
            /// Represents the [grid2x]metro\chair symbol
            /// </summary>
            public const string metro_chair = @"[grid2x]metro\chair";
            /// <summary>
            /// Represents the [grid2x]metro\chat symbol
            /// </summary>
            public const string metro_chat = @"[grid2x]metro\chat";
            /// <summary>
            /// Represents the [grid2x]metro\clear symbol
            /// </summary>
            public const string metro_clear = @"[grid2x]metro\clear";
            /// <summary>
            /// Represents the [grid2x]metro\clock symbol
            /// </summary>
            public const string metro_clock = @"[grid2x]metro\clock";
            /// <summary>
            /// Represents the [grid2x]metro\contact symbol
            /// </summary>
            public const string metro_contact = @"[grid2x]metro\contact";
            /// <summary>
            /// Represents the [grid2x]metro\contact_add symbol
            /// </summary>
            public const string metro_contact_add = @"[grid2x]metro\contact_add";
            /// <summary>
            /// Represents the [grid2x]metro\copy symbol
            /// </summary>
            public const string metro_copy = @"[grid2x]metro\copy";
            /// <summary>
            /// Represents the [grid2x]metro\cross symbol
            /// </summary>
            public const string metro_cross = @"[grid2x]metro\cross";
            /// <summary>
            /// Represents the [grid2x]metro\curtain symbol
            /// </summary>
            public const string metro_curtain = @"[grid2x]metro\curtain";
            /// <summary>
            /// Represents the [grid2x]metro\curtain_close symbol
            /// </summary>
            public const string metro_curtain_close = @"[grid2x]metro\curtain_close";
            /// <summary>
            /// Represents the [grid2x]metro\curtain_open symbol
            /// </summary>
            public const string metro_curtain_open = @"[grid2x]metro\curtain_open";
            /// <summary>
            /// Represents the [grid2x]metro\cut symbol
            /// </summary>
            public const string metro_cut = @"[grid2x]metro\cut";
            /// <summary>
            /// Represents the [grid2x]metro\datalog symbol
            /// </summary>
            public const string metro_datalog = @"[grid2x]metro\datalog";
            /// <summary>
            /// Represents the [grid2x]metro\delete symbol
            /// </summary>
            public const string metro_delete = @"[grid2x]metro\delete";
            /// <summary>
            /// Represents the [grid2x]metro\delete_letter symbol
            /// </summary>
            public const string metro_delete_letter = @"[grid2x]metro\delete_letter";
            /// <summary>
            /// Represents the [grid2x]metro\delete_word symbol
            /// </summary>
            public const string metro_delete_word = @"[grid2x]metro\delete_word";
            /// <summary>
            /// Represents the [grid2x]metro\dictionary_add symbol
            /// </summary>
            public const string metro_dictionary_add = @"[grid2x]metro\dictionary_add";
            /// <summary>
            /// Represents the [grid2x]metro\dictionary_remove symbol
            /// </summary>
            public const string metro_dictionary_remove = @"[grid2x]metro\dictionary_remove";
            /// <summary>
            /// Represents the [grid2x]metro\divide symbol
            /// </summary>
            public const string metro_divide = @"[grid2x]metro\divide";
            /// <summary>
            /// Represents the [grid2x]metro\dock symbol
            /// </summary>
            public const string metro_dock = @"[grid2x]metro\dock";
            /// <summary>
            /// Represents the [grid2x]metro\document symbol
            /// </summary>
            public const string metro_document = @"[grid2x]metro\document";
            /// <summary>
            /// Represents the [grid2x]metro\document_end symbol
            /// </summary>
            public const string metro_document_end = @"[grid2x]metro\document_end";
            /// <summary>
            /// Represents the [grid2x]metro\document_start symbol
            /// </summary>
            public const string metro_document_start = @"[grid2x]metro\document_start";
            /// <summary>
            /// Represents the [grid2x]metro\door symbol
            /// </summary>
            public const string metro_door = @"[grid2x]metro\door";
            /// <summary>
            /// Represents the [grid2x]metro\dvd symbol
            /// </summary>
            public const string metro_dvd = @"[grid2x]metro\dvd";
            /// <summary>
            /// Represents the [grid2x]metro\ecu symbol
            /// </summary>
            public const string metro_ecu = @"[grid2x]metro\ecu";
            /// <summary>
            /// Represents the [grid2x]metro\edit symbol
            /// </summary>
            public const string metro_edit = @"[grid2x]metro\edit";
            /// <summary>
            /// Represents the [grid2x]metro\email symbol
            /// </summary>
            public const string metro_email = @"[grid2x]metro\email";
            /// <summary>
            /// Represents the [grid2x]metro\enter symbol
            /// </summary>
            public const string metro_enter = @"[grid2x]metro\enter";
            /// <summary>
            /// Represents the [grid2x]metro\equals symbol
            /// </summary>
            public const string metro_equals = @"[grid2x]metro\equals";
            /// <summary>
            /// Represents the [grid2x]metro\exit symbol
            /// </summary>
            public const string metro_exit = @"[grid2x]metro\exit";
            /// <summary>
            /// Represents the [grid2x]metro\fan symbol
            /// </summary>
            public const string metro_fan = @"[grid2x]metro\fan";
            /// <summary>
            /// Represents the [grid2x]metro\fastforward symbol
            /// </summary>
            public const string metro_fastforward = @"[grid2x]metro\fastforward";
            /// <summary>
            /// Represents the [grid2x]metro\heart symbol
            /// </summary>
            public const string metro_heart = @"[grid2x]metro\heart";
            /// <summary>
            /// Represents the [grid2x]metro\hi_fi symbol
            /// </summary>
            public const string metro_hi_fi = @"[grid2x]metro\hi_fi";
            /// <summary>
            /// Represents the [grid2x]metro\hide symbol
            /// </summary>
            public const string metro_hide = @"[grid2x]metro\hide";
            /// <summary>
            /// Represents the [grid2x]metro\information symbol
            /// </summary>
            public const string metro_information = @"[grid2x]metro\information";
            /// <summary>
            /// Represents the [grid2x]metro\internet symbol
            /// </summary>
            public const string metro_internet = @"[grid2x]metro\internet";
            /// <summary>
            /// Represents the [grid2x]metro\ipod symbol
            /// </summary>
            public const string metro_ipod = @"[grid2x]metro\ipod";
            /// <summary>
            /// Represents the [grid2x]metro\jump_back symbol
            /// </summary>
            public const string metro_jump_back = @"[grid2x]metro\jump_back";
            /// <summary>
            /// Represents the [grid2x]metro\jump_forwards symbol
            /// </summary>
            public const string metro_jump_forwards = @"[grid2x]metro\jump_forwards";
            /// <summary>
            /// Represents the [grid2x]metro\jump_home symbol
            /// </summary>
            public const string metro_jump_home = @"[grid2x]metro\jump_home";
            /// <summary>
            /// Represents the [grid2x]metro\jump_pin symbol
            /// </summary>
            public const string metro_jump_pin = @"[grid2x]metro\jump_pin";
            /// <summary>
            /// Represents the [grid2x]metro\keyboard symbol
            /// </summary>
            public const string metro_keyboard = @"[grid2x]metro\keyboard";
            /// <summary>
            /// Represents the [grid2x]metro\keypad symbol
            /// </summary>
            public const string metro_keypad = @"[grid2x]metro\keypad";
            /// <summary>
            /// Represents the [grid2x]metro\lamp symbol
            /// </summary>
            public const string metro_lamp = @"[grid2x]metro\lamp";
            /// <summary>
            /// Represents the [grid2x]metro\light_bulb symbol
            /// </summary>
            public const string metro_light_bulb = @"[grid2x]metro\light_bulb";
            /// <summary>
            /// Represents the [grid2x]metro\list symbol
            /// </summary>
            public const string metro_list = @"[grid2x]metro\list";
            /// <summary>
            /// Represents the [grid2x]metro\lock symbol
            /// </summary>
            public const string metro_lock = @"[grid2x]metro\lock";
            /// <summary>
            /// Represents the [grid2x]metro\mail symbol
            /// </summary>
            public const string metro_mail = @"[grid2x]metro\mail";
            /// <summary>
            /// Represents the [grid2x]metro\mouse_double symbol
            /// </summary>
            public const string metro_mouse_double = @"[grid2x]metro\mouse_double";
            /// <summary>
            /// Represents the [grid2x]metro\mouse_drag symbol
            /// </summary>
            public const string metro_mouse_drag = @"[grid2x]metro\mouse_drag";
            /// <summary>
            /// Represents the [grid2x]metro\mouse_left symbol
            /// </summary>
            public const string metro_mouse_left = @"[grid2x]metro\mouse_left";
            /// <summary>
            /// Represents the [grid2x]metro\mouse_pointer symbol
            /// </summary>
            public const string metro_mouse_pointer = @"[grid2x]metro\mouse_pointer";
            /// <summary>
            /// Represents the [grid2x]metro\mouse_right symbol
            /// </summary>
            public const string metro_mouse_right = @"[grid2x]metro\mouse_right";
            /// <summary>
            /// Represents the [grid2x]metro\move_down symbol
            /// </summary>
            public const string metro_move_down = @"[grid2x]metro\move_down";
            /// <summary>
            /// Represents the [grid2x]metro\move_down_left symbol
            /// </summary>
            public const string metro_move_down_left = @"[grid2x]metro\move_down_left";
            /// <summary>
            /// Represents the [grid2x]metro\move_down_right symbol
            /// </summary>
            public const string metro_move_down_right = @"[grid2x]metro\move_down_right";
            /// <summary>
            /// Represents the [grid2x]metro\move_grid symbol
            /// </summary>
            public const string metro_move_grid = @"[grid2x]metro\move_grid";
            /// <summary>
            /// Represents the [grid2x]metro\move_left symbol
            /// </summary>
            public const string metro_move_left = @"[grid2x]metro\move_left";
            /// <summary>
            /// Represents the [grid2x]metro\move_right symbol
            /// </summary>
            public const string metro_move_right = @"[grid2x]metro\move_right";
            /// <summary>
            /// Represents the [grid2x]metro\move_up symbol
            /// </summary>
            public const string metro_move_up = @"[grid2x]metro\move_up";
            /// <summary>
            /// Represents the [grid2x]metro\move_up_left symbol
            /// </summary>
            public const string metro_move_up_left = @"[grid2x]metro\move_up_left";
            /// <summary>
            /// Represents the [grid2x]metro\move_up_right symbol
            /// </summary>
            public const string metro_move_up_right = @"[grid2x]metro\move_up_right";
            /// <summary>
            /// Represents the [grid2x]metro\multiply symbol
            /// </summary>
            public const string metro_multiply = @"[grid2x]metro\multiply";
            /// <summary>
            /// Represents the [grid2x]metro\music symbol
            /// </summary>
            public const string metro_music = @"[grid2x]metro\music";
            /// <summary>
            /// Represents the [grid2x]metro\mute symbol
            /// </summary>
            public const string metro_mute = @"[grid2x]metro\mute";
            /// <summary>
            /// Represents the [grid2x]metro\new symbol
            /// </summary>
            public const string metro_new = @"[grid2x]metro\new";
            /// <summary>
            /// Represents the [grid2x]metro\next symbol
            /// </summary>
            public const string metro_next = @"[grid2x]metro\next";
            /// <summary>
            /// Represents the [grid2x]metro\open symbol
            /// </summary>
            public const string metro_open = @"[grid2x]metro\open";
            /// <summary>
            /// Represents the [grid2x]metro\paragraph_next symbol
            /// </summary>
            public const string metro_paragraph_next = @"[grid2x]metro\paragraph_next";
            /// <summary>
            /// Represents the [grid2x]metro\paragraph_previous symbol
            /// </summary>
            public const string metro_paragraph_previous = @"[grid2x]metro\paragraph_previous";
            /// <summary>
            /// Represents the [grid2x]metro\paste symbol
            /// </summary>
            public const string metro_paste = @"[grid2x]metro\paste";
            /// <summary>
            /// Represents the [grid2x]metro\pause symbol
            /// </summary>
            public const string metro_pause = @"[grid2x]metro\pause";
            /// <summary>
            /// Represents the [grid2x]metro\phone_1 symbol
            /// </summary>
            public const string metro_phone_1 = @"[grid2x]metro\phone_1";
            /// <summary>
            /// Represents the [grid2x]metro\phone symbol
            /// </summary>
            public const string metro_phone = @"[grid2x]metro\phone";
            /// <summary>
            /// Represents the [grid2x]metro\phone_down symbol
            /// </summary>
            public const string metro_phone_down = @"[grid2x]metro\phone_down";
            /// <summary>
            /// Represents the [grid2x]metro\phone_up symbol
            /// </summary>
            public const string metro_phone_up = @"[grid2x]metro\phone_up";
            /// <summary>
            /// Represents the [grid2x]metro\photo symbol
            /// </summary>
            public const string metro_photo = @"[grid2x]metro\photo";
            /// <summary>
            /// Represents the [grid2x]metro\play symbol
            /// </summary>
            public const string metro_play = @"[grid2x]metro\play";
            /// <summary>
            /// Represents the [grid2x]metro\play_pause symbol
            /// </summary>
            public const string metro_play_pause = @"[grid2x]metro\play_pause";
            /// <summary>
            /// Represents the [grid2x]metro\plug symbol
            /// </summary>
            public const string metro_plug = @"[grid2x]metro\plug";
            /// <summary>
            /// Represents the [grid2x]metro\previous symbol
            /// </summary>
            public const string metro_previous = @"[grid2x]metro\previous";
            /// <summary>
            /// Represents the [grid2x]metro\print symbol
            /// </summary>
            public const string metro_print = @"[grid2x]metro\print";
            /// <summary>
            /// Represents the [grid2x]metro\radar_down_anticlockwise symbol
            /// </summary>
            public const string metro_radar_down_anticlockwise = @"[grid2x]metro\radar_down_anticlockwise";
            /// <summary>
            /// Represents the [grid2x]metro\radar_down_clockwise symbol
            /// </summary>
            public const string metro_radar_down_clockwise = @"[grid2x]metro\radar_down_clockwise";
            /// <summary>
            /// Represents the [grid2x]metro\radar_left_anticlockwise symbol
            /// </summary>
            public const string metro_radar_left_anticlockwise = @"[grid2x]metro\radar_left_anticlockwise";
            /// <summary>
            /// Represents the [grid2x]metro\radar_left_clockwise symbol
            /// </summary>
            public const string metro_radar_left_clockwise = @"[grid2x]metro\radar_left_clockwise";
            /// <summary>
            /// Represents the [grid2x]metro\radar_right_anticlockwise symbol
            /// </summary>
            public const string metro_radar_right_anticlockwise = @"[grid2x]metro\radar_right_anticlockwise";
            /// <summary>
            /// Represents the [grid2x]metro\radar_right_clockwise symbol
            /// </summary>
            public const string metro_radar_right_clockwise = @"[grid2x]metro\radar_right_clockwise";
            /// <summary>
            /// Represents the [grid2x]metro\radar_up_anticlockwise symbol
            /// </summary>
            public const string metro_radar_up_anticlockwise = @"[grid2x]metro\radar_up_anticlockwise";
            /// <summary>
            /// Represents the [grid2x]metro\radar_up_clockwise symbol
            /// </summary>
            public const string metro_radar_up_clockwise = @"[grid2x]metro\radar_up_clockwise";
            /// <summary>
            /// Represents the [grid2x]metro\radio symbol
            /// </summary>
            public const string metro_radio = @"[grid2x]metro\radio";
            /// <summary>
            /// Represents the [grid2x]metro\record symbol
            /// </summary>
            public const string metro_record = @"[grid2x]metro\record";
            /// <summary>
            /// Represents the [grid2x]metro\redo symbol
            /// </summary>
            public const string metro_redo = @"[grid2x]metro\redo";
            /// <summary>
            /// Represents the [grid2x]metro\repeat symbol
            /// </summary>
            public const string metro_repeat = @"[grid2x]metro\repeat";
            /// <summary>
            /// Represents the [grid2x]metro\reply symbol
            /// </summary>
            public const string metro_reply = @"[grid2x]metro\reply";
            /// <summary>
            /// Represents the [grid2x]metro\rest symbol
            /// </summary>
            public const string metro_rest = @"[grid2x]metro\rest";
            /// <summary>
            /// Represents the [grid2x]metro\rest_eyegaze symbol
            /// </summary>
            public const string metro_rest_eyegaze = @"[grid2x]metro\rest_eyegaze";
            /// <summary>
            /// Represents the [grid2x]metro\rest_mouse symbol
            /// </summary>
            public const string metro_rest_mouse = @"[grid2x]metro\rest_mouse";
            /// <summary>
            /// Represents the [grid2x]metro\rest_switch symbol
            /// </summary>
            public const string metro_rest_switch = @"[grid2x]metro\rest_switch";
            /// <summary>
            /// Represents the [grid2x]metro\rest_voice symbol
            /// </summary>
            public const string metro_rest_voice = @"[grid2x]metro\rest_voice";
            /// <summary>
            /// Represents the [grid2x]metro\rewind symbol
            /// </summary>
            public const string metro_rewind = @"[grid2x]metro\rewind";
            /// <summary>
            /// Represents the [grid2x]metro\rotate_anticlockwise symbol
            /// </summary>
            public const string metro_rotate_anticlockwise = @"[grid2x]metro\rotate_anticlockwise";
            /// <summary>
            /// Represents the [grid2x]metro\rotate_clockwise symbol
            /// </summary>
            public const string metro_rotate_clockwise = @"[grid2x]metro\rotate_clockwise";
            /// <summary>
            /// Represents the [grid2x]metro\run symbol
            /// </summary>
            public const string metro_run = @"[grid2x]metro\run";
            /// <summary>
            /// Represents the [grid2x]metro\save symbol
            /// </summary>
            public const string metro_save = @"[grid2x]metro\save";
            /// <summary>
            /// Represents the [grid2x]metro\save_1 symbol
            /// </summary>
            public const string metro_save_1 = @"[grid2x]metro\save_1";
            /// <summary>
            /// Represents the [grid2x]metro\sentence_next symbol
            /// </summary>
            public const string metro_sentence_next = @"[grid2x]metro\sentence_next";
            /// <summary>
            /// Represents the [grid2x]metro\sentence_previous symbol
            /// </summary>
            public const string metro_sentence_previous = @"[grid2x]metro\sentence_previous";
            /// <summary>
            /// Represents the [grid2x]metro\settings_1 symbol
            /// </summary>
            public const string metro_settings_1 = @"[grid2x]metro\settings_1";
            /// <summary>
            /// Represents the [grid2x]metro\settings symbol
            /// </summary>
            public const string metro_settings = @"[grid2x]metro\settings";
            /// <summary>
            /// Represents the [grid2x]metro\shift symbol
            /// </summary>
            public const string metro_shift = @"[grid2x]metro\shift";
            /// <summary>
            /// Represents the [grid2x]metro\shuffle symbol
            /// </summary>
            public const string metro_shuffle = @"[grid2x]metro\shuffle";
            /// <summary>
            /// Represents the [grid2x]metro\shutdown symbol
            /// </summary>
            public const string metro_shutdown = @"[grid2x]metro\shutdown";
            /// <summary>
            /// Represents the [grid2x]metro\skype symbol
            /// </summary>
            public const string metro_skype = @"[grid2x]metro\skype";
            /// <summary>
            /// Represents the [grid2x]metro\space symbol
            /// </summary>
            public const string metro_space = @"[grid2x]metro\space";
            /// <summary>
            /// Represents the [grid2x]metro\speak_all symbol
            /// </summary>
            public const string metro_speak_all = @"[grid2x]metro\speak_all";
            /// <summary>
            /// Represents the [grid2x]metro\speak_paragraph symbol
            /// </summary>
            public const string metro_speak_paragraph = @"[grid2x]metro\speak_paragraph";
            /// <summary>
            /// Represents the [grid2x]metro\speak_sentence symbol
            /// </summary>
            public const string metro_speak_sentence = @"[grid2x]metro\speak_sentence";
            /// <summary>
            /// Represents the [grid2x]metro\speak_stop symbol
            /// </summary>
            public const string metro_speak_stop = @"[grid2x]metro\speak_stop";
            /// <summary>
            /// Represents the [grid2x]metro\speak_word symbol
            /// </summary>
            public const string metro_speak_word = @"[grid2x]metro\speak_word";
            /// <summary>
            /// Represents the [grid2x]metro\star symbol
            /// </summary>
            public const string metro_star = @"[grid2x]metro\star";
            /// <summary>
            /// Represents the [grid2x]metro\stop symbol
            /// </summary>
            public const string metro_stop = @"[grid2x]metro\stop";
            /// <summary>
            /// Represents the [grid2x]metro\stop_1 symbol
            /// </summary>
            public const string metro_stop_1 = @"[grid2x]metro\stop_1";
            /// <summary>
            /// Represents the [grid2x]metro\subtract symbol
            /// </summary>
            public const string metro_subtract = @"[grid2x]metro\subtract";
            /// <summary>
            /// Represents the [grid2x]metro\suggestion_clear symbol
            /// </summary>
            public const string metro_suggestion_clear = @"[grid2x]metro\suggestion_clear";
            /// <summary>
            /// Represents the [grid2x]metro\suggestion_next symbol
            /// </summary>
            public const string metro_suggestion_next = @"[grid2x]metro\suggestion_next";
            /// <summary>
            /// Represents the [grid2x]metro\symbol_clear symbol
            /// </summary>
            public const string metro_symbol_clear = @"[grid2x]metro\symbol_clear";
            /// <summary>
            /// Represents the [grid2x]metro\symbol_next symbol
            /// </summary>
            public const string metro_symbol_next = @"[grid2x]metro\symbol_next";
            /// <summary>
            /// Represents the [grid2x]metro\television symbol
            /// </summary>
            public const string metro_television = @"[grid2x]metro\television";
            /// <summary>
            /// Represents the [grid2x]metro\tick symbol
            /// </summary>
            public const string metro_tick = @"[grid2x]metro\tick";
            /// <summary>
            /// Represents the [grid2x]metro\tv_box symbol
            /// </summary>
            public const string metro_tv_box = @"[grid2x]metro\tv_box";
            /// <summary>
            /// Represents the [grid2x]metro\undo symbol
            /// </summary>
            public const string metro_undo = @"[grid2x]metro\undo";
            /// <summary>
            /// Represents the [grid2x]metro\video symbol
            /// </summary>
            public const string metro_video = @"[grid2x]metro\video";
            /// <summary>
            /// Represents the [grid2x]metro\volume symbol
            /// </summary>
            public const string metro_volume = @"[grid2x]metro\volume";
            /// <summary>
            /// Represents the [grid2x]metro\volume_1 symbol
            /// </summary>
            public const string metro_volume_1 = @"[grid2x]metro\volume_1";
            /// <summary>
            /// Represents the [grid2x]metro\volume_2 symbol
            /// </summary>
            public const string metro_volume_2 = @"[grid2x]metro\volume_2";
            /// <summary>
            /// Represents the [grid2x]metro\volume_3 symbol
            /// </summary>
            public const string metro_volume_3 = @"[grid2x]metro\volume_3";
            /// <summary>
            /// Represents the [grid2x]metro\volume_4 symbol
            /// </summary>
            public const string metro_volume_4 = @"[grid2x]metro\volume_4";
            /// <summary>
            /// Represents the [grid2x]metro\volume_down symbol
            /// </summary>
            public const string metro_volume_down = @"[grid2x]metro\volume_down";
            /// <summary>
            /// Represents the [grid2x]metro\volume_up symbol
            /// </summary>
            public const string metro_volume_up = @"[grid2x]metro\volume_up";
            /// <summary>
            /// Represents the [grid2x]metro\window_open symbol
            /// </summary>
            public const string metro_window_open = @"[grid2x]metro\window_open";
            /// <summary>
            /// Represents the [grid2x]metro\window symbol
            /// </summary>
            public const string metro_window = @"[grid2x]metro\window";
            /// <summary>
            /// Represents the [grid2x]metro\windows symbol
            /// </summary>
            public const string metro_windows = @"[grid2x]metro\windows";
            /// <summary>
            /// Represents the [grid2x]metro\window_maximise symbol
            /// </summary>
            public const string metro_window_maximise = @"[grid2x]metro\window_maximise";
            /// <summary>
            /// Represents the [grid2x]metro\window_minimise symbol
            /// </summary>
            public const string metro_window_minimise = @"[grid2x]metro\window_minimise";
            /// <summary>
            /// Represents the [grid2x]metro\window_restore symbol
            /// </summary>
            public const string metro_window_restore = @"[grid2x]metro\window_restore";
            /// <summary>
            /// Represents the [grid2x]metro\wordprocessor symbol
            /// </summary>
            public const string metro_wordprocessor = @"[grid2x]metro\wordprocessor";
            /// <summary>
            /// Represents the [grid2x]metro\word_next symbol
            /// </summary>
            public const string metro_word_next = @"[grid2x]metro\word_next";
            /// <summary>
            /// Represents the [grid2x]metro\word_previous symbol
            /// </summary>
            public const string metro_word_previous = @"[grid2x]metro\word_previous";
            /// <summary>
            /// Represents the [grid2x]metro\zoom symbol
            /// </summary>
            public const string metro_zoom = @"[grid2x]metro\zoom";
            /// <summary>
            /// Represents the [grid2x]metro\zoom_in symbol
            /// </summary>
            public const string metro_zoom_in = @"[grid2x]metro\zoom_in";
            /// <summary>
            /// Represents the [grid2x]metro\zoom_out symbol
            /// </summary>
            public const string metro_zoom_out = @"[grid2x]metro\zoom_out";
            /// <summary>
            /// Represents the [grid2x]misc\add favourite symbol
            /// </summary>
            public const string misc_add_favourite = @"[grid2x]misc\add favourite";
            /// <summary>
            /// Represents the [grid2x]misc\maths symbol
            /// </summary>
            public const string misc_maths = @"[grid2x]misc\maths";
            /// <summary>
            /// Represents the [grid2x]misc\punctuation symbol
            /// </summary>
            public const string misc_punctuation = @"[grid2x]misc\punctuation";
            /// <summary>
            /// Represents the [grid2x]misc\remove favourite symbol
            /// </summary>
            public const string misc_remove_favourite = @"[grid2x]misc\remove favourite";
            /// <summary>
            /// Represents the [grid2x]rating\0_star symbol
            /// </summary>
            public const string rating_0_star = @"[grid2x]rating\0_star";
            /// <summary>
            /// Represents the [grid2x]rating\1_star symbol
            /// </summary>
            public const string rating_1_star = @"[grid2x]rating\1_star";
            /// <summary>
            /// Represents the [grid2x]rating\2_star symbol
            /// </summary>
            public const string rating_2_star = @"[grid2x]rating\2_star";
            /// <summary>
            /// Represents the [grid2x]rating\3_star symbol
            /// </summary>
            public const string rating_3_star = @"[grid2x]rating\3_star";
            /// <summary>
            /// Represents the [grid2x]skypestatus\away symbol
            /// </summary>
            public const string skypestatus_away = @"[grid2x]skypestatus\away";
            /// <summary>
            /// Represents the [grid2x]skypestatus\donotdisturb symbol
            /// </summary>
            public const string skypestatus_donotdisturb = @"[grid2x]skypestatus\donotdisturb";
            /// <summary>
            /// Represents the [grid2x]skypestatus\notavailable symbol
            /// </summary>
            public const string skypestatus_notavailable = @"[grid2x]skypestatus\notavailable";
            /// <summary>
            /// Represents the [grid2x]skypestatus\offline symbol
            /// </summary>
            public const string skypestatus_offline = @"[grid2x]skypestatus\offline";
            /// <summary>
            /// Represents the [grid2x]skypestatus\online symbol
            /// </summary>
            public const string skypestatus_online = @"[grid2x]skypestatus\online";
            /// <summary>
            /// Represents the [grid2x]skypestatus\out symbol
            /// </summary>
            public const string skypestatus_out = @"[grid2x]skypestatus\out";
            /// <summary>
            /// Represents the [grid2x]skypestatus\skypeme symbol
            /// </summary>
            public const string skypestatus_skypeme = @"[grid2x]skypestatus\skypeme";
        }

        /// <summary>
        /// Contains common symbols from the Grid3x symbol library
        /// </summary>
        public static class Grid3xSymbols
        {
            /// <summary>
            /// Represents the [grid3x]0 symbol
            /// </summary>
            public const string number_0 = @"[grid3x]0";
            /// <summary>
            /// Represents the [grid3x]1_oclock symbol
            /// </summary>
            public const string number_1_oclock = @"[grid3x]1_oclock";
            /// <summary>
            /// Represents the [grid3x]1 symbol
            /// </summary>
            public const string number_1 = @"[grid3x]1";
            /// <summary>
            /// Represents the [grid3x]10 symbol
            /// </summary>
            public const string number_10 = @"[grid3x]10";
            /// <summary>
            /// Represents the [grid3x]12_oclock symbol
            /// </summary>
            public const string number_12_oclock = @"[grid3x]12_oclock";
            /// <summary>
            /// Represents the [grid3x]2 symbol
            /// </summary>
            public const string number_2 = @"[grid3x]2";
            /// <summary>
            /// Represents the [grid3x]3 symbol
            /// </summary>
            public const string number_3 = @"[grid3x]3";
            /// <summary>
            /// Represents the [grid3x]4 symbol
            /// </summary>
            public const string number_4 = @"[grid3x]4";
            /// <summary>
            /// Represents the [grid3x]5 symbol
            /// </summary>
            public const string number_5 = @"[grid3x]5";
            /// <summary>
            /// Represents the [grid3x]6 symbol
            /// </summary>
            public const string number_6 = @"[grid3x]6";
            /// <summary>
            /// Represents the [grid3x]7 symbol
            /// </summary>
            public const string number_7 = @"[grid3x]7";
            /// <summary>
            /// Represents the [grid3x]8 symbol
            /// </summary>
            public const string number_8 = @"[grid3x]8";
            /// <summary>
            /// Represents the [grid3x]9 symbol
            /// </summary>
            public const string number_9 = @"[grid3x]9";
            /// <summary>
            /// Represents the [grid3x]a symbol
            /// </summary>
            public const string a = @"[grid3x]a";
            /// <summary>
            /// Represents the [grid3x]a1 symbol
            /// </summary>
            public const string a1 = @"[grid3x]a1";
            /// <summary>
            /// Represents the [grid3x]a2 symbol
            /// </summary>
            public const string a2 = @"[grid3x]a2";
            /// <summary>
            /// Represents the [grid3x]abbia_detto symbol
            /// </summary>
            public const string abbia_detto = @"[grid3x]abbia_detto";
            /// <summary>
            /// Represents the [grid3x]abc symbol
            /// </summary>
            public const string abc = @"[grid3x]abc";
            /// <summary>
            /// Represents the [grid3x]accept symbol
            /// </summary>
            public const string accept = @"[grid3x]accept";
            /// <summary>
            /// Represents the [grid3x]add_1 symbol
            /// </summary>
            public const string add_1 = @"[grid3x]add_1";
            /// <summary>
            /// Represents the [grid3x]add symbol
            /// </summary>
            public const string add = @"[grid3x]add";
            /// <summary>
            /// Represents the [grid3x]add_category symbol
            /// </summary>
            public const string add_category = @"[grid3x]add_category";
            /// <summary>
            /// Represents the [grid3x]alarm_off symbol
            /// </summary>
            public const string alarm_off = @"[grid3x]alarm_off";
            /// <summary>
            /// Represents the [grid3x]alarm symbol
            /// </summary>
            public const string alarm = @"[grid3x]alarm";
            /// <summary>
            /// Represents the [grid3x]align_centre symbol
            /// </summary>
            public const string align_centre = @"[grid3x]align_centre";
            /// <summary>
            /// Represents the [grid3x]align_grid symbol
            /// </summary>
            public const string align_grid = @"[grid3x]align_grid";
            /// <summary>
            /// Represents the [grid3x]align_justified symbol
            /// </summary>
            public const string align_justified = @"[grid3x]align_justified";
            /// <summary>
            /// Represents the [grid3x]align_left symbol
            /// </summary>
            public const string align_left = @"[grid3x]align_left";
            /// <summary>
            /// Represents the [grid3x]align_mouse_left symbol
            /// </summary>
            public const string align_mouse_left = @"[grid3x]align_mouse_left";
            /// <summary>
            /// Represents the [grid3x]align_right symbol
            /// </summary>
            public const string align_right = @"[grid3x]align_right";
            /// <summary>
            /// Represents the [grid3x]align_window_left symbol
            /// </summary>
            public const string align_window_left = @"[grid3x]align_window_left";
            /// <summary>
            /// Represents the [grid3x]alpha_core symbol
            /// </summary>
            public const string alpha_core = @"[grid3x]alpha_core";
            /// <summary>
            /// Represents the [grid3x]alt symbol
            /// </summary>
            public const string alt = @"[grid3x]alt";
            /// <summary>
            /// Represents the [grid3x]apple symbol
            /// </summary>
            public const string apple = @"[grid3x]apple";
            /// <summary>
            /// Represents the [grid3x]apple_computer symbol
            /// </summary>
            public const string apple_computer = @"[grid3x]apple_computer";
            /// <summary>
            /// Represents the [grid3x]appliance symbol
            /// </summary>
            public const string appliance = @"[grid3x]appliance";
            /// <summary>
            /// Represents the [grid3x]apps symbol
            /// </summary>
            public const string apps = @"[grid3x]apps";
            /// <summary>
            /// Represents the [grid3x]arrange_1 symbol
            /// </summary>
            public const string arrange_1 = @"[grid3x]arrange_1";
            /// <summary>
            /// Represents the [grid3x]arrange symbol
            /// </summary>
            public const string arrange = @"[grid3x]arrange";
            /// <summary>
            /// Represents the [grid3x]arrows symbol
            /// </summary>
            public const string arrows = @"[grid3x]arrows";
            /// <summary>
            /// Represents the [grid3x]arrow_down symbol
            /// </summary>
            public const string arrow_down = @"[grid3x]arrow_down";
            /// <summary>
            /// Represents the [grid3x]arrow_down_left symbol
            /// </summary>
            public const string arrow_down_left = @"[grid3x]arrow_down_left";
            /// <summary>
            /// Represents the [grid3x]arrow_down_right symbol
            /// </summary>
            public const string arrow_down_right = @"[grid3x]arrow_down_right";
            /// <summary>
            /// Represents the [grid3x]arrow_left symbol
            /// </summary>
            public const string arrow_left = @"[grid3x]arrow_left";
            /// <summary>
            /// Represents the [grid3x]arrow_right symbol
            /// </summary>
            public const string arrow_right = @"[grid3x]arrow_right";
            /// <summary>
            /// Represents the [grid3x]arrow_up symbol
            /// </summary>
            public const string arrow_up = @"[grid3x]arrow_up";
            /// <summary>
            /// Represents the [grid3x]arrow_up_left symbol
            /// </summary>
            public const string arrow_up_left = @"[grid3x]arrow_up_left";
            /// <summary>
            /// Represents the [grid3x]arrow_up_right symbol
            /// </summary>
            public const string arrow_up_right = @"[grid3x]arrow_up_right";
            /// <summary>
            /// Represents the [grid3x]assist symbol
            /// </summary>
            public const string assist = @"[grid3x]assist";
            /// <summary>
            /// Represents the [grid3x]asterisk symbol
            /// </summary>
            public const string asterisk = @"[grid3x]asterisk";
            /// <summary>
            /// Represents the [grid3x]auditory symbol
            /// </summary>
            public const string auditory = @"[grid3x]auditory";
            /// <summary>
            /// Represents the [grid3x]autocells_end symbol
            /// </summary>
            public const string autocells_end = @"[grid3x]autocells_end";
            /// <summary>
            /// Represents the [grid3x]autocells_next symbol
            /// </summary>
            public const string autocells_next = @"[grid3x]autocells_next";
            /// <summary>
            /// Represents the [grid3x]autocells_previous symbol
            /// </summary>
            public const string autocells_previous = @"[grid3x]autocells_previous";
            /// <summary>
            /// Represents the [grid3x]autocells_start symbol
            /// </summary>
            public const string autocells_start = @"[grid3x]autocells_start";
            /// <summary>
            /// Represents the [grid3x]avessi_detto symbol
            /// </summary>
            public const string avessi_detto = @"[grid3x]avessi_detto";
            /// <summary>
            /// Represents the [grid3x]avevo_detto symbol
            /// </summary>
            public const string avevo_detto = @"[grid3x]avevo_detto";
            /// <summary>
            /// Represents the [grid3x]avrei_detto symbol
            /// </summary>
            public const string avrei_detto = @"[grid3x]avrei_detto";
            /// <summary>
            /// Represents the [grid3x]avro_detto symbol
            /// </summary>
            public const string avro_detto = @"[grid3x]avro_detto";
            /// <summary>
            /// Represents the [grid3x]a_z symbol
            /// </summary>
            public const string a_z = @"[grid3x]a_z";
            /// <summary>
            /// Represents the [grid3x]a_z_2 symbol
            /// </summary>
            public const string a_z_2 = @"[grid3x]a_z_2";
            /// <summary>
            /// Represents the [grid3x]b symbol
            /// </summary>
            public const string b = @"[grid3x]b";
            /// <summary>
            /// Represents the [grid3x]b1 symbol
            /// </summary>
            public const string b1 = @"[grid3x]b1";
            /// <summary>
            /// Represents the [grid3x]back_1 symbol
            /// </summary>
            public const string back_1 = @"[grid3x]back_1";
            /// <summary>
            /// Represents the [grid3x]back symbol
            /// </summary>
            public const string back = @"[grid3x]back";
            /// <summary>
            /// Represents the [grid3x]bang_1 symbol
            /// </summary>
            public const string bang_1 = @"[grid3x]bang_1";
            /// <summary>
            /// Represents the [grid3x]bang_2 symbol
            /// </summary>
            public const string bang_2 = @"[grid3x]bang_2";
            /// <summary>
            /// Represents the [grid3x]bang_3 symbol
            /// </summary>
            public const string bang_3 = @"[grid3x]bang_3";
            /// <summary>
            /// Represents the [grid3x]bang_4 symbol
            /// </summary>
            public const string bang_4 = @"[grid3x]bang_4";
            /// <summary>
            /// Represents the [grid3x]battery symbol
            /// </summary>
            public const string battery = @"[grid3x]battery";
            /// <summary>
            /// Represents the [grid3x]battleship_4 symbol
            /// </summary>
            public const string battleship_4 = @"[grid3x]battleship_4";
            /// <summary>
            /// Represents the [grid3x]bed_down symbol
            /// </summary>
            public const string bed_down = @"[grid3x]bed_down";
            /// <summary>
            /// Represents the [grid3x]bed_feet_down symbol
            /// </summary>
            public const string bed_feet_down = @"[grid3x]bed_feet_down";
            /// <summary>
            /// Represents the [grid3x]bed_feet_up symbol
            /// </summary>
            public const string bed_feet_up = @"[grid3x]bed_feet_up";
            /// <summary>
            /// Represents the [grid3x]bed_head_down symbol
            /// </summary>
            public const string bed_head_down = @"[grid3x]bed_head_down";
            /// <summary>
            /// Represents the [grid3x]bed_head_up symbol
            /// </summary>
            public const string bed_head_up = @"[grid3x]bed_head_up";
            /// <summary>
            /// Represents the [grid3x]bed_knees_down symbol
            /// </summary>
            public const string bed_knees_down = @"[grid3x]bed_knees_down";
            /// <summary>
            /// Represents the [grid3x]bed_knees_up symbol
            /// </summary>
            public const string bed_knees_up = @"[grid3x]bed_knees_up";
            /// <summary>
            /// Represents the [grid3x]bed_tilt_down symbol
            /// </summary>
            public const string bed_tilt_down = @"[grid3x]bed_tilt_down";
            /// <summary>
            /// Represents the [grid3x]bed_tilt_up symbol
            /// </summary>
            public const string bed_tilt_up = @"[grid3x]bed_tilt_up";
            /// <summary>
            /// Represents the [grid3x]bed_up symbol
            /// </summary>
            public const string bed_up = @"[grid3x]bed_up";
            /// <summary>
            /// Represents the [grid3x]bed symbol
            /// </summary>
            public const string bed = @"[grid3x]bed";
            /// <summary>
            /// Represents the [grid3x]beeline symbol
            /// </summary>
            public const string beeline = @"[grid3x]beeline";
            /// <summary>
            /// Represents the [grid3x]beep symbol
            /// </summary>
            public const string beep = @"[grid3x]beep";
            /// <summary>
            /// Represents the [grid3x]bird symbol
            /// </summary>
            public const string bird = @"[grid3x]bird";
            /// <summary>
            /// Represents the [grid3x]bj symbol
            /// </summary>
            public const string bj = @"[grid3x]bj";
            /// <summary>
            /// Represents the [grid3x]black_pawn symbol
            /// </summary>
            public const string black_pawn = @"[grid3x]black_pawn";
            /// <summary>
            /// Represents the [grid3x]blind symbol
            /// </summary>
            public const string blind = @"[grid3x]blind";
            /// <summary>
            /// Represents the [grid3x]blind_close symbol
            /// </summary>
            public const string blind_close = @"[grid3x]blind_close";
            /// <summary>
            /// Represents the [grid3x]blind_open symbol
            /// </summary>
            public const string blind_open = @"[grid3x]blind_open";
            /// <summary>
            /// Represents the [grid3x]blu_ray symbol
            /// </summary>
            public const string blu_ray = @"[grid3x]blu_ray";
            /// <summary>
            /// Represents the [grid3x]book symbol
            /// </summary>
            public const string book = @"[grid3x]book";
            /// <summary>
            /// Represents the [grid3x]bookmark symbol
            /// </summary>
            public const string bookmark = @"[grid3x]bookmark";
            /// <summary>
            /// Represents the [grid3x]bookmark_clear symbol
            /// </summary>
            public const string bookmark_clear = @"[grid3x]bookmark_clear";
            /// <summary>
            /// Represents the [grid3x]brain symbol
            /// </summary>
            public const string brain = @"[grid3x]brain";
            /// <summary>
            /// Represents the [grid3x]brightness symbol
            /// </summary>
            public const string brightness = @"[grid3x]brightness";
            /// <summary>
            /// Represents the [grid3x]bullhorn symbol
            /// </summary>
            public const string bullhorn = @"[grid3x]bullhorn";
            /// <summary>
            /// Represents the [grid3x]c symbol
            /// </summary>
            public const string c = @"[grid3x]c";
            /// <summary>
            /// Represents the [grid3x]c1 symbol
            /// </summary>
            public const string c1 = @"[grid3x]c1";
            /// <summary>
            /// Represents the [grid3x]calculator symbol
            /// </summary>
            public const string calculator = @"[grid3x]calculator";
            /// <summary>
            /// Represents the [grid3x]calendar symbol
            /// </summary>
            public const string calendar = @"[grid3x]calendar";
            /// <summary>
            /// Represents the [grid3x]camera symbol
            /// </summary>
            public const string camera = @"[grid3x]camera";
            /// <summary>
            /// Represents the [grid3x]camera_change symbol
            /// </summary>
            public const string camera_change = @"[grid3x]camera_change";
            /// <summary>
            /// Represents the [grid3x]camera_snapshot symbol
            /// </summary>
            public const string camera_snapshot = @"[grid3x]camera_snapshot";
            /// <summary>
            /// Represents the [grid3x]capslock symbol
            /// </summary>
            public const string capslock = @"[grid3x]capslock";
            /// <summary>
            /// Represents the [grid3x]carrier_5 symbol
            /// </summary>
            public const string carrier_5 = @"[grid3x]carrier_5";
            /// <summary>
            /// Represents the [grid3x]cctv symbol
            /// </summary>
            public const string cctv = @"[grid3x]cctv";
            /// <summary>
            /// Represents the [grid3x]cctv_off symbol
            /// </summary>
            public const string cctv_off = @"[grid3x]cctv_off";
            /// <summary>
            /// Represents the [grid3x]ce_mark symbol
            /// </summary>
            public const string ce_mark = @"[grid3x]ce_mark";
            /// <summary>
            /// Represents the [grid3x]censored symbol
            /// </summary>
            public const string censored = @"[grid3x]censored";
            /// <summary>
            /// Represents the [grid3x]centre symbol
            /// </summary>
            public const string centre = @"[grid3x]centre";
            /// <summary>
            /// Represents the [grid3x]chair_down symbol
            /// </summary>
            public const string chair_down = @"[grid3x]chair_down";
            /// <summary>
            /// Represents the [grid3x]chair_feet_down symbol
            /// </summary>
            public const string chair_feet_down = @"[grid3x]chair_feet_down";
            /// <summary>
            /// Represents the [grid3x]chair_feet_up symbol
            /// </summary>
            public const string chair_feet_up = @"[grid3x]chair_feet_up";
            /// <summary>
            /// Represents the [grid3x]chair_head_down symbol
            /// </summary>
            public const string chair_head_down = @"[grid3x]chair_head_down";
            /// <summary>
            /// Represents the [grid3x]chair_head_up symbol
            /// </summary>
            public const string chair_head_up = @"[grid3x]chair_head_up";
            /// <summary>
            /// Represents the [grid3x]chair_knees_down symbol
            /// </summary>
            public const string chair_knees_down = @"[grid3x]chair_knees_down";
            /// <summary>
            /// Represents the [grid3x]chair_knees_up symbol
            /// </summary>
            public const string chair_knees_up = @"[grid3x]chair_knees_up";
            /// <summary>
            /// Represents the [grid3x]chair_tilt_down symbol
            /// </summary>
            public const string chair_tilt_down = @"[grid3x]chair_tilt_down";
            /// <summary>
            /// Represents the [grid3x]chair_tilt_up symbol
            /// </summary>
            public const string chair_tilt_up = @"[grid3x]chair_tilt_up";
            /// <summary>
            /// Represents the [grid3x]chair_up symbol
            /// </summary>
            public const string chair_up = @"[grid3x]chair_up";
            /// <summary>
            /// Represents the [grid3x]chair symbol
            /// </summary>
            public const string chair = @"[grid3x]chair";
            /// <summary>
            /// Represents the [grid3x]change_user symbol
            /// </summary>
            public const string change_user = @"[grid3x]change_user";
            /// <summary>
            /// Represents the [grid3x]chat_1 symbol
            /// </summary>
            public const string chat_1 = @"[grid3x]chat_1";
            /// <summary>
            /// Represents the [grid3x]chat symbol
            /// </summary>
            public const string chat = @"[grid3x]chat";
            /// <summary>
            /// Represents the [grid3x]chevron_1_e symbol
            /// </summary>
            public const string chevron_1_e = @"[grid3x]chevron_1_e";
            /// <summary>
            /// Represents the [grid3x]chevron_1_n symbol
            /// </summary>
            public const string chevron_1_n = @"[grid3x]chevron_1_n";
            /// <summary>
            /// Represents the [grid3x]chevron_1_ne symbol
            /// </summary>
            public const string chevron_1_ne = @"[grid3x]chevron_1_ne";
            /// <summary>
            /// Represents the [grid3x]chevron_1_next symbol
            /// </summary>
            public const string chevron_1_next = @"[grid3x]chevron_1_next";
            /// <summary>
            /// Represents the [grid3x]chevron_1_nw symbol
            /// </summary>
            public const string chevron_1_nw = @"[grid3x]chevron_1_nw";
            /// <summary>
            /// Represents the [grid3x]chevron_1_previous symbol
            /// </summary>
            public const string chevron_1_previous = @"[grid3x]chevron_1_previous";
            /// <summary>
            /// Represents the [grid3x]chevron_1_s symbol
            /// </summary>
            public const string chevron_1_s = @"[grid3x]chevron_1_s";
            /// <summary>
            /// Represents the [grid3x]chevron_1_se symbol
            /// </summary>
            public const string chevron_1_se = @"[grid3x]chevron_1_se";
            /// <summary>
            /// Represents the [grid3x]chevron_1_sw symbol
            /// </summary>
            public const string chevron_1_sw = @"[grid3x]chevron_1_sw";
            /// <summary>
            /// Represents the [grid3x]chevron_1_w symbol
            /// </summary>
            public const string chevron_1_w = @"[grid3x]chevron_1_w";
            /// <summary>
            /// Represents the [grid3x]chevron_e symbol
            /// </summary>
            public const string chevron_e = @"[grid3x]chevron_e";
            /// <summary>
            /// Represents the [grid3x]chevron_n symbol
            /// </summary>
            public const string chevron_n = @"[grid3x]chevron_n";
            /// <summary>
            /// Represents the [grid3x]chevron_ne symbol
            /// </summary>
            public const string chevron_ne = @"[grid3x]chevron_ne";
            /// <summary>
            /// Represents the [grid3x]chevron_next symbol
            /// </summary>
            public const string chevron_next = @"[grid3x]chevron_next";
            /// <summary>
            /// Represents the [grid3x]chevron_nw symbol
            /// </summary>
            public const string chevron_nw = @"[grid3x]chevron_nw";
            /// <summary>
            /// Represents the [grid3x]chevron_previous symbol
            /// </summary>
            public const string chevron_previous = @"[grid3x]chevron_previous";
            /// <summary>
            /// Represents the [grid3x]chevron_s symbol
            /// </summary>
            public const string chevron_s = @"[grid3x]chevron_s";
            /// <summary>
            /// Represents the [grid3x]chevron_se symbol
            /// </summary>
            public const string chevron_se = @"[grid3x]chevron_se";
            /// <summary>
            /// Represents the [grid3x]chevron_sw symbol
            /// </summary>
            public const string chevron_sw = @"[grid3x]chevron_sw";
            /// <summary>
            /// Represents the [grid3x]chevron_w symbol
            /// </summary>
            public const string chevron_w = @"[grid3x]chevron_w";
            /// <summary>
            /// Represents the [grid3x]choice symbol
            /// </summary>
            public const string choice = @"[grid3x]choice";
            /// <summary>
            /// Represents the [grid3x]clear symbol
            /// </summary>
            public const string clear = @"[grid3x]clear";
            /// <summary>
            /// Represents the [grid3x]clear_off symbol
            /// </summary>
            public const string clear_off = @"[grid3x]clear_off";
            /// <summary>
            /// Represents the [grid3x]clock symbol
            /// </summary>
            public const string clock = @"[grid3x]clock";
            /// <summary>
            /// Represents the [grid3x]cloud symbol
            /// </summary>
            public const string cloud = @"[grid3x]cloud";
            /// <summary>
            /// Represents the [grid3x]cloud_concept symbol
            /// </summary>
            public const string cloud_concept = @"[grid3x]cloud_concept";
            /// <summary>
            /// Represents the [grid3x]coat_rack symbol
            /// </summary>
            public const string coat_rack = @"[grid3x]coat_rack";
            /// <summary>
            /// Represents the [grid3x]coffee_aeropress symbol
            /// </summary>
            public const string coffee_aeropress = @"[grid3x]coffee_aeropress";
            /// <summary>
            /// Represents the [grid3x]coffee_bean symbol
            /// </summary>
            public const string coffee_bean = @"[grid3x]coffee_bean";
            /// <summary>
            /// Represents the [grid3x]coffee_cleverdripper symbol
            /// </summary>
            public const string coffee_cleverdripper = @"[grid3x]coffee_cleverdripper";
            /// <summary>
            /// Represents the [grid3x]coffee_cup symbol
            /// </summary>
            public const string coffee_cup = @"[grid3x]coffee_cup";
            /// <summary>
            /// Represents the [grid3x]coffee_frenchpress symbol
            /// </summary>
            public const string coffee_frenchpress = @"[grid3x]coffee_frenchpress";
            /// <summary>
            /// Represents the [grid3x]coffee_v60 symbol
            /// </summary>
            public const string coffee_v60 = @"[grid3x]coffee_v60";
            /// <summary>
            /// Represents the [grid3x]colander symbol
            /// </summary>
            public const string colander = @"[grid3x]colander";
            /// <summary>
            /// Represents the [grid3x]colon symbol
            /// </summary>
            public const string colon = @"[grid3x]colon";
            /// <summary>
            /// Represents the [grid3x]comma symbol
            /// </summary>
            public const string comma = @"[grid3x]comma";
            /// <summary>
            /// Represents the [grid3x]compass symbol
            /// </summary>
            public const string compass = @"[grid3x]compass";
            /// <summary>
            /// Represents the [grid3x]computer_switch symbol
            /// </summary>
            public const string computer_switch = @"[grid3x]computer_switch";
            /// <summary>
            /// Represents the [grid3x]condiments symbol
            /// </summary>
            public const string condiments = @"[grid3x]condiments";
            /// <summary>
            /// Represents the [grid3x]contact symbol
            /// </summary>
            public const string contact = @"[grid3x]contact";
            /// <summary>
            /// Represents the [grid3x]contact_2 symbol
            /// </summary>
            public const string contact_2 = @"[grid3x]contact_2";
            /// <summary>
            /// Represents the [grid3x]contact_3 symbol
            /// </summary>
            public const string contact_3 = @"[grid3x]contact_3";
            /// <summary>
            /// Represents the [grid3x]contact_4 symbol
            /// </summary>
            public const string contact_4 = @"[grid3x]contact_4";
            /// <summary>
            /// Represents the [grid3x]contact_5 symbol
            /// </summary>
            public const string contact_5 = @"[grid3x]contact_5";
            /// <summary>
            /// Represents the [grid3x]contact_6 symbol
            /// </summary>
            public const string contact_6 = @"[grid3x]contact_6";
            /// <summary>
            /// Represents the [grid3x]contact_7 symbol
            /// </summary>
            public const string contact_7 = @"[grid3x]contact_7";
            /// <summary>
            /// Represents the [grid3x]contact_8 symbol
            /// </summary>
            public const string contact_8 = @"[grid3x]contact_8";
            /// <summary>
            /// Represents the [grid3x]contact_9 symbol
            /// </summary>
            public const string contact_9 = @"[grid3x]contact_9";
            /// <summary>
            /// Represents the [grid3x]contact_add symbol
            /// </summary>
            public const string contact_add = @"[grid3x]contact_add";
            /// <summary>
            /// Represents the [grid3x]contact_off symbol
            /// </summary>
            public const string contact_off = @"[grid3x]contact_off";
            /// <summary>
            /// Represents the [grid3x]control symbol
            /// </summary>
            public const string control = @"[grid3x]control";
            /// <summary>
            /// Represents the [grid3x]conversation symbol
            /// </summary>
            public const string conversation = @"[grid3x]conversation";
            /// <summary>
            /// Represents the [grid3x]copy symbol
            /// </summary>
            public const string copy = @"[grid3x]copy";
            /// <summary>
            /// Represents the [grid3x]cross symbol
            /// </summary>
            public const string cross = @"[grid3x]cross";
            /// <summary>
            /// Represents the [grid3x]cruiser_3 symbol
            /// </summary>
            public const string cruiser_3 = @"[grid3x]cruiser_3";
            /// <summary>
            /// Represents the [grid3x]crystal_ball symbol
            /// </summary>
            public const string crystal_ball = @"[grid3x]crystal_ball";
            /// <summary>
            /// Represents the [grid3x]curtain symbol
            /// </summary>
            public const string curtain = @"[grid3x]curtain";
            /// <summary>
            /// Represents the [grid3x]curtain_close symbol
            /// </summary>
            public const string curtain_close = @"[grid3x]curtain_close";
            /// <summary>
            /// Represents the [grid3x]curtain_open symbol
            /// </summary>
            public const string curtain_open = @"[grid3x]curtain_open";
            /// <summary>
            /// Represents the [grid3x]cut symbol
            /// </summary>
            public const string cut = @"[grid3x]cut";
            /// <summary>
            /// Represents the [grid3x]d symbol
            /// </summary>
            public const string d = @"[grid3x]d";
            /// <summary>
            /// Represents the [grid3x]d1 symbol
            /// </summary>
            public const string d1 = @"[grid3x]d1";
            /// <summary>
            /// Represents the [grid3x]datalog symbol
            /// </summary>
            public const string datalog = @"[grid3x]datalog";
            /// <summary>
            /// Represents the [grid3x]decimal symbol
            /// </summary>
            public const string decimal_ = @"[grid3x]decimal";
            /// <summary>
            /// Represents the [grid3x]delete_letter symbol
            /// </summary>
            public const string delete_letter = @"[grid3x]delete_letter";
            /// <summary>
            /// Represents the [grid3x]delete_space symbol
            /// </summary>
            public const string delete_space = @"[grid3x]delete_space";
            /// <summary>
            /// Represents the [grid3x]delete_symbol symbol
            /// </summary>
            public const string delete_symbol = @"[grid3x]delete_symbol";
            /// <summary>
            /// Represents the [grid3x]delete_word symbol
            /// </summary>
            public const string delete_word = @"[grid3x]delete_word";
            /// <summary>
            /// Represents the [grid3x]destroyer_2 symbol
            /// </summary>
            public const string destroyer_2 = @"[grid3x]destroyer_2";
            /// <summary>
            /// Represents the [grid3x]dica symbol
            /// </summary>
            public const string dica = @"[grid3x]dica";
            /// <summary>
            /// Represents the [grid3x]dicessi symbol
            /// </summary>
            public const string dicessi = @"[grid3x]dicessi";
            /// <summary>
            /// Represents the [grid3x]dicevo symbol
            /// </summary>
            public const string dicevo = @"[grid3x]dicevo";
            /// <summary>
            /// Represents the [grid3x]dico symbol
            /// </summary>
            public const string dico = @"[grid3x]dico";
            /// <summary>
            /// Represents the [grid3x]dictionary symbol
            /// </summary>
            public const string dictionary = @"[grid3x]dictionary";
            /// <summary>
            /// Represents the [grid3x]dictionary_cross symbol
            /// </summary>
            public const string dictionary_cross = @"[grid3x]dictionary_cross";
            /// <summary>
            /// Represents the [grid3x]dictionary_plus symbol
            /// </summary>
            public const string dictionary_plus = @"[grid3x]dictionary_plus";
            /// <summary>
            /// Represents the [grid3x]direi symbol
            /// </summary>
            public const string direi = @"[grid3x]direi";
            /// <summary>
            /// Represents the [grid3x]diro symbol
            /// </summary>
            public const string diro = @"[grid3x]diro";
            /// <summary>
            /// Represents the [grid3x]discard symbol
            /// </summary>
            public const string discard = @"[grid3x]discard";
            /// <summary>
            /// Represents the [grid3x]dissi symbol
            /// </summary>
            public const string dissi = @"[grid3x]dissi";
            /// <summary>
            /// Represents the [grid3x]divide symbol
            /// </summary>
            public const string divide = @"[grid3x]divide";
            /// <summary>
            /// Represents the [grid3x]dock_1 symbol
            /// </summary>
            public const string dock_1 = @"[grid3x]dock_1";
            /// <summary>
            /// Represents the [grid3x]dock symbol
            /// </summary>
            public const string dock = @"[grid3x]dock";
            /// <summary>
            /// Represents the [grid3x]document symbol
            /// </summary>
            public const string document = @"[grid3x]document";
            /// <summary>
            /// Represents the [grid3x]documents symbol
            /// </summary>
            public const string documents = @"[grid3x]documents";
            /// <summary>
            /// Represents the [grid3x]document_end symbol
            /// </summary>
            public const string document_end = @"[grid3x]document_end";
            /// <summary>
            /// Represents the [grid3x]document_start symbol
            /// </summary>
            public const string document_start = @"[grid3x]document_start";
            /// <summary>
            /// Represents the [grid3x]door symbol
            /// </summary>
            public const string door = @"[grid3x]door";
            /// <summary>
            /// Represents the [grid3x]door_close symbol
            /// </summary>
            public const string door_close = @"[grid3x]door_close";
            /// <summary>
            /// Represents the [grid3x]door_open symbol
            /// </summary>
            public const string door_open = @"[grid3x]door_open";
            /// <summary>
            /// Represents the [grid3x]door_open_1 symbol
            /// </summary>
            public const string door_open_1 = @"[grid3x]door_open_1";
            /// <summary>
            /// Represents the [grid3x]dot_blue symbol
            /// </summary>
            public const string dot_blue = @"[grid3x]dot_blue";
            /// <summary>
            /// Represents the [grid3x]dot_green symbol
            /// </summary>
            public const string dot_green = @"[grid3x]dot_green";
            /// <summary>
            /// Represents the [grid3x]dot_red symbol
            /// </summary>
            public const string dot_red = @"[grid3x]dot_red";
            /// <summary>
            /// Represents the [grid3x]dot_yellow symbol
            /// </summary>
            public const string dot_yellow = @"[grid3x]dot_yellow";
            /// <summary>
            /// Represents the [grid3x]dot symbol
            /// </summary>
            public const string dot = @"[grid3x]dot";
            /// <summary>
            /// Represents the [grid3x]drag_handle symbol
            /// </summary>
            public const string drag_handle = @"[grid3x]drag_handle";
            /// <summary>
            /// Represents the [grid3x]dvd symbol
            /// </summary>
            public const string dvd = @"[grid3x]dvd";
            /// <summary>
            /// Represents the [grid3x]dwell_minus symbol
            /// </summary>
            public const string dwell_minus = @"[grid3x]dwell_minus";
            /// <summary>
            /// Represents the [grid3x]dwell_plus symbol
            /// </summary>
            public const string dwell_plus = @"[grid3x]dwell_plus";
            /// <summary>
            /// Represents the [grid3x]e symbol
            /// </summary>
            public const string e = @"[grid3x]e";
            /// <summary>
            /// Represents the [grid3x]e1 symbol
            /// </summary>
            public const string e1 = @"[grid3x]e1";
            /// <summary>
            /// Represents the [grid3x]ear symbol
            /// </summary>
            public const string ear = @"[grid3x]ear";
            /// <summary>
            /// Represents the [grid3x]easywave symbol
            /// </summary>
            public const string easywave = @"[grid3x]easywave";
            /// <summary>
            /// Represents the [grid3x]ebbi_detto symbol
            /// </summary>
            public const string ebbi_detto = @"[grid3x]ebbi_detto";
            /// <summary>
            /// Represents the [grid3x]ecu symbol
            /// </summary>
            public const string ecu = @"[grid3x]ecu";
            /// <summary>
            /// Represents the [grid3x]edit_1 symbol
            /// </summary>
            public const string edit_1 = @"[grid3x]edit_1";
            /// <summary>
            /// Represents the [grid3x]edit symbol
            /// </summary>
            public const string edit = @"[grid3x]edit";
            /// <summary>
            /// Represents the [grid3x]eg_camera_distance symbol
            /// </summary>
            public const string eg_camera_distance = @"[grid3x]eg_camera_distance";
            /// <summary>
            /// Represents the [grid3x]eg_distance_indicator symbol
            /// </summary>
            public const string eg_distance_indicator = @"[grid3x]eg_distance_indicator";
            /// <summary>
            /// Represents the [grid3x]eg_eye_visibility symbol
            /// </summary>
            public const string eg_eye_visibility = @"[grid3x]eg_eye_visibility";
            /// <summary>
            /// Represents the [grid3x]eg_head_angle symbol
            /// </summary>
            public const string eg_head_angle = @"[grid3x]eg_head_angle";
            /// <summary>
            /// Represents the [grid3x]eg_speak_track_status symbol
            /// </summary>
            public const string eg_speak_track_status = @"[grid3x]eg_speak_track_status";
            /// <summary>
            /// Represents the [grid3x]eg_track_status_description symbol
            /// </summary>
            public const string eg_track_status_description = @"[grid3x]eg_track_status_description";
            /// <summary>
            /// Represents the [grid3x]elephant symbol
            /// </summary>
            public const string elephant = @"[grid3x]elephant";
            /// <summary>
            /// Represents the [grid3x]enter symbol
            /// </summary>
            public const string enter = @"[grid3x]enter";
            /// <summary>
            /// Represents the [grid3x]equals symbol
            /// </summary>
            public const string equals = @"[grid3x]equals";
            /// <summary>
            /// Represents the [grid3x]evoassist symbol
            /// </summary>
            public const string evoassist = @"[grid3x]evoassist";
            /// <summary>
            /// Represents the [grid3x]exclamation symbol
            /// </summary>
            public const string exclamation = @"[grid3x]exclamation";
            /// <summary>
            /// Represents the [grid3x]exit symbol
            /// </summary>
            public const string exit = @"[grid3x]exit";
            /// <summary>
            /// Represents the [grid3x]explorer_1 symbol
            /// </summary>
            public const string explorer_1 = @"[grid3x]explorer_1";
            /// <summary>
            /// Represents the [grid3x]explorer symbol
            /// </summary>
            public const string explorer = @"[grid3x]explorer";
            /// <summary>
            /// Represents the [grid3x]eye symbol
            /// </summary>
            public const string eye = @"[grid3x]eye";
            /// <summary>
            /// Represents the [grid3x]eyegaze_calibrate symbol
            /// </summary>
            public const string eyegaze_calibrate = @"[grid3x]eyegaze_calibrate";
            /// <summary>
            /// Represents the [grid3x]eyetech1 symbol
            /// </summary>
            public const string eyetech1 = @"[grid3x]eyetech1";
            /// <summary>
            /// Represents the [grid3x]eye_monitor symbol
            /// </summary>
            public const string eye_monitor = @"[grid3x]eye_monitor";
            /// <summary>
            /// Represents the [grid3x]f symbol
            /// </summary>
            public const string f = @"[grid3x]f";
            /// <summary>
            /// Represents the [grid3x]f1 symbol
            /// </summary>
            public const string f1 = @"[grid3x]f1";
            /// <summary>
            /// Represents the [grid3x]facebook_messenger symbol
            /// </summary>
            public const string facebook_messenger = @"[grid3x]facebook_messenger";
            /// <summary>
            /// Represents the [grid3x]facebook symbol
            /// </summary>
            public const string facebook = @"[grid3x]facebook";
            /// <summary>
            /// Represents the [grid3x]fan_off symbol
            /// </summary>
            public const string fan_off = @"[grid3x]fan_off";
            /// <summary>
            /// Represents the [grid3x]fan symbol
            /// </summary>
            public const string fan = @"[grid3x]fan";
            /// <summary>
            /// Represents the [grid3x]fastforward symbol
            /// </summary>
            public const string fastforward = @"[grid3x]fastforward";
            /// <summary>
            /// Represents the [grid3x]fast_talker symbol
            /// </summary>
            public const string fast_talker = @"[grid3x]fast_talker";
            /// <summary>
            /// Represents the [grid3x]fast_talker_new symbol
            /// </summary>
            public const string fast_talker_new = @"[grid3x]fast_talker_new";
            /// <summary>
            /// Represents the [grid3x]fast_type symbol
            /// </summary>
            public const string fast_type = @"[grid3x]fast_type";
            /// <summary>
            /// Represents the [grid3x]fast_type_cell symbol
            /// </summary>
            public const string fast_type_cell = @"[grid3x]fast_type_cell";
            /// <summary>
            /// Represents the [grid3x]female symbol
            /// </summary>
            public const string female = @"[grid3x]female";
            /// <summary>
            /// Represents the [grid3x]file symbol
            /// </summary>
            public const string file = @"[grid3x]file";
            /// <summary>
            /// Represents the [grid3x]file_dvd symbol
            /// </summary>
            public const string file_dvd = @"[grid3x]file_dvd";
            /// <summary>
            /// Represents the [grid3x]file_music symbol
            /// </summary>
            public const string file_music = @"[grid3x]file_music";
            /// <summary>
            /// Represents the [grid3x]file_photo symbol
            /// </summary>
            public const string file_photo = @"[grid3x]file_photo";
            /// <summary>
            /// Represents the [grid3x]file_recording symbol
            /// </summary>
            public const string file_recording = @"[grid3x]file_recording";
            /// <summary>
            /// Represents the [grid3x]file_video symbol
            /// </summary>
            public const string file_video = @"[grid3x]file_video";
            /// <summary>
            /// Represents the [grid3x]find symbol
            /// </summary>
            public const string find = @"[grid3x]find";
            /// <summary>
            /// Represents the [grid3x]find_window symbol
            /// </summary>
            public const string find_window = @"[grid3x]find_window";
            /// <summary>
            /// Represents the [grid3x]flag symbol
            /// </summary>
            public const string flag = @"[grid3x]flag";
            /// <summary>
            /// Represents the [grid3x]folder symbol
            /// </summary>
            public const string folder = @"[grid3x]folder";
            /// <summary>
            /// Represents the [grid3x]folder_camera symbol
            /// </summary>
            public const string folder_camera = @"[grid3x]folder_camera";
            /// <summary>
            /// Represents the [grid3x]folder_message symbol
            /// </summary>
            public const string folder_message = @"[grid3x]folder_message";
            /// <summary>
            /// Represents the [grid3x]folder_music symbol
            /// </summary>
            public const string folder_music = @"[grid3x]folder_music";
            /// <summary>
            /// Represents the [grid3x]folder_photos symbol
            /// </summary>
            public const string folder_photos = @"[grid3x]folder_photos";
            /// <summary>
            /// Represents the [grid3x]folder_recording symbol
            /// </summary>
            public const string folder_recording = @"[grid3x]folder_recording";
            /// <summary>
            /// Represents the [grid3x]folder_up symbol
            /// </summary>
            public const string folder_up = @"[grid3x]folder_up";
            /// <summary>
            /// Represents the [grid3x]folder_video symbol
            /// </summary>
            public const string folder_video = @"[grid3x]folder_video";
            /// <summary>
            /// Represents the [grid3x]forced_selection_order symbol
            /// </summary>
            public const string forced_selection_order = @"[grid3x]forced_selection_order";
            /// <summary>
            /// Represents the [grid3x]forced_selection_order_cell symbol
            /// </summary>
            public const string forced_selection_order_cell = @"[grid3x]forced_selection_order_cell";
            /// <summary>
            /// Represents the [grid3x]forward symbol
            /// </summary>
            public const string forward = @"[grid3x]forward";
            /// <summary>
            /// Represents the [grid3x]fullstop symbol
            /// </summary>
            public const string fullstop = @"[grid3x]fullstop";
            /// <summary>
            /// Represents the [grid3x]g symbol
            /// </summary>
            public const string g = @"[grid3x]g";
            /// <summary>
            /// Represents the [grid3x]g1 symbol
            /// </summary>
            public const string g1 = @"[grid3x]g1";
            /// <summary>
            /// Represents the [grid3x]g2 symbol
            /// </summary>
            public const string g2 = @"[grid3x]g2";
            /// <summary>
            /// Represents the [grid3x]gamepad symbol
            /// </summary>
            public const string gamepad = @"[grid3x]gamepad";
            /// <summary>
            /// Represents the [grid3x]gewa symbol
            /// </summary>
            public const string gewa = @"[grid3x]gewa";
            /// <summary>
            /// Represents the [grid3x]glide_directions symbol
            /// </summary>
            public const string glide_directions = @"[grid3x]glide_directions";
            /// <summary>
            /// Represents the [grid3x]glide_down symbol
            /// </summary>
            public const string glide_down = @"[grid3x]glide_down";
            /// <summary>
            /// Represents the [grid3x]glide_down_left symbol
            /// </summary>
            public const string glide_down_left = @"[grid3x]glide_down_left";
            /// <summary>
            /// Represents the [grid3x]glide_down_right symbol
            /// </summary>
            public const string glide_down_right = @"[grid3x]glide_down_right";
            /// <summary>
            /// Represents the [grid3x]glide_faster symbol
            /// </summary>
            public const string glide_faster = @"[grid3x]glide_faster";
            /// <summary>
            /// Represents the [grid3x]glide_left symbol
            /// </summary>
            public const string glide_left = @"[grid3x]glide_left";
            /// <summary>
            /// Represents the [grid3x]glide_radar symbol
            /// </summary>
            public const string glide_radar = @"[grid3x]glide_radar";
            /// <summary>
            /// Represents the [grid3x]glide_radar_2 symbol
            /// </summary>
            public const string glide_radar_2 = @"[grid3x]glide_radar_2";
            /// <summary>
            /// Represents the [grid3x]glide_radar_anticlockwise symbol
            /// </summary>
            public const string glide_radar_anticlockwise = @"[grid3x]glide_radar_anticlockwise";
            /// <summary>
            /// Represents the [grid3x]glide_radar_clockwise symbol
            /// </summary>
            public const string glide_radar_clockwise = @"[grid3x]glide_radar_clockwise";
            /// <summary>
            /// Represents the [grid3x]glide_right symbol
            /// </summary>
            public const string glide_right = @"[grid3x]glide_right";
            /// <summary>
            /// Represents the [grid3x]glide_slower symbol
            /// </summary>
            public const string glide_slower = @"[grid3x]glide_slower";
            /// <summary>
            /// Represents the [grid3x]glide_speed symbol
            /// </summary>
            public const string glide_speed = @"[grid3x]glide_speed";
            /// <summary>
            /// Represents the [grid3x]glide_up symbol
            /// </summary>
            public const string glide_up = @"[grid3x]glide_up";
            /// <summary>
            /// Represents the [grid3x]glide_up_left symbol
            /// </summary>
            public const string glide_up_left = @"[grid3x]glide_up_left";
            /// <summary>
            /// Represents the [grid3x]glide_up_right symbol
            /// </summary>
            public const string glide_up_right = @"[grid3x]glide_up_right";
            /// <summary>
            /// Represents the [grid3x]go_back symbol
            /// </summary>
            public const string go_back = @"[grid3x]go_back";
            /// <summary>
            /// Represents the [grid3x]grid3 symbol
            /// </summary>
            public const string grid3 = @"[grid3x]grid3";
            /// <summary>
            /// Represents the [grid3x]gridexplorer symbol
            /// </summary>
            public const string gridexplorer = @"[grid3x]gridexplorer";
            /// <summary>
            /// Represents the [grid3x]gridplayer symbol
            /// </summary>
            public const string gridplayer = @"[grid3x]gridplayer";
            /// <summary>
            /// Represents the [grid3x]grid_manual symbol
            /// </summary>
            public const string grid_manual = @"[grid3x]grid_manual";
            /// <summary>
            /// Represents the [grid3x]grid_to_screen symbol
            /// </summary>
            public const string grid_to_screen = @"[grid3x]grid_to_screen";
            /// <summary>
            /// Represents the [grid3x]grid_window symbol
            /// </summary>
            public const string grid_window = @"[grid3x]grid_window";
            /// <summary>
            /// Represents the [grid3x]grid_window_large symbol
            /// </summary>
            public const string grid_window_large = @"[grid3x]grid_window_large";
            /// <summary>
            /// Represents the [grid3x]grid_window_small symbol
            /// </summary>
            public const string grid_window_small = @"[grid3x]grid_window_small";
            /// <summary>
            /// Represents the [grid3x]guitar symbol
            /// </summary>
            public const string guitar = @"[grid3x]guitar";
            /// <summary>
            /// Represents the [grid3x]h symbol
            /// </summary>
            public const string h = @"[grid3x]h";
            /// <summary>
            /// Represents the [grid3x]h1 symbol
            /// </summary>
            public const string h1 = @"[grid3x]h1";
            /// <summary>
            /// Represents the [grid3x]hash symbol
            /// </summary>
            public const string hash = @"[grid3x]hash";
            /// <summary>
            /// Represents the [grid3x]heading_next symbol
            /// </summary>
            public const string heading_next = @"[grid3x]heading_next";
            /// <summary>
            /// Represents the [grid3x]heading_previous symbol
            /// </summary>
            public const string heading_previous = @"[grid3x]heading_previous";
            /// <summary>
            /// Represents the [grid3x]headphones symbol
            /// </summary>
            public const string headphones = @"[grid3x]headphones";
            /// <summary>
            /// Represents the [grid3x]headphones_0 symbol
            /// </summary>
            public const string headphones_0 = @"[grid3x]headphones_0";
            /// <summary>
            /// Represents the [grid3x]headphones_1 symbol
            /// </summary>
            public const string headphones_1 = @"[grid3x]headphones_1";
            /// <summary>
            /// Represents the [grid3x]headphones_2 symbol
            /// </summary>
            public const string headphones_2 = @"[grid3x]headphones_2";
            /// <summary>
            /// Represents the [grid3x]headphones_3 symbol
            /// </summary>
            public const string headphones_3 = @"[grid3x]headphones_3";
            /// <summary>
            /// Represents the [grid3x]headphones_minus symbol
            /// </summary>
            public const string headphones_minus = @"[grid3x]headphones_minus";
            /// <summary>
            /// Represents the [grid3x]headphones_off symbol
            /// </summary>
            public const string headphones_off = @"[grid3x]headphones_off";
            /// <summary>
            /// Represents the [grid3x]headphones_plus symbol
            /// </summary>
            public const string headphones_plus = @"[grid3x]headphones_plus";
            /// <summary>
            /// Represents the [grid3x]heart symbol
            /// </summary>
            public const string heart = @"[grid3x]heart";
            /// <summary>
            /// Represents the [grid3x]help symbol
            /// </summary>
            public const string help = @"[grid3x]help";
            /// <summary>
            /// Represents the [grid3x]hi_fi symbol
            /// </summary>
            public const string hi_fi = @"[grid3x]hi_fi";
            /// <summary>
            /// Represents the [grid3x]hide symbol
            /// </summary>
            public const string hide = @"[grid3x]hide";
            /// <summary>
            /// Represents the [grid3x]history symbol
            /// </summary>
            public const string history = @"[grid3x]history";
            /// <summary>
            /// Represents the [grid3x]history_off symbol
            /// </summary>
            public const string history_off = @"[grid3x]history_off";
            /// <summary>
            /// Represents the [grid3x]ho_detto symbol
            /// </summary>
            public const string ho_detto = @"[grid3x]ho_detto";
            /// <summary>
            /// Represents the [grid3x]home symbol
            /// </summary>
            public const string home = @"[grid3x]home";
            /// <summary>
            /// Represents the [grid3x]i symbol
            /// </summary>
            public const string i = @"[grid3x]i";
            /// <summary>
            /// Represents the [grid3x]i1 symbol
            /// </summary>
            public const string i1 = @"[grid3x]i1";
            /// <summary>
            /// Represents the [grid3x]i2 symbol
            /// </summary>
            public const string i2 = @"[grid3x]i2";
            /// <summary>
            /// Represents the [grid3x]imperative symbol
            /// </summary>
            public const string imperative = @"[grid3x]imperative";
            /// <summary>
            /// Represents the [grid3x]infinity symbol
            /// </summary>
            public const string infinity = @"[grid3x]infinity";
            /// <summary>
            /// Represents the [grid3x]information symbol
            /// </summary>
            public const string information = @"[grid3x]information";
            /// <summary>
            /// Represents the [grid3x]internet symbol
            /// </summary>
            public const string internet = @"[grid3x]internet";
            /// <summary>
            /// Represents the [grid3x]ios_share symbol
            /// </summary>
            public const string ios_share = @"[grid3x]ios_share";
            /// <summary>
            /// Represents the [grid3x]iphone symbol
            /// </summary>
            public const string iphone = @"[grid3x]iphone";
            /// <summary>
            /// Represents the [grid3x]iphone_1 symbol
            /// </summary>
            public const string iphone_1 = @"[grid3x]iphone_1";
            /// <summary>
            /// Represents the [grid3x]ipod symbol
            /// </summary>
            public const string ipod = @"[grid3x]ipod";
            /// <summary>
            /// Represents the [grid3x]irtrans symbol
            /// </summary>
            public const string irtrans = @"[grid3x]irtrans";
            /// <summary>
            /// Represents the [grid3x]ir_high symbol
            /// </summary>
            public const string ir_high = @"[grid3x]ir_high";
            /// <summary>
            /// Represents the [grid3x]ir_low symbol
            /// </summary>
            public const string ir_low = @"[grid3x]ir_low";
            /// <summary>
            /// Represents the [grid3x]itachflex symbol
            /// </summary>
            public const string itachflex = @"[grid3x]itachflex";
            /// <summary>
            /// Represents the [grid3x]italy symbol
            /// </summary>
            public const string italy = @"[grid3x]italy";
            /// <summary>
            /// Represents the [grid3x]j symbol
            /// </summary>
            public const string j = @"[grid3x]j";
            /// <summary>
            /// Represents the [grid3x]j1 symbol
            /// </summary>
            public const string j1 = @"[grid3x]j1";
            /// <summary>
            /// Represents the [grid3x]jump_back symbol
            /// </summary>
            public const string jump_back = @"[grid3x]jump_back";
            /// <summary>
            /// Represents the [grid3x]jump_forwards symbol
            /// </summary>
            public const string jump_forwards = @"[grid3x]jump_forwards";
            /// <summary>
            /// Represents the [grid3x]jump_home symbol
            /// </summary>
            public const string jump_home = @"[grid3x]jump_home";
            /// <summary>
            /// Represents the [grid3x]jump_selfclose symbol
            /// </summary>
            public const string jump_selfclose = @"[grid3x]jump_selfclose";
            /// <summary>
            /// Represents the [grid3x]jump_selfclose_off symbol
            /// </summary>
            public const string jump_selfclose_off = @"[grid3x]jump_selfclose_off";
            /// <summary>
            /// Represents the [grid3x]k symbol
            /// </summary>
            public const string k = @"[grid3x]k";
            /// <summary>
            /// Represents the [grid3x]k1 symbol
            /// </summary>
            public const string k1 = @"[grid3x]k1";
            /// <summary>
            /// Represents the [grid3x]keyboard_1 symbol
            /// </summary>
            public const string keyboard_1 = @"[grid3x]keyboard_1";
            /// <summary>
            /// Represents the [grid3x]keyboard symbol
            /// </summary>
            public const string keyboard = @"[grid3x]keyboard";
            /// <summary>
            /// Represents the [grid3x]keyboard_language symbol
            /// </summary>
            public const string keyboard_language = @"[grid3x]keyboard_language";
            /// <summary>
            /// Represents the [grid3x]keyboard_next symbol
            /// </summary>
            public const string keyboard_next = @"[grid3x]keyboard_next";
            /// <summary>
            /// Represents the [grid3x]keypad symbol
            /// </summary>
            public const string keypad = @"[grid3x]keypad";
            /// <summary>
            /// Represents the [grid3x]key_down symbol
            /// </summary>
            public const string key_down = @"[grid3x]key_down";
            /// <summary>
            /// Represents the [grid3x]key_press symbol
            /// </summary>
            public const string key_press = @"[grid3x]key_press";
            /// <summary>
            /// Represents the [grid3x]key_up symbol
            /// </summary>
            public const string key_up = @"[grid3x]key_up";
            /// <summary>
            /// Represents the [grid3x]knob symbol
            /// </summary>
            public const string knob = @"[grid3x]knob";
            /// <summary>
            /// Represents the [grid3x]l symbol
            /// </summary>
            public const string l = @"[grid3x]l";
            /// <summary>
            /// Represents the [grid3x]l1 symbol
            /// </summary>
            public const string l1 = @"[grid3x]l1";
            /// <summary>
            /// Represents the [grid3x]label symbol
            /// </summary>
            public const string label = @"[grid3x]label";
            /// <summary>
            /// Represents the [grid3x]lamp_off symbol
            /// </summary>
            public const string lamp_off = @"[grid3x]lamp_off";
            /// <summary>
            /// Represents the [grid3x]lamp symbol
            /// </summary>
            public const string lamp = @"[grid3x]lamp";
            /// <summary>
            /// Represents the [grid3x]laptop symbol
            /// </summary>
            public const string laptop = @"[grid3x]laptop";
            /// <summary>
            /// Represents the [grid3x]left symbol
            /// </summary>
            public const string left = @"[grid3x]left";
            /// <summary>
            /// Represents the [grid3x]letters symbol
            /// </summary>
            public const string letters = @"[grid3x]letters";
            /// <summary>
            /// Represents the [grid3x]light_bulb_2_off symbol
            /// </summary>
            public const string light_bulb_2_off = @"[grid3x]light_bulb_2_off";
            /// <summary>
            /// Represents the [grid3x]light_bulb_2 symbol
            /// </summary>
            public const string light_bulb_2 = @"[grid3x]light_bulb_2";
            /// <summary>
            /// Represents the [grid3x]light_bulb_off symbol
            /// </summary>
            public const string light_bulb_off = @"[grid3x]light_bulb_off";
            /// <summary>
            /// Represents the [grid3x]light_bulb symbol
            /// </summary>
            public const string light_bulb = @"[grid3x]light_bulb";
            /// <summary>
            /// Represents the [grid3x]like symbol
            /// </summary>
            public const string like = @"[grid3x]like";
            /// <summary>
            /// Represents the [grid3x]line symbol
            /// </summary>
            public const string line = @"[grid3x]line";
            /// <summary>
            /// Represents the [grid3x]line_diagonal_1 symbol
            /// </summary>
            public const string line_diagonal_1 = @"[grid3x]line_diagonal_1";
            /// <summary>
            /// Represents the [grid3x]line_diagonal_2 symbol
            /// </summary>
            public const string line_diagonal_2 = @"[grid3x]line_diagonal_2";
            /// <summary>
            /// Represents the [grid3x]line_end symbol
            /// </summary>
            public const string line_end = @"[grid3x]line_end";
            /// <summary>
            /// Represents the [grid3x]line_horizontal symbol
            /// </summary>
            public const string line_horizontal = @"[grid3x]line_horizontal";
            /// <summary>
            /// Represents the [grid3x]line_next symbol
            /// </summary>
            public const string line_next = @"[grid3x]line_next";
            /// <summary>
            /// Represents the [grid3x]line_previous symbol
            /// </summary>
            public const string line_previous = @"[grid3x]line_previous";
            /// <summary>
            /// Represents the [grid3x]line_start symbol
            /// </summary>
            public const string line_start = @"[grid3x]line_start";
            /// <summary>
            /// Represents the [grid3x]line_vertical symbol
            /// </summary>
            public const string line_vertical = @"[grid3x]line_vertical";
            /// <summary>
            /// Represents the [grid3x]link symbol
            /// </summary>
            public const string link = @"[grid3x]link";
            /// <summary>
            /// Represents the [grid3x]link_down symbol
            /// </summary>
            public const string link_down = @"[grid3x]link_down";
            /// <summary>
            /// Represents the [grid3x]link_left symbol
            /// </summary>
            public const string link_left = @"[grid3x]link_left";
            /// <summary>
            /// Represents the [grid3x]link_next symbol
            /// </summary>
            public const string link_next = @"[grid3x]link_next";
            /// <summary>
            /// Represents the [grid3x]link_previous symbol
            /// </summary>
            public const string link_previous = @"[grid3x]link_previous";
            /// <summary>
            /// Represents the [grid3x]link_right symbol
            /// </summary>
            public const string link_right = @"[grid3x]link_right";
            /// <summary>
            /// Represents the [grid3x]link_up symbol
            /// </summary>
            public const string link_up = @"[grid3x]link_up";
            /// <summary>
            /// Represents the [grid3x]lion symbol
            /// </summary>
            public const string lion = @"[grid3x]lion";
            /// <summary>
            /// Represents the [grid3x]live_list symbol
            /// </summary>
            public const string live_list = @"[grid3x]live_list";
            /// <summary>
            /// Represents the [grid3x]live_refresh symbol
            /// </summary>
            public const string live_refresh = @"[grid3x]live_refresh";
            /// <summary>
            /// Represents the [grid3x]loading_dots symbol
            /// </summary>
            public const string loading_dots = @"[grid3x]loading_dots";
            /// <summary>
            /// Represents the [grid3x]lock symbol
            /// </summary>
            public const string lock_on = @"[grid3x]lock";
            /// <summary>
            /// Represents the [grid3x]lock_off symbol
            /// </summary>
            public const string lock_off = @"[grid3x]lock_off";
            /// <summary>
            /// Represents the [grid3x]log_off symbol
            /// </summary>
            public const string log_off = @"[grid3x]log_off";
            /// <summary>
            /// Represents the [grid3x]m symbol
            /// </summary>
            public const string m = @"[grid3x]m";
            /// <summary>
            /// Represents the [grid3x]m1 symbol
            /// </summary>
            public const string m1 = @"[grid3x]m1";
            /// <summary>
            /// Represents the [grid3x]magic_wand symbol
            /// </summary>
            public const string magic_wand = @"[grid3x]magic_wand";
            /// <summary>
            /// Represents the [grid3x]mail_contact_message symbol
            /// </summary>
            public const string mail_contact_message = @"[grid3x]mail_contact_message";
            /// <summary>
            /// Represents the [grid3x]mail symbol
            /// </summary>
            public const string mail = @"[grid3x]mail";
            /// <summary>
            /// Represents the [grid3x]male symbol
            /// </summary>
            public const string male = @"[grid3x]male";
            /// <summary>
            /// Represents the [grid3x]male_aging symbol
            /// </summary>
            public const string male_aging = @"[grid3x]male_aging";
            /// <summary>
            /// Represents the [grid3x]materials symbol
            /// </summary>
            public const string materials = @"[grid3x]materials";
            /// <summary>
            /// Represents the [grid3x]maths symbol
            /// </summary>
            public const string maths = @"[grid3x]maths";
            /// <summary>
            /// Represents the [grid3x]meter_0 symbol
            /// </summary>
            public const string meter_0 = @"[grid3x]meter_0";
            /// <summary>
            /// Represents the [grid3x]meter_1 symbol
            /// </summary>
            public const string meter_1 = @"[grid3x]meter_1";
            /// <summary>
            /// Represents the [grid3x]meter_2 symbol
            /// </summary>
            public const string meter_2 = @"[grid3x]meter_2";
            /// <summary>
            /// Represents the [grid3x]meter_3 symbol
            /// </summary>
            public const string meter_3 = @"[grid3x]meter_3";
            /// <summary>
            /// Represents the [grid3x]meter_4 symbol
            /// </summary>
            public const string meter_4 = @"[grid3x]meter_4";
            /// <summary>
            /// Represents the [grid3x]mountain symbol
            /// </summary>
            public const string mountain = @"[grid3x]mountain";
            /// <summary>
            /// Represents the [grid3x]mouse_double_click symbol
            /// </summary>
            public const string mouse_double_click = @"[grid3x]mouse_double_click";
            /// <summary>
            /// Represents the [grid3x]mouse_double_middle_click symbol
            /// </summary>
            public const string mouse_double_middle_click = @"[grid3x]mouse_double_middle_click";
            /// <summary>
            /// Represents the [grid3x]mouse_double_right_click symbol
            /// </summary>
            public const string mouse_double_right_click = @"[grid3x]mouse_double_right_click";
            /// <summary>
            /// Represents the [grid3x]mouse_drag symbol
            /// </summary>
            public const string mouse_drag = @"[grid3x]mouse_drag";
            /// <summary>
            /// Represents the [grid3x]mouse_middle_drag symbol
            /// </summary>
            public const string mouse_middle_drag = @"[grid3x]mouse_middle_drag";
            /// <summary>
            /// Represents the [grid3x]mouse_move symbol
            /// </summary>
            public const string mouse_move = @"[grid3x]mouse_move";
            /// <summary>
            /// Represents the [grid3x]mouse_right_drag symbol
            /// </summary>
            public const string mouse_right_drag = @"[grid3x]mouse_right_drag";
            /// <summary>
            /// Represents the [grid3x]mouse_single_click symbol
            /// </summary>
            public const string mouse_single_click = @"[grid3x]mouse_single_click";
            /// <summary>
            /// Represents the [grid3x]mouse_single_middle_click symbol
            /// </summary>
            public const string mouse_single_middle_click = @"[grid3x]mouse_single_middle_click";
            /// <summary>
            /// Represents the [grid3x]mouse_single_right_click symbol
            /// </summary>
            public const string mouse_single_right_click = @"[grid3x]mouse_single_right_click";
            /// <summary>
            /// Represents the [grid3x]mouse_1 symbol
            /// </summary>
            public const string mouse_1 = @"[grid3x]mouse_1";
            /// <summary>
            /// Represents the [grid3x]mouse_double symbol
            /// </summary>
            public const string mouse_double = @"[grid3x]mouse_double";
            /// <summary>
            /// Represents the [grid3x]mouse_left symbol
            /// </summary>
            public const string mouse_left = @"[grid3x]mouse_left";
            /// <summary>
            /// Represents the [grid3x]mouse_middle symbol
            /// </summary>
            public const string mouse_middle = @"[grid3x]mouse_middle";
            /// <summary>
            /// Represents the [grid3x]mouse_pointer symbol
            /// </summary>
            public const string mouse_pointer = @"[grid3x]mouse_pointer";
            /// <summary>
            /// Represents the [grid3x]mouse_right symbol
            /// </summary>
            public const string mouse_right = @"[grid3x]mouse_right";
            /// <summary>
            /// Represents the [grid3x]mouse_to_screen symbol
            /// </summary>
            public const string mouse_to_screen = @"[grid3x]mouse_to_screen";
            /// <summary>
            /// Represents the [grid3x]mouse_wheel_down symbol
            /// </summary>
            public const string mouse_wheel_down = @"[grid3x]mouse_wheel_down";
            /// <summary>
            /// Represents the [grid3x]mouse_wheel_up symbol
            /// </summary>
            public const string mouse_wheel_up = @"[grid3x]mouse_wheel_up";
            /// <summary>
            /// Represents the [grid3x]mouse_window symbol
            /// </summary>
            public const string mouse_window = @"[grid3x]mouse_window";
            /// <summary>
            /// Represents the [grid3x]move_category symbol
            /// </summary>
            public const string move_category = @"[grid3x]move_category";
            /// <summary>
            /// Represents the [grid3x]move_down symbol
            /// </summary>
            public const string move_down = @"[grid3x]move_down";
            /// <summary>
            /// Represents the [grid3x]move_down_left symbol
            /// </summary>
            public const string move_down_left = @"[grid3x]move_down_left";
            /// <summary>
            /// Represents the [grid3x]move_down_right symbol
            /// </summary>
            public const string move_down_right = @"[grid3x]move_down_right";
            /// <summary>
            /// Represents the [grid3x]move_grid symbol
            /// </summary>
            public const string move_grid = @"[grid3x]move_grid";
            /// <summary>
            /// Represents the [grid3x]move_left symbol
            /// </summary>
            public const string move_left = @"[grid3x]move_left";
            /// <summary>
            /// Represents the [grid3x]move_right symbol
            /// </summary>
            public const string move_right = @"[grid3x]move_right";
            /// <summary>
            /// Represents the [grid3x]move_up symbol
            /// </summary>
            public const string move_up = @"[grid3x]move_up";
            /// <summary>
            /// Represents the [grid3x]move_up_left symbol
            /// </summary>
            public const string move_up_left = @"[grid3x]move_up_left";
            /// <summary>
            /// Represents the [grid3x]move_up_right symbol
            /// </summary>
            public const string move_up_right = @"[grid3x]move_up_right";
            /// <summary>
            /// Represents the [grid3x]multiply symbol
            /// </summary>
            public const string multiply = @"[grid3x]multiply";
            /// <summary>
            /// Represents the [grid3x]music_and_video symbol
            /// </summary>
            public const string music_and_video = @"[grid3x]music_and_video";
            /// <summary>
            /// Represents the [grid3x]music symbol
            /// </summary>
            public const string music = @"[grid3x]music";
            /// <summary>
            /// Represents the [grid3x]music_0 symbol
            /// </summary>
            public const string music_0 = @"[grid3x]music_0";
            /// <summary>
            /// Represents the [grid3x]music_1 symbol
            /// </summary>
            public const string music_1 = @"[grid3x]music_1";
            /// <summary>
            /// Represents the [grid3x]music_2 symbol
            /// </summary>
            public const string music_2 = @"[grid3x]music_2";
            /// <summary>
            /// Represents the [grid3x]music_3 symbol
            /// </summary>
            public const string music_3 = @"[grid3x]music_3";
            /// <summary>
            /// Represents the [grid3x]music_all symbol
            /// </summary>
            public const string music_all = @"[grid3x]music_all";
            /// <summary>
            /// Represents the [grid3x]music_minus symbol
            /// </summary>
            public const string music_minus = @"[grid3x]music_minus";
            /// <summary>
            /// Represents the [grid3x]music_off symbol
            /// </summary>
            public const string music_off = @"[grid3x]music_off";
            /// <summary>
            /// Represents the [grid3x]music_plus symbol
            /// </summary>
            public const string music_plus = @"[grid3x]music_plus";
            /// <summary>
            /// Represents the [grid3x]mute symbol
            /// </summary>
            public const string mute = @"[grid3x]mute";
            /// <summary>
            /// Represents the [grid3x]mymessage symbol
            /// </summary>
            public const string mymessage = @"[grid3x]mymessage";
            /// <summary>
            /// Represents the [grid3x]myworld symbol
            /// </summary>
            public const string myworld = @"[grid3x]myworld";
            /// <summary>
            /// Represents the [grid3x]n symbol
            /// </summary>
            public const string n = @"[grid3x]n";
            /// <summary>
            /// Represents the [grid3x]n1 symbol
            /// </summary>
            public const string n1 = @"[grid3x]n1";
            /// <summary>
            /// Represents the [grid3x]new symbol
            /// </summary>
            public const string new_ = @"[grid3x]new";
            /// <summary>
            /// Represents the [grid3x]new_folder symbol
            /// </summary>
            public const string new_folder = @"[grid3x]new_folder";
            /// <summary>
            /// Represents the [grid3x]next symbol
            /// </summary>
            public const string next = @"[grid3x]next";
            /// <summary>
            /// Represents the [grid3x]next_grid symbol
            /// </summary>
            public const string next_grid = @"[grid3x]next_grid";
            /// <summary>
            /// Represents the [grid3x]numbers symbol
            /// </summary>
            public const string numbers = @"[grid3x]numbers";
            /// <summary>
            /// Represents the [grid3x]o symbol
            /// </summary>
            public const string o = @"[grid3x]o";
            /// <summary>
            /// Represents the [grid3x]o1 symbol
            /// </summary>
            public const string o1 = @"[grid3x]o1";
            /// <summary>
            /// Represents the [grid3x]p symbol
            /// </summary>
            public const string p = @"[grid3x]p";
            /// <summary>
            /// Represents the [grid3x]p1 symbol
            /// </summary>
            public const string p1 = @"[grid3x]p1";
            /// <summary>
            /// Represents the [grid3x]page_complex symbol
            /// </summary>
            public const string page_complex = @"[grid3x]page_complex";
            /// <summary>
            /// Represents the [grid3x]page_simple symbol
            /// </summary>
            public const string page_simple = @"[grid3x]page_simple";
            /// <summary>
            /// Represents the [grid3x]paperclip_off symbol
            /// </summary>
            public const string paperclip_off = @"[grid3x]paperclip_off";
            /// <summary>
            /// Represents the [grid3x]paperclip symbol
            /// </summary>
            public const string paperclip = @"[grid3x]paperclip";
            /// <summary>
            /// Represents the [grid3x]paragraph symbol
            /// </summary>
            public const string paragraph = @"[grid3x]paragraph";
            /// <summary>
            /// Represents the [grid3x]paragraph_next symbol
            /// </summary>
            public const string paragraph_next = @"[grid3x]paragraph_next";
            /// <summary>
            /// Represents the [grid3x]paragraph_previous symbol
            /// </summary>
            public const string paragraph_previous = @"[grid3x]paragraph_previous";
            /// <summary>
            /// Represents the [grid3x]parlaconme symbol
            /// </summary>
            public const string parlaconme = @"[grid3x]parlaconme";
            /// <summary>
            /// Represents the [grid3x]partner_display_off symbol
            /// </summary>
            public const string partner_display_off = @"[grid3x]partner_display_off";
            /// <summary>
            /// Represents the [grid3x]partner_display_on symbol
            /// </summary>
            public const string partner_display_on = @"[grid3x]partner_display_on";
            /// <summary>
            /// Represents the [grid3x]party symbol
            /// </summary>
            public const string party = @"[grid3x]party";
            /// <summary>
            /// Represents the [grid3x]paste symbol
            /// </summary>
            public const string paste = @"[grid3x]paste";
            /// <summary>
            /// Represents the [grid3x]pause symbol
            /// </summary>
            public const string pause = @"[grid3x]pause";
            /// <summary>
            /// Represents the [grid3x]phone_1 symbol
            /// </summary>
            public const string phone_1 = @"[grid3x]phone_1";
            /// <summary>
            /// Represents the [grid3x]phone_contact_message symbol
            /// </summary>
            public const string phone_contact_message = @"[grid3x]phone_contact_message";
            /// <summary>
            /// Represents the [grid3x]phone_contact symbol
            /// </summary>
            public const string phone_contact = @"[grid3x]phone_contact";
            /// <summary>
            /// Represents the [grid3x]phone symbol
            /// </summary>
            public const string phone = @"[grid3x]phone";
            /// <summary>
            /// Represents the [grid3x]phone_down symbol
            /// </summary>
            public const string phone_down = @"[grid3x]phone_down";
            /// <summary>
            /// Represents the [grid3x]phone_ring symbol
            /// </summary>
            public const string phone_ring = @"[grid3x]phone_ring";
            /// <summary>
            /// Represents the [grid3x]phone_ring_1 symbol
            /// </summary>
            public const string phone_ring_1 = @"[grid3x]phone_ring_1";
            /// <summary>
            /// Represents the [grid3x]phone_speaker symbol
            /// </summary>
            public const string phone_speaker = @"[grid3x]phone_speaker";
            /// <summary>
            /// Represents the [grid3x]phone_speaker_off symbol
            /// </summary>
            public const string phone_speaker_off = @"[grid3x]phone_speaker_off";
            /// <summary>
            /// Represents the [grid3x]phone_up symbol
            /// </summary>
            public const string phone_up = @"[grid3x]phone_up";
            /// <summary>
            /// Represents the [grid3x]phone_up_1 symbol
            /// </summary>
            public const string phone_up_1 = @"[grid3x]phone_up_1";
            /// <summary>
            /// Represents the [grid3x]phonics_for_all symbol
            /// </summary>
            public const string phonics_for_all = @"[grid3x]phonics_for_all";
            /// <summary>
            /// Represents the [grid3x]photo symbol
            /// </summary>
            public const string photo = @"[grid3x]photo";
            /// <summary>
            /// Represents the [grid3x]photos symbol
            /// </summary>
            public const string photos = @"[grid3x]photos";
            /// <summary>
            /// Represents the [grid3x]photo_off symbol
            /// </summary>
            public const string photo_off = @"[grid3x]photo_off";
            /// <summary>
            /// Represents the [grid3x]pie symbol
            /// </summary>
            public const string pie = @"[grid3x]pie";
            /// <summary>
            /// Represents the [grid3x]pin symbol
            /// </summary>
            public const string pin = @"[grid3x]pin";
            /// <summary>
            /// Represents the [grid3x]place symbol
            /// </summary>
            public const string place = @"[grid3x]place";
            /// <summary>
            /// Represents the [grid3x]play symbol
            /// </summary>
            public const string play = @"[grid3x]play";
            /// <summary>
            /// Represents the [grid3x]playlist symbol
            /// </summary>
            public const string playlist = @"[grid3x]playlist";
            /// <summary>
            /// Represents the [grid3x]play_pause symbol
            /// </summary>
            public const string play_pause = @"[grid3x]play_pause";
            /// <summary>
            /// Represents the [grid3x]plug_off symbol
            /// </summary>
            public const string plug_off = @"[grid3x]plug_off";
            /// <summary>
            /// Represents the [grid3x]plug symbol
            /// </summary>
            public const string plug = @"[grid3x]plug";
            /// <summary>
            /// Represents the [grid3x]plus_minus symbol
            /// </summary>
            public const string plus_minus = @"[grid3x]plus_minus";
            /// <summary>
            /// Represents the [grid3x]plus_s symbol
            /// </summary>
            public const string plus_s = @"[grid3x]plus_s";
            /// <summary>
            /// Represents the [grid3x]plus_t symbol
            /// </summary>
            public const string plus_t = @"[grid3x]plus_t";
            /// <summary>
            /// Represents the [grid3x]podd symbol
            /// </summary>
            public const string podd = @"[grid3x]podd";
            /// <summary>
            /// Represents the [grid3x]pointer_down symbol
            /// </summary>
            public const string pointer_down = @"[grid3x]pointer_down";
            /// <summary>
            /// Represents the [grid3x]pointer_left symbol
            /// </summary>
            public const string pointer_left = @"[grid3x]pointer_left";
            /// <summary>
            /// Represents the [grid3x]pointer_right symbol
            /// </summary>
            public const string pointer_right = @"[grid3x]pointer_right";
            /// <summary>
            /// Represents the [grid3x]pointer_up symbol
            /// </summary>
            public const string pointer_up = @"[grid3x]pointer_up";
            /// <summary>
            /// Represents the [grid3x]predict symbol
            /// </summary>
            public const string predict = @"[grid3x]predict";
            /// <summary>
            /// Represents the [grid3x]predict_dictionary symbol
            /// </summary>
            public const string predict_dictionary = @"[grid3x]predict_dictionary";
            /// <summary>
            /// Represents the [grid3x]predict_phonetic symbol
            /// </summary>
            public const string predict_phonetic = @"[grid3x]predict_phonetic";
            /// <summary>
            /// Represents the [grid3x]predict_pictures symbol
            /// </summary>
            public const string predict_pictures = @"[grid3x]predict_pictures";
            /// <summary>
            /// Represents the [grid3x]predict_spelling symbol
            /// </summary>
            public const string predict_spelling = @"[grid3x]predict_spelling";
            /// <summary>
            /// Represents the [grid3x]predict_text symbol
            /// </summary>
            public const string predict_text = @"[grid3x]predict_text";
            /// <summary>
            /// Represents the [grid3x]predict_wordlist symbol
            /// </summary>
            public const string predict_wordlist = @"[grid3x]predict_wordlist";
            /// <summary>
            /// Represents the [grid3x]previous symbol
            /// </summary>
            public const string previous = @"[grid3x]previous";
            /// <summary>
            /// Represents the [grid3x]previous_grid symbol
            /// </summary>
            public const string previous_grid = @"[grid3x]previous_grid";
            /// <summary>
            /// Represents the [grid3x]print_1 symbol
            /// </summary>
            public const string print_1 = @"[grid3x]print_1";
            /// <summary>
            /// Represents the [grid3x]print symbol
            /// </summary>
            public const string print = @"[grid3x]print";
            /// <summary>
            /// Represents the [grid3x]punctuation symbol
            /// </summary>
            public const string punctuation = @"[grid3x]punctuation";
            /// <summary>
            /// Represents the [grid3x]q symbol
            /// </summary>
            public const string q = @"[grid3x]q";
            /// <summary>
            /// Represents the [grid3x]q1 symbol
            /// </summary>
            public const string q1 = @"[grid3x]q1";
            /// <summary>
            /// Represents the [grid3x]queen symbol
            /// </summary>
            public const string queen = @"[grid3x]queen";
            /// <summary>
            /// Represents the [grid3x]question symbol
            /// </summary>
            public const string question = @"[grid3x]question";
            /// <summary>
            /// Represents the [grid3x]quill symbol
            /// </summary>
            public const string quill = @"[grid3x]quill";
            /// <summary>
            /// Represents the [grid3x]r symbol
            /// </summary>
            public const string r = @"[grid3x]r";
            /// <summary>
            /// Represents the [grid3x]r1 symbol
            /// </summary>
            public const string r1 = @"[grid3x]r1";
            /// <summary>
            /// Represents the [grid3x]rabbit symbol
            /// </summary>
            public const string rabbit = @"[grid3x]rabbit";
            /// <summary>
            /// Represents the [grid3x]radar_down_anticlockwise symbol
            /// </summary>
            public const string radar_down_anticlockwise = @"[grid3x]radar_down_anticlockwise";
            /// <summary>
            /// Represents the [grid3x]radar_down_clockwise symbol
            /// </summary>
            public const string radar_down_clockwise = @"[grid3x]radar_down_clockwise";
            /// <summary>
            /// Represents the [grid3x]radar_left_anticlockwise symbol
            /// </summary>
            public const string radar_left_anticlockwise = @"[grid3x]radar_left_anticlockwise";
            /// <summary>
            /// Represents the [grid3x]radar_left_clockwise symbol
            /// </summary>
            public const string radar_left_clockwise = @"[grid3x]radar_left_clockwise";
            /// <summary>
            /// Represents the [grid3x]radar_right_anticlockwise symbol
            /// </summary>
            public const string radar_right_anticlockwise = @"[grid3x]radar_right_anticlockwise";
            /// <summary>
            /// Represents the [grid3x]radar_right_clockwise symbol
            /// </summary>
            public const string radar_right_clockwise = @"[grid3x]radar_right_clockwise";
            /// <summary>
            /// Represents the [grid3x]radar_up_anticlockwise symbol
            /// </summary>
            public const string radar_up_anticlockwise = @"[grid3x]radar_up_anticlockwise";
            /// <summary>
            /// Represents the [grid3x]radar_up_clockwise symbol
            /// </summary>
            public const string radar_up_clockwise = @"[grid3x]radar_up_clockwise";
            /// <summary>
            /// Represents the [grid3x]radiator symbol
            /// </summary>
            public const string radiator = @"[grid3x]radiator";
            /// <summary>
            /// Represents the [grid3x]radio symbol
            /// </summary>
            public const string radio = @"[grid3x]radio";
            /// <summary>
            /// Represents the [grid3x]record symbol
            /// </summary>
            public const string record = @"[grid3x]record";
            /// <summary>
            /// Represents the [grid3x]recording symbol
            /// </summary>
            public const string recording = @"[grid3x]recording";
            /// <summary>
            /// Represents the [grid3x]redo symbol
            /// </summary>
            public const string redo = @"[grid3x]redo";
            /// <summary>
            /// Represents the [grid3x]refresh symbol
            /// </summary>
            public const string refresh = @"[grid3x]refresh";
            /// <summary>
            /// Represents the [grid3x]remote symbol
            /// </summary>
            public const string remote = @"[grid3x]remote";
            /// <summary>
            /// Represents the [grid3x]remote_editing symbol
            /// </summary>
            public const string remote_editing = @"[grid3x]remote_editing";
            /// <summary>
            /// Represents the [grid3x]repeat symbol
            /// </summary>
            public const string repeat = @"[grid3x]repeat";
            /// <summary>
            /// Represents the [grid3x]reply_2 symbol
            /// </summary>
            public const string reply_2 = @"[grid3x]reply_2";
            /// <summary>
            /// Represents the [grid3x]reply_all symbol
            /// </summary>
            public const string reply_all = @"[grid3x]reply_all";
            /// <summary>
            /// Represents the [grid3x]reply symbol
            /// </summary>
            public const string reply = @"[grid3x]reply";
            /// <summary>
            /// Represents the [grid3x]reset_cell symbol
            /// </summary>
            public const string reset_cell = @"[grid3x]reset_cell";
            /// <summary>
            /// Represents the [grid3x]rest symbol
            /// </summary>
            public const string rest = @"[grid3x]rest";
            /// <summary>
            /// Represents the [grid3x]restart symbol
            /// </summary>
            public const string restart = @"[grid3x]restart";
            /// <summary>
            /// Represents the [grid3x]restart_1 symbol
            /// </summary>
            public const string restart_1 = @"[grid3x]restart_1";
            /// <summary>
            /// Represents the [grid3x]rest_eyegaze symbol
            /// </summary>
            public const string rest_eyegaze = @"[grid3x]rest_eyegaze";
            /// <summary>
            /// Represents the [grid3x]rest_mouse symbol
            /// </summary>
            public const string rest_mouse = @"[grid3x]rest_mouse";
            /// <summary>
            /// Represents the [grid3x]rest_pointer symbol
            /// </summary>
            public const string rest_pointer = @"[grid3x]rest_pointer";
            /// <summary>
            /// Represents the [grid3x]rest_switch symbol
            /// </summary>
            public const string rest_switch = @"[grid3x]rest_switch";
            /// <summary>
            /// Represents the [grid3x]rest_touch symbol
            /// </summary>
            public const string rest_touch = @"[grid3x]rest_touch";
            /// <summary>
            /// Represents the [grid3x]rest_voice symbol
            /// </summary>
            public const string rest_voice = @"[grid3x]rest_voice";
            /// <summary>
            /// Represents the [grid3x]rewind symbol
            /// </summary>
            public const string rewind = @"[grid3x]rewind";
            /// <summary>
            /// Represents the [grid3x]rotate_anticlockwise symbol
            /// </summary>
            public const string rotate_anticlockwise = @"[grid3x]rotate_anticlockwise";
            /// <summary>
            /// Represents the [grid3x]rotate_clockwise symbol
            /// </summary>
            public const string rotate_clockwise = @"[grid3x]rotate_clockwise";
            /// <summary>
            /// Represents the [grid3x]run symbol
            /// </summary>
            public const string run = @"[grid3x]run";
            /// <summary>
            /// Represents the [grid3x]s symbol
            /// </summary>
            public const string s = @"[grid3x]s";
            /// <summary>
            /// Represents the [grid3x]s1 symbol
            /// </summary>
            public const string s1 = @"[grid3x]s1";
            /// <summary>
            /// Represents the [grid3x]salt_shaker symbol
            /// </summary>
            public const string salt_shaker = @"[grid3x]salt_shaker";
            /// <summary>
            /// Represents the [grid3x]save_1 symbol
            /// </summary>
            public const string save_1 = @"[grid3x]save_1";
            /// <summary>
            /// Represents the [grid3x]screen symbol
            /// </summary>
            public const string screen = @"[grid3x]screen";
            /// <summary>
            /// Represents the [grid3x]screens symbol
            /// </summary>
            public const string screens = @"[grid3x]screens";
            /// <summary>
            /// Represents the [grid3x]screens_next symbol
            /// </summary>
            public const string screens_next = @"[grid3x]screens_next";
            /// <summary>
            /// Represents the [grid3x]screen_bottom symbol
            /// </summary>
            public const string screen_bottom = @"[grid3x]screen_bottom";
            /// <summary>
            /// Represents the [grid3x]screen_bottom_left symbol
            /// </summary>
            public const string screen_bottom_left = @"[grid3x]screen_bottom_left";
            /// <summary>
            /// Represents the [grid3x]screen_bottom_right symbol
            /// </summary>
            public const string screen_bottom_right = @"[grid3x]screen_bottom_right";
            /// <summary>
            /// Represents the [grid3x]screen_centre symbol
            /// </summary>
            public const string screen_centre = @"[grid3x]screen_centre";
            /// <summary>
            /// Represents the [grid3x]screen_left symbol
            /// </summary>
            public const string screen_left = @"[grid3x]screen_left";
            /// <summary>
            /// Represents the [grid3x]screen_off symbol
            /// </summary>
            public const string screen_off = @"[grid3x]screen_off";
            /// <summary>
            /// Represents the [grid3x]screen_off_1 symbol
            /// </summary>
            public const string screen_off_1 = @"[grid3x]screen_off_1";
            /// <summary>
            /// Represents the [grid3x]screen_right symbol
            /// </summary>
            public const string screen_right = @"[grid3x]screen_right";
            /// <summary>
            /// Represents the [grid3x]screen_top symbol
            /// </summary>
            public const string screen_top = @"[grid3x]screen_top";
            /// <summary>
            /// Represents the [grid3x]screen_top_left symbol
            /// </summary>
            public const string screen_top_left = @"[grid3x]screen_top_left";
            /// <summary>
            /// Represents the [grid3x]screen_top_right symbol
            /// </summary>
            public const string screen_top_right = @"[grid3x]screen_top_right";
            /// <summary>
            /// Represents the [grid3x]second_screen_symbols_off symbol
            /// </summary>
            public const string second_screen_symbols_off = @"[grid3x]second_screen_symbols_off";
            /// <summary>
            /// Represents the [grid3x]second_screen_symbols_on symbol
            /// </summary>
            public const string second_screen_symbols_on = @"[grid3x]second_screen_symbols_on";
            /// <summary>
            /// Represents the [grid3x]select symbol
            /// </summary>
            public const string select = @"[grid3x]select";
            /// <summary>
            /// Represents the [grid3x]select_all symbol
            /// </summary>
            public const string select_all = @"[grid3x]select_all";
            /// <summary>
            /// Represents the [grid3x]semicolon symbol
            /// </summary>
            public const string semicolon = @"[grid3x]semicolon";
            /// <summary>
            /// Represents the [grid3x]send symbol
            /// </summary>
            public const string send = @"[grid3x]send";
            /// <summary>
            /// Represents the [grid3x]sentence symbol
            /// </summary>
            public const string sentence = @"[grid3x]sentence";
            /// <summary>
            /// Represents the [grid3x]sentence_next symbol
            /// </summary>
            public const string sentence_next = @"[grid3x]sentence_next";
            /// <summary>
            /// Represents the [grid3x]sentence_previous symbol
            /// </summary>
            public const string sentence_previous = @"[grid3x]sentence_previous";
            /// <summary>
            /// Represents the [grid3x]servus symbol
            /// </summary>
            public const string servus = @"[grid3x]servus";
            /// <summary>
            /// Represents the [grid3x]settings_1 symbol
            /// </summary>
            public const string settings_1 = @"[grid3x]settings_1";
            /// <summary>
            /// Represents the [grid3x]settings_2 symbol
            /// </summary>
            public const string settings_2 = @"[grid3x]settings_2";
            /// <summary>
            /// Represents the [grid3x]settings symbol
            /// </summary>
            public const string settings = @"[grid3x]settings";
            /// <summary>
            /// Represents the [grid3x]set_home symbol
            /// </summary>
            public const string set_home = @"[grid3x]set_home";
            /// <summary>
            /// Represents the [grid3x]share_1 symbol
            /// </summary>
            public const string share_1 = @"[grid3x]share_1";
            /// <summary>
            /// Represents the [grid3x]share symbol
            /// </summary>
            public const string share = @"[grid3x]share";
            /// <summary>
            /// Represents the [grid3x]shift symbol
            /// </summary>
            public const string shift = @"[grid3x]shift";
            /// <summary>
            /// Represents the [grid3x]show_desktop symbol
            /// </summary>
            public const string show_desktop = @"[grid3x]show_desktop";
            /// <summary>
            /// Represents the [grid3x]shuffle symbol
            /// </summary>
            public const string shuffle = @"[grid3x]shuffle";
            /// <summary>
            /// Represents the [grid3x]shutdown symbol
            /// </summary>
            public const string shutdown = @"[grid3x]shutdown";
            /// <summary>
            /// Represents the [grid3x]single_activation symbol
            /// </summary>
            public const string single_activation = @"[grid3x]single_activation";
            /// <summary>
            /// Represents the [grid3x]single_activation_cell symbol
            /// </summary>
            public const string single_activation_cell = @"[grid3x]single_activation_cell";
            /// <summary>
            /// Represents the [grid3x]skype symbol
            /// </summary>
            public const string skype = @"[grid3x]skype";
            /// <summary>
            /// Represents the [grid3x]slideshow symbol
            /// </summary>
            public const string slideshow = @"[grid3x]slideshow";
            /// <summary>
            /// Represents the [grid3x]slowmeter symbol
            /// </summary>
            public const string slowmeter = @"[grid3x]slowmeter";
            /// <summary>
            /// Represents the [grid3x]sms_message symbol
            /// </summary>
            public const string sms_message = @"[grid3x]sms_message";
            /// <summary>
            /// Represents the [grid3x]sms_message_off symbol
            /// </summary>
            public const string sms_message_off = @"[grid3x]sms_message_off";
            /// <summary>
            /// Represents the [grid3x]sofa symbol
            /// </summary>
            public const string sofa = @"[grid3x]sofa";
            /// <summary>
            /// Represents the [grid3x]space symbol
            /// </summary>
            public const string space = @"[grid3x]space";
            /// <summary>
            /// Represents the [grid3x]speaker symbol
            /// </summary>
            public const string speaker = @"[grid3x]speaker";
            /// <summary>
            /// Represents the [grid3x]speaker_0 symbol
            /// </summary>
            public const string speaker_0 = @"[grid3x]speaker_0";
            /// <summary>
            /// Represents the [grid3x]speaker_1 symbol
            /// </summary>
            public const string speaker_1 = @"[grid3x]speaker_1";
            /// <summary>
            /// Represents the [grid3x]speaker_2 symbol
            /// </summary>
            public const string speaker_2 = @"[grid3x]speaker_2";
            /// <summary>
            /// Represents the [grid3x]speaker_3 symbol
            /// </summary>
            public const string speaker_3 = @"[grid3x]speaker_3";
            /// <summary>
            /// Represents the [grid3x]speaker_minus symbol
            /// </summary>
            public const string speaker_minus = @"[grid3x]speaker_minus";
            /// <summary>
            /// Represents the [grid3x]speaker_mute symbol
            /// </summary>
            public const string speaker_mute = @"[grid3x]speaker_mute";
            /// <summary>
            /// Represents the [grid3x]speaker_plus symbol
            /// </summary>
            public const string speaker_plus = @"[grid3x]speaker_plus";
            /// <summary>
            /// Represents the [grid3x]speakunique_logo symbol
            /// </summary>
            public const string speakunique_logo = @"[grid3x]speakunique_logo";
            /// <summary>
            /// Represents the [grid3x]speak_all symbol
            /// </summary>
            public const string speak_all = @"[grid3x]speak_all";
            /// <summary>
            /// Represents the [grid3x]speak_as_you_type symbol
            /// </summary>
            public const string speak_as_you_type = @"[grid3x]speak_as_you_type";
            /// <summary>
            /// Represents the [grid3x]speak_as_you_type_off symbol
            /// </summary>
            public const string speak_as_you_type_off = @"[grid3x]speak_as_you_type_off";
            /// <summary>
            /// Represents the [grid3x]speak_cell symbol
            /// </summary>
            public const string speak_cell = @"[grid3x]speak_cell";
            /// <summary>
            /// Represents the [grid3x]speak_clipboard symbol
            /// </summary>
            public const string speak_clipboard = @"[grid3x]speak_clipboard";
            /// <summary>
            /// Represents the [grid3x]speak_date symbol
            /// </summary>
            public const string speak_date = @"[grid3x]speak_date";
            /// <summary>
            /// Represents the [grid3x]speak_exclamation symbol
            /// </summary>
            public const string speak_exclamation = @"[grid3x]speak_exclamation";
            /// <summary>
            /// Represents the [grid3x]speak_paragraph symbol
            /// </summary>
            public const string speak_paragraph = @"[grid3x]speak_paragraph";
            /// <summary>
            /// Represents the [grid3x]speak_paragraph_1 symbol
            /// </summary>
            public const string speak_paragraph_1 = @"[grid3x]speak_paragraph_1";
            /// <summary>
            /// Represents the [grid3x]speak_question symbol
            /// </summary>
            public const string speak_question = @"[grid3x]speak_question";
            /// <summary>
            /// Represents the [grid3x]speak_selection symbol
            /// </summary>
            public const string speak_selection = @"[grid3x]speak_selection";
            /// <summary>
            /// Represents the [grid3x]speak_sentence symbol
            /// </summary>
            public const string speak_sentence = @"[grid3x]speak_sentence";
            /// <summary>
            /// Represents the [grid3x]speak_stop symbol
            /// </summary>
            public const string speak_stop = @"[grid3x]speak_stop";
            /// <summary>
            /// Represents the [grid3x]speak_time symbol
            /// </summary>
            public const string speak_time = @"[grid3x]speak_time";
            /// <summary>
            /// Represents the [grid3x]speak_word symbol
            /// </summary>
            public const string speak_word = @"[grid3x]speak_word";
            /// <summary>
            /// Represents the [grid3x]standby symbol
            /// </summary>
            public const string standby = @"[grid3x]standby";
            /// <summary>
            /// Represents the [grid3x]star_1 symbol
            /// </summary>
            public const string star_1 = @"[grid3x]star_1";
            /// <summary>
            /// Represents the [grid3x]star symbol
            /// </summary>
            public const string star = @"[grid3x]star";
            /// <summary>
            /// Represents the [grid3x]start_program symbol
            /// </summary>
            public const string start_program = @"[grid3x]start_program";
            /// <summary>
            /// Represents the [grid3x]star_off symbol
            /// </summary>
            public const string star_off = @"[grid3x]star_off";
            /// <summary>
            /// Represents the [grid3x]stop symbol
            /// </summary>
            public const string stop = @"[grid3x]stop";
            /// <summary>
            /// Represents the [grid3x]stop_1 symbol
            /// </summary>
            public const string stop_1 = @"[grid3x]stop_1";
            /// <summary>
            /// Represents the [grid3x]style_bold symbol
            /// </summary>
            public const string style_bold = @"[grid3x]style_bold";
            /// <summary>
            /// Represents the [grid3x]style_italic symbol
            /// </summary>
            public const string style_italic = @"[grid3x]style_italic";
            /// <summary>
            /// Represents the [grid3x]style_underline symbol
            /// </summary>
            public const string style_underline = @"[grid3x]style_underline";
            /// <summary>
            /// Represents the [grid3x]submarine_3 symbol
            /// </summary>
            public const string submarine_3 = @"[grid3x]submarine_3";
            /// <summary>
            /// Represents the [grid3x]subtract symbol
            /// </summary>
            public const string subtract = @"[grid3x]subtract";
            /// <summary>
            /// Represents the [grid3x]super_core symbol
            /// </summary>
            public const string super_core = @"[grid3x]super_core";
            /// <summary>
            /// Represents the [grid3x]switch symbol
            /// </summary>
            public const string switch_ = @"[grid3x]switch";
            /// <summary>
            /// Represents the [grid3x]switch_off_1 symbol
            /// </summary>
            public const string switch_off_1 = @"[grid3x]switch_off_1";
            /// <summary>
            /// Represents the [grid3x]switch_off_2 symbol
            /// </summary>
            public const string switch_off_2 = @"[grid3x]switch_off_2";
            /// <summary>
            /// Represents the [grid3x]switch_on_1 symbol
            /// </summary>
            public const string switch_on_1 = @"[grid3x]switch_on_1";
            /// <summary>
            /// Represents the [grid3x]switch_on_2 symbol
            /// </summary>
            public const string switch_on_2 = @"[grid3x]switch_on_2";
            /// <summary>
            /// Represents the [grid3x]symbol symbol
            /// </summary>
            public const string symbol = @"[grid3x]symbol";
            /// <summary>
            /// Represents the [grid3x]symbol_add symbol
            /// </summary>
            public const string symbol_add = @"[grid3x]symbol_add";
            /// <summary>
            /// Represents the [grid3x]symbol_chat symbol
            /// </summary>
            public const string symbol_chat = @"[grid3x]symbol_chat";
            /// <summary>
            /// Represents the [grid3x]symbol_clear symbol
            /// </summary>
            public const string symbol_clear = @"[grid3x]symbol_clear";
            /// <summary>
            /// Represents the [grid3x]symbol_next symbol
            /// </summary>
            public const string symbol_next = @"[grid3x]symbol_next";
            /// <summary>
            /// Represents the [grid3x]symbol_talker_a symbol
            /// </summary>
            public const string symbol_talker_a = @"[grid3x]symbol_talker_a";
            /// <summary>
            /// Represents the [grid3x]symbol_talker_b symbol
            /// </summary>
            public const string symbol_talker_b = @"[grid3x]symbol_talker_b";
            /// <summary>
            /// Represents the [grid3x]symbol_talker_c symbol
            /// </summary>
            public const string symbol_talker_c = @"[grid3x]symbol_talker_c";
            /// <summary>
            /// Represents the [grid3x]symbol_talker_d symbol
            /// </summary>
            public const string symbol_talker_d = @"[grid3x]symbol_talker_d";
            /// <summary>
            /// Represents the [grid3x]symbol_tick symbol
            /// </summary>
            public const string symbol_tick = @"[grid3x]symbol_tick";
            /// <summary>
            /// Represents the [grid3x]symoji symbol
            /// </summary>
            public const string symoji = @"[grid3x]symoji";
            /// <summary>
            /// Represents the [grid3x]symojinegative symbol
            /// </summary>
            public const string symojinegative = @"[grid3x]symojinegative";
            /// <summary>
            /// Represents the [grid3x]symojiother symbol
            /// </summary>
            public const string symojiother = @"[grid3x]symojiother";
            /// <summary>
            /// Represents the [grid3x]symojipositive symbol
            /// </summary>
            public const string symojipositive = @"[grid3x]symojipositive";
            /// <summary>
            /// Represents the [grid3x]t symbol
            /// </summary>
            public const string t = @"[grid3x]t";
            /// <summary>
            /// Represents the [grid3x]t1 symbol
            /// </summary>
            public const string t1 = @"[grid3x]t1";
            /// <summary>
            /// Represents the [grid3x]tab symbol
            /// </summary>
            public const string tab = @"[grid3x]tab";
            /// <summary>
            /// Represents the [grid3x]tablet symbol
            /// </summary>
            public const string tablet = @"[grid3x]tablet";
            /// <summary>
            /// Represents the [grid3x]tablet_1 symbol
            /// </summary>
            public const string tablet_1 = @"[grid3x]tablet_1";
            /// <summary>
            /// Represents the [grid3x]television symbol
            /// </summary>
            public const string television = @"[grid3x]television";
            /// <summary>
            /// Represents the [grid3x]text symbol
            /// </summary>
            public const string text = @"[grid3x]text";
            /// <summary>
            /// Represents the [grid3x]text_1 symbol
            /// </summary>
            public const string text_1 = @"[grid3x]text_1";
            /// <summary>
            /// Represents the [grid3x]text_change symbol
            /// </summary>
            public const string text_change = @"[grid3x]text_change";
            /// <summary>
            /// Represents the [grid3x]text_chat symbol
            /// </summary>
            public const string text_chat = @"[grid3x]text_chat";
            /// <summary>
            /// Represents the [grid3x]text_cross symbol
            /// </summary>
            public const string text_cross = @"[grid3x]text_cross";
            /// <summary>
            /// Represents the [grid3x]text_minus symbol
            /// </summary>
            public const string text_minus = @"[grid3x]text_minus";
            /// <summary>
            /// Represents the [grid3x]text_off symbol
            /// </summary>
            public const string text_off = @"[grid3x]text_off";
            /// <summary>
            /// Represents the [grid3x]text_plus symbol
            /// </summary>
            public const string text_plus = @"[grid3x]text_plus";
            /// <summary>
            /// Represents the [grid3x]text_random symbol
            /// </summary>
            public const string text_random = @"[grid3x]text_random";
            /// <summary>
            /// Represents the [grid3x]text_talker symbol
            /// </summary>
            public const string text_talker = @"[grid3x]text_talker";
            /// <summary>
            /// Represents the [grid3x]text_talker_2 symbol
            /// </summary>
            public const string text_talker_2 = @"[grid3x]text_talker_2";
            /// <summary>
            /// Represents the [grid3x]text_tick symbol
            /// </summary>
            public const string text_tick = @"[grid3x]text_tick";
            /// <summary>
            /// Represents the [grid3x]think symbol
            /// </summary>
            public const string think = @"[grid3x]think";
            /// <summary>
            /// Represents the [grid3x]tick symbol
            /// </summary>
            public const string tick = @"[grid3x]tick";
            /// <summary>
            /// Represents the [grid3x]timer symbol
            /// </summary>
            public const string timer = @"[grid3x]timer";
            /// <summary>
            /// Represents the [grid3x]time_minus symbol
            /// </summary>
            public const string time_minus = @"[grid3x]time_minus";
            /// <summary>
            /// Represents the [grid3x]time_plus symbol
            /// </summary>
            public const string time_plus = @"[grid3x]time_plus";
            /// <summary>
            /// Represents the [grid3x]tira symbol
            /// </summary>
            public const string tira = @"[grid3x]tira";
            /// <summary>
            /// Represents the [grid3x]tools symbol
            /// </summary>
            public const string tools = @"[grid3x]tools";
            /// <summary>
            /// Represents the [grid3x]tortoise symbol
            /// </summary>
            public const string tortoise = @"[grid3x]tortoise";
            /// <summary>
            /// Represents the [grid3x]touch symbol
            /// </summary>
            public const string touch = @"[grid3x]touch";
            /// <summary>
            /// Represents the [grid3x]trophy symbol
            /// </summary>
            public const string trophy = @"[grid3x]trophy";
            /// <summary>
            /// Represents the [grid3x]tv_box symbol
            /// </summary>
            public const string tv_box = @"[grid3x]tv_box";
            /// <summary>
            /// Represents the [grid3x]twitter symbol
            /// </summary>
            public const string twitter = @"[grid3x]twitter";
            /// <summary>
            /// Represents the [grid3x]u symbol
            /// </summary>
            public const string u = @"[grid3x]u";
            /// <summary>
            /// Represents the [grid3x]u1 symbol
            /// </summary>
            public const string u1 = @"[grid3x]u1";
            /// <summary>
            /// Represents the [grid3x]undo symbol
            /// </summary>
            public const string undo = @"[grid3x]undo";
            /// <summary>
            /// Represents the [grid3x]university symbol
            /// </summary>
            public const string university = @"[grid3x]university";
            /// <summary>
            /// Represents the [grid3x]university_1 symbol
            /// </summary>
            public const string university_1 = @"[grid3x]university_1";
            /// <summary>
            /// Represents the [grid3x]users symbol
            /// </summary>
            public const string users = @"[grid3x]users";
            /// <summary>
            /// Represents the [grid3x]uuirt symbol
            /// </summary>
            public const string uuirt = @"[grid3x]uuirt";
            /// <summary>
            /// Represents the [grid3x]v symbol
            /// </summary>
            public const string v = @"[grid3x]v";
            /// <summary>
            /// Represents the [grid3x]v1 symbol
            /// </summary>
            public const string v1 = @"[grid3x]v1";
            /// <summary>
            /// Represents the [grid3x]verb_continuous symbol
            /// </summary>
            public const string verb_continuous = @"[grid3x]verb_continuous";
            /// <summary>
            /// Represents the [grid3x]verb_first_person_2 symbol
            /// </summary>
            public const string verb_first_person_2 = @"[grid3x]verb_first_person_2";
            /// <summary>
            /// Represents the [grid3x]verb_first_person_plural symbol
            /// </summary>
            public const string verb_first_person_plural = @"[grid3x]verb_first_person_plural";
            /// <summary>
            /// Represents the [grid3x]verb_first_person symbol
            /// </summary>
            public const string verb_first_person = @"[grid3x]verb_first_person";
            /// <summary>
            /// Represents the [grid3x]verb_future symbol
            /// </summary>
            public const string verb_future = @"[grid3x]verb_future";
            /// <summary>
            /// Represents the [grid3x]verb_future2 symbol
            /// </summary>
            public const string verb_future2 = @"[grid3x]verb_future2";
            /// <summary>
            /// Represents the [grid3x]verb_modify symbol
            /// </summary>
            public const string verb_modify = @"[grid3x]verb_modify";
            /// <summary>
            /// Represents the [grid3x]verb_past_2 symbol
            /// </summary>
            public const string verb_past_2 = @"[grid3x]verb_past_2";
            /// <summary>
            /// Represents the [grid3x]verb_past_participle symbol
            /// </summary>
            public const string verb_past_participle = @"[grid3x]verb_past_participle";
            /// <summary>
            /// Represents the [grid3x]verb_past_plural symbol
            /// </summary>
            public const string verb_past_plural = @"[grid3x]verb_past_plural";
            /// <summary>
            /// Represents the [grid3x]verb_past symbol
            /// </summary>
            public const string verb_past = @"[grid3x]verb_past";
            /// <summary>
            /// Represents the [grid3x]verb_perfect symbol
            /// </summary>
            public const string verb_perfect = @"[grid3x]verb_perfect";
            /// <summary>
            /// Represents the [grid3x]verb_person symbol
            /// </summary>
            public const string verb_person = @"[grid3x]verb_person";
            /// <summary>
            /// Represents the [grid3x]verb_plural_2 symbol
            /// </summary>
            public const string verb_plural_2 = @"[grid3x]verb_plural_2";
            /// <summary>
            /// Represents the [grid3x]verb_plural symbol
            /// </summary>
            public const string verb_plural = @"[grid3x]verb_plural";
            /// <summary>
            /// Represents the [grid3x]verb_present_participle symbol
            /// </summary>
            public const string verb_present_participle = @"[grid3x]verb_present_participle";
            /// <summary>
            /// Represents the [grid3x]verb_present symbol
            /// </summary>
            public const string verb_present = @"[grid3x]verb_present";
            /// <summary>
            /// Represents the [grid3x]verb_root symbol
            /// </summary>
            public const string verb_root = @"[grid3x]verb_root";
            /// <summary>
            /// Represents the [grid3x]verb_second_person_2 symbol
            /// </summary>
            public const string verb_second_person_2 = @"[grid3x]verb_second_person_2";
            /// <summary>
            /// Represents the [grid3x]verb_second_person_3 symbol
            /// </summary>
            public const string verb_second_person_3 = @"[grid3x]verb_second_person_3";
            /// <summary>
            /// Represents the [grid3x]verb_simple symbol
            /// </summary>
            public const string verb_simple = @"[grid3x]verb_simple";
            /// <summary>
            /// Represents the [grid3x]verb_singular symbol
            /// </summary>
            public const string verb_singular = @"[grid3x]verb_singular";
            /// <summary>
            /// Represents the [grid3x]verb_third_person_2 symbol
            /// </summary>
            public const string verb_third_person_2 = @"[grid3x]verb_third_person_2";
            /// <summary>
            /// Represents the [grid3x]verb_third_person_3 symbol
            /// </summary>
            public const string verb_third_person_3 = @"[grid3x]verb_third_person_3";
            /// <summary>
            /// Represents the [grid3x]verb_third_person symbol
            /// </summary>
            public const string verb_third_person = @"[grid3x]verb_third_person";
            /// <summary>
            /// Represents the [grid3x]verb_time symbol
            /// </summary>
            public const string verb_time = @"[grid3x]verb_time";
            /// <summary>
            /// Represents the [grid3x]verb symbol
            /// </summary>
            public const string verb = @"[grid3x]verb";
            /// <summary>
            /// Represents the [grid3x]verb_cell symbol
            /// </summary>
            public const string verb_cell = @"[grid3x]verb_cell";
            /// <summary>
            /// Represents the [grid3x]verb_prediction symbol
            /// </summary>
            public const string verb_prediction = @"[grid3x]verb_prediction";
            /// <summary>
            /// Represents the [grid3x]verb_word symbol
            /// </summary>
            public const string verb_word = @"[grid3x]verb_word";
            /// <summary>
            /// Represents the [grid3x]video symbol
            /// </summary>
            public const string video = @"[grid3x]video";
            /// <summary>
            /// Represents the [grid3x]video_camera symbol
            /// </summary>
            public const string video_camera = @"[grid3x]video_camera";
            /// <summary>
            /// Represents the [grid3x]vocabulary_for_life symbol
            /// </summary>
            public const string vocabulary_for_life = @"[grid3x]vocabulary_for_life";
            /// <summary>
            /// Represents the [grid3x]vocochat symbol
            /// </summary>
            public const string vocochat = @"[grid3x]vocochat";
            /// <summary>
            /// Represents the [grid3x]voice symbol
            /// </summary>
            public const string voice = @"[grid3x]voice";
            /// <summary>
            /// Represents the [grid3x]volume_1 symbol
            /// </summary>
            public const string volume_1 = @"[grid3x]volume_1";
            /// <summary>
            /// Represents the [grid3x]volume_2 symbol
            /// </summary>
            public const string volume_2 = @"[grid3x]volume_2";
            /// <summary>
            /// Represents the [grid3x]volume_3 symbol
            /// </summary>
            public const string volume_3 = @"[grid3x]volume_3";
            /// <summary>
            /// Represents the [grid3x]volume_4 symbol
            /// </summary>
            public const string volume_4 = @"[grid3x]volume_4";
            /// <summary>
            /// Represents the [grid3x]w symbol
            /// </summary>
            public const string w = @"[grid3x]w";
            /// <summary>
            /// Represents the [grid3x]w1 symbol
            /// </summary>
            public const string w1 = @"[grid3x]w1";
            /// <summary>
            /// Represents the [grid3x]wait symbol
            /// </summary>
            public const string wait = @"[grid3x]wait";
            /// <summary>
            /// Represents the [grid3x]warning symbol
            /// </summary>
            public const string warning = @"[grid3x]warning";
            /// <summary>
            /// Represents the [grid3x]weight symbol
            /// </summary>
            public const string weight = @"[grid3x]weight";
            /// <summary>
            /// Represents the [grid3x]whale symbol
            /// </summary>
            public const string whale = @"[grid3x]whale";
            /// <summary>
            /// Represents the [grid3x]window_open symbol
            /// </summary>
            public const string window_open = @"[grid3x]window_open";
            /// <summary>
            /// Represents the [grid3x]window symbol
            /// </summary>
            public const string window = @"[grid3x]window";
            /// <summary>
            /// Represents the [grid3x]windows symbol
            /// </summary>
            public const string windows = @"[grid3x]windows";
            /// <summary>
            /// Represents the [grid3x]window_flip symbol
            /// </summary>
            public const string window_flip = @"[grid3x]window_flip";
            /// <summary>
            /// Represents the [grid3x]window_height symbol
            /// </summary>
            public const string window_height = @"[grid3x]window_height";
            /// <summary>
            /// Represents the [grid3x]window_maximise symbol
            /// </summary>
            public const string window_maximise = @"[grid3x]window_maximise";
            /// <summary>
            /// Represents the [grid3x]window_minimise symbol
            /// </summary>
            public const string window_minimise = @"[grid3x]window_minimise";
            /// <summary>
            /// Represents the [grid3x]window_move symbol
            /// </summary>
            public const string window_move = @"[grid3x]window_move";
            /// <summary>
            /// Represents the [grid3x]window_narrow symbol
            /// </summary>
            public const string window_narrow = @"[grid3x]window_narrow";
            /// <summary>
            /// Represents the [grid3x]window_next symbol
            /// </summary>
            public const string window_next = @"[grid3x]window_next";
            /// <summary>
            /// Represents the [grid3x]window_previous symbol
            /// </summary>
            public const string window_previous = @"[grid3x]window_previous";
            /// <summary>
            /// Represents the [grid3x]window_resize symbol
            /// </summary>
            public const string window_resize = @"[grid3x]window_resize";
            /// <summary>
            /// Represents the [grid3x]window_restore symbol
            /// </summary>
            public const string window_restore = @"[grid3x]window_restore";
            /// <summary>
            /// Represents the [grid3x]window_short symbol
            /// </summary>
            public const string window_short = @"[grid3x]window_short";
            /// <summary>
            /// Represents the [grid3x]window_tall symbol
            /// </summary>
            public const string window_tall = @"[grid3x]window_tall";
            /// <summary>
            /// Represents the [grid3x]window_to_screen symbol
            /// </summary>
            public const string window_to_screen = @"[grid3x]window_to_screen";
            /// <summary>
            /// Represents the [grid3x]window_wide symbol
            /// </summary>
            public const string window_wide = @"[grid3x]window_wide";
            /// <summary>
            /// Represents the [grid3x]window_width symbol
            /// </summary>
            public const string window_width = @"[grid3x]window_width";
            /// <summary>
            /// Represents the [grid3x]word symbol
            /// </summary>
            public const string word = @"[grid3x]word";
            /// <summary>
            /// Represents the [grid3x]wordlist_1 symbol
            /// </summary>
            public const string wordlist_1 = @"[grid3x]wordlist_1";
            /// <summary>
            /// Represents the [grid3x]wordlist symbol
            /// </summary>
            public const string wordlist = @"[grid3x]wordlist";
            /// <summary>
            /// Represents the [grid3x]wordlist_change symbol
            /// </summary>
            public const string wordlist_change = @"[grid3x]wordlist_change";
            /// <summary>
            /// Represents the [grid3x]wordlist_cross symbol
            /// </summary>
            public const string wordlist_cross = @"[grid3x]wordlist_cross";
            /// <summary>
            /// Represents the [grid3x]wordlist_minus symbol
            /// </summary>
            public const string wordlist_minus = @"[grid3x]wordlist_minus";
            /// <summary>
            /// Represents the [grid3x]wordlist_plus symbol
            /// </summary>
            public const string wordlist_plus = @"[grid3x]wordlist_plus";
            /// <summary>
            /// Represents the [grid3x]wordlist_random symbol
            /// </summary>
            public const string wordlist_random = @"[grid3x]wordlist_random";
            /// <summary>
            /// Represents the [grid3x]wordlist_reset symbol
            /// </summary>
            public const string wordlist_reset = @"[grid3x]wordlist_reset";
            /// <summary>
            /// Represents the [grid3x]wordlist_tick symbol
            /// </summary>
            public const string wordlist_tick = @"[grid3x]wordlist_tick";
            /// <summary>
            /// Represents the [grid3x]wordpower symbol
            /// </summary>
            public const string wordpower = @"[grid3x]wordpower";
            /// <summary>
            /// Represents the [grid3x]wordprocessor symbol
            /// </summary>
            public const string wordprocessor = @"[grid3x]wordprocessor";
            /// <summary>
            /// Represents the [grid3x]word_next symbol
            /// </summary>
            public const string word_next = @"[grid3x]word_next";
            /// <summary>
            /// Represents the [grid3x]word_power symbol
            /// </summary>
            public const string word_power = @"[grid3x]word_power";
            /// <summary>
            /// Represents the [grid3x]word_previous symbol
            /// </summary>
            public const string word_previous = @"[grid3x]word_previous";
            /// <summary>
            /// Represents the [grid3x]world symbol
            /// </summary>
            public const string world = @"[grid3x]world";
            /// <summary>
            /// Represents the [grid3x]write_cell symbol
            /// </summary>
            public const string write_cell = @"[grid3x]write_cell";
            /// <summary>
            /// Represents the [grid3x]writing symbol
            /// </summary>
            public const string writing = @"[grid3x]writing";
            /// <summary>
            /// Represents the [grid3x]x symbol
            /// </summary>
            public const string x = @"[grid3x]x";
            /// <summary>
            /// Represents the [grid3x]x1 symbol
            /// </summary>
            public const string x1 = @"[grid3x]x1";
            /// <summary>
            /// Represents the [grid3x]y symbol
            /// </summary>
            public const string y = @"[grid3x]y";
            /// <summary>
            /// Represents the [grid3x]y1 symbol
            /// </summary>
            public const string y1 = @"[grid3x]y1";
            /// <summary>
            /// Represents the [grid3x]youtube symbol
            /// </summary>
            public const string youtube = @"[grid3x]youtube";
            /// <summary>
            /// Represents the [grid3x]z symbol
            /// </summary>
            public const string z = @"[grid3x]z";
            /// <summary>
            /// Represents the [grid3x]z1 symbol
            /// </summary>
            public const string z1 = @"[grid3x]z1";
            /// <summary>
            /// Represents the [grid3x]zoom symbol
            /// </summary>
            public const string zoom = @"[grid3x]zoom";
            /// <summary>
            /// Represents the [grid3x]zoom_in symbol
            /// </summary>
            public const string zoom_in = @"[grid3x]zoom_in";
            /// <summary>
            /// Represents the [grid3x]zoom_out symbol
            /// </summary>
            public const string zoom_out = @"[grid3x]zoom_out";
            /// <summary>
            /// Represents the [grid3x]zwave symbol
            /// </summary>
            public const string zwave = @"[grid3x]zwave";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_addfriend symbol
            /// </summary>
            public const string accessible_apps_fb_addfriend = @"[grid3x]accessible apps\fb_addfriend";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_addphoto symbol
            /// </summary>
            public const string accessible_apps_fb_addphoto = @"[grid3x]accessible apps\fb_addphoto";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_addvideo symbol
            /// </summary>
            public const string accessible_apps_fb_addvideo = @"[grid3x]accessible apps\fb_addvideo";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_checkin symbol
            /// </summary>
            public const string accessible_apps_fb_checkin = @"[grid3x]accessible apps\fb_checkin";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_close symbol
            /// </summary>
            public const string accessible_apps_fb_close = @"[grid3x]accessible apps\fb_close";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_comment symbol
            /// </summary>
            public const string accessible_apps_fb_comment = @"[grid3x]accessible apps\fb_comment";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_createpost symbol
            /// </summary>
            public const string accessible_apps_fb_createpost = @"[grid3x]accessible apps\fb_createpost";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_down symbol
            /// </summary>
            public const string accessible_apps_fb_down = @"[grid3x]accessible apps\fb_down";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_down2 symbol
            /// </summary>
            public const string accessible_apps_fb_down2 = @"[grid3x]accessible apps\fb_down2";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_email symbol
            /// </summary>
            public const string accessible_apps_fb_email = @"[grid3x]accessible apps\fb_email";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_emojiangry symbol
            /// </summary>
            public const string accessible_apps_fb_emojiangry = @"[grid3x]accessible apps\fb_emojiangry";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_emojihaha symbol
            /// </summary>
            public const string accessible_apps_fb_emojihaha = @"[grid3x]accessible apps\fb_emojihaha";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_emojilike symbol
            /// </summary>
            public const string accessible_apps_fb_emojilike = @"[grid3x]accessible apps\fb_emojilike";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_emojilove symbol
            /// </summary>
            public const string accessible_apps_fb_emojilove = @"[grid3x]accessible apps\fb_emojilove";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_emojisad symbol
            /// </summary>
            public const string accessible_apps_fb_emojisad = @"[grid3x]accessible apps\fb_emojisad";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_emojiwow symbol
            /// </summary>
            public const string accessible_apps_fb_emojiwow = @"[grid3x]accessible apps\fb_emojiwow";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_feelings symbol
            /// </summary>
            public const string accessible_apps_fb_feelings = @"[grid3x]accessible apps\fb_feelings";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_friendrequests symbol
            /// </summary>
            public const string accessible_apps_fb_friendrequests = @"[grid3x]accessible apps\fb_friendrequests";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_friends symbol
            /// </summary>
            public const string accessible_apps_fb_friends = @"[grid3x]accessible apps\fb_friends";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_homefeed symbol
            /// </summary>
            public const string accessible_apps_fb_homefeed = @"[grid3x]accessible apps\fb_homefeed";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_info symbol
            /// </summary>
            public const string accessible_apps_fb_info = @"[grid3x]accessible apps\fb_info";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_left symbol
            /// </summary>
            public const string accessible_apps_fb_left = @"[grid3x]accessible apps\fb_left";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_left2 symbol
            /// </summary>
            public const string accessible_apps_fb_left2 = @"[grid3x]accessible apps\fb_left2";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_less symbol
            /// </summary>
            public const string accessible_apps_fb_less = @"[grid3x]accessible apps\fb_less";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_like symbol
            /// </summary>
            public const string accessible_apps_fb_like = @"[grid3x]accessible apps\fb_like";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_links symbol
            /// </summary>
            public const string accessible_apps_fb_links = @"[grid3x]accessible apps\fb_links";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_login symbol
            /// </summary>
            public const string accessible_apps_fb_login = @"[grid3x]accessible apps\fb_login";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_manual symbol
            /// </summary>
            public const string accessible_apps_fb_manual = @"[grid3x]accessible apps\fb_manual";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_messenger symbol
            /// </summary>
            public const string accessible_apps_fb_messenger = @"[grid3x]accessible apps\fb_messenger";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_more symbol
            /// </summary>
            public const string accessible_apps_fb_more = @"[grid3x]accessible apps\fb_more";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_mute symbol
            /// </summary>
            public const string accessible_apps_fb_mute = @"[grid3x]accessible apps\fb_mute";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_mygroups symbol
            /// </summary>
            public const string accessible_apps_fb_mygroups = @"[grid3x]accessible apps\fb_mygroups";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_navigate symbol
            /// </summary>
            public const string accessible_apps_fb_navigate = @"[grid3x]accessible apps\fb_navigate";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_newmessage symbol
            /// </summary>
            public const string accessible_apps_fb_newmessage = @"[grid3x]accessible apps\fb_newmessage";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_notifications symbol
            /// </summary>
            public const string accessible_apps_fb_notifications = @"[grid3x]accessible apps\fb_notifications";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_openclosecomments symbol
            /// </summary>
            public const string accessible_apps_fb_openclosecomments = @"[grid3x]accessible apps\fb_openclosecomments";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_password symbol
            /// </summary>
            public const string accessible_apps_fb_password = @"[grid3x]accessible apps\fb_password";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_photoviewer symbol
            /// </summary>
            public const string accessible_apps_fb_photoviewer = @"[grid3x]accessible apps\fb_photoviewer";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_privacy symbol
            /// </summary>
            public const string accessible_apps_fb_privacy = @"[grid3x]accessible apps\fb_privacy";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_read symbol
            /// </summary>
            public const string accessible_apps_fb_read = @"[grid3x]accessible apps\fb_read";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_readnextcomment symbol
            /// </summary>
            public const string accessible_apps_fb_readnextcomment = @"[grid3x]accessible apps\fb_readnextcomment";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_readnextmessage symbol
            /// </summary>
            public const string accessible_apps_fb_readnextmessage = @"[grid3x]accessible apps\fb_readnextmessage";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_readprevmessage symbol
            /// </summary>
            public const string accessible_apps_fb_readprevmessage = @"[grid3x]accessible apps\fb_readprevmessage";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_readreply symbol
            /// </summary>
            public const string accessible_apps_fb_readreply = @"[grid3x]accessible apps\fb_readreply";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_removefriend symbol
            /// </summary>
            public const string accessible_apps_fb_removefriend = @"[grid3x]accessible apps\fb_removefriend";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_rest symbol
            /// </summary>
            public const string accessible_apps_fb_rest = @"[grid3x]accessible apps\fb_rest";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_right symbol
            /// </summary>
            public const string accessible_apps_fb_right = @"[grid3x]accessible apps\fb_right";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_right2 symbol
            /// </summary>
            public const string accessible_apps_fb_right2 = @"[grid3x]accessible apps\fb_right2";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_scrolldown symbol
            /// </summary>
            public const string accessible_apps_fb_scrolldown = @"[grid3x]accessible apps\fb_scrolldown";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_scrollleft symbol
            /// </summary>
            public const string accessible_apps_fb_scrollleft = @"[grid3x]accessible apps\fb_scrollleft";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_scrollright symbol
            /// </summary>
            public const string accessible_apps_fb_scrollright = @"[grid3x]accessible apps\fb_scrollright";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_scrollup symbol
            /// </summary>
            public const string accessible_apps_fb_scrollup = @"[grid3x]accessible apps\fb_scrollup";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_search symbol
            /// </summary>
            public const string accessible_apps_fb_search = @"[grid3x]accessible apps\fb_search";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_sharenow symbol
            /// </summary>
            public const string accessible_apps_fb_sharenow = @"[grid3x]accessible apps\fb_sharenow";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_stopreading symbol
            /// </summary>
            public const string accessible_apps_fb_stopreading = @"[grid3x]accessible apps\fb_stopreading";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_tagfriends symbol
            /// </summary>
            public const string accessible_apps_fb_tagfriends = @"[grid3x]accessible apps\fb_tagfriends";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_timeline symbol
            /// </summary>
            public const string accessible_apps_fb_timeline = @"[grid3x]accessible apps\fb_timeline";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_type symbol
            /// </summary>
            public const string accessible_apps_fb_type = @"[grid3x]accessible apps\fb_type";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_unmute symbol
            /// </summary>
            public const string accessible_apps_fb_unmute = @"[grid3x]accessible apps\fb_unmute";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_up symbol
            /// </summary>
            public const string accessible_apps_fb_up = @"[grid3x]accessible apps\fb_up";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_up2 symbol
            /// </summary>
            public const string accessible_apps_fb_up2 = @"[grid3x]accessible apps\fb_up2";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_viewmorecomments symbol
            /// </summary>
            public const string accessible_apps_fb_viewmorecomments = @"[grid3x]accessible apps\fb_viewmorecomments";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_zoomin symbol
            /// </summary>
            public const string accessible_apps_fb_zoomin = @"[grid3x]accessible apps\fb_zoomin";
            /// <summary>
            /// Represents the [grid3x]accessible apps\fb_zoomout symbol
            /// </summary>
            public const string accessible_apps_fb_zoomout = @"[grid3x]accessible apps\fb_zoomout";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_browse symbol
            /// </summary>
            public const string accessible_apps_spt_browse = @"[grid3x]accessible apps\spt_browse";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_charts symbol
            /// </summary>
            public const string accessible_apps_spt_charts = @"[grid3x]accessible apps\spt_charts";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_clear symbol
            /// </summary>
            public const string accessible_apps_spt_clear = @"[grid3x]accessible apps\spt_clear";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_closecancel symbol
            /// </summary>
            public const string accessible_apps_spt_closecancel = @"[grid3x]accessible apps\spt_closecancel";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_confirm symbol
            /// </summary>
            public const string accessible_apps_spt_confirm = @"[grid3x]accessible apps\spt_confirm";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_create symbol
            /// </summary>
            public const string accessible_apps_spt_create = @"[grid3x]accessible apps\spt_create";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_deleteletter symbol
            /// </summary>
            public const string accessible_apps_spt_deleteletter = @"[grid3x]accessible apps\spt_deleteletter";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_deleteword symbol
            /// </summary>
            public const string accessible_apps_spt_deleteword = @"[grid3x]accessible apps\spt_deleteword";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_discover symbol
            /// </summary>
            public const string accessible_apps_spt_discover = @"[grid3x]accessible apps\spt_discover";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_followadd symbol
            /// </summary>
            public const string accessible_apps_spt_followadd = @"[grid3x]accessible apps\spt_followadd";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_genres symbol
            /// </summary>
            public const string accessible_apps_spt_genres = @"[grid3x]accessible apps\spt_genres";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_gridexplorer symbol
            /// </summary>
            public const string accessible_apps_spt_gridexplorer = @"[grid3x]accessible apps\spt_gridexplorer";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_home symbol
            /// </summary>
            public const string accessible_apps_spt_home = @"[grid3x]accessible apps\spt_home";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_info symbol
            /// </summary>
            public const string accessible_apps_spt_info = @"[grid3x]accessible apps\spt_info";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon1 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon1 = @"[grid3x]accessible apps\spt_infoicon1";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon2 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon2 = @"[grid3x]accessible apps\spt_infoicon2";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon3 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon3 = @"[grid3x]accessible apps\spt_infoicon3";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon4 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon4 = @"[grid3x]accessible apps\spt_infoicon4";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon5 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon5 = @"[grid3x]accessible apps\spt_infoicon5";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon6 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon6 = @"[grid3x]accessible apps\spt_infoicon6";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon7 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon7 = @"[grid3x]accessible apps\spt_infoicon7";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon8 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon8 = @"[grid3x]accessible apps\spt_infoicon8";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_infoicon9 symbol
            /// </summary>
            public const string accessible_apps_spt_infoicon9 = @"[grid3x]accessible apps\spt_infoicon9";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_login symbol
            /// </summary>
            public const string accessible_apps_spt_login = @"[grid3x]accessible apps\spt_login";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_logout symbol
            /// </summary>
            public const string accessible_apps_spt_logout = @"[grid3x]accessible apps\spt_logout";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_myalbums symbol
            /// </summary>
            public const string accessible_apps_spt_myalbums = @"[grid3x]accessible apps\spt_myalbums";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_myartists symbol
            /// </summary>
            public const string accessible_apps_spt_myartists = @"[grid3x]accessible apps\spt_myartists";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_myfavourites symbol
            /// </summary>
            public const string accessible_apps_spt_myfavourites = @"[grid3x]accessible apps\spt_myfavourites";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_mylibrary symbol
            /// </summary>
            public const string accessible_apps_spt_mylibrary = @"[grid3x]accessible apps\spt_mylibrary";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_myplaylists symbol
            /// </summary>
            public const string accessible_apps_spt_myplaylists = @"[grid3x]accessible apps\spt_myplaylists";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_mypodcasts symbol
            /// </summary>
            public const string accessible_apps_spt_mypodcasts = @"[grid3x]accessible apps\spt_mypodcasts";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_new symbol
            /// </summary>
            public const string accessible_apps_spt_new = @"[grid3x]accessible apps\spt_new";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_newplaylist symbol
            /// </summary>
            public const string accessible_apps_spt_newplaylist = @"[grid3x]accessible apps\spt_newplaylist";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_next symbol
            /// </summary>
            public const string accessible_apps_spt_next = @"[grid3x]accessible apps\spt_next";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_nextcontent symbol
            /// </summary>
            public const string accessible_apps_spt_nextcontent = @"[grid3x]accessible apps\spt_nextcontent";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_nowplaying symbol
            /// </summary>
            public const string accessible_apps_spt_nowplaying = @"[grid3x]accessible apps\spt_nowplaying";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_password symbol
            /// </summary>
            public const string accessible_apps_spt_password = @"[grid3x]accessible apps\spt_password";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_playondevices symbol
            /// </summary>
            public const string accessible_apps_spt_playondevices = @"[grid3x]accessible apps\spt_playondevices";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_playpause symbol
            /// </summary>
            public const string accessible_apps_spt_playpause = @"[grid3x]accessible apps\spt_playpause";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_podcasts symbol
            /// </summary>
            public const string accessible_apps_spt_podcasts = @"[grid3x]accessible apps\spt_podcasts";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_previous symbol
            /// </summary>
            public const string accessible_apps_spt_previous = @"[grid3x]accessible apps\spt_previous";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_previouscontent symbol
            /// </summary>
            public const string accessible_apps_spt_previouscontent = @"[grid3x]accessible apps\spt_previouscontent";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_rememberme symbol
            /// </summary>
            public const string accessible_apps_spt_rememberme = @"[grid3x]accessible apps\spt_rememberme";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_rest symbol
            /// </summary>
            public const string accessible_apps_spt_rest = @"[grid3x]accessible apps\spt_rest";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_search symbol
            /// </summary>
            public const string accessible_apps_spt_search = @"[grid3x]accessible apps\spt_search";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_shift symbol
            /// </summary>
            public const string accessible_apps_spt_shift = @"[grid3x]accessible apps\spt_shift";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_shuffle symbol
            /// </summary>
            public const string accessible_apps_spt_shuffle = @"[grid3x]accessible apps\spt_shuffle";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_songmenu symbol
            /// </summary>
            public const string accessible_apps_spt_songmenu = @"[grid3x]accessible apps\spt_songmenu";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_spotifylogo symbol
            /// </summary>
            public const string accessible_apps_spt_spotifylogo = @"[grid3x]accessible apps\spt_spotifylogo";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_spotifylogo_s symbol
            /// </summary>
            public const string accessible_apps_spt_spotifylogo_s = @"[grid3x]accessible apps\spt_spotifylogo_s";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_tools symbol
            /// </summary>
            public const string accessible_apps_spt_tools = @"[grid3x]accessible apps\spt_tools";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_undo symbol
            /// </summary>
            public const string accessible_apps_spt_undo = @"[grid3x]accessible apps\spt_undo";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_username symbol
            /// </summary>
            public const string accessible_apps_spt_username = @"[grid3x]accessible apps\spt_username";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_volumedown symbol
            /// </summary>
            public const string accessible_apps_spt_volumedown = @"[grid3x]accessible apps\spt_volumedown";
            /// <summary>
            /// Represents the [grid3x]accessible apps\spt_volumeup symbol
            /// </summary>
            public const string accessible_apps_spt_volumeup = @"[grid3x]accessible apps\spt_volumeup";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_apply_filter symbol
            /// </summary>
            public const string accessible_apps_yt_apply_filter = @"[grid3x]accessible apps\yt_apply_filter";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_arrow_down symbol
            /// </summary>
            public const string accessible_apps_yt_arrow_down = @"[grid3x]accessible apps\yt_arrow_down";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_arrow_left symbol
            /// </summary>
            public const string accessible_apps_yt_arrow_left = @"[grid3x]accessible apps\yt_arrow_left";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_arrow_right symbol
            /// </summary>
            public const string accessible_apps_yt_arrow_right = @"[grid3x]accessible apps\yt_arrow_right";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_arrow_up symbol
            /// </summary>
            public const string accessible_apps_yt_arrow_up = @"[grid3x]accessible apps\yt_arrow_up";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_back symbol
            /// </summary>
            public const string accessible_apps_yt_back = @"[grid3x]accessible apps\yt_back";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_close_ads_banners symbol
            /// </summary>
            public const string accessible_apps_yt_close_ads_banners = @"[grid3x]accessible apps\yt_close_ads_banners";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_disable_autoplay symbol
            /// </summary>
            public const string accessible_apps_yt_disable_autoplay = @"[grid3x]accessible apps\yt_disable_autoplay";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_jump_to_top symbol
            /// </summary>
            public const string accessible_apps_yt_jump_to_top = @"[grid3x]accessible apps\yt_jump_to_top";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_logo symbol
            /// </summary>
            public const string accessible_apps_yt_logo = @"[grid3x]accessible apps\yt_logo";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_logo_tile symbol
            /// </summary>
            public const string accessible_apps_yt_logo_tile = @"[grid3x]accessible apps\yt_logo_tile";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_mute_unmute symbol
            /// </summary>
            public const string accessible_apps_yt_mute_unmute = @"[grid3x]accessible apps\yt_mute_unmute";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_play_pause symbol
            /// </summary>
            public const string accessible_apps_yt_play_pause = @"[grid3x]accessible apps\yt_play_pause";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_read symbol
            /// </summary>
            public const string accessible_apps_yt_read = @"[grid3x]accessible apps\yt_read";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_rest symbol
            /// </summary>
            public const string accessible_apps_yt_rest = @"[grid3x]accessible apps\yt_rest";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_select symbol
            /// </summary>
            public const string accessible_apps_yt_select = @"[grid3x]accessible apps\yt_select";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_setup symbol
            /// </summary>
            public const string accessible_apps_yt_setup = @"[grid3x]accessible apps\yt_setup";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_stop_reading symbol
            /// </summary>
            public const string accessible_apps_yt_stop_reading = @"[grid3x]accessible apps\yt_stop_reading";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_trending symbol
            /// </summary>
            public const string accessible_apps_yt_trending = @"[grid3x]accessible apps\yt_trending";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_volume_down symbol
            /// </summary>
            public const string accessible_apps_yt_volume_down = @"[grid3x]accessible apps\yt_volume_down";
            /// <summary>
            /// Represents the [grid3x]accessible apps\yt_volume_up symbol
            /// </summary>
            public const string accessible_apps_yt_volume_up = @"[grid3x]accessible apps\yt_volume_up";
            /// <summary>
            /// Represents the [grid3x]grid set categories\apps symbol
            /// </summary>
            public const string grid_set_categories_apps = @"[grid3x]grid set categories\apps";
            /// <summary>
            /// Represents the [grid3x]grid set categories\computer symbol
            /// </summary>
            public const string grid_set_categories_computer = @"[grid3x]grid set categories\computer";
            /// <summary>
            /// Represents the [grid3x]grid set categories\ec symbol
            /// </summary>
            public const string grid_set_categories_ec = @"[grid3x]grid set categories\ec";
            /// <summary>
            /// Represents the [grid3x]grid set categories\interactive symbol
            /// </summary>
            public const string grid_set_categories_interactive = @"[grid3x]grid set categories\interactive";
            /// <summary>
            /// Represents the [grid3x]grid set categories\symbols symbol
            /// </summary>
            public const string grid_set_categories_symbols = @"[grid3x]grid set categories\symbols";
            /// <summary>
            /// Represents the [grid3x]grid set categories\text symbol
            /// </summary>
            public const string grid_set_categories_text = @"[grid3x]grid set categories\text";
            /// <summary>
            /// Represents the [grid3x]grid set categories\wordpower symbol
            /// </summary>
            public const string grid_set_categories_wordpower = @"[grid3x]grid set categories\wordpower";
            /// <summary>
            /// Represents the [grid3x]italian verbs\absolute_superlative symbol
            /// </summary>
            public const string italian_verbs_absolute_superlative = @"[grid3x]italian verbs\absolute_superlative";
            /// <summary>
            /// Represents the [grid3x]italian verbs\adverb symbol
            /// </summary>
            public const string italian_verbs_adverb = @"[grid3x]italian verbs\adverb";
            /// <summary>
            /// Represents the [grid3x]italian verbs\adverb_abs_sup symbol
            /// </summary>
            public const string italian_verbs_adverb_abs_sup = @"[grid3x]italian verbs\adverb_abs_sup";
            /// <summary>
            /// Represents the [grid3x]italian verbs\agli symbol
            /// </summary>
            public const string italian_verbs_agli = @"[grid3x]italian verbs\agli";
            /// <summary>
            /// Represents the [grid3x]italian verbs\ai symbol
            /// </summary>
            public const string italian_verbs_ai = @"[grid3x]italian verbs\ai";
            /// <summary>
            /// Represents the [grid3x]italian verbs\al symbol
            /// </summary>
            public const string italian_verbs_al = @"[grid3x]italian verbs\al";
            /// <summary>
            /// Represents the [grid3x]italian verbs\all' symbol
            /// </summary>
            public const string italian_verbs_all = @"[grid3x]italian verbs\all'";
            /// <summary>
            /// Represents the [grid3x]italian verbs\alla symbol
            /// </summary>
            public const string italian_verbs_alla = @"[grid3x]italian verbs\alla";
            /// <summary>
            /// Represents the [grid3x]italian verbs\alle symbol
            /// </summary>
            public const string italian_verbs_alle = @"[grid3x]italian verbs\alle";
            /// <summary>
            /// Represents the [grid3x]italian verbs\allo symbol
            /// </summary>
            public const string italian_verbs_allo = @"[grid3x]italian verbs\allo";
            /// <summary>
            /// Represents the [grid3x]italian verbs\augmentative symbol
            /// </summary>
            public const string italian_verbs_augmentative = @"[grid3x]italian verbs\augmentative";
            /// <summary>
            /// Represents the [grid3x]italian verbs\comparative_majority symbol
            /// </summary>
            public const string italian_verbs_comparative_majority = @"[grid3x]italian verbs\comparative_majority";
            /// <summary>
            /// Represents the [grid3x]italian verbs\comparative_minority symbol
            /// </summary>
            public const string italian_verbs_comparative_minority = @"[grid3x]italian verbs\comparative_minority";
            /// <summary>
            /// Represents the [grid3x]italian verbs\conditional_past symbol
            /// </summary>
            public const string italian_verbs_conditional_past = @"[grid3x]italian verbs\conditional_past";
            /// <summary>
            /// Represents the [grid3x]italian verbs\conditional_present symbol
            /// </summary>
            public const string italian_verbs_conditional_present = @"[grid3x]italian verbs\conditional_present";
            /// <summary>
            /// Represents the [grid3x]italian verbs\conjunctive_imperfect symbol
            /// </summary>
            public const string italian_verbs_conjunctive_imperfect = @"[grid3x]italian verbs\conjunctive_imperfect";
            /// <summary>
            /// Represents the [grid3x]italian verbs\conjunctive_past symbol
            /// </summary>
            public const string italian_verbs_conjunctive_past = @"[grid3x]italian verbs\conjunctive_past";
            /// <summary>
            /// Represents the [grid3x]italian verbs\conjunctive_present symbol
            /// </summary>
            public const string italian_verbs_conjunctive_present = @"[grid3x]italian verbs\conjunctive_present";
            /// <summary>
            /// Represents the [grid3x]italian verbs\conjuntive_past_perfect symbol
            /// </summary>
            public const string italian_verbs_conjuntive_past_perfect = @"[grid3x]italian verbs\conjuntive_past_perfect";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dagli symbol
            /// </summary>
            public const string italian_verbs_dagli = @"[grid3x]italian verbs\dagli";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dai symbol
            /// </summary>
            public const string italian_verbs_dai = @"[grid3x]italian verbs\dai";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dal symbol
            /// </summary>
            public const string italian_verbs_dal = @"[grid3x]italian verbs\dal";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dall' symbol
            /// </summary>
            public const string italian_verbs_dall = @"[grid3x]italian verbs\dall'";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dalla symbol
            /// </summary>
            public const string italian_verbs_dalla = @"[grid3x]italian verbs\dalla";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dalle symbol
            /// </summary>
            public const string italian_verbs_dalle = @"[grid3x]italian verbs\dalle";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dallo symbol
            /// </summary>
            public const string italian_verbs_dallo = @"[grid3x]italian verbs\dallo";
            /// <summary>
            /// Represents the [grid3x]italian verbs\degli symbol
            /// </summary>
            public const string italian_verbs_degli = @"[grid3x]italian verbs\degli";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dei symbol
            /// </summary>
            public const string italian_verbs_dei = @"[grid3x]italian verbs\dei";
            /// <summary>
            /// Represents the [grid3x]italian verbs\del symbol
            /// </summary>
            public const string italian_verbs_del = @"[grid3x]italian verbs\del";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dell' symbol
            /// </summary>
            public const string italian_verbs_dell = @"[grid3x]italian verbs\dell'";
            /// <summary>
            /// Represents the [grid3x]italian verbs\della symbol
            /// </summary>
            public const string italian_verbs_della = @"[grid3x]italian verbs\della";
            /// <summary>
            /// Represents the [grid3x]italian verbs\delle symbol
            /// </summary>
            public const string italian_verbs_delle = @"[grid3x]italian verbs\delle";
            /// <summary>
            /// Represents the [grid3x]italian verbs\dello symbol
            /// </summary>
            public const string italian_verbs_dello = @"[grid3x]italian verbs\dello";
            /// <summary>
            /// Represents the [grid3x]italian verbs\derogatory symbol
            /// </summary>
            public const string italian_verbs_derogatory = @"[grid3x]italian verbs\derogatory";
            /// <summary>
            /// Represents the [grid3x]italian verbs\diminutive symbol
            /// </summary>
            public const string italian_verbs_diminutive = @"[grid3x]italian verbs\diminutive";
            /// <summary>
            /// Represents the [grid3x]italian verbs\feminine_plural symbol
            /// </summary>
            public const string italian_verbs_feminine_plural = @"[grid3x]italian verbs\feminine_plural";
            /// <summary>
            /// Represents the [grid3x]italian verbs\feminine_plural_abs_sup symbol
            /// </summary>
            public const string italian_verbs_feminine_plural_abs_sup = @"[grid3x]italian verbs\feminine_plural_abs_sup";
            /// <summary>
            /// Represents the [grid3x]italian verbs\feminine_singular symbol
            /// </summary>
            public const string italian_verbs_feminine_singular = @"[grid3x]italian verbs\feminine_singular";
            /// <summary>
            /// Represents the [grid3x]italian verbs\feminine_sinular_abs_sup symbol
            /// </summary>
            public const string italian_verbs_feminine_sinular_abs_sup = @"[grid3x]italian verbs\feminine_sinular_abs_sup";
            /// <summary>
            /// Represents the [grid3x]italian verbs\funky double arrow symbol
            /// </summary>
            public const string italian_verbs_funky_double_arrow = @"[grid3x]italian verbs\funky double arrow";
            /// <summary>
            /// Represents the [grid3x]italian verbs\future symbol
            /// </summary>
            public const string italian_verbs_future = @"[grid3x]italian verbs\future";
            /// <summary>
            /// Represents the [grid3x]italian verbs\future_perfect symbol
            /// </summary>
            public const string italian_verbs_future_perfect = @"[grid3x]italian verbs\future_perfect";
            /// <summary>
            /// Represents the [grid3x]italian verbs\generic_plural_abs_sup symbol
            /// </summary>
            public const string italian_verbs_generic_plural_abs_sup = @"[grid3x]italian verbs\generic_plural_abs_sup";
            /// <summary>
            /// Represents the [grid3x]italian verbs\generic_plural_augmentative symbol
            /// </summary>
            public const string italian_verbs_generic_plural_augmentative = @"[grid3x]italian verbs\generic_plural_augmentative";
            /// <summary>
            /// Represents the [grid3x]italian verbs\generic_plural_derogative symbol
            /// </summary>
            public const string italian_verbs_generic_plural_derogative = @"[grid3x]italian verbs\generic_plural_derogative";
            /// <summary>
            /// Represents the [grid3x]italian verbs\generic_plural_diminutive symbol
            /// </summary>
            public const string italian_verbs_generic_plural_diminutive = @"[grid3x]italian verbs\generic_plural_diminutive";
            /// <summary>
            /// Represents the [grid3x]italian verbs\gli symbol
            /// </summary>
            public const string italian_verbs_gli = @"[grid3x]italian verbs\gli";
            /// <summary>
            /// Represents the [grid3x]italian verbs\i+ symbol
            /// </summary>
            public const string italian_verbs_i_plus = @"[grid3x]italian verbs\i+";
            /// <summary>
            /// Represents the [grid3x]italian verbs\i_ symbol
            /// </summary>
            public const string italian_verbs_i_ = @"[grid3x]italian verbs\i_";
            /// <summary>
            /// Represents the [grid3x]italian verbs\i symbol
            /// </summary>
            public const string italian_verbs_i = @"[grid3x]italian verbs\i";
            /// <summary>
            /// Represents the [grid3x]italian verbs\il+ symbol
            /// </summary>
            public const string italian_verbs_il_plus = @"[grid3x]italian verbs\il+";
            /// <summary>
            /// Represents the [grid3x]italian verbs\il_ symbol
            /// </summary>
            public const string italian_verbs_il_ = @"[grid3x]italian verbs\il_";
            /// <summary>
            /// Represents the [grid3x]italian verbs\il symbol
            /// </summary>
            public const string italian_verbs_il = @"[grid3x]italian verbs\il";
            /// <summary>
            /// Represents the [grid3x]italian verbs\imperative symbol
            /// </summary>
            public const string italian_verbs_imperative = @"[grid3x]italian verbs\imperative";
            /// <summary>
            /// Represents the [grid3x]italian verbs\imperfect symbol
            /// </summary>
            public const string italian_verbs_imperfect = @"[grid3x]italian verbs\imperfect";
            /// <summary>
            /// Represents the [grid3x]italian verbs\l' symbol
            /// </summary>
            public const string italian_verbs_l = @"[grid3x]italian verbs\l'";
            /// <summary>
            /// Represents the [grid3x]italian verbs\la+ symbol
            /// </summary>
            public const string italian_verbs_la_plus = @"[grid3x]italian verbs\la+";
            /// <summary>
            /// Represents the [grid3x]italian verbs\la_ symbol
            /// </summary>
            public const string italian_verbs_la_ = @"[grid3x]italian verbs\la_";
            /// <summary>
            /// Represents the [grid3x]italian verbs\la symbol
            /// </summary>
            public const string italian_verbs_la = @"[grid3x]italian verbs\la";
            /// <summary>
            /// Represents the [grid3x]italian verbs\le+ symbol
            /// </summary>
            public const string italian_verbs_le_plus = @"[grid3x]italian verbs\le+";
            /// <summary>
            /// Represents the [grid3x]italian verbs\le_ symbol
            /// </summary>
            public const string italian_verbs_le_ = @"[grid3x]italian verbs\le_";
            /// <summary>
            /// Represents the [grid3x]italian verbs\le symbol
            /// </summary>
            public const string italian_verbs_le = @"[grid3x]italian verbs\le";
            /// <summary>
            /// Represents the [grid3x]italian verbs\lo symbol
            /// </summary>
            public const string italian_verbs_lo = @"[grid3x]italian verbs\lo";
            /// <summary>
            /// Represents the [grid3x]italian verbs\masculine_plural symbol
            /// </summary>
            public const string italian_verbs_masculine_plural = @"[grid3x]italian verbs\masculine_plural";
            /// <summary>
            /// Represents the [grid3x]italian verbs\masculine_plural_abs_sup symbol
            /// </summary>
            public const string italian_verbs_masculine_plural_abs_sup = @"[grid3x]italian verbs\masculine_plural_abs_sup";
            /// <summary>
            /// Represents the [grid3x]italian verbs\masculine_singular symbol
            /// </summary>
            public const string italian_verbs_masculine_singular = @"[grid3x]italian verbs\masculine_singular";
            /// <summary>
            /// Represents the [grid3x]italian verbs\masculine_singular_abs_sup symbol
            /// </summary>
            public const string italian_verbs_masculine_singular_abs_sup = @"[grid3x]italian verbs\masculine_singular_abs_sup";
            /// <summary>
            /// Represents the [grid3x]italian verbs\negli symbol
            /// </summary>
            public const string italian_verbs_negli = @"[grid3x]italian verbs\negli";
            /// <summary>
            /// Represents the [grid3x]italian verbs\nei symbol
            /// </summary>
            public const string italian_verbs_nei = @"[grid3x]italian verbs\nei";
            /// <summary>
            /// Represents the [grid3x]italian verbs\nel symbol
            /// </summary>
            public const string italian_verbs_nel = @"[grid3x]italian verbs\nel";
            /// <summary>
            /// Represents the [grid3x]italian verbs\nell' symbol
            /// </summary>
            public const string italian_verbs_nell = @"[grid3x]italian verbs\nell'";
            /// <summary>
            /// Represents the [grid3x]italian verbs\nella symbol
            /// </summary>
            public const string italian_verbs_nella = @"[grid3x]italian verbs\nella";
            /// <summary>
            /// Represents the [grid3x]italian verbs\nelle symbol
            /// </summary>
            public const string italian_verbs_nelle = @"[grid3x]italian verbs\nelle";
            /// <summary>
            /// Represents the [grid3x]italian verbs\nello symbol
            /// </summary>
            public const string italian_verbs_nello = @"[grid3x]italian verbs\nello";
            /// <summary>
            /// Represents the [grid3x]italian verbs\past symbol
            /// </summary>
            public const string italian_verbs_past = @"[grid3x]italian verbs\past";
            /// <summary>
            /// Represents the [grid3x]italian verbs\past_perfect_distant symbol
            /// </summary>
            public const string italian_verbs_past_perfect_distant = @"[grid3x]italian verbs\past_perfect_distant";
            /// <summary>
            /// Represents the [grid3x]italian verbs\past_perfect_recent symbol
            /// </summary>
            public const string italian_verbs_past_perfect_recent = @"[grid3x]italian verbs\past_perfect_recent";
            /// <summary>
            /// Represents the [grid3x]italian verbs\plurale_generico_sup_ass symbol
            /// </summary>
            public const string italian_verbs_plurale_generico_sup_ass = @"[grid3x]italian verbs\plurale_generico_sup_ass";
            /// <summary>
            /// Represents the [grid3x]italian verbs\present symbol
            /// </summary>
            public const string italian_verbs_present = @"[grid3x]italian verbs\present";
            /// <summary>
            /// Represents the [grid3x]italian verbs\remote_past symbol
            /// </summary>
            public const string italian_verbs_remote_past = @"[grid3x]italian verbs\remote_past";
            /// <summary>
            /// Represents the [grid3x]italian verbs\singolare_generico symbol
            /// </summary>
            public const string italian_verbs_singolare_generico = @"[grid3x]italian verbs\singolare_generico";
            /// <summary>
            /// Represents the [grid3x]italian verbs\sugli symbol
            /// </summary>
            public const string italian_verbs_sugli = @"[grid3x]italian verbs\sugli";
            /// <summary>
            /// Represents the [grid3x]italian verbs\sui symbol
            /// </summary>
            public const string italian_verbs_sui = @"[grid3x]italian verbs\sui";
            /// <summary>
            /// Represents the [grid3x]italian verbs\sul symbol
            /// </summary>
            public const string italian_verbs_sul = @"[grid3x]italian verbs\sul";
            /// <summary>
            /// Represents the [grid3x]italian verbs\sull' symbol
            /// </summary>
            public const string italian_verbs_sull = @"[grid3x]italian verbs\sull'";
            /// <summary>
            /// Represents the [grid3x]italian verbs\sulla symbol
            /// </summary>
            public const string italian_verbs_sulla = @"[grid3x]italian verbs\sulla";
            /// <summary>
            /// Represents the [grid3x]italian verbs\sulle symbol
            /// </summary>
            public const string italian_verbs_sulle = @"[grid3x]italian verbs\sulle";
            /// <summary>
            /// Represents the [grid3x]italian verbs\sullo symbol
            /// </summary>
            public const string italian_verbs_sullo = @"[grid3x]italian verbs\sullo";
            /// <summary>
            /// Represents the [grid3x]italian verbs\un' symbol
            /// </summary>
            public const string italian_verbs_un_ = @"[grid3x]italian verbs\un'";
            /// <summary>
            /// Represents the [grid3x]italian verbs\un symbol
            /// </summary>
            public const string italian_verbs_un = @"[grid3x]italian verbs\un";
            /// <summary>
            /// Represents the [grid3x]italian verbs\una symbol
            /// </summary>
            public const string italian_verbs_una = @"[grid3x]italian verbs\una";
            /// <summary>
            /// Represents the [grid3x]italian verbs\uno symbol
            /// </summary>
            public const string italian_verbs_uno = @"[grid3x]italian verbs\uno";
            /// <summary>
            /// Represents the [grid3x]italian verbs\verb perfect future passive symbol
            /// </summary>
            public const string italian_verbs_verb_perfect_future_passive = @"[grid3x]italian verbs\verb perfect future passive";
            /// <summary>
            /// Represents the [grid3x]italian verbs\verb perfect past passive symbol
            /// </summary>
            public const string italian_verbs_verb_perfect_past_passive = @"[grid3x]italian verbs\verb perfect past passive";
            /// <summary>
            /// Represents the [grid3x]italian verbs\verb simple future passive symbol
            /// </summary>
            public const string italian_verbs_verb_simple_future_passive = @"[grid3x]italian verbs\verb simple future passive";
            /// <summary>
            /// Represents the [grid3x]look to read\bag symbol
            /// </summary>
            public const string look_to_read_bag = @"[grid3x]look to read\bag";
            /// <summary>
            /// Represents the [grid3x]look to read\bat symbol
            /// </summary>
            public const string look_to_read_bat = @"[grid3x]look to read\bat";
            /// <summary>
            /// Represents the [grid3x]look to read\bed symbol
            /// </summary>
            public const string look_to_read_bed = @"[grid3x]look to read\bed";
            /// <summary>
            /// Represents the [grid3x]look to read\big symbol
            /// </summary>
            public const string look_to_read_big = @"[grid3x]look to read\big";
            /// <summary>
            /// Represents the [grid3x]look to read\boat symbol
            /// </summary>
            public const string look_to_read_boat = @"[grid3x]look to read\boat";
            /// <summary>
            /// Represents the [grid3x]look to read\broken symbol
            /// </summary>
            public const string look_to_read_broken = @"[grid3x]look to read\broken";
            /// <summary>
            /// Represents the [grid3x]look to read\bug symbol
            /// </summary>
            public const string look_to_read_bug = @"[grid3x]look to read\bug";
            /// <summary>
            /// Represents the [grid3x]look to read\buzz_bug symbol
            /// </summary>
            public const string look_to_read_buzz_bug = @"[grid3x]look to read\buzz_bug";
            /// <summary>
            /// Represents the [grid3x]look to read\buzz symbol
            /// </summary>
            public const string look_to_read_buzz = @"[grid3x]look to read\buzz";
            /// <summary>
            /// Represents the [grid3x]look to read\carrot symbol
            /// </summary>
            public const string look_to_read_carrot = @"[grid3x]look to read\carrot";
            /// <summary>
            /// Represents the [grid3x]look to read\cat symbol
            /// </summary>
            public const string look_to_read_cat = @"[grid3x]look to read\cat";
            /// <summary>
            /// Represents the [grid3x]look to read\chip symbol
            /// </summary>
            public const string look_to_read_chip = @"[grid3x]look to read\chip";
            /// <summary>
            /// Represents the [grid3x]look to read\chips_wish symbol
            /// </summary>
            public const string look_to_read_chips_wish = @"[grid3x]look to read\chips_wish";
            /// <summary>
            /// Represents the [grid3x]look to read\clock symbol
            /// </summary>
            public const string look_to_read_clock = @"[grid3x]look to read\clock";
            /// <summary>
            /// Represents the [grid3x]look to read\crab symbol
            /// </summary>
            public const string look_to_read_crab = @"[grid3x]look to read\crab";
            /// <summary>
            /// Represents the [grid3x]look to read\dad symbol
            /// </summary>
            public const string look_to_read_dad = @"[grid3x]look to read\dad";
            /// <summary>
            /// Represents the [grid3x]look to read\duck symbol
            /// </summary>
            public const string look_to_read_duck = @"[grid3x]look to read\duck";
            /// <summary>
            /// Represents the [grid3x]look to read\eat symbol
            /// </summary>
            public const string look_to_read_eat = @"[grid3x]look to read\eat";
            /// <summary>
            /// Represents the [grid3x]look to read\fat_bat symbol
            /// </summary>
            public const string look_to_read_fat_bat = @"[grid3x]look to read\fat_bat";
            /// <summary>
            /// Represents the [grid3x]look to read\fatbat symbol
            /// </summary>
            public const string look_to_read_fatbat = @"[grid3x]look to read\fatbat";
            /// <summary>
            /// Represents the [grid3x]look to read\fish symbol
            /// </summary>
            public const string look_to_read_fish = @"[grid3x]look to read\fish";
            /// <summary>
            /// Represents the [grid3x]look to read\fly symbol
            /// </summary>
            public const string look_to_read_fly = @"[grid3x]look to read\fly";
            /// <summary>
            /// Represents the [grid3x]look to read\food symbol
            /// </summary>
            public const string look_to_read_food = @"[grid3x]look to read\food";
            /// <summary>
            /// Represents the [grid3x]look to read\fox symbol
            /// </summary>
            public const string look_to_read_fox = @"[grid3x]look to read\fox";
            /// <summary>
            /// Represents the [grid3x]look to read\frog symbol
            /// </summary>
            public const string look_to_read_frog = @"[grid3x]look to read\frog";
            /// <summary>
            /// Represents the [grid3x]look to read\fun symbol
            /// </summary>
            public const string look_to_read_fun = @"[grid3x]look to read\fun";
            /// <summary>
            /// Represents the [grid3x]look to read\go symbol
            /// </summary>
            public const string look_to_read_go = @"[grid3x]look to read\go";
            /// <summary>
            /// Represents the [grid3x]look to read\good symbol
            /// </summary>
            public const string look_to_read_good = @"[grid3x]look to read\good";
            /// <summary>
            /// Represents the [grid3x]look to read\help symbol
            /// </summary>
            public const string look_to_read_help = @"[grid3x]look to read\help";
            /// <summary>
            /// Represents the [grid3x]look to read\hen symbol
            /// </summary>
            public const string look_to_read_hen = @"[grid3x]look to read\hen";
            /// <summary>
            /// Represents the [grid3x]look to read\hide symbol
            /// </summary>
            public const string look_to_read_hide = @"[grid3x]look to read\hide";
            /// <summary>
            /// Represents the [grid3x]look to read\hop symbol
            /// </summary>
            public const string look_to_read_hop = @"[grid3x]look to read\hop";
            /// <summary>
            /// Represents the [grid3x]look to read\i_am_a_fish symbol
            /// </summary>
            public const string look_to_read_i_am_a_fish = @"[grid3x]look to read\i_am_a_fish";
            /// <summary>
            /// Represents the [grid3x]look to read\ill symbol
            /// </summary>
            public const string look_to_read_ill = @"[grid3x]look to read\ill";
            /// <summary>
            /// Represents the [grid3x]look to read\in symbol
            /// </summary>
            public const string look_to_read_in = @"[grid3x]look to read\in";
            /// <summary>
            /// Represents the [grid3x]look to read\jam symbol
            /// </summary>
            public const string look_to_read_jam = @"[grid3x]look to read\jam";
            /// <summary>
            /// Represents the [grid3x]look to read\jig symbol
            /// </summary>
            public const string look_to_read_jig = @"[grid3x]look to read\jig";
            /// <summary>
            /// Represents the [grid3x]look to read\jump symbol
            /// </summary>
            public const string look_to_read_jump = @"[grid3x]look to read\jump";
            /// <summary>
            /// Represents the [grid3x]look to read\kit_licks symbol
            /// </summary>
            public const string look_to_read_kit_licks = @"[grid3x]look to read\kit_licks";
            /// <summary>
            /// Represents the [grid3x]look to read\kit symbol
            /// </summary>
            public const string look_to_read_kit = @"[grid3x]look to read\kit";
            /// <summary>
            /// Represents the [grid3x]look to read\lick symbol
            /// </summary>
            public const string look_to_read_lick = @"[grid3x]look to read\lick";
            /// <summary>
            /// Represents the [grid3x]look to read\like symbol
            /// </summary>
            public const string look_to_read_like = @"[grid3x]look to read\like";
            /// <summary>
            /// Represents the [grid3x]look to read\look symbol
            /// </summary>
            public const string look_to_read_look = @"[grid3x]look to read\look";
            /// <summary>
            /// Represents the [grid3x]look to read\looktoread symbol
            /// </summary>
            public const string look_to_read_looktoread = @"[grid3x]look to read\looktoread";
            /// <summary>
            /// Represents the [grid3x]look to read\lots symbol
            /// </summary>
            public const string look_to_read_lots = @"[grid3x]look to read\lots";
            /// <summary>
            /// Represents the [grid3x]look to read\mess symbol
            /// </summary>
            public const string look_to_read_mess = @"[grid3x]look to read\mess";
            /// <summary>
            /// Represents the [grid3x]look to read\mole symbol
            /// </summary>
            public const string look_to_read_mole = @"[grid3x]look to read\mole";
            /// <summary>
            /// Represents the [grid3x]look to read\more symbol
            /// </summary>
            public const string look_to_read_more = @"[grid3x]look to read\more";
            /// <summary>
            /// Represents the [grid3x]look to read\mrlock symbol
            /// </summary>
            public const string look_to_read_mrlock = @"[grid3x]look to read\mrlock";
            /// <summary>
            /// Represents the [grid3x]look to read\mrspider symbol
            /// </summary>
            public const string look_to_read_mrspider = @"[grid3x]look to read\mrspider";
            /// <summary>
            /// Represents the [grid3x]look to read\mrsspider symbol
            /// </summary>
            public const string look_to_read_mrsspider = @"[grid3x]look to read\mrsspider";
            /// <summary>
            /// Represents the [grid3x]look to read\mud symbol
            /// </summary>
            public const string look_to_read_mud = @"[grid3x]look to read\mud";
            /// <summary>
            /// Represents the [grid3x]look to read\mum symbol
            /// </summary>
            public const string look_to_read_mum = @"[grid3x]look to read\mum";
            /// <summary>
            /// Represents the [grid3x]look to read\mums_shopping_trip symbol
            /// </summary>
            public const string look_to_read_mums_shopping_trip = @"[grid3x]look to read\mums_shopping_trip";
            /// <summary>
            /// Represents the [grid3x]look to read\nan symbol
            /// </summary>
            public const string look_to_read_nan = @"[grid3x]look to read\nan";
            /// <summary>
            /// Represents the [grid3x]look to read\nap symbol
            /// </summary>
            public const string look_to_read_nap = @"[grid3x]look to read\nap";
            /// <summary>
            /// Represents the [grid3x]look to read\night_spiders symbol
            /// </summary>
            public const string look_to_read_night_spiders = @"[grid3x]look to read\night_spiders";
            /// <summary>
            /// Represents the [grid3x]look to read\not symbol
            /// </summary>
            public const string look_to_read_not = @"[grid3x]look to read\not";
            /// <summary>
            /// Represents the [grid3x]look to read\odd symbol
            /// </summary>
            public const string look_to_read_odd = @"[grid3x]look to read\odd";
            /// <summary>
            /// Represents the [grid3x]look to read\ohno symbol
            /// </summary>
            public const string look_to_read_ohno = @"[grid3x]look to read\ohno";
            /// <summary>
            /// Represents the [grid3x]look to read\out symbol
            /// </summary>
            public const string look_to_read_out = @"[grid3x]look to read\out";
            /// <summary>
            /// Represents the [grid3x]look to read\paint symbol
            /// </summary>
            public const string look_to_read_paint = @"[grid3x]look to read\paint";
            /// <summary>
            /// Represents the [grid3x]look to read\pip_hops symbol
            /// </summary>
            public const string look_to_read_pip_hops = @"[grid3x]look to read\pip_hops";
            /// <summary>
            /// Represents the [grid3x]look to read\pip symbol
            /// </summary>
            public const string look_to_read_pip = @"[grid3x]look to read\pip";
            /// <summary>
            /// Represents the [grid3x]look to read\play symbol
            /// </summary>
            public const string look_to_read_play = @"[grid3x]look to read\play";
            /// <summary>
            /// Represents the [grid3x]look to read\pond_picnic symbol
            /// </summary>
            public const string look_to_read_pond_picnic = @"[grid3x]look to read\pond_picnic";
            /// <summary>
            /// Represents the [grid3x]look to read\pond symbol
            /// </summary>
            public const string look_to_read_pond = @"[grid3x]look to read\pond";
            /// <summary>
            /// Represents the [grid3x]look to read\poppy symbol
            /// </summary>
            public const string look_to_read_poppy = @"[grid3x]look to read\poppy";
            /// <summary>
            /// Represents the [grid3x]look to read\present symbol
            /// </summary>
            public const string look_to_read_present = @"[grid3x]look to read\present";
            /// <summary>
            /// Represents the [grid3x]look to read\rabbit_king symbol
            /// </summary>
            public const string look_to_read_rabbit_king = @"[grid3x]look to read\rabbit_king";
            /// <summary>
            /// Represents the [grid3x]look to read\rabbit symbol
            /// </summary>
            public const string look_to_read_rabbit = @"[grid3x]look to read\rabbit";
            /// <summary>
            /// Represents the [grid3x]look to read\rabbitking symbol
            /// </summary>
            public const string look_to_read_rabbitking = @"[grid3x]look to read\rabbitking";
            /// <summary>
            /// Represents the [grid3x]look to read\rain symbol
            /// </summary>
            public const string look_to_read_rain = @"[grid3x]look to read\rain";
            /// <summary>
            /// Represents the [grid3x]look to read\rainy_day symbol
            /// </summary>
            public const string look_to_read_rainy_day = @"[grid3x]look to read\rainy_day";
            /// <summary>
            /// Represents the [grid3x]look to read\rat symbol
            /// </summary>
            public const string look_to_read_rat = @"[grid3x]look to read\rat";
            /// <summary>
            /// Represents the [grid3x]look to read\ring symbol
            /// </summary>
            public const string look_to_read_ring = @"[grid3x]look to read\ring";
            /// <summary>
            /// Represents the [grid3x]look to read\run symbol
            /// </summary>
            public const string look_to_read_run = @"[grid3x]look to read\run";
            /// <summary>
            /// Represents the [grid3x]look to read\sad symbol
            /// </summary>
            public const string look_to_read_sad = @"[grid3x]look to read\sad";
            /// <summary>
            /// Represents the [grid3x]look to read\say symbol
            /// </summary>
            public const string look_to_read_say = @"[grid3x]look to read\say";
            /// <summary>
            /// Represents the [grid3x]look to read\ship symbol
            /// </summary>
            public const string look_to_read_ship = @"[grid3x]look to read\ship";
            /// <summary>
            /// Represents the [grid3x]look to read\shop symbol
            /// </summary>
            public const string look_to_read_shop = @"[grid3x]look to read\shop";
            /// <summary>
            /// Represents the [grid3x]look to read\sleep symbol
            /// </summary>
            public const string look_to_read_sleep = @"[grid3x]look to read\sleep";
            /// <summary>
            /// Represents the [grid3x]look to read\snow_1 symbol
            /// </summary>
            public const string look_to_read_snow_1 = @"[grid3x]look to read\snow_1";
            /// <summary>
            /// Represents the [grid3x]look to read\snow symbol
            /// </summary>
            public const string look_to_read_snow = @"[grid3x]look to read\snow";
            /// <summary>
            /// Represents the [grid3x]look to read\spotty_dragon symbol
            /// </summary>
            public const string look_to_read_spotty_dragon = @"[grid3x]look to read\spotty_dragon";
            /// <summary>
            /// Represents the [grid3x]look to read\spottydragon symbol
            /// </summary>
            public const string look_to_read_spottydragon = @"[grid3x]look to read\spottydragon";
            /// <summary>
            /// Represents the [grid3x]look to read\stage_1 symbol
            /// </summary>
            public const string look_to_read_stage_1 = @"[grid3x]look to read\stage_1";
            /// <summary>
            /// Represents the [grid3x]look to read\stage_2 symbol
            /// </summary>
            public const string look_to_read_stage_2 = @"[grid3x]look to read\stage_2";
            /// <summary>
            /// Represents the [grid3x]look to read\stage_3 symbol
            /// </summary>
            public const string look_to_read_stage_3 = @"[grid3x]look to read\stage_3";
            /// <summary>
            /// Represents the [grid3x]look to read\stage_4 symbol
            /// </summary>
            public const string look_to_read_stage_4 = @"[grid3x]look to read\stage_4";
            /// <summary>
            /// Represents the [grid3x]look to read\stop symbol
            /// </summary>
            public const string look_to_read_stop = @"[grid3x]look to read\stop";
            /// <summary>
            /// Represents the [grid3x]look to read\stuck symbol
            /// </summary>
            public const string look_to_read_stuck = @"[grid3x]look to read\stuck";
            /// <summary>
            /// Represents the [grid3x]look to read\talk symbol
            /// </summary>
            public const string look_to_read_talk = @"[grid3x]look to read\talk";
            /// <summary>
            /// Represents the [grid3x]look to read\tap symbol
            /// </summary>
            public const string look_to_read_tap = @"[grid3x]look to read\tap";
            /// <summary>
            /// Represents the [grid3x]look to read\ted symbol
            /// </summary>
            public const string look_to_read_ted = @"[grid3x]look to read\ted";
            /// <summary>
            /// Represents the [grid3x]look to read\ten_hens symbol
            /// </summary>
            public const string look_to_read_ten_hens = @"[grid3x]look to read\ten_hens";
            /// <summary>
            /// Represents the [grid3x]look to read\throw symbol
            /// </summary>
            public const string look_to_read_throw = @"[grid3x]look to read\throw";
            /// <summary>
            /// Represents the [grid3x]look to read\tick_tock_clock symbol
            /// </summary>
            public const string look_to_read_tick_tock_clock = @"[grid3x]look to read\tick_tock_clock";
            /// <summary>
            /// Represents the [grid3x]look to read\tidy symbol
            /// </summary>
            public const string look_to_read_tidy = @"[grid3x]look to read\tidy";
            /// <summary>
            /// Represents the [grid3x]look to read\up symbol
            /// </summary>
            public const string look_to_read_up = @"[grid3x]look to read\up";
            /// <summary>
            /// Represents the [grid3x]look to read\want symbol
            /// </summary>
            public const string look_to_read_want = @"[grid3x]look to read\want";
            /// <summary>
            /// Represents the [grid3x]look to read\web symbol
            /// </summary>
            public const string look_to_read_web = @"[grid3x]look to read\web";
            /// <summary>
            /// Represents the [grid3x]look to read\wet symbol
            /// </summary>
            public const string look_to_read_wet = @"[grid3x]look to read\wet";
            /// <summary>
            /// Represents the [grid3x]look to read\which_duck symbol
            /// </summary>
            public const string look_to_read_which_duck = @"[grid3x]look to read\which_duck";
            /// <summary>
            /// Represents the [grid3x]look to read\which symbol
            /// </summary>
            public const string look_to_read_which = @"[grid3x]look to read\which";
            /// <summary>
            /// Represents the [grid3x]look to read\wish symbol
            /// </summary>
            public const string look_to_read_wish = @"[grid3x]look to read\wish";
            /// <summary>
            /// Represents the [grid3x]look to read\yuck symbol
            /// </summary>
            public const string look_to_read_yuck = @"[grid3x]look to read\yuck";
            /// <summary>
            /// Represents the [grid3x]look to read\zip symbol
            /// </summary>
            public const string look_to_read_zip = @"[grid3x]look to read\zip";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\animals symbol
            /// </summary>
            public const string soundfx_categories_animals = @"[grid3x]soundfx categories\animals";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\animals_birds symbol
            /// </summary>
            public const string soundfx_categories_animals_birds = @"[grid3x]soundfx categories\animals_birds";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\animals_dog symbol
            /// </summary>
            public const string soundfx_categories_animals_dog = @"[grid3x]soundfx categories\animals_dog";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\animals_farm symbol
            /// </summary>
            public const string soundfx_categories_animals_farm = @"[grid3x]soundfx categories\animals_farm";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\animals_wild symbol
            /// </summary>
            public const string soundfx_categories_animals_wild = @"[grid3x]soundfx categories\animals_wild";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\bellsalarms symbol
            /// </summary>
            public const string soundfx_categories_bellsalarms = @"[grid3x]soundfx categories\bellsalarms";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\bellsalarms_clock symbol
            /// </summary>
            public const string soundfx_categories_bellsalarms_clock = @"[grid3x]soundfx categories\bellsalarms_clock";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\bellsalarms_telephone symbol
            /// </summary>
            public const string soundfx_categories_bellsalarms_telephone = @"[grid3x]soundfx categories\bellsalarms_telephone";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\crashbangwallop symbol
            /// </summary>
            public const string soundfx_categories_crashbangwallop = @"[grid3x]soundfx categories\crashbangwallop";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\fooddrink symbol
            /// </summary>
            public const string soundfx_categories_fooddrink = @"[grid3x]soundfx categories\fooddrink";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\fooddrink_drink symbol
            /// </summary>
            public const string soundfx_categories_fooddrink_drink = @"[grid3x]soundfx categories\fooddrink_drink";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\fooddrink_food symbol
            /// </summary>
            public const string soundfx_categories_fooddrink_food = @"[grid3x]soundfx categories\fooddrink_food";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\fun symbol
            /// </summary>
            public const string soundfx_categories_fun = @"[grid3x]soundfx categories\fun";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\nature symbol
            /// </summary>
            public const string soundfx_categories_nature = @"[grid3x]soundfx categories\nature";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\nature_fire symbol
            /// </summary>
            public const string soundfx_categories_nature_fire = @"[grid3x]soundfx categories\nature_fire";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\nature_water symbol
            /// </summary>
            public const string soundfx_categories_nature_water = @"[grid3x]soundfx categories\nature_water";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\others symbol
            /// </summary>
            public const string soundfx_categories_others = @"[grid3x]soundfx categories\others";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\people symbol
            /// </summary>
            public const string soundfx_categories_people = @"[grid3x]soundfx categories\people";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\people_crowd symbol
            /// </summary>
            public const string soundfx_categories_people_crowd = @"[grid3x]soundfx categories\people_crowd";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\phonics symbol
            /// </summary>
            public const string soundfx_categories_phonics = @"[grid3x]soundfx categories\phonics";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\phonics_endblends symbol
            /// </summary>
            public const string soundfx_categories_phonics_endblends = @"[grid3x]soundfx categories\phonics_endblends";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\phonics_initialclusters symbol
            /// </summary>
            public const string soundfx_categories_phonics_initialclusters = @"[grid3x]soundfx categories\phonics_initialclusters";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\phonics_rime symbol
            /// </summary>
            public const string soundfx_categories_phonics_rime = @"[grid3x]soundfx categories\phonics_rime";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\phonics_singlelettersounds symbol
            /// </summary>
            public const string soundfx_categories_phonics_singlelettersounds = @"[grid3x]soundfx categories\phonics_singlelettersounds";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\phonics_softsounds symbol
            /// </summary>
            public const string soundfx_categories_phonics_softsounds = @"[grid3x]soundfx categories\phonics_softsounds";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\phonics_vowelsounds symbol
            /// </summary>
            public const string soundfx_categories_phonics_vowelsounds = @"[grid3x]soundfx categories\phonics_vowelsounds";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\shortbeeps symbol
            /// </summary>
            public const string soundfx_categories_shortbeeps = @"[grid3x]soundfx categories\shortbeeps";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\sport symbol
            /// </summary>
            public const string soundfx_categories_sport = @"[grid3x]soundfx categories\sport";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\technology symbol
            /// </summary>
            public const string soundfx_categories_technology = @"[grid3x]soundfx categories\technology";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\transport symbol
            /// </summary>
            public const string soundfx_categories_transport = @"[grid3x]soundfx categories\transport";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\transport_air symbol
            /// </summary>
            public const string soundfx_categories_transport_air = @"[grid3x]soundfx categories\transport_air";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\transport_road symbol
            /// </summary>
            public const string soundfx_categories_transport_road = @"[grid3x]soundfx categories\transport_road";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\transport_sea symbol
            /// </summary>
            public const string soundfx_categories_transport_sea = @"[grid3x]soundfx categories\transport_sea";
            /// <summary>
            /// Represents the [grid3x]soundfx categories\transport_trains symbol
            /// </summary>
            public const string soundfx_categories_transport_trains = @"[grid3x]soundfx categories\transport_trains";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals symbol
            /// </summary>
            public const string symbol_categories_animals = @"[grid3x]symbol categories\animals";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals_amphibiansreptiles symbol
            /// </summary>
            public const string symbol_categories_animals_amphibiansreptiles = @"[grid3x]symbol categories\animals_amphibiansreptiles";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals_aquatic symbol
            /// </summary>
            public const string symbol_categories_animals_aquatic = @"[grid3x]symbol categories\animals_aquatic";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals_birds symbol
            /// </summary>
            public const string symbol_categories_animals_birds = @"[grid3x]symbol categories\animals_birds";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals_dinosaurs symbol
            /// </summary>
            public const string symbol_categories_animals_dinosaurs = @"[grid3x]symbol categories\animals_dinosaurs";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals_farmanimals symbol
            /// </summary>
            public const string symbol_categories_animals_farmanimals = @"[grid3x]symbol categories\animals_farmanimals";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals_insects symbol
            /// </summary>
            public const string symbol_categories_animals_insects = @"[grid3x]symbol categories\animals_insects";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals_pets symbol
            /// </summary>
            public const string symbol_categories_animals_pets = @"[grid3x]symbol categories\animals_pets";
            /// <summary>
            /// Represents the [grid3x]symbol categories\animals_wildanimals symbol
            /// </summary>
            public const string symbol_categories_animals_wildanimals = @"[grid3x]symbol categories\animals_wildanimals";
            /// <summary>
            /// Represents the [grid3x]symbol categories\arasaac symbol
            /// </summary>
            public const string symbol_categories_arasaac = @"[grid3x]symbol categories\arasaac";
            /// <summary>
            /// Represents the [grid3x]symbol categories\bliss symbol
            /// </summary>
            public const string symbol_categories_bliss = @"[grid3x]symbol categories\bliss";
            /// <summary>
            /// Represents the [grid3x]symbol categories\clothes symbol
            /// </summary>
            public const string symbol_categories_clothes = @"[grid3x]symbol categories\clothes";
            /// <summary>
            /// Represents the [grid3x]symbol categories\clothes_accessories symbol
            /// </summary>
            public const string symbol_categories_clothes_accessories = @"[grid3x]symbol categories\clothes_accessories";
            /// <summary>
            /// Represents the [grid3x]symbol categories\clothes_hats symbol
            /// </summary>
            public const string symbol_categories_clothes_hats = @"[grid3x]symbol categories\clothes_hats";
            /// <summary>
            /// Represents the [grid3x]symbol categories\clothes_shoes symbol
            /// </summary>
            public const string symbol_categories_clothes_shoes = @"[grid3x]symbol categories\clothes_shoes";
            /// <summary>
            /// Represents the [grid3x]symbol categories\clothes_underwear symbol
            /// </summary>
            public const string symbol_categories_clothes_underwear = @"[grid3x]symbol categories\clothes_underwear";
            /// <summary>
            /// Represents the [grid3x]symbol categories\clothes_uniforms symbol
            /// </summary>
            public const string symbol_categories_clothes_uniforms = @"[grid3x]symbol categories\clothes_uniforms";
            /// <summary>
            /// Represents the [grid3x]symbol categories\coloursshapes symbol
            /// </summary>
            public const string symbol_categories_coloursshapes = @"[grid3x]symbol categories\coloursshapes";
            /// <summary>
            /// Represents the [grid3x]symbol categories\communication symbol
            /// </summary>
            public const string symbol_categories_communication = @"[grid3x]symbol categories\communication";
            /// <summary>
            /// Represents the [grid3x]symbol categories\communication_aac symbol
            /// </summary>
            public const string symbol_categories_communication_aac = @"[grid3x]symbol categories\communication_aac";
            /// <summary>
            /// Represents the [grid3x]symbol categories\containers symbol
            /// </summary>
            public const string symbol_categories_containers = @"[grid3x]symbol categories\containers";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries symbol
            /// </summary>
            public const string symbol_categories_countries = @"[grid3x]symbol categories\countries";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_africa symbol
            /// </summary>
            public const string symbol_categories_countries_africa = @"[grid3x]symbol categories\countries_africa";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_asia symbol
            /// </summary>
            public const string symbol_categories_countries_asia = @"[grid3x]symbol categories\countries_asia";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_australasia symbol
            /// </summary>
            public const string symbol_categories_countries_australasia = @"[grid3x]symbol categories\countries_australasia";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_europe symbol
            /// </summary>
            public const string symbol_categories_countries_europe = @"[grid3x]symbol categories\countries_europe";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_flags symbol
            /// </summary>
            public const string symbol_categories_countries_flags = @"[grid3x]symbol categories\countries_flags";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_middleeast symbol
            /// </summary>
            public const string symbol_categories_countries_middleeast = @"[grid3x]symbol categories\countries_middleeast";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_northamerica symbol
            /// </summary>
            public const string symbol_categories_countries_northamerica = @"[grid3x]symbol categories\countries_northamerica";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_southamerica symbol
            /// </summary>
            public const string symbol_categories_countries_southamerica = @"[grid3x]symbol categories\countries_southamerica";
            /// <summary>
            /// Represents the [grid3x]symbol categories\countries_uk symbol
            /// </summary>
            public const string symbol_categories_countries_uk = @"[grid3x]symbol categories\countries_uk";
            /// <summary>
            /// Represents the [grid3x]symbol categories\crime symbol
            /// </summary>
            public const string symbol_categories_crime = @"[grid3x]symbol categories\crime";
            /// <summary>
            /// Represents the [grid3x]symbol categories\culture symbol
            /// </summary>
            public const string symbol_categories_culture = @"[grid3x]symbol categories\culture";
            /// <summary>
            /// Represents the [grid3x]symbol categories\culture_music symbol
            /// </summary>
            public const string symbol_categories_culture_music = @"[grid3x]symbol categories\culture_music";
            /// <summary>
            /// Represents the [grid3x]symbol categories\culture_singing symbol
            /// </summary>
            public const string symbol_categories_culture_singing = @"[grid3x]symbol categories\culture_singing";
            /// <summary>
            /// Represents the [grid3x]symbol categories\culture_tvfilm symbol
            /// </summary>
            public const string symbol_categories_culture_tvfilm = @"[grid3x]symbol categories\culture_tvfilm";
            /// <summary>
            /// Represents the [grid3x]symbol categories\dbur symbol
            /// </summary>
            public const string symbol_categories_dbur = @"[grid3x]symbol categories\dbur";
            /// <summary>
            /// Represents the [grid3x]symbol categories\descriptions symbol
            /// </summary>
            public const string symbol_categories_descriptions = @"[grid3x]symbol categories\descriptions";
            /// <summary>
            /// Represents the [grid3x]symbol categories\descriptions_people symbol
            /// </summary>
            public const string symbol_categories_descriptions_people = @"[grid3x]symbol categories\descriptions_people";
            /// <summary>
            /// Represents the [grid3x]symbol categories\descriptions_position symbol
            /// </summary>
            public const string symbol_categories_descriptions_position = @"[grid3x]symbol categories\descriptions_position";
            /// <summary>
            /// Represents the [grid3x]symbol categories\descriptions_quantity symbol
            /// </summary>
            public const string symbol_categories_descriptions_quantity = @"[grid3x]symbol categories\descriptions_quantity";
            /// <summary>
            /// Represents the [grid3x]symbol categories\education symbol
            /// </summary>
            public const string symbol_categories_education = @"[grid3x]symbol categories\education";
            /// <summary>
            /// Represents the [grid3x]symbol categories\education_art symbol
            /// </summary>
            public const string symbol_categories_education_art = @"[grid3x]symbol categories\education_art";
            /// <summary>
            /// Represents the [grid3x]symbol categories\education_designtechnology symbol
            /// </summary>
            public const string symbol_categories_education_designtechnology = @"[grid3x]symbol categories\education_designtechnology";
            /// <summary>
            /// Represents the [grid3x]symbol categories\education_literacy symbol
            /// </summary>
            public const string symbol_categories_education_literacy = @"[grid3x]symbol categories\education_literacy";
            /// <summary>
            /// Represents the [grid3x]symbol categories\education_nurseryrhymessongs symbol
            /// </summary>
            public const string symbol_categories_education_nurseryrhymessongs = @"[grid3x]symbol categories\education_nurseryrhymessongs";
            /// <summary>
            /// Represents the [grid3x]symbol categories\eyegaze symbol
            /// </summary>
            public const string symbol_categories_eyegaze = @"[grid3x]symbol categories\eyegaze";
            /// <summary>
            /// Represents the [grid3x]symbol categories\feelings symbol
            /// </summary>
            public const string symbol_categories_feelings = @"[grid3x]symbol categories\feelings";
            /// <summary>
            /// Represents the [grid3x]symbol categories\fooddrink symbol
            /// </summary>
            public const string symbol_categories_fooddrink = @"[grid3x]symbol categories\fooddrink";
            /// <summary>
            /// Represents the [grid3x]symbol categories\fooddrink_bread symbol
            /// </summary>
            public const string symbol_categories_fooddrink_bread = @"[grid3x]symbol categories\fooddrink_bread";
            /// <summary>
            /// Represents the [grid3x]symbol categories\fooddrink_cookingeating symbol
            /// </summary>
            public const string symbol_categories_fooddrink_cookingeating = @"[grid3x]symbol categories\fooddrink_cookingeating";
            /// <summary>
            /// Represents the [grid3x]symbol categories\fooddrink_dairy symbol
            /// </summary>
            public const string symbol_categories_fooddrink_dairy = @"[grid3x]symbol categories\fooddrink_dairy";
            /// <summary>
            /// Represents the [grid3x]symbol categories\fooddrink_dessertssnacks symbol
            /// </summary>
            public const string symbol_categories_fooddrink_dessertssnacks = @"[grid3x]symbol categories\fooddrink_dessertssnacks";
            /// <summary>
            /// Represents the [grid3x]symbol categories\fooddrink_drinks symbol
            /// </summary>
            public const string symbol_categories_fooddrink_drinks = @"[grid3x]symbol categories\fooddrink_drinks";
            /// <summary>
            /// Represents the [grid3x]symbol categories\fooddrink_fruitveg symbol
            /// </summary>
            public const string symbol_categories_fooddrink_fruitveg = @"[grid3x]symbol categories\fooddrink_fruitveg";
            /// <summary>
            /// Represents the [grid3x]symbol categories\fooddrink_meatfish symbol
            /// </summary>
            public const string symbol_categories_fooddrink_meatfish = @"[grid3x]symbol categories\fooddrink_meatfish";
            /// <summary>
            /// Represents the [grid3x]symbol categories\grammar symbol
            /// </summary>
            public const string symbol_categories_grammar = @"[grid3x]symbol categories\grammar";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures symbol
            /// </summary>
            public const string symbol_categories_gridpictures = @"[grid3x]symbol categories\gridpictures";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_apps symbol
            /// </summary>
            public const string symbol_categories_gridpictures_apps = @"[grid3x]symbol categories\gridpictures_apps";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_apps_facebook symbol
            /// </summary>
            public const string symbol_categories_gridpictures_apps_facebook = @"[grid3x]symbol categories\gridpictures_apps_facebook";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_apps_spotify symbol
            /// </summary>
            public const string symbol_categories_gridpictures_apps_spotify = @"[grid3x]symbol categories\gridpictures_apps_spotify";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_apps_youtube symbol
            /// </summary>
            public const string symbol_categories_gridpictures_apps_youtube = @"[grid3x]symbol categories\gridpictures_apps_youtube";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_categories symbol
            /// </summary>
            public const string symbol_categories_gridpictures_categories = @"[grid3x]symbol categories\gridpictures_categories";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_computer symbol
            /// </summary>
            public const string symbol_categories_gridpictures_computer = @"[grid3x]symbol categories\gridpictures_computer";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_environmentcontrol symbol
            /// </summary>
            public const string symbol_categories_gridpictures_environmentcontrol = @"[grid3x]symbol categories\gridpictures_environmentcontrol";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_grammar symbol
            /// </summary>
            public const string symbol_categories_gridpictures_grammar = @"[grid3x]symbol categories\gridpictures_grammar";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning = @"[grid3x]symbol categories\gridpictures_interactivelearning";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_4inarow symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_4inarow = @"[grid3x]symbol categories\gridpictures_interactivelearning_4inarow";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_amegiodescribing symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_amegiodescribing = @"[grid3x]symbol categories\gridpictures_interactivelearning_amegiodescribing";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_amegiofirstwords symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_amegiofirstwords = @"[grid3x]symbol categories\gridpictures_interactivelearning_amegiofirstwords";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_amegiointro symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_amegiointro = @"[grid3x]symbol categories\gridpictures_interactivelearning_amegiointro";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_amegiojustforfun symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_amegiojustforfun = @"[grid3x]symbol categories\gridpictures_interactivelearning_amegiojustforfun";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_amegiomorewords symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_amegiomorewords = @"[grid3x]symbol categories\gridpictures_interactivelearning_amegiomorewords";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_amegiosoundthesame symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_amegiosoundthesame = @"[grid3x]symbol categories\gridpictures_interactivelearning_amegiosoundthesame";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_amegiotwowords symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_amegiotwowords = @"[grid3x]symbol categories\gridpictures_interactivelearning_amegiotwowords";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_ancientegypt symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_ancientegypt = @"[grid3x]symbol categories\gridpictures_interactivelearning_ancientegypt";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_bigcity symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_bigcity = @"[grid3x]symbol categories\gridpictures_interactivelearning_bigcity";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_bugsplat symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_bugsplat = @"[grid3x]symbol categories\gridpictures_interactivelearning_bugsplat";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_cakefactory symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_cakefactory = @"[grid3x]symbol categories\gridpictures_interactivelearning_cakefactory";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_carmaker symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_carmaker = @"[grid3x]symbol categories\gridpictures_interactivelearning_carmaker";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_catwalk symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_catwalk = @"[grid3x]symbol categories\gridpictures_interactivelearning_catwalk";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_classroom symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_classroom = @"[grid3x]symbol categories\gridpictures_interactivelearning_classroom";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_dilbertthedog symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_dilbertthedog = @"[grid3x]symbol categories\gridpictures_interactivelearning_dilbertthedog";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_fancydress symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_fancydress = @"[grid3x]symbol categories\gridpictures_interactivelearning_fancydress";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_fireworks symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_fireworks = @"[grid3x]symbol categories\gridpictures_interactivelearning_fireworks";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_jazzyjungle symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_jazzyjungle = @"[grid3x]symbol categories\gridpictures_interactivelearning_jazzyjungle";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_lazylake symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_lazylake = @"[grid3x]symbol categories\gridpictures_interactivelearning_lazylake";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_looktoread symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_looktoread = @"[grid3x]symbol categories\gridpictures_interactivelearning_looktoread";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_magicbrush symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_magicbrush = @"[grid3x]symbol categories\gridpictures_interactivelearning_magicbrush";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_magichouse symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_magichouse = @"[grid3x]symbol categories\gridpictures_interactivelearning_magichouse";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_magicmouse symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_magicmouse = @"[grid3x]symbol categories\gridpictures_interactivelearning_magicmouse";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_magicpiano symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_magicpiano = @"[grid3x]symbol categories\gridpictures_interactivelearning_magicpiano";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_maze symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_maze = @"[grid3x]symbol categories\gridpictures_interactivelearning_maze";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_mountainbiker symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_mountainbiker = @"[grid3x]symbol categories\gridpictures_interactivelearning_mountainbiker";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_noughtsandcrosses symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_noughtsandcrosses = @"[grid3x]symbol categories\gridpictures_interactivelearning_noughtsandcrosses";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_parklife symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_parklife = @"[grid3x]symbol categories\gridpictures_interactivelearning_parklife";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_picturemaker symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_picturemaker = @"[grid3x]symbol categories\gridpictures_interactivelearning_picturemaker";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_planetpog symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_planetpog = @"[grid3x]symbol categories\gridpictures_interactivelearning_planetpog";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_robosnail symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_robosnail = @"[grid3x]symbol categories\gridpictures_interactivelearning_robosnail";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_snowtown symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_snowtown = @"[grid3x]symbol categories\gridpictures_interactivelearning_snowtown";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_soundboxbeats symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_soundboxbeats = @"[grid3x]symbol categories\gridpictures_interactivelearning_soundboxbeats";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_soundboxgroove symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_soundboxgroove = @"[grid3x]symbol categories\gridpictures_interactivelearning_soundboxgroove";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_soundboxintro symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_soundboxintro = @"[grid3x]symbol categories\gridpictures_interactivelearning_soundboxintro";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_soundboxrhythm symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_soundboxrhythm = @"[grid3x]symbol categories\gridpictures_interactivelearning_soundboxrhythm";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_interactivelearning_wildwest symbol
            /// </summary>
            public const string symbol_categories_gridpictures_interactivelearning_wildwest = @"[grid3x]symbol categories\gridpictures_interactivelearning_wildwest";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_lettersnumbers symbol
            /// </summary>
            public const string symbol_categories_gridpictures_lettersnumbers = @"[grid3x]symbol categories\gridpictures_lettersnumbers";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_media symbol
            /// </summary>
            public const string symbol_categories_gridpictures_media = @"[grid3x]symbol categories\gridpictures_media";
            /// <summary>
            /// Represents the [grid3x]symbol categories\gridpictures_symoji symbol
            /// </summary>
            public const string symbol_categories_gridpictures_symoji = @"[grid3x]symbol categories\gridpictures_symoji";
            /// <summary>
            /// Represents the [grid3x]symbol categories\health symbol
            /// </summary>
            public const string symbol_categories_health = @"[grid3x]symbol categories\health";
            /// <summary>
            /// Represents the [grid3x]symbol categories\health_bodyparts symbol
            /// </summary>
            public const string symbol_categories_health_bodyparts = @"[grid3x]symbol categories\health_bodyparts";
            /// <summary>
            /// Represents the [grid3x]symbol categories\health_dentist symbol
            /// </summary>
            public const string symbol_categories_health_dentist = @"[grid3x]symbol categories\health_dentist";
            /// <summary>
            /// Represents the [grid3x]symbol categories\health_medicalassistance symbol
            /// </summary>
            public const string symbol_categories_health_medicalassistance = @"[grid3x]symbol categories\health_medicalassistance";
            /// <summary>
            /// Represents the [grid3x]symbol categories\health_personal symbol
            /// </summary>
            public const string symbol_categories_health_personal = @"[grid3x]symbol categories\health_personal";
            /// <summary>
            /// Represents the [grid3x]symbol categories\health_physicaltherapy symbol
            /// </summary>
            public const string symbol_categories_health_physicaltherapy = @"[grid3x]symbol categories\health_physicaltherapy";
            /// <summary>
            /// Represents the [grid3x]symbol categories\health_sexualityandgender symbol
            /// </summary>
            public const string symbol_categories_health_sexualityandgender = @"[grid3x]symbol categories\health_sexualityandgender";
            /// <summary>
            /// Represents the [grid3x]symbol categories\health_symptoms symbol
            /// </summary>
            public const string symbol_categories_health_symptoms = @"[grid3x]symbol categories\health_symptoms";
            /// <summary>
            /// Represents the [grid3x]symbol categories\history symbol
            /// </summary>
            public const string symbol_categories_history = @"[grid3x]symbol categories\history";
            /// <summary>
            /// Represents the [grid3x]symbol categories\home symbol
            /// </summary>
            public const string symbol_categories_home = @"[grid3x]symbol categories\home";
            /// <summary>
            /// Represents the [grid3x]symbol categories\home_bathroom symbol
            /// </summary>
            public const string symbol_categories_home_bathroom = @"[grid3x]symbol categories\home_bathroom";
            /// <summary>
            /// Represents the [grid3x]symbol categories\home_bedroom symbol
            /// </summary>
            public const string symbol_categories_home_bedroom = @"[grid3x]symbol categories\home_bedroom";
            /// <summary>
            /// Represents the [grid3x]symbol categories\home_dressing symbol
            /// </summary>
            public const string symbol_categories_home_dressing = @"[grid3x]symbol categories\home_dressing";
            /// <summary>
            /// Represents the [grid3x]symbol categories\home_garden symbol
            /// </summary>
            public const string symbol_categories_home_garden = @"[grid3x]symbol categories\home_garden";
            /// <summary>
            /// Represents the [grid3x]symbol categories\home_housework symbol
            /// </summary>
            public const string symbol_categories_home_housework = @"[grid3x]symbol categories\home_housework";
            /// <summary>
            /// Represents the [grid3x]symbol categories\home_kitchen symbol
            /// </summary>
            public const string symbol_categories_home_kitchen = @"[grid3x]symbol categories\home_kitchen";
            /// <summary>
            /// Represents the [grid3x]symbol categories\leisure symbol
            /// </summary>
            public const string symbol_categories_leisure = @"[grid3x]symbol categories\leisure";
            /// <summary>
            /// Represents the [grid3x]symbol categories\leisure_artscrafts symbol
            /// </summary>
            public const string symbol_categories_leisure_artscrafts = @"[grid3x]symbol categories\leisure_artscrafts";
            /// <summary>
            /// Represents the [grid3x]symbol categories\leisure_shopping symbol
            /// </summary>
            public const string symbol_categories_leisure_shopping = @"[grid3x]symbol categories\leisure_shopping";
            /// <summary>
            /// Represents the [grid3x]symbol categories\leisure_toysgames symbol
            /// </summary>
            public const string symbol_categories_leisure_toysgames = @"[grid3x]symbol categories\leisure_toysgames";
            /// <summary>
            /// Represents the [grid3x]symbol categories\maths symbol
            /// </summary>
            public const string symbol_categories_maths = @"[grid3x]symbol categories\maths";
            /// <summary>
            /// Represents the [grid3x]symbol categories\maths_numbers symbol
            /// </summary>
            public const string symbol_categories_maths_numbers = @"[grid3x]symbol categories\maths_numbers";
            /// <summary>
            /// Represents the [grid3x]symbol categories\metacom symbol
            /// </summary>
            public const string symbol_categories_metacom = @"[grid3x]symbol categories\metacom";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money symbol
            /// </summary>
            public const string symbol_categories_money = @"[grid3x]symbol categories\money";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money_dollars symbol
            /// </summary>
            public const string symbol_categories_money_dollars = @"[grid3x]symbol categories\money_dollars";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money_euros symbol
            /// </summary>
            public const string symbol_categories_money_euros = @"[grid3x]symbol categories\money_euros";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money_hungarianforint symbol
            /// </summary>
            public const string symbol_categories_money_hungarianforint = @"[grid3x]symbol categories\money_hungarianforint";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money_krona symbol
            /// </summary>
            public const string symbol_categories_money_krona = @"[grid3x]symbol categories\money_krona";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money_krone symbol
            /// </summary>
            public const string symbol_categories_money_krone = @"[grid3x]symbol categories\money_krone";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money_malawikwacha symbol
            /// </summary>
            public const string symbol_categories_money_malawikwacha = @"[grid3x]symbol categories\money_malawikwacha";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money_pounds symbol
            /// </summary>
            public const string symbol_categories_money_pounds = @"[grid3x]symbol categories\money_pounds";
            /// <summary>
            /// Represents the [grid3x]symbol categories\money_zloty symbol
            /// </summary>
            public const string symbol_categories_money_zloty = @"[grid3x]symbol categories\money_zloty";
            /// <summary>
            /// Represents the [grid3x]symbol categories\nature symbol
            /// </summary>
            public const string symbol_categories_nature = @"[grid3x]symbol categories\nature";
            /// <summary>
            /// Represents the [grid3x]symbol categories\nature_plants symbol
            /// </summary>
            public const string symbol_categories_nature_plants = @"[grid3x]symbol categories\nature_plants";
            /// <summary>
            /// Represents the [grid3x]symbol categories\nature_seaside symbol
            /// </summary>
            public const string symbol_categories_nature_seaside = @"[grid3x]symbol categories\nature_seaside";
            /// <summary>
            /// Represents the [grid3x]symbol categories\officework symbol
            /// </summary>
            public const string symbol_categories_officework = @"[grid3x]symbol categories\officework";
            /// <summary>
            /// Represents the [grid3x]symbol categories\officework_office symbol
            /// </summary>
            public const string symbol_categories_officework_office = @"[grid3x]symbol categories\officework_office";
            /// <summary>
            /// Represents the [grid3x]symbol categories\people symbol
            /// </summary>
            public const string symbol_categories_people = @"[grid3x]symbol categories\people";
            /// <summary>
            /// Represents the [grid3x]symbol categories\people_characters symbol
            /// </summary>
            public const string symbol_categories_people_characters = @"[grid3x]symbol categories\people_characters";
            /// <summary>
            /// Represents the [grid3x]symbol categories\people_family symbol
            /// </summary>
            public const string symbol_categories_people_family = @"[grid3x]symbol categories\people_family";
            /// <summary>
            /// Represents the [grid3x]symbol categories\people_famouspeople symbol
            /// </summary>
            public const string symbol_categories_people_famouspeople = @"[grid3x]symbol categories\people_famouspeople";
            /// <summary>
            /// Represents the [grid3x]symbol categories\people_occupations symbol
            /// </summary>
            public const string symbol_categories_people_occupations = @"[grid3x]symbol categories\people_occupations";
            /// <summary>
            /// Represents the [grid3x]symbol categories\places symbol
            /// </summary>
            public const string symbol_categories_places = @"[grid3x]symbol categories\places";
            /// <summary>
            /// Represents the [grid3x]symbol categories\places_buildings symbol
            /// </summary>
            public const string symbol_categories_places_buildings = @"[grid3x]symbol categories\places_buildings";
            /// <summary>
            /// Represents the [grid3x]symbol categories\places_landmarks symbol
            /// </summary>
            public const string symbol_categories_places_landmarks = @"[grid3x]symbol categories\places_landmarks";
            /// <summary>
            /// Represents the [grid3x]symbol categories\places_outdoors symbol
            /// </summary>
            public const string symbol_categories_places_outdoors = @"[grid3x]symbol categories\places_outdoors";
            /// <summary>
            /// Represents the [grid3x]symbol categories\places_water symbol
            /// </summary>
            public const string symbol_categories_places_water = @"[grid3x]symbol categories\places_water";
            /// <summary>
            /// Represents the [grid3x]symbol categories\politics symbol
            /// </summary>
            public const string symbol_categories_politics = @"[grid3x]symbol categories\politics";
            /// <summary>
            /// Represents the [grid3x]symbol categories\religion symbol
            /// </summary>
            public const string symbol_categories_religion = @"[grid3x]symbol categories\religion";
            /// <summary>
            /// Represents the [grid3x]symbol categories\religion_buddhist symbol
            /// </summary>
            public const string symbol_categories_religion_buddhist = @"[grid3x]symbol categories\religion_buddhist";
            /// <summary>
            /// Represents the [grid3x]symbol categories\religion_christian symbol
            /// </summary>
            public const string symbol_categories_religion_christian = @"[grid3x]symbol categories\religion_christian";
            /// <summary>
            /// Represents the [grid3x]symbol categories\religion_hindu symbol
            /// </summary>
            public const string symbol_categories_religion_hindu = @"[grid3x]symbol categories\religion_hindu";
            /// <summary>
            /// Represents the [grid3x]symbol categories\religion_jewish symbol
            /// </summary>
            public const string symbol_categories_religion_jewish = @"[grid3x]symbol categories\religion_jewish";
            /// <summary>
            /// Represents the [grid3x]symbol categories\religion_muslim symbol
            /// </summary>
            public const string symbol_categories_religion_muslim = @"[grid3x]symbol categories\religion_muslim";
            /// <summary>
            /// Represents the [grid3x]symbol categories\religion_sikh symbol
            /// </summary>
            public const string symbol_categories_religion_sikh = @"[grid3x]symbol categories\religion_sikh";
            /// <summary>
            /// Represents the [grid3x]symbol categories\science symbol
            /// </summary>
            public const string symbol_categories_science = @"[grid3x]symbol categories\science";
            /// <summary>
            /// Represents the [grid3x]symbol categories\science_chemistry symbol
            /// </summary>
            public const string symbol_categories_science_chemistry = @"[grid3x]symbol categories\science_chemistry";
            /// <summary>
            /// Represents the [grid3x]symbol categories\science_space symbol
            /// </summary>
            public const string symbol_categories_science_space = @"[grid3x]symbol categories\science_space";
            /// <summary>
            /// Represents the [grid3x]symbol categories\signlanguage symbol
            /// </summary>
            public const string symbol_categories_signlanguage = @"[grid3x]symbol categories\signlanguage";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport symbol
            /// </summary>
            public const string symbol_categories_sport = @"[grid3x]symbol categories\sport";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport_athletics symbol
            /// </summary>
            public const string symbol_categories_sport_athletics = @"[grid3x]symbol categories\sport_athletics";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport_gymnastics symbol
            /// </summary>
            public const string symbol_categories_sport_gymnastics = @"[grid3x]symbol categories\sport_gymnastics";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport_martialarts symbol
            /// </summary>
            public const string symbol_categories_sport_martialarts = @"[grid3x]symbol categories\sport_martialarts";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport_racketsports symbol
            /// </summary>
            public const string symbol_categories_sport_racketsports = @"[grid3x]symbol categories\sport_racketsports";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport_teamsports symbol
            /// </summary>
            public const string symbol_categories_sport_teamsports = @"[grid3x]symbol categories\sport_teamsports";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport_watersports symbol
            /// </summary>
            public const string symbol_categories_sport_watersports = @"[grid3x]symbol categories\sport_watersports";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport_wintersports symbol
            /// </summary>
            public const string symbol_categories_sport_wintersports = @"[grid3x]symbol categories\sport_wintersports";
            /// <summary>
            /// Represents the [grid3x]symbol categories\sport_yoga symbol
            /// </summary>
            public const string symbol_categories_sport_yoga = @"[grid3x]symbol categories\sport_yoga";
            /// <summary>
            /// Represents the [grid3x]symbol categories\technology symbol
            /// </summary>
            public const string symbol_categories_technology = @"[grid3x]symbol categories\technology";
            /// <summary>
            /// Represents the [grid3x]symbol categories\technology_assistivetechnology symbol
            /// </summary>
            public const string symbol_categories_technology_assistivetechnology = @"[grid3x]symbol categories\technology_assistivetechnology";
            /// <summary>
            /// Represents the [grid3x]symbol categories\technology_computer symbol
            /// </summary>
            public const string symbol_categories_technology_computer = @"[grid3x]symbol categories\technology_computer";
            /// <summary>
            /// Represents the [grid3x]symbol categories\timedate symbol
            /// </summary>
            public const string symbol_categories_timedate = @"[grid3x]symbol categories\timedate";
            /// <summary>
            /// Represents the [grid3x]symbol categories\timedate_months symbol
            /// </summary>
            public const string symbol_categories_timedate_months = @"[grid3x]symbol categories\timedate_months";
            /// <summary>
            /// Represents the [grid3x]symbol categories\timedate_specialevents symbol
            /// </summary>
            public const string symbol_categories_timedate_specialevents = @"[grid3x]symbol categories\timedate_specialevents";
            /// <summary>
            /// Represents the [grid3x]symbol categories\timedate_time symbol
            /// </summary>
            public const string symbol_categories_timedate_time = @"[grid3x]symbol categories\timedate_time";
            /// <summary>
            /// Represents the [grid3x]symbol categories\timedate_year symbol
            /// </summary>
            public const string symbol_categories_timedate_year = @"[grid3x]symbol categories\timedate_year";
            /// <summary>
            /// Represents the [grid3x]symbol categories\transport symbol
            /// </summary>
            public const string symbol_categories_transport = @"[grid3x]symbol categories\transport";
            /// <summary>
            /// Represents the [grid3x]symbol categories\transport_air symbol
            /// </summary>
            public const string symbol_categories_transport_air = @"[grid3x]symbol categories\transport_air";
            /// <summary>
            /// Represents the [grid3x]symbol categories\transport_land symbol
            /// </summary>
            public const string symbol_categories_transport_land = @"[grid3x]symbol categories\transport_land";
            /// <summary>
            /// Represents the [grid3x]symbol categories\transport_sea symbol
            /// </summary>
            public const string symbol_categories_transport_sea = @"[grid3x]symbol categories\transport_sea";
            /// <summary>
            /// Represents the [grid3x]symbol categories\transport_space symbol
            /// </summary>
            public const string symbol_categories_transport_space = @"[grid3x]symbol categories\transport_space";
            /// <summary>
            /// Represents the [grid3x]symbol categories\verbs symbol
            /// </summary>
            public const string symbol_categories_verbs = @"[grid3x]symbol categories\verbs";
            /// <summary>
            /// Represents the [grid3x]symbol categories\weather symbol
            /// </summary>
            public const string symbol_categories_weather = @"[grid3x]symbol categories\weather";

        }
    }
}
