using System;
using System.Windows.Forms;

namespace Code2Profile.VoiceMacro
{
    public interface IAction
    {

    }

    public class MacroAction
    {
        public int MacroType;
        public KeyboardAction Keyboard; // 1
        public MouseAction Mouse; // 2
        public long? Pause; // 3
        public string FindWindowAndActivate; // 4
        public short? StartStopListen; // 5 (0 = stop, 1 = start, 2 = toggle)
        public short? StartStopExecute; // 6
        public short? StartStopAutoProfile; // 7
        public short? StartStopShortCuts; // 8
        public short? MinRestToggleVM; // 9 (0 = minimize, 1 = restore, 2 = toggle)
        public CloseWindowAction CloseWindow; // 11
        public WaitForWindow WaitForWindow; // 12
        public short? StartStopScheduler;  // 13
        public short? StartStopIgnoreCommands;  // 14
        public KillProcessAction KillProcess; // 15
        public string ChangeEngine; // 19
        public SwitchToProfileAction SwitchToProfile; // 20
        public RunOtherMacroAction RunOtherMacro; // 22
        public ChangeTargetWindowAction ChangeTargetWindow; // 25
        public ChangeWindowTitleAction ChangeWindowTitle; // 26
        public ResizeMoveWindowAction ResizeMoveWindow; // 27
        public ChangeWindowStyleAction ChangeDisplayStyle; // 28
        public bool? BlockInput; // 30
        public SpeechToTextAction SpeechToText; // 40
        public WriteToLogAction WriteToLog; // 45
        public OpenFileAction OpenFileAction; // 50
        public PlaySoundAction PlaySound; // 53
        public SpeakTextAction SpeakText; // 54
        public InsertTextAction InsertText; // 55
        public short? Clipboard; // 56 (0 = Copy, 1 = Paste)
        public ShowDialogAction ShowDialog; // 57
        public ShowOSDAction ShowOSD; // 58
        public string HideOSD; // 59
        public LoopAction LoopAction; // 60
        public string Comment; // 61
        public ToggleAction Toggle; // 62
        public SetStateAction SetState; // 68 = SetState
        public WaitForPixelAction WaitForPixel; // 70
        public GetKeyStateAction GetKeyState; // 80
        public SendVirtualKeysAction SendVirtualKeys; // 81
        public ShowUIAction ShowUI; // 90
        public string Label; // 100
        public string GotoLabel; // 101
        public IfElseIf IfElseIf; // 120
        public SendToPluginAction SendToPlugin; // 150
        public SetVariable SetVariable; // 200

        //For XML serializer.
        public bool ShouldSerializePause() => Pause.HasValue;
        public bool ShouldSerializeStartStopListen() => StartStopListen.HasValue;
        public bool ShouldSerializeStartStopExecute() => StartStopExecute.HasValue;
        public bool ShouldSerializeStartStopAutoProfile() => StartStopAutoProfile.HasValue;
        public bool ShouldSerializeStartStopShortCuts() => StartStopShortCuts.HasValue;
        public bool ShouldSerializeMinRestToggleVM() => MinRestToggleVM.HasValue;
        public bool ShouldSerializeStartStopScheduler() => StartStopScheduler.HasValue;
        public bool ShouldSerializeStartStopIgnoreCommands() => StartStopIgnoreCommands.HasValue;
        public bool ShouldSerializeBlockInput() => BlockInput.HasValue;
        public bool ShouldSerializeClipboard() => Clipboard.HasValue;

        internal int GetMacroType()
        {
            if (Keyboard != null) { return 1; }
            else if (Mouse != null) { return 2; }
            else if (Pause != null) { return 3; }
            else if (FindWindowAndActivate != null) { return 4; }
            else if (StartStopListen != null) { return 5; }
            else if (StartStopExecute != null) { return 6; }
            else if (StartStopAutoProfile != null) { return 7; }
            else if (StartStopShortCuts != null) { return 8; }
            else if (MinRestToggleVM != null) { return 9; }
            //else if (AbortMacro != null) { return 10; }
            else if (CloseWindow != null) { return 11; }
            else if (WaitForWindow != null) { return 12; }
            else if (StartStopScheduler != null) { return 13; }
            else if (StartStopIgnoreCommands != null) { return 14; }
            else if (KillProcess != null) { return 15; }
            else if (ChangeEngine != null) { return 19; }
            else if (SwitchToProfile != null) { return 20; }
            //else if (AbortMacro != null) { return 21; }
            else if (RunOtherMacro != null) { return 22; }
            //else if (StopSound != null) { return 23; }
            else if (ChangeTargetWindow != null) { return 25; }
            else if (ChangeWindowTitle != null) { return 26; }
            else if (ResizeMoveWindow != null) { return 27; }
            //else if (ChangewindowStyle != null) { return 28; }
            else if (BlockInput != null) { return 30; }
            else if (SpeechToText != null) { return 40; }
            else if (WriteToLog != null) { return 45; }
            else if (OpenFileAction != null) { return 50; }
            else if (PlaySound != null) { return 53; }
            else if (SpeakText != null) { return 54; }
            else if (InsertText != null) { return 55; }
            else if (Clipboard != null) { return 56; }
            else if (ShowDialog != null) { return 57; }
            else if (ShowOSD != null) { return 58; }
            else if (HideOSD != null) { return 59; }
            else if (LoopAction != null) { return 60; }
            else if (Comment != null) { return 61; }
            else if (Toggle != null) { return 62; }
            //else if (Rotate != null) { return 63; }
            else if (SetState != null) { return 68; }
            else if (WaitForPixel != null) { return 70; }
            else if (GetKeyState != null) { return 80; }
            else if (SendVirtualKeys != null) { return 81; }
            else if (Label != null) { return 100; }
            else if (GotoLabel != null) { return 101; }
            //else if (ExitMacro != null) { return 103; }
            else if (IfElseIf != null) { return 120; }
            else if (SendToPlugin != null) { return 150; }
            else if (SetVariable != null) { return 200; }
            else { return 0; }
        }
    }

