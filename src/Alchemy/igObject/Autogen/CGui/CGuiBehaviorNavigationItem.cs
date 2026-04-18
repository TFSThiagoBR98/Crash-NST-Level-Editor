namespace Alchemy
{
    [ObjectAttr(nst: 256, ctr: 328, align: 8)]
    public class CGuiBehaviorNavigationItem : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiAnimationTag? _animSetLocked;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiAnimationTag? _animSetUnlocked;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiAnimationTag? _animPressed;
        [FieldAttr(ctr: 168)] public EGuiMenuSound _pressedSound;
        [FieldAttr(nst: 144, ctr: 176, refCount: false)] public igGuiAnimationTag? _animFocusOn;
        [FieldAttr(nst: 152, ctr: 184, refCount: false)] public igGuiAnimationTag? _animFocusOff;
        [FieldAttr(nst: 160, ctr: 192, refCount: false)] public igGuiAnimationTag? _animFocusedLoop;
        [FieldAttr(ctr: 200, refCount: false)] public igGuiAnimationTag? _animFocusOnLocked;
        [FieldAttr(ctr: 208, refCount: false)] public igGuiAnimationTag? _animFocusOffLocked;
        [FieldAttr(ctr: 216, refCount: false)] public igGuiAnimationTag? _animFocusedLoopLocked;
        [FieldAttr(nst: 168, ctr: 224)] public EigGuiAnimationLoopMode _animFocusedLoopMode = EigGuiAnimationLoopMode.kGuiLoopRepeat;
        [FieldAttr(nst: 176, refCount: false)] public igGuiAnimationTag? _animFocusabilityOn;
        [FieldAttr(nst: 184, refCount: false)] public igGuiAnimationTag? _animFocusabilityOff;
        [FieldAttr(nst: 192, ctr: 232)] public string? _itemText = null;
        [FieldAttr(nst: 200, ctr: 240, refCount: false)] public igGuiPlaceable? _textPlaceable;
        [FieldAttr(ctr: 248, refCount: false)] public igGuiPlaceable? _text2Placeable;
        [FieldAttr(nst: 208, ctr: 256, refCount: false)] public igGuiPlaceable? _leftItem;
        [FieldAttr(nst: 216, ctr: 264, refCount: false)] public igGuiPlaceable? _rightItem;
        [FieldAttr(nst: 224, ctr: 272, refCount: false)] public igGuiPlaceable? _upItem;
        [FieldAttr(nst: 232, ctr: 280, refCount: false)] public igGuiPlaceable? _downItem;
        [FieldAttr(nst: 240, ctr: 288)] public EGuiMenuSound _focusSound = EGuiMenuSound.eGMS_Navigate;
        [FieldAttr(ctr: 292)] public bool _playLoseFocusOnPress;
        [FieldAttr(ctr: 293)] public bool _checkMultiplayerRestriction;
        [FieldAttr(ctr: 294)] public bool _checkNetworkErrors;
        [FieldAttr(ctr: 295)] public bool _checkForBaseNetworkErrors;
        [FieldAttr(nst: 248, ctr: 296)] public igGuiAnimationCategory? _focusCategory;
        [FieldAttr(ctr: 304)] public bool _selectPressed;
        [FieldAttr(ctr: 305)] public bool _isFocused;
        [FieldAttr(ctr: 306)] public bool _isLocked;
        [FieldAttr(ctr: 312, refCount: false)] public igGuiAnimationTag? _animPressedLocked;
        [FieldAttr(ctr: 320)] public bool _isItemLocked;
    }
}
