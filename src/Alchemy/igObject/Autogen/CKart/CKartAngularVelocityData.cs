namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CKartAngularVelocityData : igObject
    {
        [FieldAttr(ctr: 12)] public float _maxAngularAcceleration;
        [FieldAttr(ctr: 16)] public float _angularAccelerationMuliplierThreshold;
        [FieldAttr(ctr: 20)] public float _angularAccelerationMuliplierRate;
        [FieldAttr(ctr: 24)] public float _maxAngularVelocity;
        [FieldAttr(ctr: 28)] public igVfxRangedCurveMetaField _speedRelatedCurve = new();
    }
}