    public class KeyboardAction : IAction 
    {
        public Keys Key;
        public short ClickDownUp; // (0 = Click, 1 = Down, 2 = Up)
        public bool lShift;
        public bool rShift;
        public bool Alt;
        public bool rCTRL;
        public bool lCTRL;
        public bool LWin;
        public bool RWin;
        public bool ALTGR;
        public double ClickDuration;
    }

    public class MouseAction : IAction 
    {
        public bool Move;
        public bool Click;
        public bool Scroll;
        public Pos Position;
        public short lButton; // 0 = nothing, 1 = down , 2 = up, -1 = click
        public short mButton;
        public short rButton;
        public short xButton1;
        public short xButton2;
        public int Clicks;
        public double ClickDuration;
        public int ScrollDistance;
        public bool RelativeToWindowPos;
        // 0 = TopLeft, 1 = TopRight, 2 = BottomLeft, 3 = BottomRight, 4 = Center
        public short RelativePosCorner;
        public bool RelativeToCurrentPos;
        public bool RelativeToLastSetPos;
        public bool ReturnToOldLocation;
    }

    public class Pos
    {
        public string X;
        public string Y;
    }

    public class Siz
    {
        public string Width;
        public string Height;
    }

    public class WriteToLogAction : IAction
    {
        public string Text;
        public string Label;
        public short ColorR;
        public short ColorG;
        public short ColorB;
    }

    public class OpenFileAction : IAction
    {
        public string FileName;
        public string Arguments;
        public string WorkingDirectory;
        public short WindowStyle;
        // Public NoWindow As Boolean
        public bool WaitForExit;
    }

    public class SendVirtualKeysAction : IAction
    {
        public string KeyCodes;
        public int ClickDuration;
        public int ClickDelay;
    }

    public class InsertTextAction : IAction
    {
        public string Text;
        public bool UseKeyboard;
        public bool UseAlternative;
        public int ClickDuration;
        public int ClickDelay;
    }

    public class PlaySoundAction : IAction
    {
        public string AudioFile;
        public string Volume;
        public bool Sync;
    }

    public class SpeakTextAction : IAction
    {
        public string Text;
        public int Volume;
        public int Speed;
        public string Voice;
        public bool Sync;
    }

    public class WaitForWindow
    {
        public string WindowName;
        public bool AbortTimeOut;
        public long Timeout;
    }

    public class CloseWindowAction : IAction
    {
        public string WindowName;
    }

    public class KillProcessAction : IAction
    {
        public string ProcessName;
    }

    public class SwitchToProfileAction : IAction
    {
        public string ProfileGUID;
    }

    public class RunOtherMacroAction : IAction
    {
        public string ProfileGUID;
        public string MacroGUID;
        public string Variable;
        public bool RunOnlyOneThread;
        public bool Sync;
    }

    public class LoopAction : IAction
    {
        public bool LoopStartStop; // True = Start, False = Stop
        public string LoopCount;
    }

    public class ShowDialogAction : IAction
    {
        public string Title;
        public string Text;
        public string Button1;
        public string Button2;
        public string Button3;
        public short StartPosition;
        public Pos ManualPosition;
        public bool WaitForClose;
        public bool UseTimeOut;
        public long Timeout;
    }

    public class OSDTextElement
    {
        public string Text;
        public short Align; // 0 = left, 1 = center, 2 = right
        public Font Font;
        public short ColorR;
        public short ColorG;
        public short ColorB;
        public int PositionY;
    }

    public class Font
    {
        public string Name;
        public short Style;
        public double Size;
        public byte GDICharset;
    }

    public class ChangeTargetWindowAction : IAction
    {
        public string TargetWindow;
    }

