namespace Code2Profile.VoiceMacro
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class VoiceMacroProfile
    {

        private string gUIDField;

        private string profileNameField;

        private string targetWindowField;

        private VoiceMacroProfileCommands[] commandsField;

        /// <remarks/>
        public string GUID
        {
            get => gUIDField;
            set => gUIDField = value;
        }

        /// <remarks/>
        public string ProfileName
        {
            get => profileNameField;
            set => profileNameField = value;
        }

        /// <remarks/>
        public string TargetWindow
        {
            get => targetWindowField;
            set => targetWindowField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Commands", IsNullable = false)]
        public VoiceMacroProfileCommands[] Commands
        {
            get => commandsField;
            set => commandsField = value;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class VoiceMacroProfileCommands
    {

        private string gUIDField;

        private string recocnitionTextField;

        private VoiceMacroProfileCommandsShortCut shortCutField;

        private bool useRecognitionField;

        private bool useRecognitionFieldSpecified;

        private VoiceMacroProfileCommandsMacroAction[] macroActionsField;

        /// <remarks/>
        public string GUID
        {
            get => gUIDField;
            set => gUIDField = value;
        }

        /// <remarks/>
        public string RecocnitionText
        {
            get => recocnitionTextField;
            set => recocnitionTextField = value;
        }

        /// <remarks/>
        public VoiceMacroProfileCommandsShortCut ShortCut
        {
            get => shortCutField;
            set => shortCutField = value;
        }

        /// <remarks/>
        public bool UseRecognition
        {
            get => useRecognitionField;
            set => useRecognitionField = value;
        }

        /// <remarks/>
        public bool UseRecognitionSpecified
        {
            get => useRecognitionFieldSpecified;
            set => useRecognitionFieldSpecified = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MacroAction", IsNullable = false)]
        public VoiceMacroProfileCommandsMacroAction[] MacroActions
        {
            get => macroActionsField;
            set => macroActionsField = value;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class VoiceMacroProfileCommandsShortCut
    {

        private string keyField;

        private byte onKeyActionField;

        private byte clicksField;

        /// <remarks/>
        public string Key
        {
            get => keyField;
            set => keyField = value;
        }

        /// <remarks/>
        public byte OnKeyAction
        {
            get => onKeyActionField;
            set => onKeyActionField = value;
        }

        /// <remarks/>
        public byte Clicks
        {
            get => clicksField;
            set => clicksField = value;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class VoiceMacroProfileCommandsMacroAction
    {

        private byte macroTypeField;

        private VoiceMacroProfileCommandsMacroActionKeyboard keyboardField;

        private VoiceMacroProfileCommandsMacroActionWriteToLog writeToLogField;

        /// <remarks/>
        public byte MacroType
        {
            get => macroTypeField;
            set => macroTypeField = value;
        }

        /// <remarks/>
        public VoiceMacroProfileCommandsMacroActionKeyboard Keyboard
        {
            get => keyboardField;
            set => keyboardField = value;
        }

        /// <remarks/>
        public VoiceMacroProfileCommandsMacroActionWriteToLog WriteToLog
        {
            get => writeToLogField;
            set => writeToLogField = value;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class VoiceMacroProfileCommandsMacroActionKeyboard
    {

        private string keyField;

        private byte clickDownUpField;

        private byte clickDurationField;

        /// <remarks/>
        public string Key
        {
            get => keyField;
            set => keyField = value;
        }

        /// <remarks/>
        public byte ClickDownUp
        {
            get => clickDownUpField;
            set => clickDownUpField = value;
        }

        /// <remarks/>
        public byte ClickDuration
        {
            get => clickDurationField;
            set => clickDurationField = value;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class VoiceMacroProfileCommandsMacroActionWriteToLog
    {

        private string textField;

        private string labelField;

        private byte colorRField;

        private byte colorGField;

        private byte colorBField;

        /// <remarks/>
        public string Text
        {
            get => textField;
            set => textField = value;
        }

        /// <remarks/>
        public string Label
        {
            get => labelField;
            set => labelField = value;
        }

        /// <remarks/>
        public byte ColorR
        {
            get => colorRField;
            set => colorRField = value;
        }

        /// <remarks/>
        public byte ColorG
        {
            get => colorGField;
            set => colorGField = value;
        }

        /// <remarks/>
        public byte ColorB
        {
            get => colorBField;
            set => colorBField = value;
        }
    }
}
