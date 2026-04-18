namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class igAnimationTransition : igObject
    {
        [FieldAttr(ctr: 16)] public igAnimation2? _baseAnimation;
        [FieldAttr(ctr: 24)] public igMemoryRef<igAnimationTransitionPoint2> _transitionPointArray = new();
        [FieldAttr(ctr: 40)] public int _transitionPointCount;
        [FieldAttr(ctr: 48)] public igAnimationTransitionParameters? _defaultParameters;
    }
}
