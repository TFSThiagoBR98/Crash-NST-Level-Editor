namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CGuiBehaviorAnimatePlaceable : igGuiBehavior
    {
        [FieldAttr(ctr: 12)] public float _totalDuration;
        [FieldAttr(ctr: 16)] public EigEaseType _easeType;
        [FieldAttr(ctr: 20)] public float _easeIn;
        [FieldAttr(ctr: 24)] public float _easeOut;
        [FieldAttr(ctr: 28)] public igVec3fMetaField _startPosition = new();
        [FieldAttr(ctr: 40)] public igVec3fMetaField _endPosition = new();
        [FieldAttr(ctr: 52)] public bool _animate;
        [FieldAttr(ctr: 56)] public float _startTime;
    }
}
