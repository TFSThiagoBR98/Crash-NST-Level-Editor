namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGuiBehaviorOctaneGrandPrixVignette : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _titlePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _pointsPlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _animationIn;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _animationOut;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _noPointAnimationIn;
        [FieldAttr(ctr: 56)] public igHandleMetaField _visibleDurationFunction = new();
        [FieldAttr(ctr: 64)] public float _visibleTime;
    }
}
