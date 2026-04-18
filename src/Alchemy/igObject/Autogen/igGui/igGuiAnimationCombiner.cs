namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 64, align: 8)]
    public class igGuiAnimationCombiner : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igGuiEventAnimationEnd? _animationEndEvent;
        [FieldAttr(ctr: 24)] public igGuiEventAnimationLoop? _animationLoopEvent;
        [FieldAttr(nst: 24, ctr: 32)] public igVectorMetaField<igGuiAnimationPlayState> _states = new();
        [FieldAttr(nst: 48, ctr: 56)] public bool _isUpdating;
    }
}
