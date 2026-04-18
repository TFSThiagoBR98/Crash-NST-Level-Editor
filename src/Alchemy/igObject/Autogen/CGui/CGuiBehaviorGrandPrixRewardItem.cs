namespace Alchemy
{
    [ObjectAttr(ctr: 160, align: 8)]
    public class CGuiBehaviorGrandPrixRewardItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _backgroundPlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _unlockedStateAnimation;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _lockedStateAnimation;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _nextRewardAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _toNextRewardState;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _unlockingAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _lastRewardUnlockedStateAnimation;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _lastRewardLockedStateAnimation;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiAnimationTag? _lastRewardNextRewardAnimation;
        [FieldAttr(ctr: 96, refCount: false)] public igGuiAnimationTag? _lastRewardToNextRewardState;
        [FieldAttr(ctr: 104, refCount: false)] public igGuiAnimationTag? _lastTierRewardUnlockingAnimation;
        [FieldAttr(ctr: 112, refCount: false)] public igGuiAnimationTag? _barChangeInAnim;
        [FieldAttr(ctr: 120, refCount: false)] public igGuiAnimationTag? _barChangeOutAnim;
        [FieldAttr(ctr: 128, refCount: false)] public igGuiAnimationTag? _lastRewardBarChangeInAnim;
        [FieldAttr(ctr: 136, refCount: false)] public igGuiAnimationTag? _lastRewardBarChangeOutAnim;
        [FieldAttr(ctr: 144)] public igGuiAnimationCategory? _stateCategory;
        [FieldAttr(ctr: 152)] public bool _isUnlockAnimDone;
        [FieldAttr(ctr: 153)] public bool _isLastRewardOfTier;
        [FieldAttr(ctr: 156)] public int _rewardId;
    }
}
