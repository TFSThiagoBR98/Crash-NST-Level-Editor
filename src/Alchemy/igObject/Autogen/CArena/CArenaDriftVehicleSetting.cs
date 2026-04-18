namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 152, align: 8)]
    public class CArenaDriftVehicleSetting : CDriftVehicleSetting
    {
        [FieldAttr(nst: 48, ctr: 40)] public igVfxRangedCurveMetaField _accelerationVelocityCurve = new();
        [FieldAttr(nst: 132, ctr: 124)] public float _accelerationTimeToMaxSpeed = 1.0f;
        [FieldAttr(nst: 136, ctr: 128)] public float _forwardSpeedPreservedAtMinAngle = 1.0f;
        [FieldAttr(nst: 140, ctr: 132)] public float _forwardSpeedPreservedAtMaxAngle = 0.69999999f;
        [FieldAttr(nst: 144, ctr: 136)] public float _angleThresholdRemoveMaxSpeed = 30.0f;
        [FieldAttr(nst: 148, ctr: 140)] public float _angleVelocityThresholdStop = 40.0f;
        [FieldAttr(nst: 152, ctr: 144)] public float _turningSpeedScaleForRelativeControls = 1.0f;
    }
}
