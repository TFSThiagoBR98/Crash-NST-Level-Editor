namespace Alchemy
{
    [ObjectAttr(nst: 248, ctr: 256, align: 8)]
    public class CGuiBehaviorContinueGameButton : CGuiBehavior
    {
        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igGuiAnimationTag? _pressAnimation;
        [FieldAttr(nst: 152, ctr: 152)] public EGuiMenuSound _pressSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 160, ctr: 160)] public igHandleMetaField _zoneToBegin = new();
        [FieldAttr(nst: 168, ctr: 168)] public CFadeOutPresetData? _fadePreset;
        [FieldAttr(nst: 176, ctr: 176, refCount: false)] public igGuiPlaceable? _backupPlaceable;
        [FieldAttr(nst: 184, ctr: 184)] public string? _defaultText = "CONTINUE";
        [FieldAttr(nst: 192, ctr: 192)] public string? _deletingText = "...DELETING...";
        [FieldAttr(nst: 200, ctr: 200)] public CDialogBoxInfo? _corruptSaveDialog;
        [FieldAttr(nst: 208, ctr: 208)] public CDialogBoxInfo? _invalidOwnerSaveDialog;
        [FieldAttr(nst: 216, ctr: 216)] public CDialogBoxInfo? _deleteConfirmedDialog;
        [FieldAttr(nst: 224, ctr: 224)] public CDialogBoxInfo? _insufficientSpaceForAutosaveDialog;
        [FieldAttr(nst: 232, ctr: 232, refCount: false)] public igGuiProject? _dialogProject;
        [FieldAttr(nst: 240, ctr: 240)] public bool _dialogAccepted;
        [FieldAttr(nst: 244, ctr: 244)] public ESaveLoad _pendingSaveProcess;
        [FieldAttr(ctr: 248)] public bool _isSaveProcessCompleteCallbackRegistered;
    }
}
