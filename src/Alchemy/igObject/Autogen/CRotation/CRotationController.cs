namespace Alchemy
{
    [ObjectAttr(nst: 208, ctr: 192, align: 16)]
    public class CRotationController : CBaseMovementController
    {
        public enum ERotationMode
        {
            eRM_Reliable = 0,
            eRM_Additive = 1,
        }

        public enum ERotationSource
        {
            eRS_Auto = 0,
            eRS_AngleOffset = 1,
            eRS_AxisSpeed = 2,
            eRS_AxisTime = 3,
        }

        [FieldAttr(nst: 56, ctr: 48)] public igVec3fMetaField _rotationAxis = new();
        [FieldAttr(nst: 68, ctr: 60)] public igVec3fMetaField _offset = new();
        [FieldAttr(nst: 80, ctr: 72)] public igHandleMetaField _pivotEntity = new();
        [FieldAttr(nst: 88, ctr: 80)] public bool _facePivot = true;
        [FieldAttr(nst: 92, ctr: 84)] public float _degreesToRotate = 360.0f;
        [FieldAttr(nst: 96, ctr: 88)] public bool _isLocalRotation;
        [FieldAttr(nst: 97, ctr: 89)] public bool _replicateSlider = true;
        [FieldAttr(nst: 100, ctr: 92)] public ESliderMode _mode;
        [FieldAttr(nst: 104, ctr: 96)] public ERotationMode _rotationMode;
        [FieldAttr(nst: 108, ctr: 100)] public float _duration = 1.0f;
        [FieldAttr(nst: 112, ctr: 104)] public EigEaseType _easeType = EigEaseType.kEaseTypeQuadratic;
        [FieldAttr(nst: 116, ctr: 108)] public float _easeIn;
        [FieldAttr(nst: 120, ctr: 112)] public float _easeOut;
        [FieldAttr(nst: 124, ctr: 116)] public float _forcedSpeed = 3.4028234663852886e+38f;
        [FieldAttr(nst: 128, ctr: 120)] public CSlider? _slider;
        [FieldAttr(nst: 136, ctr: 128)] public float _previousSliderValue;
        [FieldAttr(nst: 140, ctr: 132)] public igVec3fMetaField _axis = new();
        [FieldAttr(nst: 160, ctr: 144)] public igQuaternionfMetaField _sourceOrientation = new();
        [FieldAttr(nst: 176, ctr: 160)] public igQuaternionfMetaField _targetOrientation = new();
        [FieldAttr(nst: 192, ctr: 176)] public bool _reachedTargetOrientation;
        [FieldAttr(nst: 196, ctr: 180)] public ERotationSource _rotationSource;
    }
}
