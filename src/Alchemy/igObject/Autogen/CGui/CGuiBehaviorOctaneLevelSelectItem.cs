namespace Alchemy
{
    [ObjectAttr(ctr: 168, align: 8)]
    public class CGuiBehaviorOctaneLevelSelectItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _levelButton;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _timeTrialStars;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _goldStar;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _silverStar;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _timeTrialStarsPressedAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _timeTrialStarsFocusAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _timeTrialStarsDefocusAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _timeTrialStarsInitializeAnimation;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 96, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 104)] public string? _levelToLoad;
        [FieldAttr(ctr: 112)] public igHandleMetaField _levelImage = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _minimapImage = new();
        [FieldAttr(ctr: 128)] public igHandleMetaField _backgroundImage = new();
        [FieldAttr(ctr: 136)] public igVec4ucMetaField _levelColor = new();
        [FieldAttr(ctr: 144)] public igGuiAnimationCategory? _focusCategory;
        [FieldAttr(ctr: 152)] public igGuiAnimationCategory? _starsFocusCategory;
        [FieldAttr(ctr: 160)] public igHandleMetaField _levelAmbienceSFX = new();
    }
}
