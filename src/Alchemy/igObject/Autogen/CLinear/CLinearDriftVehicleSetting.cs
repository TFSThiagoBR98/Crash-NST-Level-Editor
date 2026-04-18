namespace Alchemy
{
    [ObjectAttr(nst: 232, ctr: 224, align: 8)]
    public class CLinearDriftVehicleSetting : CDriftVehicleSetting
    {
        [FieldAttr(nst: 48, ctr: 40)] public igVfxRangedCurveMetaField _angularSpeedMultiplierOverTimeCurve = new();
        [FieldAttr(nst: 132, ctr: 124)] public igVfxRangedCurveMetaField _angularSpeedAdderOverTimeCurve = new();
        [FieldAttr(nst: 216, ctr: 208)] public float _driftTimeToModifierCurvesEnd = 5.0f;
        [FieldAttr(nst: 220, ctr: 212)] public float _maxAngularSpeed = 50.0f;
        [FieldAttr(nst: 224, ctr: 216)] public float _counterSteerMultiplier = 0.1f;
        [FieldAttr(nst: 228, ctr: 220)] public float _driftTimeToMaxTurn;
    }
}
