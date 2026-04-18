namespace Alchemy
{
    [ObjectAttr(nst: 576, ctr: 608, align: 16)]
    public class CMotorcycleCamera : CConstrainedCamera
    {
        [FieldAttr(nst: 432, ctr: 464)] public igHandleMetaField _splineEntity = new();
        [FieldAttr(nst: 440, ctr: 472)] public igHandleMetaField _focusedEntity = new();
        [FieldAttr(nst: 448, ctr: 480)] public float _distanceAlongSpline;
        [FieldAttr(nst: 452, ctr: 484)] public igVec3fMetaField _rotationVelocity = new();
        [FieldAttr(nst: 464, ctr: 496)] public igVec3fMetaField _lastSplineForward = new();
        [FieldAttr(nst: 476, ctr: 508)] public igVec3fMetaField _lastValidForward = new();
        [FieldAttr(nst: 488, ctr: 520)] public float _forwardFollowAngle = 38.0f;
        [FieldAttr(nst: 492, ctr: 524)] public float _rotationDamping = 0.088f;
        [FieldAttr(nst: 496, ctr: 528)] public igVec3fMetaField _lastPosition = new();
        [FieldAttr(nst: 508, ctr: 540)] public igVec3fMetaField _positionVelocity = new();
        [FieldAttr(nst: 520, ctr: 552)] public float _positionDamping = 1.0f;
        [FieldAttr(nst: 524, ctr: 556)] public igVec2fMetaField _positionOffsetFromPlayer = new();
        [FieldAttr(nst: 532, ctr: 564)] public float _cameraFollowPitch = -19.0f;
        [FieldAttr(nst: 536, ctr: 568)] public float _cameraRampPitch = -25.0f;
        [FieldAttr(nst: 540, ctr: 572)] public bool _rampPitchingActive;
        [FieldAttr(nst: 544, ctr: 576)] public float _lastPitch;
        [FieldAttr(nst: 548, ctr: 580)] public float _pitchVelocity;
        [FieldAttr(nst: 552, ctr: 584)] public float _pitchDamping = 1.0f;
        [FieldAttr(nst: 556, ctr: 588)] public bool _cameraUpdateActive = true;
        [FieldAttr(nst: 557, ctr: 589)] public bool _cameraVerticalLocked;
        [FieldAttr(nst: 560, ctr: 592)] public float _verticalLockedPositionDamping = 0.5f;
        [FieldAttr(nst: 564, ctr: 596)] public float _cameraGroundHeight;
    }
}
