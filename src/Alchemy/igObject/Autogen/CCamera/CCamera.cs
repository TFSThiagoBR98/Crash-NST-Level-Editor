namespace Alchemy
{
    [ObjectAttr(nst: 416, ctr: 448, align: 16)]
    public class CCamera : CCameraBase
    {
        [FieldAttr(nst: 288, ctr: 292)] public float _dampingFactor = 0.2f;
        [FieldAttr(nst: 292, ctr: 296)] public float _fovStorage = 1.396f;
        [FieldAttr(ctr: 300)] public float _rawFov;
        [FieldAttr(nst: 296, ctr: 304)] public float _maxZoomOutDistance = 1024.0f;
        [FieldAttr(nst: 300, ctr: 308)] public bool _depthOfFieldEnabled = true;
        [FieldAttr(nst: 304, ctr: 320)] public igVec4fMetaField _focusPlanes = new();
        [FieldAttr(ctr: 336)] public float _motionBlurExposureTimeOverride;
        [FieldAttr(nst: 320, ctr: 344)] public CCameraClipSettings? _clipSettings;
        [FieldAttr(nst: 328, ctr: 352)] public CCameraDistanceCullSettings? _distanceCullSettings;
        [FieldAttr(nst: 336, ctr: 360)] public float _depthTetherDistance = 800.0f;
        [FieldAttr(nst: 340, ctr: 364)] public bool _shadowSettingsState;
        [FieldAttr(nst: 344, ctr: 368)] public float _shadowRange = 3000.0f;
        [FieldAttr(nst: 352, ctr: 384)] public igVec4fMetaField _shadowBias = new();
        [FieldAttr(nst: 368, ctr: 400)] public float _vfxCullRadiusScale = 1.0f;
        [FieldAttr(nst: 372, ctr: 404)] public float _mobileShaderLodDistance = 1200.0f;
        [FieldAttr(nst: 376, ctr: 408)] public float _mobileShadowRange = 1000.0f;
        [FieldAttr(nst: 380, ctr: 412)] public float _mobileShadowHeightOffset = 1000.0f;
        [FieldAttr(nst: 384, ctr: 416)] public float _mobileShadowFarPlane = 1500.0f;
        [FieldAttr(nst: 388, ctr: 420)] public CTransformMetaField _transformVelocity = new();
    }
}
