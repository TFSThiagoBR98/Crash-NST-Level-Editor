namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igGuiAnimationBinding : igObject
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiPlaceable? _placeable;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiAnimation? _animation;
        [FieldAttr(nst: 32, ctr: 32)] public igVectorMetaField<igGuiTrackBinding> _trackBindings = new();
    }
}
