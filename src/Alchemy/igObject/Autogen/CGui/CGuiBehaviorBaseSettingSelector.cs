namespace Alchemy
{
    [ObjectAttr(ctr: 448, align: 8)]
    public class CGuiBehaviorBaseSettingSelector : CGuiBehaviorNavigationItem
    {
        [FieldAttr(ctr: 328)] public string? _optionName;
        [FieldAttr(ctr: 336, refCount: false)] public igGuiPlaceable? _nameTextPlaceable;
        [FieldAttr(ctr: 344)] public EGuiMenuSound _cycleSound;
        [FieldAttr(ctr: 348)] public EGuiMenuSound _cycleFailSound;
        [FieldAttr(ctr: 352, refCount: false)] public igGuiAnimationTag? _animCycleNext;
        [FieldAttr(ctr: 360, refCount: false)] public igGuiAnimationTag? _animCyclePrevious;
        [FieldAttr(ctr: 368, refCount: false)] public igGuiAnimationTag? _animDisableCycle;
        [FieldAttr(ctr: 376, refCount: false)] public igGuiAnimationTag? _animEnableCycle;
        [FieldAttr(ctr: 384, refCount: false)] public igGuiAnimationTag? _animDisableCycleFocus;
        [FieldAttr(ctr: 392, refCount: false)] public igGuiAnimationTag? _animDisableCycleDefocus;
        [FieldAttr(ctr: 400)] public int _defaultIndex;
        [FieldAttr(ctr: 404)] public bool _wrap;
        [FieldAttr(ctr: 408)] public igGuiAnimationCategory? _cycleToggleCategory;
        [FieldAttr(ctr: 416)] public int _currentIndex;
        [FieldAttr(ctr: 424)] public igStringRefList? _settingList;
        [FieldAttr(ctr: 432)] public igBoolList? _enabledSettings;
        [FieldAttr(ctr: 440)] public bool _isFinishedLoading;
    }
}