    public class ChangeWindowTitleAction : IAction
    {
        public string Title;
    }

    public class ResizeMoveWindowAction : IAction
    {
        public string WindowTitle;
        public bool Resize;
        public int ResizeWidth;
        public int ResizeHeight;
        public bool Move;
        public int MoveX;
        public int MoveY;
    }

    public class ChangeWindowStyleAction : IAction
    {
        public string WindowTitle;
        public bool SetStyle;
        public int Style;
        public bool SetTransparency;
        public short Transparency;
        public bool SetTopMost;
        public bool TopMost;
    }

    public class SpeechToTextAction : IAction
    {
        public string SpeechToTextFile;
        public ttsPhrase[] ttsPhrases;
        public string CommandExit;
        public string CommandConfirm;
        public string CommandDelete;
        public string CommandAbort;
        public bool WriteAll;
        public bool PlaySounds;
        public int Volume;
    }

    public class IfElseIf
    {
        public bool IfOrElseIf; // True = "If" or False = "ElseIf"
        public string Condition;
    }

    public class SendToPluginAction : IAction
    {
        public string PluginName;
        public string PluginID;
        public string Param1;
        public string Param2;
        public string Param3;
        public bool Synch;
    }

    public class SetVariable
    {
        public string Name;
        public string Value;
    }

    public class ttsPhrase
    {
        public string Phrase;
        public int AutoAction;
    }

    public class ttsCommand
    {
        public string Action;
        public int IndexOffset;
    }

    public class ToggleAction : IAction
    {
        public short ToggleOnOff; // 1 = on , 0 = off
        public bool Toggle; // DONT SAVE!
    }

    public class WaitForPixelAction : IAction
    {
        public bool RelativeToWindowPos;
        // 0 = TopLeft, 1 = TopRight, 2 = BottomLeft, 3 = BottomRight, 4 = Center
        public short RelativePosCorner;
        public Pos Position;
        public short ColorRed;
        public short ColorGreen;
        public short ColorBlue;
        public long Timeout;
        public long Pollrate;
        public short Tolerance;
        public bool WaitForDisappear; // False = appear, True = disappear
        public bool ExitLoop;
    }

    // 68
    public class SetStateAction : IAction
    {
        public string ProfileGUID;
        public string MacroGUID;
        public bool ToggleSet;
        public short ToggleOnOff; // 1 = on , 0 = off
        public bool RotateSet;
        public int RotateSetIndex;
    }

    public class GetKeyStateAction : IAction
    {
        public string VariableName;
        public Keys Key;
        public bool GetToggle;
        public bool WaitForKey;
        public bool DownOnUpOff;
        public long Timeout;
    }

    // ShowUI
    public class ShowUIAction : IAction
    {
        // Public UIName As String
        public string UIText;
        public string VarUIText;
        public int UIStartPosition;
        public bool AutoSize;
        public Color BackColor;
        public Font Font;
        public Color ForeColor;
        public Pos Location;
        public Siz Size;
        public UIElement[] UIElements;
    }

    public class ShowOSDAction : IAction
    {
        public string OSDName;
        public OSDTextElement[] OSDTextElements;
        public short StartPosition;
        public int Width;
        public int Height;
        public string DisplayName;
        public Pos ManualPosition;
        public double DisplayTime;
        public short Transparency;
    }

    public class Color
    {
        public string A;
        public string R;
        public string G;
        public string B;
    }

    public class UIElement
    {
        // "Text", "ForeColor", "Font", "BackColor", "BorderStyle", "TextAlign", "FlatStyle",
        // "FlatAppearance", "TickFrequency", "TickStyle", "Maximum", "Value", "Minimum", "LargeChange", "TabStop", "TabIndex",
        // "Style", "MarqueeAnimationSpeed", "Items", "DropDownStyle", "MaxDropDownItems", "Step", "CustomFormat", "Format", "Size",
        // "Location", "AutoSize", "Anchor", "Dock", "Multiline", "Checked"
        public int Anchor;
        public bool AutoSize;
        public Color BackColor;
        public int BorderStyle;
        public bool Checked;
        public string CustomFormat;
        public int Dock;
        public bool Enabled;
        public Font Font; // Font
        public Color ForeColor;
        public int FlatStyle;
        //public FlatButtonAppearance FlatAppearance; // FlatButtonAppearance
        public string Format;
        public string Increment;
        public string Items; // ListBox.ObjectCollection
        public Pos Location; // Point
        public bool Multiline;
        public string Maximum;
        public string Minimum;
        public string Name;
        public Siz Size; // Size
        public bool TabStop;
        public int TabIndex;
        public string Text;
        public int TextAlign;
        public string Type;
        public string Value;

        public string ResultVariable;
        public string VarText;
        public string VarItems;
        public string VarValue;
        public string VarChecked;
        public string VarEnabled;
    }
}
