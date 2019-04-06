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


        public bool HasMB
        {
            get => hasMBField;
            set => hasMBField = value;
        }


        public string Id
        {
            get => idField;
            set => idField = value;
        }


        public string Name
        {
            get => nameField;
            set => nameField = value;
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("Command", IsNullable = false)]
        public ProfileCommand[] Commands
        {
            get => commandsField;
            set => commandsField = value;
        }


        public bool OverrideGlobal
        {
            get => overrideGlobalField;
            set => overrideGlobalField = value;
        }


        public int GlobalHotkeyIndex
        {
            get => globalHotkeyIndexField;
            set => globalHotkeyIndexField = value;
        }


        public bool GlobalHotkeyEnabled
        {
            get => globalHotkeyEnabledField;
            set => globalHotkeyEnabledField = value;
        }


        public int GlobalHotkeyValue
        {
            get => globalHotkeyValueField;
            set => globalHotkeyValueField = value;
        }


        public int GlobalHotkeyShift
        {
            get => globalHotkeyShiftField;
            set => globalHotkeyShiftField = value;
        }


        public int GlobalHotkeyAlt
        {
            get => globalHotkeyAltField;
            set => globalHotkeyAltField = value;
        }


        public int GlobalHotkeyCtrl
        {
            get => globalHotkeyCtrlField;
            set => globalHotkeyCtrlField = value;
        }


        public int GlobalHotkeyWin
        {
            get => globalHotkeyWinField;
            set => globalHotkeyWinField = value;
        }


        public bool GlobalHotkeyPassThru
        {
            get => globalHotkeyPassThruField;
            set => globalHotkeyPassThruField = value;
        }


        public bool OverrideMouse
        {
            get => overrideMouseField;
            set => overrideMouseField = value;
        }


        public int MouseIndex
        {
            get => mouseIndexField;
            set => mouseIndexField = value;
        }


        public bool OverrideStop
        {
            get => overrideStopField;
            set => overrideStopField = value;
        }


        public bool StopCommandHotkeyEnabled
        {
            get => stopCommandHotkeyEnabledField;
            set => stopCommandHotkeyEnabledField = value;
        }


        public int StopCommandHotkeyValue
        {
            get => stopCommandHotkeyValueField;
            set => stopCommandHotkeyValueField = value;
        }


        public int StopCommandHotkeyShift
        {
            get => stopCommandHotkeyShiftField;
            set => stopCommandHotkeyShiftField = value;
        }


        public int StopCommandHotkeyAlt
        {
            get => stopCommandHotkeyAltField;
            set => stopCommandHotkeyAltField = value;
        }


        public int StopCommandHotkeyCtrl
        {
            get => stopCommandHotkeyCtrlField;
            set => stopCommandHotkeyCtrlField = value;
        }


        public int StopCommandHotkeyWin
        {
            get => stopCommandHotkeyWinField;
            set => stopCommandHotkeyWinField = value;
        }


        public bool StopCommandHotkeyPassThru
        {
            get => stopCommandHotkeyPassThruField;
            set => stopCommandHotkeyPassThruField = value;
        }


        public bool DisableShortcuts
        {
            get => disableShortcutsField;
            set => disableShortcutsField = value;
        }


        public bool UseOverrideListening
        {
            get => useOverrideListeningField;
            set => useOverrideListeningField = value;
        }


        public bool OverrideJoystickGlobal
        {
            get => overrideJoystickGlobalField;
            set => overrideJoystickGlobalField = value;
        }


        public int GlobalJoystickIndex
        {
            get => globalJoystickIndexField;
            set => globalJoystickIndexField = value;
        }


        public int GlobalJoystickButton
        {
            get => globalJoystickButtonField;
            set => globalJoystickButtonField = value;
        }


        public int GlobalJoystickNumber
        {
            get => globalJoystickNumberField;
            set => globalJoystickNumberField = value;
        }


        public int GlobalJoystickButton2
        {
            get => globalJoystickButton2Field;
            set => globalJoystickButton2Field = value;
        }


        public int GlobalJoystickNumber2
        {
            get => globalJoystickNumber2Field;
            set => globalJoystickNumber2Field = value;
        }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ReferencedProfile
        {
            get => referencedProfileField;
            set => referencedProfileField = value;
        }


        public string ExportVAVersion
        {
            get => exportVAVersionField;
            set => exportVAVersionField = value;
        }


        public int ExportOSVersionMajor
        {
            get => exportOSVersionMajorField;
            set => exportOSVersionMajorField = value;
        }


        public int ExportOSVersionMinor
        {
            get => exportOSVersionMinorField;
            set => exportOSVersionMinorField = value;
        }


        public bool OverrideConfidence
        {
            get => overrideConfidenceField;
            set => overrideConfidenceField = value;
        }


        public int Confidence
        {
            get => confidenceField;
            set => confidenceField = value;
        }


        public bool CatchAllEnabled
        {
            get => catchAllEnabledField;
            set => catchAllEnabledField = value;
        }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object CatchAllId
        {
            get => catchAllIdField;
            set => catchAllIdField = value;
        }


        public bool InitializeCommandEnabled
        {
            get => initializeCommandEnabledField;
            set => initializeCommandEnabledField = value;
        }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object InitializeCommandId
        {
            get => initializeCommandIdField;
            set => initializeCommandIdField = value;
        }


        public bool UseProcessOverride
        {
            get => useProcessOverrideField;
            set => useProcessOverrideField = value;
        }


        public bool ProcessOverrideAciveWindow
        {
            get => processOverrideAciveWindowField;
            set => processOverrideAciveWindowField = value;
        }


        public bool DictationCommandEnabled
        {
            get => dictationCommandEnabledField;
            set => dictationCommandEnabledField = value;
        }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object DictationCommandId
        {
            get => dictationCommandIdField;
            set => dictationCommandIdField = value;
        }


        public bool EnableProfileSwitch
        {
            get => enableProfileSwitchField;
            set => enableProfileSwitchField = value;
        }


        public object CategoryGroups
        {
            get => categoryGroupsField;
            set => categoryGroupsField = value;
        }


        public bool GroupCategory
        {
            get => groupCategoryField;
            set => groupCategoryField = value;
        }


        public string LastEditedCommand
        {
            get => lastEditedCommandField;
            set => lastEditedCommandField = value;
        }


        public int IS
        {
            get => isField;
            set => isField = value;
        }


        public int IO
        {
            get => ioField;
            set => ioField = value;
        }


        public int IP
        {
            get => ipField;
            set => ipField = value;
        }


        public int BE
        {
            get => beField;
            set => beField = value;
        }


        public bool UnloadCommandEnabled
        {
            get => unloadCommandEnabledField;
            set => unloadCommandEnabledField = value;
        }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object UnloadCommandId
        {
            get => unloadCommandIdField;
            set => unloadCommandIdField = value;
        }


        public bool BlockExternal
        {
            get => blockExternalField;
            set => blockExternalField = value;
        }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object AuthorID
        {
            get => authorIDField;
            set => authorIDField = value;
        }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ProductID
        {
            get => productIDField;
            set => productIDField = value;
        }


        public int CR
        {
            get => crField;
            set => crField = value;
        }


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


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object Referrer
        {
            get => referrerField;
            set => referrerField = value;
        }


        public int ExecType
        {
            get => execTypeField;
            set => execTypeField = value;
        }


        public int Confidence
        {
            get => confidenceField;
            set => confidenceField = value;
        }


        public int PrefixActionCount
        {
            get => prefixActionCountField;
            set => prefixActionCountField = value;
        }


        public bool IsDynamicallyCreated
        {
            get => isDynamicallyCreatedField;
            set => isDynamicallyCreatedField = value;
        }


        public bool TargetProcessSet
        {
            get => targetProcessSetField;
            set => targetProcessSetField = value;
        }


        public int TargetProcessType
        {
            get => targetProcessTypeField;
            set => targetProcessTypeField = value;
        }


        public int TargetProcessLevel
        {
            get => targetProcessLevelField;
            set => targetProcessLevelField = value;
        }


        public int CompareType
        {
            get => compareTypeField;
            set => compareTypeField = value;
        }


        public bool ExecFromWildcard
        {
            get => execFromWildcardField;
            set => execFromWildcardField = value;
        }


        public bool IsSubCommand
        {
            get => isSubCommandField;
            set => isSubCommandField = value;
        }


        public bool IsOverride
        {
            get => isOverrideField;
            set => isOverrideField = value;
        }


        public string BaseId
        {
            get => baseIdField;
            set => baseIdField = value;
        }


        public string OriginId
        {
            get => originIdField;
            set => originIdField = value;
        }


        public bool SessionEnabled
        {
            get => sessionEnabledField;
            set => sessionEnabledField = value;
        }


        public string Id
        {
            get => idField;
            set => idField = value;
        }


        public string CommandString
        {
            get => commandStringField;
            set => commandStringField = value;
        }


        [System.Xml.Serialization.XmlArrayItemAttribute("CommandAction", IsNullable = false)]
        public ProfileCommandCommandAction[] ActionSequence
        {
            get => actionSequenceField;
            set => actionSequenceField = value;
        }


        public bool Async
        {
            get => asyncField;
            set => asyncField = value;
        }


        public bool Enabled
        {
            get => enabledField;
            set => enabledField = value;
        }


        public bool UseShortcut
        {
            get => useShortcutField;
            set => useShortcutField = value;
        }


        public int keyValue
        {
            get => keyValueField;
            set => keyValueField = value;
        }


        public int keyShift
        {
            get => keyShiftField;
            set => keyShiftField = value;
        }


        public int keyAlt
        {
            get => keyAltField;
            set => keyAltField = value;
        }


        public int keyCtrl
        {
            get => keyCtrlField;
            set => keyCtrlField = value;
        }


        public int keyWin
        {
            get => keyWinField;
            set => keyWinField = value;
        }


        public bool keyPassthru
        {
            get => keyPassthruField;
            set => keyPassthruField = value;
        }


        public bool UseSpokenPhrase
        {
            get => useSpokenPhraseField;
            set => useSpokenPhraseField = value;
        }


        public bool onlyKeyUp
        {
            get => onlyKeyUpField;
            set => onlyKeyUpField = value;
        }


        public int RepeatNumber
        {
            get => repeatNumberField;
            set => repeatNumberField = value;
        }


        public int RepeatType
        {
            get => repeatTypeField;
            set => repeatTypeField = value;
        }


        public int CommandType
        {
            get => commandTypeField;
            set => commandTypeField = value;
        }


        public string SourceProfile
        {
            get => sourceProfileField;
            set => sourceProfileField = value;
        }


        public bool UseConfidence
        {
            get => useConfidenceField;
            set => useConfidenceField = value;
        }


        public int minimumConfidenceLevel
        {
            get => minimumConfidenceLevelField;
            set => minimumConfidenceLevelField = value;
        }


        public bool UseJoystick
        {
            get => useJoystickField;
            set => useJoystickField = value;
        }


        public int joystickNumber
        {
            get => joystickNumberField;
            set => joystickNumberField = value;
        }


        public int joystickButton
        {
            get => joystickButtonField;
            set => joystickButtonField = value;
        }


        public int joystickNumber2
        {
            get => joystickNumber2Field;
            set => joystickNumber2Field = value;
        }


        public int joystickButton2
        {
            get => joystickButton2Field;
            set => joystickButton2Field = value;
        }


        public bool joystickUp
        {
            get => joystickUpField;
            set => joystickUpField = value;
        }


        public bool KeepRepeating
        {
            get => keepRepeatingField;
            set => keepRepeatingField = value;
        }


        public bool UseProcessOverride
        {
            get => useProcessOverrideField;
            set => useProcessOverrideField = value;
        }


        public bool ProcessOverrideActiveWindow
        {
            get => processOverrideActiveWindowField;
            set => processOverrideActiveWindowField = value;
        }


        public bool LostFocusStop
        {
            get => lostFocusStopField;
            set => lostFocusStopField = value;
        }


        public bool PauseLostFocus
        {
            get => pauseLostFocusField;
            set => pauseLostFocusField = value;
        }


        public bool LostFocusBackCompat
        {
            get => lostFocusBackCompatField;
            set => lostFocusBackCompatField = value;
        }


        public bool UseMouse
        {
            get => useMouseField;
            set => useMouseField = value;
        }


        public bool Mouse1
        {
            get => mouse1Field;
            set => mouse1Field = value;
        }


        public bool Mouse2
        {
            get => mouse2Field;
            set => mouse2Field = value;
        }


        public bool Mouse3
        {
            get => mouse3Field;
            set => mouse3Field = value;
        }


        public bool Mouse4
        {
            get => mouse4Field;
            set => mouse4Field = value;
        }


        public bool Mouse5
        {
            get => mouse5Field;
            set => mouse5Field = value;
        }


        public bool Mouse6
        {
            get => mouse6Field;
            set => mouse6Field = value;
        }


        public bool Mouse7
        {
            get => mouse7Field;
            set => mouse7Field = value;
        }


        public bool Mouse8
        {
            get => mouse8Field;
            set => mouse8Field = value;
        }


        public bool Mouse9
        {
            get => mouse9Field;
            set => mouse9Field = value;
        }


        public bool MouseUpOnly
        {
            get => mouseUpOnlyField;
            set => mouseUpOnlyField = value;
        }


        public bool MousePassThru
        {
            get => mousePassThruField;
            set => mousePassThruField = value;
        }


        public bool joystickExclusive
        {
            get => joystickExclusiveField;
            set => joystickExclusiveField = value;
        }


        public string lastEditedAction
        {
            get => lastEditedActionField;
            set => lastEditedActionField = value;
        }


        public bool UseProfileProcessOverride
        {
            get => useProfileProcessOverrideField;
            set => useProfileProcessOverrideField = value;
        }


        public bool ProfileProcessOverrideActiveWindow
        {
            get => profileProcessOverrideActiveWindowField;
            set => profileProcessOverrideActiveWindowField = value;
        }


        public bool RepeatIfKeysDown
        {
            get => repeatIfKeysDownField;
            set => repeatIfKeysDownField = value;
        }


        public bool RepeatIfMouseDown
        {
            get => repeatIfMouseDownField;
            set => repeatIfMouseDownField = value;
        }


        public bool RepeatIfJoystickDown
        {
            get => repeatIfJoystickDownField;
            set => repeatIfJoystickDownField = value;
        }


        public int AH
        {
            get => ahField;
            set => ahField = value;
        }


        public int CL
        {
            get => clField;
            set => clField = value;
        }


        public bool HasMB
        {
            get => hasMBField;
            set => hasMBField = value;
        }


        public bool UseVariableHotkey
        {
            get => useVariableHotkeyField;
            set => useVariableHotkeyField = value;
        }


        public int CLE
        {
            get => cLEField;
            set => cLEField = value;
        }


        public bool EX1
        {
            get => eX1Field;
            set => eX1Field = value;
        }


        public bool EX2
        {
            get => eX2Field;
            set => eX2Field = value;
        }


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


        public string _caption
        {
            get => _captionField;
            set => _captionField = value;
        }


        public bool PairingSet
        {
            get => pairingSetField;
            set => pairingSetField = value;
        }


        public bool PairingSetElse
        {
            get => pairingSetElseField;
            set => pairingSetElseField = value;
        }


        public int Ordinal
        {
            get => ordinalField;
            set => ordinalField = value;
        }


        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object ConditionMet
        {
            get => conditionMetField;
            set => conditionMetField = value;
        }


        public int IndentLevel
        {
            get => indentLevelField;
            set => indentLevelField = value;
        }


        public bool ConditionSkip
        {
            get => conditionSkipField;
            set => conditionSkipField = value;
        }


        public bool IsSuffixAction
        {
            get => isSuffixActionField;
            set => isSuffixActionField = value;
        }


        public int DecimalTransient1
        {
            get => decimalTransient1Field;
            set => decimalTransient1Field = value;
        }


        public string Caption
        {
            get => captionField;
            set => captionField = value;
        }


        public string Id
        {
            get => idField;
            set => idField = value;
        }


        public string ActionType
        {
            get => actionTypeField;
            set => actionTypeField = value;
        }


        public decimal Duration
        {
            get => durationField;
            set => durationField = value;
        }


        public int Delay
        {
            get => delayField;
            set => delayField = value;
        }


        public ProfileCommandCommandActionKeyCodes KeyCodes
        {
            get => keyCodesField;
            set => keyCodesField = value;
        }


        public object Context
        {
            get => contextField;
            set => contextField = value;
        }


        public object Context2
        {
            get => contextField;
            set => context2Field = value;
        }


        public object Context3
        {
            get => contextField;
            set => context3Field = value;
        }


        public object Context4
        {
            get => contextField;
            set => context4Field = value;
        }


        public int X
        {
            get => xField;
            set => xField = value;
        }


        public int Y
        {
            get => yField;
            set => yField = value;
        }


        public int Z
        {
            get => zField;
            set => zField = value;
        }


        public int InputMode
        {
            get => inputModeField;
            set => inputModeField = value;
        }


        public int ConditionPairing
        {
            get => conditionPairingField;
            set => conditionPairingField = value;
        }


        public int ConditionGroup
        {
            get => conditionGroupField;
            set => conditionGroupField = value;
        }


        public int ConditionStartOperator
        {
            get => conditionStartOperatorField;
            set => conditionStartOperatorField = value;
        }


        public int ConditionStartValue
        {
            get => conditionStartValueField;
            set => conditionStartValueField = value;
        }


        public int ConditionStartValueType
        {
            get => conditionStartValueTypeField;
            set => conditionStartValueTypeField = value;
        }


        public int ConditionStartType
        {
            get => conditionStartTypeField;
            set => conditionStartTypeField = value;
        }


        public int DecimalContext1
        {
            get => decimalContext1Field;
            set => decimalContext1Field = value;
        }


        public int DecimalContext2
        {
            get => decimalContext2Field;
            set => decimalContext2Field = value;
        }


        public System.DateTime DateContext1
        {
            get => dateContext1Field;
            set => dateContext1Field = value;
        }


        public System.DateTime DateContext2
        {
            get => dateContext2Field;
            set => dateContext2Field = value;
        }


        public bool Disabled
        {
            get => disabledField;
            set => disabledField = value;
        }


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


        public byte unsignedShort
        {
            get => unsignedShortField;
            set => unsignedShortField = value;
        }
    }


}
