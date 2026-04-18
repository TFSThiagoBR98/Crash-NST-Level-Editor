namespace Alchemy
{
    [ObjectAttr(nst: 264, align: 8)]
    public class CGuiBehaviorGraphicsMenu : CGuiBehavior
    {
        [FieldAttr(nst: 144, refCount: false)] public igGuiList? _optionsList;
        [FieldAttr(nst: 152, refCount: false)] public igGuiPlaceable? _settingInfoText;
        [FieldAttr(nst: 160, refCount: false)] public igGuiPlaceable? _gpuInfoText;
        [FieldAttr(nst: 168, refCount: false)] public igGuiAnimationTag? _crash1Animation;
        [FieldAttr(nst: 176, refCount: false)] public igGuiAnimationTag? _crash2Animation;
        [FieldAttr(nst: 184, refCount: false)] public igGuiAnimationTag? _crash3Animation;
        [FieldAttr(nst: 192)] public string? _option1Text = null;
        [FieldAttr(nst: 200)] public string? _option2Text = null;
        [FieldAttr(nst: 208)] public string? _backText = null;
        [FieldAttr(nst: 216)] public int _displayRevertTimeoutSeconds = 10;
        [FieldAttr(nst: 224)] public string? _countdownPlaceableName = "Countdown";
        [FieldAttr(nst: 232)] public bool _isClosing;
        [FieldAttr(nst: 233)] public bool _showApplyButton;
        [FieldAttr(nst: 234)] public bool _displayRevertRequested;
        [FieldAttr(nst: 240)] public igHandleMetaField _displayRevertDialogProject = new();
        [FieldAttr(nst: 248)] public igTimeMetaField _displayRevertDialogStartTime = new();
        [FieldAttr(nst: 256, refCount: false)] public CGuiBehaviorBaseGraphicsMenuOption? currentFocusedBehavior;
    }
}
