namespace Alchemy
{
    [ObjectAttr(nst: 240, ctr: 232, align: 8)]
    public class CFallSpeedModifier : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _activated;
        [FieldAttr(nst: 20, ctr: 16)] public float _timeActivated;
        [FieldAttr(nst: 24, ctr: 20)] public float _startVelocity;
        [FieldAttr(nst: 28, ctr: 24)] public float _minActivationVelocity = -50.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _duration = 1.0f;
        [FieldAttr(nst: 40, ctr: 32)] public string? _activatingState = null;
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _activatingStateVariable = new();
        [FieldAttr(nst: 56, ctr: 48)] public int _activatingStateIntValue;
        [FieldAttr(nst: 60, ctr: 52)] public float _maximumInputVelocity = -200.0f;
        [FieldAttr(nst: 64, ctr: 56)] public int _priority;
        [FieldAttr(nst: 68, ctr: 60)] public igVfxRangedCurveMetaField _velocityLifetimeCurve = new();
        [FieldAttr(nst: 152, ctr: 144)] public igVfxRangedCurveMetaField _velocityActivationCurve = new();
        [FieldAttr(nst: 236, ctr: 228)] public float _velocityActivationCurveMaxTime = 0.3f;
    }
}
