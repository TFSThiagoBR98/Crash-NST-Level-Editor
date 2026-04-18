namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 88, align: 8)]
    public class CBuoyancyComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public float _buoyancy = 1.0f;
        [FieldAttr(nst: 28, ctr: 20)] public float _horizontalDrag = 1.0f;
        [FieldAttr(nst: 32, ctr: 24)] public float _verticalDrag = 1.0f;
        [FieldAttr(nst: 36, ctr: 28)] public float _restingRatio = 0.1f;
        [FieldAttr(nst: 40, ctr: 32)] public float _enterWaterVelocityFactor = 0.8f;
        [FieldAttr(nst: 44, ctr: 36)] public float _exitWaterVelocityFactor = 0.8f;
        [FieldAttr(nst: 48, ctr: 40)] public float _minVelocityMagnitudeForRipple = 100.0f;
        [FieldAttr(nst: 52, ctr: 44)] public float _minSubmergedDeltaForRipple = 0.01f;
        [FieldAttr(nst: 56, ctr: 48)] public bool _rippleEnabled = true;
        [FieldAttr(nst: 60, ctr: 52)] public float _rippleRadius = 5.0f;
        [FieldAttr(nst: 64, ctr: 56)] public float _rippleIntensity = 0.5f;
        [FieldAttr(nst: 68, ctr: 60)] public float _raycastOffsetAbove = 1000.0f;
        [FieldAttr(nst: 72, ctr: 64)] public float _raycastOffsetBelow = 1000.0f;
        [FieldAttr(nst: 80, ctr: 72)] public igHandleMetaField _targetWaterSurfaceMaterial = new();
        [FieldAttr(nst: 88, ctr: 80)] public EMode _mode;
    }
}
