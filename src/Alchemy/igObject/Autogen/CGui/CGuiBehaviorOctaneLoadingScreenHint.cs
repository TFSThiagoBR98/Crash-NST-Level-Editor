namespace Alchemy
{
    [ObjectAttr(ctr: 168, align: 8)]
    public class CGuiBehaviorOctaneLoadingScreenHint : CGuiBehavior
    {
        [FieldAttr(ctr: 144, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiPlaceable? _hintPlaceable;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiAnimationTag? _idleAnimation;
    }
}
