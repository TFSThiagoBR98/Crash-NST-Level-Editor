namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CGuiBehaviorOctaneGrandPrixNitroBoost : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _timePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _activeAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _inactiveAnimation;
        [FieldAttr(ctr: 40)] public bool _isBoostActive;
        [FieldAttr(ctr: 48)] public igGuiAnimationCategory? _activeCategory;
    }
}
