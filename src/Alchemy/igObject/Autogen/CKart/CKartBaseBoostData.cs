namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CKartBaseBoostData : igObject
    {
        [FieldAttr(ctr: 12)] public float _speed;
        [FieldAttr(ctr: 16)] public CKartBoostDriftOffsets? _driftOffsets;
        [FieldAttr(ctr: 24)] public float _maxAngularAccelerationRatio;
        [FieldAttr(ctr: 28)] public float _boostInDuration;
        [FieldAttr(ctr: 32)] public float _boostSustainDuration;
        [FieldAttr(ctr: 36)] public float _boostOutDuration;
    }
}
