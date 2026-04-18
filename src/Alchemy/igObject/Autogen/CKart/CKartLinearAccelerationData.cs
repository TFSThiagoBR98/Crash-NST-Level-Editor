namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CKartLinearAccelerationData : igObject
    {
        [FieldAttr(ctr: 12)] public float _duration;
        [FieldAttr(ctr: 16)] public float _durationWhileTurning;
        [FieldAttr(ctr: 20)] public igVfxRangedCurveMetaField _curve = new();
    }
}
