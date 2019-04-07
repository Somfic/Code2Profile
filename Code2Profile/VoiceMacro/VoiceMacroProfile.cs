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

        private MacroAction[] macroActionsField;

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
        public MacroAction[] MacroActions
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
}
