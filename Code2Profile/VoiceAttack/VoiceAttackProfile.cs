namespace Code2Profile.VoiceAttack
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Profile
    {

        private bool hasMBField;

        private string idField;

        private string nameField;

        private ProfileCommand[] commandsField;

        private bool overrideGlobalField;

        private byte globalHotkeyIndexField;

        private bool globalHotkeyEnabledField;

        private byte globalHotkeyValueField;

        private byte globalHotkeyShiftField;

        private byte globalHotkeyAltField;

        private byte globalHotkeyCtrlField;

        private byte globalHotkeyWinField;

        private bool globalHotkeyPassThruField;

        private bool overrideMouseField;

        private byte mouseIndexField;

        private bool overrideStopField;

        private bool stopCommandHotkeyEnabledField;

        private byte stopCommandHotkeyValueField;

        private byte stopCommandHotkeyShiftField;

        private byte stopCommandHotkeyAltField;

        private byte stopCommandHotkeyCtrlField;

        private byte stopCommandHotkeyWinField;

        private bool stopCommandHotkeyPassThruField;

        private bool disableShortcutsField;

        private bool useOverrideListeningField;

        private bool overrideJoystickGlobalField;

        private byte globalJoystickIndexField;

        private byte globalJoystickButtonField;

        private byte globalJoystickNumberField;

        private byte globalJoystickButton2Field;

        private byte globalJoystickNumber2Field;

        private object referencedProfileField;

        private string exportVAVersionField;

        private byte exportOSVersionMajorField;

        private byte exportOSVersionMinorField;

        private bool overrideConfidenceField;

        private byte confidenceField;

        private bool catchAllEnabledField;

        private object catchAllIdField;

        private bool initializeCommandEnabledField;

        private object initializeCommandIdField;

        private bool useProcessOverrideField;

        private bool processOverrideAciveWindowField;

        private bool dictationCommandEnabledField;

        private object dictationCommandIdField;

        private bool enableProfileSwitchField;

        private object categoryGroupsField;

        private bool groupCategoryField;

        private string lastEditedCommandField;

        private byte isField;

        private byte ioField;

        private byte ipField;

        private byte beField;

        private bool unloadCommandEnabledField;

        private object unloadCommandIdField;

        private bool blockExternalField;

        private object authorIDField;

        private object productIDField;

        private byte crField;

        private object internalIDField;

        /// <remarks/>
        public bool HasMB
        {
            get
            {
                return this.hasMBField;
            }
            set
            {
                this.hasMBField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Command", IsNullable = false)]
        public ProfileCommand[] Commands
        {
            get
            {
                return this.commandsField;
            }
            set
            {
                this.commandsField = value;
            }
        }

        /// <remarks/>
        public bool OverrideGlobal
        {
            get
            {
                return this.overrideGlobalField;
            }
            set
            {
                this.overrideGlobalField = value;
            }
        }

        /// <remarks/>
        public byte GlobalHotkeyIndex
        {
            get
            {
                return this.globalHotkeyIndexField;
            }
            set
            {
                this.globalHotkeyIndexField = value;
            }
        }

        /// <remarks/>
        public bool GlobalHotkeyEnabled
        {
            get
            {
                return this.globalHotkeyEnabledField;
            }
            set
            {
                this.globalHotkeyEnabledField = value;
            }
        }

        /// <remarks/>
        public byte GlobalHotkeyValue
        {
            get
            {
                return this.globalHotkeyValueField;
            }
            set
            {
                this.globalHotkeyValueField = value;
            }
        }

        /// <remarks/>
        public byte GlobalHotkeyShift
        {
            get
            {
                return this.globalHotkeyShiftField;
            }
            set
            {
                this.globalHotkeyShiftField = value;
            }
        }

        /// <remarks/>
        public byte GlobalHotkeyAlt
        {
            get
            {
                return this.globalHotkeyAltField;
            }
            set
            {
                this.globalHotkeyAltField = value;
            }
        }

        /// <remarks/>
        public byte GlobalHotkeyCtrl
        {
            get
            {
                return this.globalHotkeyCtrlField;
            }
            set
            {
                this.globalHotkeyCtrlField = value;
            }
        }

        /// <remarks/>
        public byte GlobalHotkeyWin
        {
            get
            {
                return this.globalHotkeyWinField;
            }
            set
            {
                this.globalHotkeyWinField = value;
            }
        }

        /// <remarks/>
        public bool GlobalHotkeyPassThru
        {
            get
            {
                return this.globalHotkeyPassThruField;
            }
            set
            {
                this.globalHotkeyPassThruField = value;
            }
        }

        /// <remarks/>
        public bool OverrideMouse
        {
            get
            {
                return this.overrideMouseField;
            }
            set
            {
                this.overrideMouseField = value;
            }
        }

        /// <remarks/>
        public byte MouseIndex
        {
            get
            {
                return this.mouseIndexField;
            }
            set
            {
                this.mouseIndexField = value;
            }
        }

        /// <remarks/>
        public bool OverrideStop
        {
            get
            {
                return this.overrideStopField;
            }
            set
            {
                this.overrideStopField = value;
            }
        }

        /// <remarks/>
        public bool StopCommandHotkeyEnabled
        {
            get
            {
                return this.stopCommandHotkeyEnabledField;
            }
            set
            {
                this.stopCommandHotkeyEnabledField = value;
            }
        }

        /// <remarks/>
        public byte StopCommandHotkeyValue
        {
            get
            {
                return this.stopCommandHotkeyValueField;
            }
            set
            {
                this.stopCommandHotkeyValueField = value;
            }
        }

        /// <remarks/>
        public byte StopCommandHotkeyShift
        {
            get
            {
                return this.stopCommandHotkeyShiftField;
            }
            set
            {
                this.stopCommandHotkeyShiftField = value;
            }
        }

        /// <remarks/>
        public byte StopCommandHotkeyAlt
        {
            get
            {
                return this.stopCommandHotkeyAltField;
            }
            set
            {
                this.stopCommandHotkeyAltField = value;
            }
        }

        /// <remarks/>
        public byte StopCommandHotkeyCtrl
        {
            get
            {
                return this.stopCommandHotkeyCtrlField;
            }
            set
            {
                this.stopCommandHotkeyCtrlField = value;
            }
        }

        /// <remarks/>
        public byte StopCommandHotkeyWin
        {
            get
            {
                return this.stopCommandHotkeyWinField;
            }
            set
            {
                this.stopCommandHotkeyWinField = value;
            }
        }

        /// <remarks/>
        public bool StopCommandHotkeyPassThru
        {
            get
            {
                return this.stopCommandHotkeyPassThruField;
            }
            set
            {
                this.stopCommandHotkeyPassThruField = value;
            }
        }

        /// <remarks/>
        public bool DisableShortcuts
        {
            get
            {
                return this.disableShortcutsField;
            }
            set
            {
                this.disableShortcutsField = value;
            }
        }

        /// <remarks/>
        public bool UseOverrideListening
        {
            get
            {
                return this.useOverrideListeningField;
            }
            set
            {
                this.useOverrideListeningField = value;
            }
        }

        /// <remarks/>
        public bool OverrideJoystickGlobal
        {
            get
            {
                return this.overrideJoystickGlobalField;
            }
            set
            {
                this.overrideJoystickGlobalField = value;
            }
        }

        /// <remarks/>
        public byte GlobalJoystickIndex
        {
            get
            {
                return this.globalJoystickIndexField;
            }
            set
            {
                this.globalJoystickIndexField = value;
            }
        }

        /// <remarks/>
        public byte GlobalJoystickButton
        {
            get
            {
                return this.globalJoystickButtonField;
            }
            set
            {
                this.globalJoystickButtonField = value;
            }
        }

        /// <remarks/>
        public byte GlobalJoystickNumber
        {
            get
            {
                return this.globalJoystickNumberField;
            }
            set
            {
                this.globalJoystickNumberField = value;
            }
        }

        /// <remarks/>
        public byte GlobalJoystickButton2
        {
            get
            {
                return this.globalJoystickButton2Field;
            }
            set
            {
                this.globalJoystickButton2Field = value;
            }
        }

        /// <remarks/>
        public byte GlobalJoystickNumber2
        {
            get
            {
                return this.globalJoystickNumber2Field;
            }
            set
            {
                this.globalJoystickNumber2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ReferencedProfile
        {
            get
            {
                return this.referencedProfileField;
            }
            set
            {
                this.referencedProfileField = value;
            }
        }

        /// <remarks/>
        public string ExportVAVersion
        {
            get
            {
                return this.exportVAVersionField;
            }
            set
            {
                this.exportVAVersionField = value;
            }
        }

        /// <remarks/>
        public byte ExportOSVersionMajor
        {
            get
            {
                return this.exportOSVersionMajorField;
            }
            set
            {
                this.exportOSVersionMajorField = value;
            }
        }

        /// <remarks/>
        public byte ExportOSVersionMinor
        {
            get
            {
                return this.exportOSVersionMinorField;
            }
            set
            {
                this.exportOSVersionMinorField = value;
            }
        }

        /// <remarks/>
        public bool OverrideConfidence
        {
            get
            {
                return this.overrideConfidenceField;
            }
            set
            {
                this.overrideConfidenceField = value;
            }
        }

        /// <remarks/>
        public byte Confidence
        {
            get
            {
                return this.confidenceField;
            }
            set
            {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        public bool CatchAllEnabled
        {
            get
            {
                return this.catchAllEnabledField;
            }
            set
            {
                this.catchAllEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object CatchAllId
        {
            get
            {
                return this.catchAllIdField;
            }
            set
            {
                this.catchAllIdField = value;
            }
        }

        /// <remarks/>
        public bool InitializeCommandEnabled
        {
            get
            {
                return this.initializeCommandEnabledField;
            }
            set
            {
                this.initializeCommandEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object InitializeCommandId
        {
            get
            {
                return this.initializeCommandIdField;
            }
            set
            {
                this.initializeCommandIdField = value;
            }
        }

        /// <remarks/>
        public bool UseProcessOverride
        {
            get
            {
                return this.useProcessOverrideField;
            }
            set
            {
                this.useProcessOverrideField = value;
            }
        }

        /// <remarks/>
        public bool ProcessOverrideAciveWindow
        {
            get
            {
                return this.processOverrideAciveWindowField;
            }
            set
            {
                this.processOverrideAciveWindowField = value;
            }
        }

        /// <remarks/>
        public bool DictationCommandEnabled
        {
            get
            {
                return this.dictationCommandEnabledField;
            }
            set
            {
                this.dictationCommandEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object DictationCommandId
        {
            get
            {
                return this.dictationCommandIdField;
            }
            set
            {
                this.dictationCommandIdField = value;
            }
        }

        /// <remarks/>
        public bool EnableProfileSwitch
        {
            get
            {
                return this.enableProfileSwitchField;
            }
            set
            {
                this.enableProfileSwitchField = value;
            }
        }

        /// <remarks/>
        public object CategoryGroups
        {
            get
            {
                return this.categoryGroupsField;
            }
            set
            {
                this.categoryGroupsField = value;
            }
        }

        /// <remarks/>
        public bool GroupCategory
        {
            get
            {
                return this.groupCategoryField;
            }
            set
            {
                this.groupCategoryField = value;
            }
        }

        /// <remarks/>
        public string LastEditedCommand
        {
            get
            {
                return this.lastEditedCommandField;
            }
            set
            {
                this.lastEditedCommandField = value;
            }
        }

        /// <remarks/>
        public byte IS
        {
            get
            {
                return this.isField;
            }
            set
            {
                this.isField = value;
            }
        }

        /// <remarks/>
        public byte IO
        {
            get
            {
                return this.ioField;
            }
            set
            {
                this.ioField = value;
            }
        }

        /// <remarks/>
        public byte IP
        {
            get
            {
                return this.ipField;
            }
            set
            {
                this.ipField = value;
            }
        }

        /// <remarks/>
        public byte BE
        {
            get
            {
                return this.beField;
            }
            set
            {
                this.beField = value;
            }
        }

        /// <remarks/>
        public bool UnloadCommandEnabled
        {
            get
            {
                return this.unloadCommandEnabledField;
            }
            set
            {
                this.unloadCommandEnabledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object UnloadCommandId
        {
            get
            {
                return this.unloadCommandIdField;
            }
            set
            {
                this.unloadCommandIdField = value;
            }
        }

        /// <remarks/>
        public bool BlockExternal
        {
            get
            {
                return this.blockExternalField;
            }
            set
            {
                this.blockExternalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object AuthorID
        {
            get
            {
                return this.authorIDField;
            }
            set
            {
                this.authorIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        public byte CR
        {
            get
            {
                return this.crField;
            }
            set
            {
                this.crField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object InternalID
        {
            get
            {
                return this.internalIDField;
            }
            set
            {
                this.internalIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProfileCommand
    {

        private object referrerField;

        private byte execTypeField;

        private byte confidenceField;

        private byte prefixActionCountField;

        private bool isDynamicallyCreatedField;

        private bool targetProcessSetField;

        private byte targetProcessTypeField;

        private byte targetProcessLevelField;

        private byte compareTypeField;

        private bool execFromWildcardField;

        private bool isSubCommandField;

        private bool isOverrideField;

        private string baseIdField;

        private string originIdField;

        private bool sessionEnabledField;

        private string idField;

        private string commandStringField;

        private ProfileCommandCommandAction[] actionSequenceField;

        private bool asyncField;

        private bool enabledField;

        private bool useShortcutField;

        private byte keyValueField;

        private byte keyShiftField;

        private byte keyAltField;

        private byte keyCtrlField;

        private byte keyWinField;

        private bool keyPassthruField;

        private bool useSpokenPhraseField;

        private bool onlyKeyUpField;

        private byte repeatNumberField;

        private byte repeatTypeField;

        private byte commandTypeField;

        private string sourceProfileField;

        private bool useConfidenceField;

        private byte minimumConfidenceLevelField;

        private bool useJoystickField;

        private byte joystickNumberField;

        private byte joystickButtonField;

        private byte joystickNumber2Field;

        private byte joystickButton2Field;

        private bool joystickUpField;

        private bool keepRepeatingField;

        private bool useProcessOverrideField;

        private bool processOverrideActiveWindowField;

        private bool lostFocusStopField;

        private bool pauseLostFocusField;

        private bool lostFocusBackCompatField;

        private bool useMouseField;

        private bool mouse1Field;

        private bool mouse2Field;

        private bool mouse3Field;

        private bool mouse4Field;

        private bool mouse5Field;

        private bool mouse6Field;

        private bool mouse7Field;

        private bool mouse8Field;

        private bool mouse9Field;

        private bool mouseUpOnlyField;

        private bool mousePassThruField;

        private bool joystickExclusiveField;

        private string lastEditedActionField;

        private bool useProfileProcessOverrideField;

        private bool profileProcessOverrideActiveWindowField;

        private bool repeatIfKeysDownField;

        private bool repeatIfMouseDownField;

        private bool repeatIfJoystickDownField;

        private byte ahField;

        private byte clField;

        private bool hasMBField;

        private bool useVariableHotkeyField;

        private byte cLEField;

        private bool eX1Field;

        private bool eX2Field;

        private object internalIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Referrer
        {
            get
            {
                return this.referrerField;
            }
            set
            {
                this.referrerField = value;
            }
        }

        /// <remarks/>
        public byte ExecType
        {
            get
            {
                return this.execTypeField;
            }
            set
            {
                this.execTypeField = value;
            }
        }

        /// <remarks/>
        public byte Confidence
        {
            get
            {
                return this.confidenceField;
            }
            set
            {
                this.confidenceField = value;
            }
        }

        /// <remarks/>
        public byte PrefixActionCount
        {
            get
            {
                return this.prefixActionCountField;
            }
            set
            {
                this.prefixActionCountField = value;
            }
        }

        /// <remarks/>
        public bool IsDynamicallyCreated
        {
            get
            {
                return this.isDynamicallyCreatedField;
            }
            set
            {
                this.isDynamicallyCreatedField = value;
            }
        }

        /// <remarks/>
        public bool TargetProcessSet
        {
            get
            {
                return this.targetProcessSetField;
            }
            set
            {
                this.targetProcessSetField = value;
            }
        }

        /// <remarks/>
        public byte TargetProcessType
        {
            get
            {
                return this.targetProcessTypeField;
            }
            set
            {
                this.targetProcessTypeField = value;
            }
        }

        /// <remarks/>
        public byte TargetProcessLevel
        {
            get
            {
                return this.targetProcessLevelField;
            }
            set
            {
                this.targetProcessLevelField = value;
            }
        }

        /// <remarks/>
        public byte CompareType
        {
            get
            {
                return this.compareTypeField;
            }
            set
            {
                this.compareTypeField = value;
            }
        }

        /// <remarks/>
        public bool ExecFromWildcard
        {
            get
            {
                return this.execFromWildcardField;
            }
            set
            {
                this.execFromWildcardField = value;
            }
        }

        /// <remarks/>
        public bool IsSubCommand
        {
            get
            {
                return this.isSubCommandField;
            }
            set
            {
                this.isSubCommandField = value;
            }
        }

        /// <remarks/>
        public bool IsOverride
        {
            get
            {
                return this.isOverrideField;
            }
            set
            {
                this.isOverrideField = value;
            }
        }

        /// <remarks/>
        public string BaseId
        {
            get
            {
                return this.baseIdField;
            }
            set
            {
                this.baseIdField = value;
            }
        }

        /// <remarks/>
        public string OriginId
        {
            get
            {
                return this.originIdField;
            }
            set
            {
                this.originIdField = value;
            }
        }

        /// <remarks/>
        public bool SessionEnabled
        {
            get
            {
                return this.sessionEnabledField;
            }
            set
            {
                this.sessionEnabledField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string CommandString
        {
            get
            {
                return this.commandStringField;
            }
            set
            {
                this.commandStringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CommandAction", IsNullable = false)]
        public ProfileCommandCommandAction[] ActionSequence
        {
            get
            {
                return this.actionSequenceField;
            }
            set
            {
                this.actionSequenceField = value;
            }
        }

        /// <remarks/>
        public bool Async
        {
            get
            {
                return this.asyncField;
            }
            set
            {
                this.asyncField = value;
            }
        }

        /// <remarks/>
        public bool Enabled
        {
            get
            {
                return this.enabledField;
            }
            set
            {
                this.enabledField = value;
            }
        }

        /// <remarks/>
        public bool UseShortcut
        {
            get
            {
                return this.useShortcutField;
            }
            set
            {
                this.useShortcutField = value;
            }
        }

        /// <remarks/>
        public byte keyValue
        {
            get
            {
                return this.keyValueField;
            }
            set
            {
                this.keyValueField = value;
            }
        }

        /// <remarks/>
        public byte keyShift
        {
            get
            {
                return this.keyShiftField;
            }
            set
            {
                this.keyShiftField = value;
            }
        }

        /// <remarks/>
        public byte keyAlt
        {
            get
            {
                return this.keyAltField;
            }
            set
            {
                this.keyAltField = value;
            }
        }

        /// <remarks/>
        public byte keyCtrl
        {
            get
            {
                return this.keyCtrlField;
            }
            set
            {
                this.keyCtrlField = value;
            }
        }

        /// <remarks/>
        public byte keyWin
        {
            get
            {
                return this.keyWinField;
            }
            set
            {
                this.keyWinField = value;
            }
        }

        /// <remarks/>
        public bool keyPassthru
        {
            get
            {
                return this.keyPassthruField;
            }
            set
            {
                this.keyPassthruField = value;
            }
        }

        /// <remarks/>
        public bool UseSpokenPhrase
        {
            get
            {
                return this.useSpokenPhraseField;
            }
            set
            {
                this.useSpokenPhraseField = value;
            }
        }

        /// <remarks/>
        public bool onlyKeyUp
        {
            get
            {
                return this.onlyKeyUpField;
            }
            set
            {
                this.onlyKeyUpField = value;
            }
        }

        /// <remarks/>
        public byte RepeatNumber
        {
            get
            {
                return this.repeatNumberField;
            }
            set
            {
                this.repeatNumberField = value;
            }
        }

        /// <remarks/>
        public byte RepeatType
        {
            get
            {
                return this.repeatTypeField;
            }
            set
            {
                this.repeatTypeField = value;
            }
        }

        /// <remarks/>
        public byte CommandType
        {
            get
            {
                return this.commandTypeField;
            }
            set
            {
                this.commandTypeField = value;
            }
        }

        /// <remarks/>
        public string SourceProfile
        {
            get
            {
                return this.sourceProfileField;
            }
            set
            {
                this.sourceProfileField = value;
            }
        }

        /// <remarks/>
        public bool UseConfidence
        {
            get
            {
                return this.useConfidenceField;
            }
            set
            {
                this.useConfidenceField = value;
            }
        }

        /// <remarks/>
        public byte minimumConfidenceLevel
        {
            get
            {
                return this.minimumConfidenceLevelField;
            }
            set
            {
                this.minimumConfidenceLevelField = value;
            }
        }

        /// <remarks/>
        public bool UseJoystick
        {
            get
            {
                return this.useJoystickField;
            }
            set
            {
                this.useJoystickField = value;
            }
        }

        /// <remarks/>
        public byte joystickNumber
        {
            get
            {
                return this.joystickNumberField;
            }
            set
            {
                this.joystickNumberField = value;
            }
        }

        /// <remarks/>
        public byte joystickButton
        {
            get
            {
                return this.joystickButtonField;
            }
            set
            {
                this.joystickButtonField = value;
            }
        }

        /// <remarks/>
        public byte joystickNumber2
        {
            get
            {
                return this.joystickNumber2Field;
            }
            set
            {
                this.joystickNumber2Field = value;
            }
        }

        /// <remarks/>
        public byte joystickButton2
        {
            get
            {
                return this.joystickButton2Field;
            }
            set
            {
                this.joystickButton2Field = value;
            }
        }

        /// <remarks/>
        public bool joystickUp
        {
            get
            {
                return this.joystickUpField;
            }
            set
            {
                this.joystickUpField = value;
            }
        }

        /// <remarks/>
        public bool KeepRepeating
        {
            get
            {
                return this.keepRepeatingField;
            }
            set
            {
                this.keepRepeatingField = value;
            }
        }

        /// <remarks/>
        public bool UseProcessOverride
        {
            get
            {
                return this.useProcessOverrideField;
            }
            set
            {
                this.useProcessOverrideField = value;
            }
        }

        /// <remarks/>
        public bool ProcessOverrideActiveWindow
        {
            get
            {
                return this.processOverrideActiveWindowField;
            }
            set
            {
                this.processOverrideActiveWindowField = value;
            }
        }

        /// <remarks/>
        public bool LostFocusStop
        {
            get
            {
                return this.lostFocusStopField;
            }
            set
            {
                this.lostFocusStopField = value;
            }
        }

        /// <remarks/>
        public bool PauseLostFocus
        {
            get
            {
                return this.pauseLostFocusField;
            }
            set
            {
                this.pauseLostFocusField = value;
            }
        }

        /// <remarks/>
        public bool LostFocusBackCompat
        {
            get
            {
                return this.lostFocusBackCompatField;
            }
            set
            {
                this.lostFocusBackCompatField = value;
            }
        }

        /// <remarks/>
        public bool UseMouse
        {
            get
            {
                return this.useMouseField;
            }
            set
            {
                this.useMouseField = value;
            }
        }

        /// <remarks/>
        public bool Mouse1
        {
            get
            {
                return this.mouse1Field;
            }
            set
            {
                this.mouse1Field = value;
            }
        }

        /// <remarks/>
        public bool Mouse2
        {
            get
            {
                return this.mouse2Field;
            }
            set
            {
                this.mouse2Field = value;
            }
        }

        /// <remarks/>
        public bool Mouse3
        {
            get
            {
                return this.mouse3Field;
            }
            set
            {
                this.mouse3Field = value;
            }
        }

        /// <remarks/>
        public bool Mouse4
        {
            get
            {
                return this.mouse4Field;
            }
            set
            {
                this.mouse4Field = value;
            }
        }

        /// <remarks/>
        public bool Mouse5
        {
            get
            {
                return this.mouse5Field;
            }
            set
            {
                this.mouse5Field = value;
            }
        }

        /// <remarks/>
        public bool Mouse6
        {
            get
            {
                return this.mouse6Field;
            }
            set
            {
                this.mouse6Field = value;
            }
        }

        /// <remarks/>
        public bool Mouse7
        {
            get
            {
                return this.mouse7Field;
            }
            set
            {
                this.mouse7Field = value;
            }
        }

        /// <remarks/>
        public bool Mouse8
        {
            get
            {
                return this.mouse8Field;
            }
            set
            {
                this.mouse8Field = value;
            }
        }

        /// <remarks/>
        public bool Mouse9
        {
            get
            {
                return this.mouse9Field;
            }
            set
            {
                this.mouse9Field = value;
            }
        }

        /// <remarks/>
        public bool MouseUpOnly
        {
            get
            {
                return this.mouseUpOnlyField;
            }
            set
            {
                this.mouseUpOnlyField = value;
            }
        }

        /// <remarks/>
        public bool MousePassThru
        {
            get
            {
                return this.mousePassThruField;
            }
            set
            {
                this.mousePassThruField = value;
            }
        }

        /// <remarks/>
        public bool joystickExclusive
        {
            get
            {
                return this.joystickExclusiveField;
            }
            set
            {
                this.joystickExclusiveField = value;
            }
        }

        /// <remarks/>
        public string lastEditedAction
        {
            get
            {
                return this.lastEditedActionField;
            }
            set
            {
                this.lastEditedActionField = value;
            }
        }

        /// <remarks/>
        public bool UseProfileProcessOverride
        {
            get
            {
                return this.useProfileProcessOverrideField;
            }
            set
            {
                this.useProfileProcessOverrideField = value;
            }
        }

        /// <remarks/>
        public bool ProfileProcessOverrideActiveWindow
        {
            get
            {
                return this.profileProcessOverrideActiveWindowField;
            }
            set
            {
                this.profileProcessOverrideActiveWindowField = value;
            }
        }

        /// <remarks/>
        public bool RepeatIfKeysDown
        {
            get
            {
                return this.repeatIfKeysDownField;
            }
            set
            {
                this.repeatIfKeysDownField = value;
            }
        }

        /// <remarks/>
        public bool RepeatIfMouseDown
        {
            get
            {
                return this.repeatIfMouseDownField;
            }
            set
            {
                this.repeatIfMouseDownField = value;
            }
        }

        /// <remarks/>
        public bool RepeatIfJoystickDown
        {
            get
            {
                return this.repeatIfJoystickDownField;
            }
            set
            {
                this.repeatIfJoystickDownField = value;
            }
        }

        /// <remarks/>
        public byte AH
        {
            get
            {
                return this.ahField;
            }
            set
            {
                this.ahField = value;
            }
        }

        /// <remarks/>
        public byte CL
        {
            get
            {
                return this.clField;
            }
            set
            {
                this.clField = value;
            }
        }

        /// <remarks/>
        public bool HasMB
        {
            get
            {
                return this.hasMBField;
            }
            set
            {
                this.hasMBField = value;
            }
        }

        /// <remarks/>
        public bool UseVariableHotkey
        {
            get
            {
                return this.useVariableHotkeyField;
            }
            set
            {
                this.useVariableHotkeyField = value;
            }
        }

        /// <remarks/>
        public byte CLE
        {
            get
            {
                return this.cLEField;
            }
            set
            {
                this.cLEField = value;
            }
        }

        /// <remarks/>
        public bool EX1
        {
            get
            {
                return this.eX1Field;
            }
            set
            {
                this.eX1Field = value;
            }
        }

        /// <remarks/>
        public bool EX2
        {
            get
            {
                return this.eX2Field;
            }
            set
            {
                this.eX2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object InternalId
        {
            get
            {
                return this.internalIdField;
            }
            set
            {
                this.internalIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProfileCommandCommandAction
    {

        private string _captionField;

        private bool pairingSetField;

        private bool pairingSetElseField;

        private byte ordinalField;

        private object conditionMetField;

        private byte indentLevelField;

        private bool conditionSkipField;

        private bool isSuffixActionField;

        private byte decimalTransient1Field;

        private string captionField;

        private string idField;

        private string actionTypeField;

        private decimal durationField;

        private byte delayField;

        private ProfileCommandCommandActionKeyCodes keyCodesField;

        private object contextField;

        private byte xField;

        private byte yField;

        private byte zField;

        private byte inputModeField;

        private byte conditionPairingField;

        private byte conditionGroupField;

        private byte conditionStartOperatorField;

        private byte conditionStartValueField;

        private byte conditionStartValueTypeField;

        private byte conditionStartTypeField;

        private byte decimalContext1Field;

        private byte decimalContext2Field;

        private System.DateTime dateContext1Field;

        private System.DateTime dateContext2Field;

        private bool disabledField;

        private object randomSoundsField;

        /// <remarks/>
        public string _caption
        {
            get
            {
                return this._captionField;
            }
            set
            {
                this._captionField = value;
            }
        }

        /// <remarks/>
        public bool PairingSet
        {
            get
            {
                return this.pairingSetField;
            }
            set
            {
                this.pairingSetField = value;
            }
        }

        /// <remarks/>
        public bool PairingSetElse
        {
            get
            {
                return this.pairingSetElseField;
            }
            set
            {
                this.pairingSetElseField = value;
            }
        }

        /// <remarks/>
        public byte Ordinal
        {
            get
            {
                return this.ordinalField;
            }
            set
            {
                this.ordinalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ConditionMet
        {
            get
            {
                return this.conditionMetField;
            }
            set
            {
                this.conditionMetField = value;
            }
        }

        /// <remarks/>
        public byte IndentLevel
        {
            get
            {
                return this.indentLevelField;
            }
            set
            {
                this.indentLevelField = value;
            }
        }

        /// <remarks/>
        public bool ConditionSkip
        {
            get
            {
                return this.conditionSkipField;
            }
            set
            {
                this.conditionSkipField = value;
            }
        }

        /// <remarks/>
        public bool IsSuffixAction
        {
            get
            {
                return this.isSuffixActionField;
            }
            set
            {
                this.isSuffixActionField = value;
            }
        }

        /// <remarks/>
        public byte DecimalTransient1
        {
            get
            {
                return this.decimalTransient1Field;
            }
            set
            {
                this.decimalTransient1Field = value;
            }
        }

        /// <remarks/>
        public string Caption
        {
            get
            {
                return this.captionField;
            }
            set
            {
                this.captionField = value;
            }
        }

        /// <remarks/>
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string ActionType
        {
            get
            {
                return this.actionTypeField;
            }
            set
            {
                this.actionTypeField = value;
            }
        }

        /// <remarks/>
        public decimal Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        public byte Delay
        {
            get
            {
                return this.delayField;
            }
            set
            {
                this.delayField = value;
            }
        }

        /// <remarks/>
        public ProfileCommandCommandActionKeyCodes KeyCodes
        {
            get
            {
                return this.keyCodesField;
            }
            set
            {
                this.keyCodesField = value;
            }
        }

        /// <remarks/>
        public object Context
        {
            get
            {
                return this.contextField;
            }
            set
            {
                this.contextField = value;
            }
        }

        /// <remarks/>
        public byte X
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public byte Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public byte Z
        {
            get
            {
                return this.zField;
            }
            set
            {
                this.zField = value;
            }
        }

        /// <remarks/>
        public byte InputMode
        {
            get
            {
                return this.inputModeField;
            }
            set
            {
                this.inputModeField = value;
            }
        }

        /// <remarks/>
        public byte ConditionPairing
        {
            get
            {
                return this.conditionPairingField;
            }
            set
            {
                this.conditionPairingField = value;
            }
        }

        /// <remarks/>
        public byte ConditionGroup
        {
            get
            {
                return this.conditionGroupField;
            }
            set
            {
                this.conditionGroupField = value;
            }
        }

        /// <remarks/>
        public byte ConditionStartOperator
        {
            get
            {
                return this.conditionStartOperatorField;
            }
            set
            {
                this.conditionStartOperatorField = value;
            }
        }

        /// <remarks/>
        public byte ConditionStartValue
        {
            get
            {
                return this.conditionStartValueField;
            }
            set
            {
                this.conditionStartValueField = value;
            }
        }

        /// <remarks/>
        public byte ConditionStartValueType
        {
            get
            {
                return this.conditionStartValueTypeField;
            }
            set
            {
                this.conditionStartValueTypeField = value;
            }
        }

        /// <remarks/>
        public byte ConditionStartType
        {
            get
            {
                return this.conditionStartTypeField;
            }
            set
            {
                this.conditionStartTypeField = value;
            }
        }

        /// <remarks/>
        public byte DecimalContext1
        {
            get
            {
                return this.decimalContext1Field;
            }
            set
            {
                this.decimalContext1Field = value;
            }
        }

        /// <remarks/>
        public byte DecimalContext2
        {
            get
            {
                return this.decimalContext2Field;
            }
            set
            {
                this.decimalContext2Field = value;
            }
        }

        /// <remarks/>
        public System.DateTime DateContext1
        {
            get
            {
                return this.dateContext1Field;
            }
            set
            {
                this.dateContext1Field = value;
            }
        }

        /// <remarks/>
        public System.DateTime DateContext2
        {
            get
            {
                return this.dateContext2Field;
            }
            set
            {
                this.dateContext2Field = value;
            }
        }

        /// <remarks/>
        public bool Disabled
        {
            get
            {
                return this.disabledField;
            }
            set
            {
                this.disabledField = value;
            }
        }

        /// <remarks/>
        public object RandomSounds
        {
            get
            {
                return this.randomSoundsField;
            }
            set
            {
                this.randomSoundsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProfileCommandCommandActionKeyCodes
    {

        private byte unsignedShortField;

        /// <remarks/>
        public byte unsignedShort
        {
            get
            {
                return this.unsignedShortField;
            }
            set
            {
                this.unsignedShortField = value;
            }
        }
    }


}
