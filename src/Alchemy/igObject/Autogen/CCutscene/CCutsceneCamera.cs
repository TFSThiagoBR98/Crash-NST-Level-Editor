namespace Alchemy
{
    [ObjectAttr(nst: 512, ctr: 560, align: 16)]
    public class CCutsceneCamera : CCamera
    {
        [FieldAttr(nst: 416, ctr: 448)] public CCameraKeyframeAnimation? _animation;
        [FieldAttr(nst: 424, ctr: 456)] public string? _motionPathFilename = null;
        [FieldAttr(nst: 432, ctr: 464)] public igSpline? _spline;
        [FieldAttr(nst: 440, ctr: 472)] public float _splineMoveSpeed = 320.0f;
        [FieldAttr(nst: 448, ctr: 480)] public igHandleMetaField _attachToEntity = new();
        [FieldAttr(ctr: 488)] public bool _useWorldValues;
        [FieldAttr(nst: 456, ctr: 492)] public igVec3fMetaField _attachedEntityLocalOffset = new();
        [FieldAttr(nst: 468, ctr: 504)] public igVec3fMetaField _attachedEntityLocalAngles = new();
        [FieldAttr(ctr: 516)] public bool _retainAttachedEntityAngle;
        [FieldAttr(nst: 480, ctr: 520)] public float _currentPositionOnSpline;
        [FieldAttr(nst: 488, ctr: 528)] public igObject? _motionPath = new();
        [FieldAttr(nst: 496, ctr: 536)] public float _runningTime;
        [FieldAttr(nst: 500, ctr: 540)] public float _dataPumpFloatBindForFOV;
        [FieldAttr(nst: 504, ctr: 544)] public bool _isInternalAttachToEntity;
        [FieldAttr(nst: 508, ctr: 548)] public uint _lastFrameUpdated;
    }
}
