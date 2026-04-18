namespace Alchemy
{
    [ObjectAttr(nst: 432, ctr: 448, align: 16)]
    public class CCameraBox : CCameraBase
    {
        public enum ECameraBoxSide
        {
            eCBS_Front = 0,
            eCBS_Back = 1,
            eCBS_Right = 2,
            eCBS_Left = 3,
            eCBS_Bottom = 4,
            eCBS_Top = 5,
            eCBS_None = 6,
            eCBS_Debug = 7,
        }

        [FieldAttr(nst: 288, ctr: 292)] public igVec3fMetaField _min = new();
        [FieldAttr(nst: 300, ctr: 304)] public igVec3fMetaField _max = new();
        [FieldAttr(nst: 312, ctr: 320)] public igHandleMetaField _requiredPreviousCamera = new();
        [FieldAttr(nst: 320, ctr: 328)] public CCameraBaseHandleList? _allowedPreviousCameras;
        [FieldAttr(nst: 328, ctr: 336)] public bool _superChargersBackActivationHack;
        [FieldAttr(nst: 336, ctr: 344)] public CCameraBox? _previousCameraBox;
        [FieldAttr(nst: 344, ctr: 352)] public CCameraBase? _camera;
        [FieldAttr(nst: 352, ctr: 360)] public igHandleMetaField _activeCamera = new();
        [FieldAttr(nst: 360, ctr: 368)] public CCameraBase? _explicitlyDefinedPreviousCamera;
        [FieldAttr(nst: 368, ctr: 376)] public CCameraBlendList? _cameraBlends;
        [FieldAttr(nst: 376, ctr: 384)] public EigEaseMode _easeMode = EigEaseMode.kEaseModeInOut;
        [FieldAttr(nst: 380, ctr: 388)] public EigEaseType _easeType = EigEaseType.kEaseTypeCubic;
        [FieldAttr(nst: 384, ctr: 392)] public igVec3fMetaField _targetCached = new();
        [FieldAttr(nst: 396, ctr: 404)] public float _progressCached;
        [FieldAttr(nst: 400, ctr: 408)] public bool _containsTargetCached;
        [FieldAttr(nst: 401, ctr: 409)] public bool _isEnabled = true;
        [FieldAttr(nst: 404, ctr: 412)] public ECameraBoxState _state;
        [FieldAttr(nst: 408, ctr: 416)] public ECameraModelBlendType _blendType = ECameraModelBlendType.eCMBT_Linear;
        [FieldAttr(nst: 416, ctr: 424)] public CCameraBoxPeachesCallback? _peachesCallback;
        [FieldAttr(nst: 424, ctr: 432)] public ECameraBoxSide _activatedSide = CCameraBox.ECameraBoxSide.eCBS_None;
    }
}
