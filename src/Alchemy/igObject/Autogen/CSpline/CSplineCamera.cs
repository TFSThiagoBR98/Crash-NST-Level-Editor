namespace Alchemy
{
    [ObjectAttr(nst: 592, ctr: 624, align: 16)]
    public class CSplineCamera : CConstrainedCamera
    {
        [FieldAttr(nst: 432, ctr: 464)] public igHandleMetaField _splineEntity = new();
        [FieldAttr(nst: 440, ctr: 472)] public CSplineCameraData? _data;
        [FieldAttr(nst: 448, ctr: 480)] public float _distanceFromPlayer;
        [FieldAttr(nst: 452, ctr: 484)] public float _desiredDistanceFromPlayer;
        [FieldAttr(nst: 456, ctr: 488)] public float _distanceAlongSpline;
        [FieldAttr(nst: 460, ctr: 492)] public float _offsetFromSpline;
        [FieldAttr(nst: 464, ctr: 496)] public bool _isVerticalSection;
        [FieldAttr(nst: 468, ctr: 500)] public int _ignoredAxis = 2;
        [FieldAttr(nst: 472, ctr: 504)] public float _distanceFromPlayerVelocity;
        [FieldAttr(nst: 476, ctr: 508)] public igVec3fMetaField _rotationVelocity = new();
        [FieldAttr(nst: 488, ctr: 520)] public igVec3fMetaField _inputRotationVelocity = new();
        [FieldAttr(nst: 500, ctr: 532)] public float _distanceAlongSplineVelocity;
        [FieldAttr(nst: 504, ctr: 536)] public float _offsetFromSplineVelocity;
        [FieldAttr(nst: 508)] public EPlayerId _playerId;
        [FieldAttr(nst: 512, ctr: 540)] public bool _hasTargetMovedOnce;
        [FieldAttr(nst: 516, ctr: 544)] public igVec3fMetaField _targetStartPosition = new();
        [FieldAttr(nst: 528, ctr: 556)] public float _pitchOffset;
        [FieldAttr(nst: 532, ctr: 560)] public ESplineMode _currentSplineCameraMode;
        [FieldAttr(nst: 536, ctr: 568)] public CTimer? _directionalOffsetTimer;
        [FieldAttr(nst: 544, ctr: 576)] public CTimer? _pitchOffsetTimer;
        [FieldAttr(nst: 552, ctr: 584)] public CTransformMetaField _inputTransform = new();
    }
}
