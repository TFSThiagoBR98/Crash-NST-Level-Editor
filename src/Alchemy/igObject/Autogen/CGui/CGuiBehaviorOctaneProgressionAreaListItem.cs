namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGuiBehaviorOctaneProgressionAreaListItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _areaButton;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 40)] public string? _areaName;
        [FieldAttr(ctr: 48)] public igHandleMetaField _areaIcon = new();
        [FieldAttr(ctr: 56)] public int _hubAreaIndex;
        [FieldAttr(ctr: 64)] public igGuiAnimationCategory? _focusCategory;
    }
}
