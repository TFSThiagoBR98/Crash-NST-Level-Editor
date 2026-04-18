namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CKartLinearVelocityData : igObject
    {
        [FieldAttr(ctr: 12)] public float _maxLinearVelocity;
        [FieldAttr(ctr: 16)] public float _maxBoostedVelocity;
        [FieldAttr(ctr: 20)] public float _slideFactor;
        [FieldAttr(ctr: 24)] public CKartLinearAccelerationData? _accelerationCurve;
        [FieldAttr(ctr: 32)] public CKartLinearAccelerationData? _decelerationNaturalCurve;
        [FieldAttr(ctr: 40)] public CKartLinearAccelerationData? _decelerationBrakingCurve;
    }
}
