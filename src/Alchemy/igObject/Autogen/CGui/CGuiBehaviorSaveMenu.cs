namespace Alchemy
{
    [ObjectAttr(nst: 264, ctr: 320, align: 8)]
    public class CGuiBehaviorSaveMenu : CGuiBehavior
    {
        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igGuiAnimationTag? _introAnimation;
        [FieldAttr(nst: 152, ctr: 152, refCount: false)] public igGuiAnimationTag? _outroAnimation;
        [FieldAttr(nst: 160, ctr: 160, refCount: false)] public igGuiAnimationTag? _idleAnimation;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiAnimationTag? _idleSlotAnimation;
        [FieldAttr(nst: 168, ctr: 176, refCount: false)] public igGuiAnimationTag? _preDialogAnimation;
        [FieldAttr(nst: 176, ctr: 184, refCount: false)] public igGuiAnimationTag? _postDialogAnimation;
        [FieldAttr(nst: 184, ctr: 192)] public EigGuiAnimationLoopMode _animIdleLoopMode = EigGuiAnimationLoopMode.kGuiLoopRepeat;
        [FieldAttr(nst: 188, ctr: 196)] public bool _alwaysSwitchBackToAutosaveSlot;
        [FieldAttr(nst: 192, ctr: 200)] public string? _cancelButtonLegendText = null;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiProject? _projectToBackToInMainMenu;
        [FieldAttr(nst: 200, ctr: 216, refCount: false)] public igGuiPlaceable? _startingFocusPlaceable;
        [FieldAttr(ctr: 224, refCount: false)] public igGuiPlaceable? _firstSlotPlaceable;
        [FieldAttr(ctr: 232, refCount: false)] public igGuiPlaceable? _secondSlotPlaceable;
        [FieldAttr(ctr: 240, refCount: false)] public igGuiPlaceable? _thirdSlotPlaceable;
        [FieldAttr(ctr: 248, refCount: false)] public igGuiPlaceable? _fourthSlotPlaceable;
        [FieldAttr(nst: 208, ctr: 256, refCount: false)] public igGuiProject? _saveDialogBoxProject;
        [FieldAttr(nst: 216, ctr: 264, refCount: false)] public CGuiSaveSlotOperationBase? _currentOperation;
        [FieldAttr(nst: 224, ctr: 272)] public igHandleMetaField _currentOperationPlaceable = new();
        [FieldAttr(nst: 232, ctr: 280)] public int _currentSaveSlot;
        [FieldAttr(nst: 240, ctr: 288)] public igGuiAnimationCategory? _animationCategory;
        [FieldAttr(ctr: 296)] public igGuiAnimationCategory? _slotAnimationCategory;
        [FieldAttr(nst: 248, ctr: 304)] public CDialogBoxInfo? _pendingDialogBoxInfo;
        [FieldAttr(nst: 256, ctr: 312)] public bool _pendingOperationConfirmed;
    }
}
