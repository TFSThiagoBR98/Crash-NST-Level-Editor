namespace Alchemy
{
    [ObjectAttr(nst: 232, ctr: 232, align: 8)]
    public class CGuiBehaviorNewGameButton : CGuiBehavior
    {
        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igGuiAnimationTag? _pressAnimation;
        [FieldAttr(nst: 152, ctr: 152)] public EGuiMenuSound _pressSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 160, ctr: 160)] public igHandleMetaField _zoneToBegin = new();
        [FieldAttr(nst: 168, ctr: 168)] public CFadeOutPresetData? _fadePreset;
        [FieldAttr(nst: 176, ctr: 176)] public string? _overwriteSaveDialogTitle = null;
        [FieldAttr(nst: 184, ctr: 184)] public string? _overwriteSaveDialogBody = null;
        [FieldAttr(nst: 192, ctr: 192)] public string? _confirmOverwriteOptionText = null;
        [FieldAttr(nst: 200)] public string? _disableAutoSaveOptionText = null;
        [FieldAttr(ctr: 200)] public string? _cancelNewGameOptionText;
        [FieldAttr(nst: 208, ctr: 208)] public igHandleMetaField _overwriteDialogImage = new();
        [FieldAttr(nst: 216, ctr: 216, refCount: false)] public igGuiProject? _overwriteDialogProject;
        [FieldAttr(nst: 224, ctr: 224)] public bool _dialogAccepted;
        [FieldAttr(nst: 225, ctr: 225)] public bool _isSaving;
        [FieldAttr(ctr: 226)] public bool _isSaveProcessCompleteCallbackRegistered;
    }
}
