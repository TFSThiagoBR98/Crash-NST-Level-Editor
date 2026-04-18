namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CAudioGraphDriverModeFlying : CAudioGraphDriverMode
    {
        [FieldAttr(nst: 56)] public float _defaultEngineValue = 0.5f;
        [FieldAttr(nst: 60)] public float _maxEngineValueChangePerSecond = 1.0f;
        [FieldAttr(nst: 64)] public float _maxBrakingEngineValueChangePerSecond = 2.0f;
        [FieldAttr(nst: 68)] public float _maxYawFactor = -0.2f;
        [FieldAttr(nst: 72)] public float _maxPitchFactor = 0.25f;
        [FieldAttr(nst: 76)] public float _brakeFactor = -0.5f;
        [FieldAttr(nst: 80)] public float _speedUpFactor = 0.3f;
        [FieldAttr(nst: 84)] public float _currentEngineValue;
    }
}
