namespace Alchemy
{
    [ObjectAttr(ctr: 632, align: 8)]
    public class CKartCameraSettings : igObject
    {
        [FieldAttr(ctr: 12)] public float _forwardFollowAngle;
        [FieldAttr(ctr: 16)] public float _rotationDamping;
        [FieldAttr(ctr: 20)] public float _heightDamping;
        [FieldAttr(ctr: 24)] public float _positionDamping;
        [FieldAttr(ctr: 28)] public igVec2fMetaField _positionOffsetFromPlayer = new();
        [FieldAttr(ctr: 36)] public float _cameraFollowPitch;
        [FieldAttr(ctr: 40)] public float _cameraFollowRollRatio;
        [FieldAttr(ctr: 44)] public float _pitchDamping;
        [FieldAttr(ctr: 48)] public float _pitchDampingSuperFall;
        [FieldAttr(ctr: 52)] public float _verticalLockedPositionDamping;
        [FieldAttr(ctr: 56)] public float _cameraGroundHeight;
        [FieldAttr(ctr: 60)] public bool _applySpeedBasedOffset;
        [FieldAttr(ctr: 64)] public float _maxSpeedBasedOffset;
        [FieldAttr(ctr: 68)] public igVfxRangedCurveMetaField _speedBasedOffsetCurve = new();
        [FieldAttr(ctr: 152)] public float _maxBoostBasedOffset;
        [FieldAttr(ctr: 156)] public igVfxRangedCurveMetaField _boostFadeInOffsetCurve = new();
        [FieldAttr(ctr: 240)] public float _boostFadeInOffsetDuration;
        [FieldAttr(ctr: 244)] public igVfxRangedCurveMetaField _boostFadeOutOffsetCurve = new();
        [FieldAttr(ctr: 328)] public float _boostFadeOutOffsetDuration;
        [FieldAttr(ctr: 332)] public float _maxFallingBasedOffset;
        [FieldAttr(ctr: 336)] public igVfxRangedCurveMetaField _fallingFadeInOffsetCurve = new();
        [FieldAttr(ctr: 420)] public float _fallingFadeInOffsetDuration;
        [FieldAttr(ctr: 424)] public igVfxRangedCurveMetaField _fallingFadeOutOffsetCurve = new();
        [FieldAttr(ctr: 508)] public float _fallingFadeOutOffsetDuration;
        [FieldAttr(ctr: 512)] public float _minFallingTime;
        [FieldAttr(ctr: 516)] public float _turnOffset;
        [FieldAttr(ctr: 520)] public float _maxAngularSpeedForTurnOffset;
        [FieldAttr(ctr: 524)] public igVfxRangedCurveMetaField _turnOffsetFromAngularSpeedCurve = new();
        [FieldAttr(ctr: 608)] public float _driftTurnOffset;
        [FieldAttr(ctr: 612)] public float _driftTurnCloseUpOffset;
        [FieldAttr(ctr: 616)] public float _wallDetectionRadius;
        [FieldAttr(ctr: 620)] public float _detectionDistanceOverFloor;
        [FieldAttr(ctr: 624)] public float _collisionCameraReturnDuration;
        [FieldAttr(ctr: 628)] public float _backwardCollisionCameraTransferToHeightScale;
    }
}
