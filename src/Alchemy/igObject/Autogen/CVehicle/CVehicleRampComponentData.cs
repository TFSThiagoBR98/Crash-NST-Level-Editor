namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 8)]
    public class CVehicleRampComponentData : CEntityComponentData
    {
        public enum EBoostForwardDirectionOverride
        {
            eBFDO_None = 0,
            eBFDO_X = 1,
            eBFDO_Y = 2,
        }

        public enum ERampJumpMode
        {
            eRJM_Spline = 0,
            eRJM_Impulse = 1,
        }

        [FieldAttr(nst: 24)] public float _minVelocityRequired = 300.0f;
        [FieldAttr(nst: 32)] public CEntityData? _dummySplineEntityData;
        [FieldAttr(nst: 40)] public bool _applyRotationalKeyframes;
        [FieldAttr(nst: 48)] public CVehicleBoostData? _vehicleBoost;
        [FieldAttr(nst: 56)] public float _maxHorizontalAngleDifferenceForActivation = 180.0f;
        [FieldAttr(nst: 60)] public EBoostForwardDirectionOverride _boostForwardDirectionOverride;
        [FieldAttr(nst: 64)] public igHandleMetaField _activatedVfx = new();
        [FieldAttr(nst: 72)] public CBoltPoint? _boostPadBoltPoint;
        [FieldAttr(nst: 80)] public ERampJumpMode _rampJumpMode = CVehicleRampComponentData.ERampJumpMode.eRJM_Impulse;
        [FieldAttr(nst: 84)] public float _rampTime;
        [FieldAttr(nst: 88)] public igVec3fMetaField _rampImpulse = new();
    }
}
