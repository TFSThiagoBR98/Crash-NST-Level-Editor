namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CGuiBehaviorGrandPrixChallengeListItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _countPlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _focusedNamePlaceable;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _focusedCountPlaceable;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _unfocusAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _completedAnimation;
        [FieldAttr(ctr: 72)] public igGuiAnimationCategory? _focusCategory;
        [FieldAttr(ctr: 80)] public CAEAchievement? _challengeInfo;
        [FieldAttr(ctr: 88)] public igHandleMetaField _listItem = new();
    }
}
