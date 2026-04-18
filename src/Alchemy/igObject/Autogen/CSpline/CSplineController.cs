namespace Alchemy
{
    [ObjectAttr(nst: 288, ctr: 272, align: 16)]
    public class CSplineController : CBaseMovementController
    {
        [FieldAttr(nst: 56, ctr: 48)] public igHandleMetaField _splineEntity = new();
        [FieldAttr(nst: 64, ctr: 56)] public CSplineVelocityMover? _velocityMover;
        [FieldAttr(nst: 72, ctr: 64)] public CSplineRotationMover? _rotationMover;
        [FieldAttr(nst: 80, ctr: 72)] public CSplineAttachBehavior? _attachBehavior;
        [FieldAttr(nst: 88, ctr: 80)] public float _previewDistance;
        [FieldAttr(nst: 92, ctr: 84)] public float _startAtDistance;
        [FieldAttr(nst: 96, ctr: 88)] public bool _startReversed;
        [FieldAttr(nst: 100, ctr: 92)] public ESplineEndBehavior _endBehavior;
        [FieldAttr(nst: 104, ctr: 96)] public bool _respondToEvents = true;
        [FieldAttr(nst: 105, ctr: 97)] public bool _replicateDistance;
        [FieldAttr(nst: 112, ctr: 104)] public COnSplineCompleteEventList? _onSplineCompleteEventList;
        [FieldAttr(nst: 120, ctr: 112)] public igVscDelegateMetaField _scriptSplineCompleteCallback = new();
        [FieldAttr(nst: 136, ctr: 128)] public bool _isPaused;
        [FieldAttr(nst: 140, ctr: 132)] public igVec3fMetaField _previousDestinationPosition = new();
        [FieldAttr(nst: 160, ctr: 144)] public igQuaternionfMetaField _previousDestinationRotation = new();
        [FieldAttr(nst: 176, ctr: 160)] public igQuaternionfMetaField _startRotation = new();
        [FieldAttr(nst: 192, ctr: 176)] public float _distance;
        [FieldAttr(nst: 196, ctr: 180)] public bool _reversed;
        [FieldAttr(nst: 200, ctr: 184)] public igSplineEventList? _currentEvents;
        [FieldAttr(nst: 208, ctr: 192)] public float _velocityChangeStartValue;
        [FieldAttr(nst: 212, ctr: 196)] public float _velocityChangeEndValue;
        [FieldAttr(nst: 216, ctr: 200)] public float _velocityChangeDuration;
        [FieldAttr(nst: 220, ctr: 204)] public float _velocityChangeTime;
        [FieldAttr(nst: 224, ctr: 208)] public bool _controllerHasAttachedVehicle;
        [FieldAttr(nst: 232, ctr: 216)] public CChangeRequest? _disableDistanceReplicationRequest;
        [FieldAttr(nst: 240, ctr: 224)] public bool _magicMomentDisabled;
        [FieldAttr(nst: 248, ctr: 232)] public CPhysicsMotionProperties? _cachedMotionProperties;
        [FieldAttr(nst: 256, ctr: 240)] public bool _playPending;
        [FieldAttr(nst: 257, ctr: 241)] public bool _playInReversePending;
        [FieldAttr(nst: 258, ctr: 242)] public bool _pausePending;
        [FieldAttr(nst: 259, ctr: 243)] public bool _jumpToBeginningPending;
        [FieldAttr(nst: 260, ctr: 244)] public bool _jumpToEndPending;
        [FieldAttr(nst: 264, ctr: 248)] public float _lastUpdateDistance;
        [FieldAttr(nst: 272, ctr: 256)] public igHandleMetaField _disabledVehicleSplineMover = new();
    }
}
