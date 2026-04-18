namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class igAnimationTransitionPoint2 : igObject
    {
        [FieldAttr(ctr: 12)] public int _transitionTime;
        [FieldAttr(ctr: 16)] public igAnimationTransitionParameters? _parameters;
    }
}
