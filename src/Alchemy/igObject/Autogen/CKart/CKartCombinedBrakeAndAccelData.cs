namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CKartCombinedBrakeAndAccelData : igObject
    {
        [FieldAttr(ctr: 12)] public float _targetMaxSpeedRatio;
        [FieldAttr(ctr: 16)] public float _brakeMultiplier;
        [FieldAttr(ctr: 20)] public float _accelMultiplier;
    }
}
