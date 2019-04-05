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

        private int globalHotkeyIndexField;

        private bool globalHotkeyEnabledField;

        private int globalHotkeyValueField;

        private int globalHotkeyShiftField;

        private int globalHotkeyAltField;

        private int globalHotkeyCtrlField;

        private int globalHotkeyWinField;

        private bool globalHotkeyPassThruField;

        private bool overrideMouseField;

        private int mouseIndexField;

        private bool overrideStopField;

        private bool stopCommandHotkeyEnabledField;

        private int stopCommandHotkeyValueField;

        private int stopCommandHotkeyShiftField;

        private int stopCommandHotkeyAltField;

        private int stopCommandHotkeyCtrlField;

        private int stopCommandHotkeyWinField;

        private bool stopCommandHotkeyPassThruField;

        private bool disableShortcutsField;

        private bool useOverrideListeningField;

        private bool overrideJoystickGlobalField;

        private int globalJoystickIndexField;

        private int globalJoystickButtonField;

        private int globalJoystickNumberField;

        private int globalJoystickButton2Field;

        private int globalJoystickNumber2Field;

        private object referencedProfileField;

        private string exportVAVersionField;

        private int exportOSVersionMajorField;

        private int exportOSVersionMinorField;

        private bool overrideConfidenceField;

        private int confidenceField;

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

        private int isField;

        private int ioField;

        private int ipField;

        private int beField;

        private bool unloadCommandEnabledField;

        private object unloadCommandIdField;

        private bool blockExternalField;

        private object authorIDField;

        private object productIDField;

        private int crField;

        private object internalIDField;

        /// <remarks/>
        public bool HasMB
        {
            get => hasMBField;
            set => hasMBField = value;
        }

        /// <remarks/>
        public string Id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks/>
        public string Name
        {
            get => nameField;
            set => nameField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Command", IsNullable = false)]
        public ProfileCommand[] Commands
        {
            get => commandsField;
            set => commandsField = value;
        }

        /// <remarks/>
        public bool OverrideGlobal
        {
            get => overrideGlobalField;
            set => overrideGlobalField = value;
        }

        /// <remarks/>
        public int GlobalHotkeyIndex
        {
            get => globalHotkeyIndexField;
            set => globalHotkeyIndexField = value;
        }

        /// <remarks/>
        public bool GlobalHotkeyEnabled
        {
            get => globalHotkeyEnabledField;
            set => globalHotkeyEnabledField = value;
        }

        /// <remarks/>
        public int GlobalHotkeyValue
        {
            get => globalHotkeyValueField;
            set => globalHotkeyValueField = value;
        }

        /// <remarks/>
        public int GlobalHotkeyShift
        {
            get => globalHotkeyShiftField;
            set => globalHotkeyShiftField = value;
        }

        /// <remarks/>
        public int GlobalHotkeyAlt
        {
            get => globalHotkeyAltField;
            set => globalHotkeyAltField = value;
        }

        /// <remarks/>
        public int GlobalHotkeyCtrl
        {
            get => globalHotkeyCtrlField;
            set => globalHotkeyCtrlField = value;
        }

        /// <remarks/>
        public int GlobalHotkeyWin
        {
            get => globalHotkeyWinField;
            set => globalHotkeyWinField = value;
        }

        /// <remarks/>
        public bool GlobalHotkeyPassThru
        {
            get => globalHotkeyPassThruField;
            set => globalHotkeyPassThruField = value;
        }

        /// <remarks/>
        public bool OverrideMouse
        {
            get => overrideMouseField;
            set => overrideMouseField = value;
        }

        /// <remarks/>
        public int MouseIndex
        {
            get => mouseIndexField;
            set => mouseIndexField = value;
        }

        /// <remarks/>
        public bool OverrideStop
        {
            get => overrideStopField;
            set => overrideStopField = value;
        }

        /// <remarks/>
        public bool StopCommandHotkeyEnabled
        {
            get => stopCommandHotkeyEnabledField;
            set => stopCommandHotkeyEnabledField = value;
        }

        /// <remarks/>
        public int StopCommandHotkeyValue
        {
            get => stopCommandHotkeyValueField;
            set => stopCommandHotkeyValueField = value;
        }

        /// <remarks/>
        public int StopCommandHotkeyShift
        {
            get => stopCommandHotkeyShiftField;
            set => stopCommandHotkeyShiftField = value;
        }

        /// <remarks/>
        public int StopCommandHotkeyAlt
        {
            get => stopCommandHotkeyAltField;
            set => stopCommandHotkeyAltField = value;
        }

        /// <remarks/>
        public int StopCommandHotkeyCtrl
        {
            get => stopCommandHotkeyCtrlField;
            set => stopCommandHotkeyCtrlField = value;
        }

        /// <remarks/>
        public int StopCommandHotkeyWin
        {
            get => stopCommandHotkeyWinField;
            set => stopCommandHotkeyWinField = value;
        }

        /// <remarks/>
        public bool StopCommandHotkeyPassThru
        {
            get => stopCommandHotkeyPassThruField;
            set => stopCommandHotkeyPassThruField = value;
        }

        /// <remarks/>
        public bool DisableShortcuts
        {
            get => disableShortcutsField;
            set => disableShortcutsField = value;
        }

        /// <remarks/>
        public bool UseOverrideListening
        {
            get => useOverrideListeningField;
            set => useOverrideListeningField = value;
        }

        /// <remarks/>
        public bool OverrideJoystickGlobal
        {
            get => overrideJoystickGlobalField;
            set => overrideJoystickGlobalField = value;
        }

        /// <remarks/>
        public int GlobalJoystickIndex
        {
            get => globalJoystickIndexField;
            set => globalJoystickIndexField = value;
        }

        /// <remarks/>
        public int GlobalJoystickButton
        {
            get => globalJoystickButtonField;
            set => globalJoystickButtonField = value;
        }

        /// <remarks/>
        public int GlobalJoystickNumber
        {
            get => globalJoystickNumberField;
            set => globalJoystickNumberField = value;
        }

        /// <remarks/>
        public int GlobalJoystickButton2
        {
            get => globalJoystickButton2Field;
            set => globalJoystickButton2Field = value;
        }

        /// <remarks/>
        public int GlobalJoystickNumber2
        {
            get => globalJoystickNumber2Field;
            set => globalJoystickNumber2Field = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ReferencedProfile
        {
            get => referencedProfileField;
            set => referencedProfileField = value;
        }

        /// <remarks/>
        public string ExportVAVersion
        {
            get => exportVAVersionField;
            set => exportVAVersionField = value;
        }

        /// <remarks/>
        public int ExportOSVersionMajor
        {
            get => exportOSVersionMajorField;
            set => exportOSVersionMajorField = value;
        }

        /// <remarks/>
        public int ExportOSVersionMinor
        {
            get => exportOSVersionMinorField;
            set => exportOSVersionMinorField = value;
        }

        /// <remarks/>
        public bool OverrideConfidence
        {
            get => overrideConfidenceField;
            set => overrideConfidenceField = value;
        }

        /// <remarks/>
        public int Confidence
        {
            get => confidenceField;
            set => confidenceField = value;
        }

        /// <remarks/>
        public bool CatchAllEnabled
        {
            get => catchAllEnabledField;
            set => catchAllEnabledField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object CatchAllId
        {
            get => catchAllIdField;
            set => catchAllIdField = value;
        }

        /// <remarks/>
        public bool InitializeCommandEnabled
        {
            get => initializeCommandEnabledField;
            set => initializeCommandEnabledField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object InitializeCommandId
        {
            get => initializeCommandIdField;
            set => initializeCommandIdField = value;
        }

        /// <remarks/>
        public bool UseProcessOverride
        {
            get => useProcessOverrideField;
            set => useProcessOverrideField = value;
        }

        /// <remarks/>
        public bool ProcessOverrideAciveWindow
        {
            get => processOverrideAciveWindowField;
            set => processOverrideAciveWindowField = value;
        }

        /// <remarks/>
        public bool DictationCommandEnabled
        {
            get => dictationCommandEnabledField;
            set => dictationCommandEnabledField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object DictationCommandId
        {
            get => dictationCommandIdField;
            set => dictationCommandIdField = value;
        }

        /// <remarks/>
        public bool EnableProfileSwitch
        {
            get => enableProfileSwitchField;
            set => enableProfileSwitchField = value;
        }

        /// <remarks/>
        public object CategoryGroups
        {
            get => categoryGroupsField;
            set => categoryGroupsField = value;
        }

        /// <remarks/>
        public bool GroupCategory
        {
            get => groupCategoryField;
            set => groupCategoryField = value;
        }

        /// <remarks/>
        public string LastEditedCommand
        {
            get => lastEditedCommandField;
            set => lastEditedCommandField = value;
        }

        /// <remarks/>
        public int IS
        {
            get => isField;
            set => isField = value;
        }

        /// <remarks/>
        public int IO
        {
            get => ioField;
            set => ioField = value;
        }

        /// <remarks/>
        public int IP
        {
            get => ipField;
            set => ipField = value;
        }

        /// <remarks/>
        public int BE
        {
            get => beField;
            set => beField = value;
        }

        /// <remarks/>
        public bool UnloadCommandEnabled
        {
            get => unloadCommandEnabledField;
            set => unloadCommandEnabledField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object UnloadCommandId
        {
            get => unloadCommandIdField;
            set => unloadCommandIdField = value;
        }

        /// <remarks/>
        public bool BlockExternal
        {
            get => blockExternalField;
            set => blockExternalField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object AuthorID
        {
            get => authorIDField;
            set => authorIDField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ProductID
        {
            get => productIDField;
            set => productIDField = value;
        }

        /// <remarks/>
        public int CR
        {
            get => crField;
            set => crField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object InternalID
        {
            get => internalIDField;
            set => internalIDField = value;
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ProfileCommand
    {

        private object referrerField;

        private int execTypeField;

        private int confidenceField;

        private int prefixActionCountField;

        private bool isDynamicallyCreatedField;

        private bool targetProcessSetField;

        private int targetProcessTypeField;

        private int targetProcessLevelField;

        private int compareTypeField;

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

        private int keyValueField;

        private int keyShiftField;

        private int keyAltField;

        private int keyCtrlField;

        private int keyWinField;

        private bool keyPassthruField;

        private bool useSpokenPhraseField;

        private bool onlyKeyUpField;

        private int repeatNumberField;

        private int repeatTypeField;

        private int commandTypeField;

        private string sourceProfileField;

        private bool useConfidenceField;

        private int minimumConfidenceLevelField;

        private bool useJoystickField;

        private int joystickNumberField;

        private int joystickButtonField;

        private int joystickNumber2Field;

        private int joystickButton2Field;

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

        private int ahField;

        private int clField;

        private bool hasMBField;

        private bool useVariableHotkeyField;

        private int cLEField;

        private bool eX1Field;

        private bool eX2Field;

        private object internalIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Referrer
        {
            get => referrerField;
            set => referrerField = value;
        }

        /// <remarks/>
        public int ExecType
        {
            get => execTypeField;
            set => execTypeField = value;
        }

        /// <remarks/>
        public int Confidence
        {
            get => confidenceField;
            set => confidenceField = value;
        }

        /// <remarks/>
        public int PrefixActionCount
        {
            get => prefixActionCountField;
            set => prefixActionCountField = value;
        }

        /// <remarks/>
        public bool IsDynamicallyCreated
        {
            get => isDynamicallyCreatedField;
            set => isDynamicallyCreatedField = value;
        }

        /// <remarks/>
        public bool TargetProcessSet
        {
            get => targetProcessSetField;
            set => targetProcessSetField = value;
        }

        /// <remarks/>
        public int TargetProcessType
        {
            get => targetProcessTypeField;
            set => targetProcessTypeField = value;
        }

        /// <remarks/>
        public int TargetProcessLevel
        {
            get => targetProcessLevelField;
            set => targetProcessLevelField = value;
        }

        /// <remarks/>
        public int CompareType
        {
            get => compareTypeField;
            set => compareTypeField = value;
        }

        /// <remarks/>
        public bool ExecFromWildcard
        {
            get => execFromWildcardField;
            set => execFromWildcardField = value;
        }

        /// <remarks/>
        public bool IsSubCommand
        {
            get => isSubCommandField;
            set => isSubCommandField = value;
        }

        /// <remarks/>
        public bool IsOverride
        {
            get => isOverrideField;
            set => isOverrideField = value;
        }

        /// <remarks/>
        public string BaseId
        {
            get => baseIdField;
            set => baseIdField = value;
        }

        /// <remarks/>
        public string OriginId
        {
            get => originIdField;
            set => originIdField = value;
        }

        /// <remarks/>
        public bool SessionEnabled
        {
            get => sessionEnabledField;
            set => sessionEnabledField = value;
        }

        /// <remarks/>
        public string Id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks/>
        public string CommandString
        {
            get => commandStringField;
            set => commandStringField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CommandAction", IsNullable = false)]
        public ProfileCommandCommandAction[] ActionSequence
        {
            get => actionSequenceField;
            set => actionSequenceField = value;
        }

        /// <remarks/>
        public bool Async
        {
            get => asyncField;
            set => asyncField = value;
        }

        /// <remarks/>
        public bool Enabled
        {
            get => enabledField;
            set => enabledField = value;
        }

        /// <remarks/>
        public bool UseShortcut
        {
            get => useShortcutField;
            set => useShortcutField = value;
        }

        /// <remarks/>
        public int keyValue
        {
            get => keyValueField;
            set => keyValueField = value;
        }

        /// <remarks/>
        public int keyShift
        {
            get => keyShiftField;
            set => keyShiftField = value;
        }

        /// <remarks/>
        public int keyAlt
        {
            get => keyAltField;
            set => keyAltField = value;
        }

        /// <remarks/>
        public int keyCtrl
        {
            get => keyCtrlField;
            set => keyCtrlField = value;
        }

        /// <remarks/>
        public int keyWin
        {
            get => keyWinField;
            set => keyWinField = value;
        }

        /// <remarks/>
        public bool keyPassthru
        {
            get => keyPassthruField;
            set => keyPassthruField = value;
        }

        /// <remarks/>
        public bool UseSpokenPhrase
        {
            get => useSpokenPhraseField;
            set => useSpokenPhraseField = value;
        }

        /// <remarks/>
        public bool onlyKeyUp
        {
            get => onlyKeyUpField;
            set => onlyKeyUpField = value;
        }

        /// <remarks/>
        public int RepeatNumber
        {
            get => repeatNumberField;
            set => repeatNumberField = value;
        }

        /// <remarks/>
        public int RepeatType
        {
            get => repeatTypeField;
            set => repeatTypeField = value;
        }

        /// <remarks/>
        public int CommandType
        {
            get => commandTypeField;
            set => commandTypeField = value;
        }

        /// <remarks/>
        public string SourceProfile
        {
            get => sourceProfileField;
            set => sourceProfileField = value;
        }

        /// <remarks/>
        public bool UseConfidence
        {
            get => useConfidenceField;
            set => useConfidenceField = value;
        }

        /// <remarks/>
        public int minimumConfidenceLevel
        {
            get => minimumConfidenceLevelField;
            set => minimumConfidenceLevelField = value;
        }

        /// <remarks/>
        public bool UseJoystick
        {
            get => useJoystickField;
            set => useJoystickField = value;
        }

        /// <remarks/>
        public int joystickNumber
        {
            get => joystickNumberField;
            set => joystickNumberField = value;
        }

        /// <remarks/>
        public int joystickButton
        {
            get => joystickButtonField;
            set => joystickButtonField = value;
        }

        /// <remarks/>
        public int joystickNumber2
        {
            get => joystickNumber2Field;
            set => joystickNumber2Field = value;
        }

        /// <remarks/>
        public int joystickButton2
        {
            get => joystickButton2Field;
            set => joystickButton2Field = value;
        }

        /// <remarks/>
        public bool joystickUp
        {
            get => joystickUpField;
            set => joystickUpField = value;
        }

        /// <remarks/>
        public bool KeepRepeating
        {
            get => keepRepeatingField;
            set => keepRepeatingField = value;
        }

        /// <remarks/>
        public bool UseProcessOverride
        {
            get => useProcessOverrideField;
            set => useProcessOverrideField = value;
        }

        /// <remarks/>
        public bool ProcessOverrideActiveWindow
        {
            get => processOverrideActiveWindowField;
            set => processOverrideActiveWindowField = value;
        }

        /// <remarks/>
        public bool LostFocusStop
        {
            get => lostFocusStopField;
            set => lostFocusStopField = value;
        }

        /// <remarks/>
        public bool PauseLostFocus
        {
            get => pauseLostFocusField;
            set => pauseLostFocusField = value;
        }

        /// <remarks/>
        public bool LostFocusBackCompat
        {
            get => lostFocusBackCompatField;
            set => lostFocusBackCompatField = value;
        }

        /// <remarks/>
        public bool UseMouse
        {
            get => useMouseField;
            set => useMouseField = value;
        }

        /// <remarks/>
        public bool Mouse1
        {
            get => mouse1Field;
            set => mouse1Field = value;
        }

        /// <remarks/>
        public bool Mouse2
        {
            get => mouse2Field;
            set => mouse2Field = value;
        }

        /// <remarks/>
        public bool Mouse3
        {
            get => mouse3Field;
            set => mouse3Field = value;
        }

        /// <remarks/>
        public bool Mouse4
        {
            get => mouse4Field;
            set => mouse4Field = value;
        }

        /// <remarks/>
        public bool Mouse5
        {
            get => mouse5Field;
            set => mouse5Field = value;
        }

        /// <remarks/>
        public bool Mouse6
        {
            get => mouse6Field;
            set => mouse6Field = value;
        }

        /// <remarks/>
        public bool Mouse7
        {
            get => mouse7Field;
            set => mouse7Field = value;
        }

        /// <remarks/>
        public bool Mouse8
        {
            get => mouse8Field;
            set => mouse8Field = value;
        }

        /// <remarks/>
        public bool Mouse9
        {
            get => mouse9Field;
            set => mouse9Field = value;
        }

        /// <remarks/>
        public bool MouseUpOnly
        {
            get => mouseUpOnlyField;
            set => mouseUpOnlyField = value;
        }

        /// <remarks/>
        public bool MousePassThru
        {
            get => mousePassThruField;
            set => mousePassThruField = value;
        }

        /// <remarks/>
        public bool joystickExclusive
        {
            get => joystickExclusiveField;
            set => joystickExclusiveField = value;
        }

        /// <remarks/>
        public string lastEditedAction
        {
            get => lastEditedActionField;
            set => lastEditedActionField = value;
        }

        /// <remarks/>
        public bool UseProfileProcessOverride
        {
            get => useProfileProcessOverrideField;
            set => useProfileProcessOverrideField = value;
        }

        /// <remarks/>
        public bool ProfileProcessOverrideActiveWindow
        {
            get => profileProcessOverrideActiveWindowField;
            set => profileProcessOverrideActiveWindowField = value;
        }

        /// <remarks/>
        public bool RepeatIfKeysDown
        {
            get => repeatIfKeysDownField;
            set => repeatIfKeysDownField = value;
        }

        /// <remarks/>
        public bool RepeatIfMouseDown
        {
            get => repeatIfMouseDownField;
            set => repeatIfMouseDownField = value;
        }

        /// <remarks/>
        public bool RepeatIfJoystickDown
        {
            get => repeatIfJoystickDownField;
            set => repeatIfJoystickDownField = value;
        }

        /// <remarks/>
        public int AH
        {
            get => ahField;
            set => ahField = value;
        }

        /// <remarks/>
        public int CL
        {
            get => clField;
            set => clField = value;
        }

        /// <remarks/>
        public bool HasMB
        {
            get => hasMBField;
            set => hasMBField = value;
        }

        /// <remarks/>
        public bool UseVariableHotkey
        {
            get => useVariableHotkeyField;
            set => useVariableHotkeyField = value;
        }

        /// <remarks/>
        public int CLE
        {
            get => cLEField;
            set => cLEField = value;
        }

        /// <remarks/>
        public bool EX1
        {
            get => eX1Field;
            set => eX1Field = value;
        }

        /// <remarks/>
        public bool EX2
        {
            get => eX2Field;
            set => eX2Field = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object InternalId
        {
            get => internalIdField;
            set => internalIdField = value;
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

        private int ordinalField;

        private object conditionMetField;

        private int indentLevelField;

        private bool conditionSkipField;

        private bool isSuffixActionField;

        private int decimalTransient1Field;

        private string captionField;

        private string idField;

        private string actionTypeField;

        private decimal durationField;

        private int delayField;

        private ProfileCommandCommandActionKeyCodes keyCodesField;

        private object contextField;

        private object context2Field;

        private object context3Field;

        private object context4Field;

        private int xField;

        private int yField;

        private int zField;

        private int inputModeField;

        private int conditionPairingField;

        private int conditionGroupField;

        private int conditionStartOperatorField;

        private int conditionStartValueField;

        private int conditionStartValueTypeField;

        private int conditionStartTypeField;

        private int decimalContext1Field;

        private int decimalContext2Field;

        private System.DateTime dateContext1Field;

        private System.DateTime dateContext2Field;

        private bool disabledField;

        private object randomSoundsField;

        /// <remarks/>
        public string _caption
        {
            get => _captionField;
            set => _captionField = value;
        }

        /// <remarks/>
        public bool PairingSet
        {
            get => pairingSetField;
            set => pairingSetField = value;
        }

        /// <remarks/>
        public bool PairingSetElse
        {
            get => pairingSetElseField;
            set => pairingSetElseField = value;
        }

        /// <remarks/>
        public int Ordinal
        {
            get => ordinalField;
            set => ordinalField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ConditionMet
        {
            get => conditionMetField;
            set => conditionMetField = value;
        }

        /// <remarks/>
        public int IndentLevel
        {
            get => indentLevelField;
            set => indentLevelField = value;
        }

        /// <remarks/>
        public bool ConditionSkip
        {
            get => conditionSkipField;
            set => conditionSkipField = value;
        }

        /// <remarks/>
        public bool IsSuffixAction
        {
            get => isSuffixActionField;
            set => isSuffixActionField = value;
        }

        /// <remarks/>
        public int DecimalTransient1
        {
            get => decimalTransient1Field;
            set => decimalTransient1Field = value;
        }

        /// <remarks/>
        public string Caption
        {
            get => captionField;
            set => captionField = value;
        }

        /// <remarks/>
        public string Id
        {
            get => idField;
            set => idField = value;
        }

        /// <remarks/>
        public string ActionType
        {
            get => actionTypeField;
            set => actionTypeField = value;
        }

        /// <remarks/>
        public decimal Duration
        {
            get => durationField;
            set => durationField = value;
        }

        /// <remarks/>
        public int Delay
        {
            get => delayField;
            set => delayField = value;
        }

        /// <remarks/>
        public ProfileCommandCommandActionKeyCodes KeyCodes
        {
            get => keyCodesField;
            set => keyCodesField = value;
        }

        /// <remarks/>
        public object Context
        {
            get => contextField;
            set => contextField = value;
        }

        /// <remarks/>
        public object Context2
        {
            get => contextField;
            set => context2Field = value;
        }

        /// <remarks/>
        public object Context3
        {
            get => contextField;
            set => context3Field = value;
        }

        /// <remarks/>
        public object Context4
        {
            get => contextField;
            set => context4Field = value;
        }

        /// <remarks/>
        public int X
        {
            get => xField;
            set => xField = value;
        }

        /// <remarks/>
        public int Y
        {
            get => yField;
            set => yField = value;
        }

        /// <remarks/>
        public int Z
        {
            get => zField;
            set => zField = value;
        }

        /// <remarks/>
        public int InputMode
        {
            get => inputModeField;
            set => inputModeField = value;
        }

        /// <remarks/>
        public int ConditionPairing
        {
            get => conditionPairingField;
            set => conditionPairingField = value;
        }

        /// <remarks/>
        public int ConditionGroup
        {
            get => conditionGroupField;
            set => conditionGroupField = value;
        }

        /// <remarks/>
        public int ConditionStartOperator
        {
            get => conditionStartOperatorField;
            set => conditionStartOperatorField = value;
        }

        /// <remarks/>
        public int ConditionStartValue
        {
            get => conditionStartValueField;
            set => conditionStartValueField = value;
        }

        /// <remarks/>
        public int ConditionStartValueType
        {
            get => conditionStartValueTypeField;
            set => conditionStartValueTypeField = value;
        }

        /// <remarks/>
        public int ConditionStartType
        {
            get => conditionStartTypeField;
            set => conditionStartTypeField = value;
        }

        /// <remarks/>
        public int DecimalContext1
        {
            get => decimalContext1Field;
            set => decimalContext1Field = value;
        }

        /// <remarks/>
        public int DecimalContext2
        {
            get => decimalContext2Field;
            set => decimalContext2Field = value;
        }

        /// <remarks/>
        public System.DateTime DateContext1
        {
            get => dateContext1Field;
            set => dateContext1Field = value;
        }

        /// <remarks/>
        public System.DateTime DateContext2
        {
            get => dateContext2Field;
            set => dateContext2Field = value;
        }

        /// <remarks/>
        public bool Disabled
        {
            get => disabledField;
            set => disabledField = value;
        }

        /// <remarks/>
        public object RandomSounds
        {
            get => randomSoundsField;
            set => randomSoundsField = value;
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
            get => unsignedShortField;
            set => unsignedShortField = value;
        }
    }


}
