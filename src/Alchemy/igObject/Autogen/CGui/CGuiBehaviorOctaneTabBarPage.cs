namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGuiBehaviorOctaneTabBarPage : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _backgroundPlaceable;
        [FieldAttr(ctr: 32)] public igHandleMetaField _evenBackground = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _oddBackground = new();
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 64)] public igGuiAnimationCategory? _focusCategory;
    }
}
