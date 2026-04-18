namespace Alchemy
{
    [ObjectAttr(ctr: 656, align: 16)]
    public class CKartCamera : CConstrainedCamera
    {
        [FieldAttr(ctr: 464)] public igHandleMetaField _focusedEntity = new();
        [FieldAttr(ctr: 472)] public bool _cameraUpdateActive;
        [FieldAttr(ctr: 476)] public igVec3fMetaField _rotationVelocity = new();
        [FieldAttr(ctr: 488)] public igVec3fMetaField _lastValidForward = new();
        [FieldAttr(ctr: 500)] public igVec2fMetaField _lastPosition = new();
        [FieldAttr(ctr: 508)] public float _heightVelocity;
        [FieldAttr(ctr: 512)] public float _lastHeight;
        [FieldAttr(ctr: 516)] public igVec2fMetaField _positionVelocity = new();
        [FieldAttr(ctr: 524)] public float _lastPitch;
        [FieldAttr(ctr: 528)] public float _pitchVelocity;
        [FieldAttr(ctr: 532)] public bool _cameraVerticalLocked;
        [FieldAttr(ctr: 536)] public igVec3fMetaField _finalPosition = new();
        [FieldAttr(ctr: 548)] public igVec3fMetaField _finalRotationAngles = new();
        [FieldAttr(ctr: 560)] public bool _reverseMode;
        [FieldAttr(ctr: 561)] public bool _reverseModeLastFrame;
        [FieldAttr(ctr: 564)] public igTimeMetaField _lastCollisionTime = new();
        [FieldAttr(ctr: 568)] public igVec3fMetaField _lastCollisionFinalPosition = new();
        [FieldAttr(ctr: 580)] public float _currentBackwardCollisionCameraTransferToHeightScale;
        [FieldAttr(ctr: 584)] public igHandleMetaField _kartControllerComponentHandle = new();
        [FieldAttr(ctr: 592)] public EKartCameraMode _currentMode;
        [FieldAttr(ctr: 596)] public bool _isReverse;
        [FieldAttr(ctr: 600)] public CKartCameraSettings? _nearSettings;
        [FieldAttr(ctr: 608)] public CKartCameraSettings? _farSettings;
        [FieldAttr(ctr: 616)] public CKartCameraSettings? _reverseSettings;
        [FieldAttr(ctr: 624)] public CKartCameraSettings? _reverseFarSettings;
        [FieldAttr(ctr: 632)] public igHandleMetaField _overrideFocusedEntity = new();
        [FieldAttr(ctr: 640)] public float _driftCamAllowedRatio;
        [FieldAttr(ctr: 644)] public bool _wasSuperFalling;
        [FieldAttr(ctr: 648)] public igTimeMetaField _lastFallingTime = new();
        [FieldAttr(ctr: 652)] public igTimeMetaField _fallingStartTime = new();
    }
}
