namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 4)]
    public class igAnimationTransitionParameters : igObject
    {
        [FieldAttr(ctr: 12)] public float _startRatio;
        [FieldAttr(ctr: 16)] public float _endRatio;
        [FieldAttr(ctr: 20)] public int _duration;
        [FieldAttr(ctr: 24)] public int _targetStartTime;
    }
}
