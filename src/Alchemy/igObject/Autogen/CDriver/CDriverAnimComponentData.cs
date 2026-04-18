namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CDriverAnimComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _yawRatioLerpActiveSpeed;
        [FieldAttr(ctr: 20)] public float _yawRatioLerpPassiveSpeed;
        [FieldAttr(ctr: 24)] public float _yawMaxAnimDeviation;
        [FieldAttr(ctr: 28)] public float _turnWeightIncreaseSpeed;
        [FieldAttr(ctr: 32)] public float _turnWeightDecreaseSpeed;
        [FieldAttr(ctr: 36)] public float _scaleKartUp;
        [FieldAttr(ctr: 40)] public float _pedalsCloseUp;
        [FieldAttr(ctr: 44)] public bool _applyLowerBodyKartFit;
        [FieldAttr(ctr: 48)] public float _idleBreakerFirstDelay;
        [FieldAttr(ctr: 52)] public float _idleBreakerInterval;
        [FieldAttr(ctr: 56)] public bool _isCrashBandicoot;
    }
}
