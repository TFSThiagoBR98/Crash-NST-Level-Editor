namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 8)]
    public class CGuiBehaviorGrandPrixChallengeGroupItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _backgroundPlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _countPlaceable;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _unfocusAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _pressedAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _completedAnimation;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _forceFocusStateAnimation;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiPlaceable? _groupPlaceable;
        [FieldAttr(ctr: 96)] public igGuiAnimationCategory? _focusCategory;
        [FieldAttr(ctr: 104)] public igGuiAnimationCategory? _completeCategory;
        [FieldAttr(ctr: 112)] public uint _groupId;
    }
}
