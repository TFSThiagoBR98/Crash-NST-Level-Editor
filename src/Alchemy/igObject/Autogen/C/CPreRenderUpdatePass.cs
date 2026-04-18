namespace Alchemy
{
    [ObjectAttr(nst: 640, ctr: 672, align: 16)]
    public class CPreRenderUpdatePass : CPreRenderUpdatePassBase
    {
        [FieldAttr(nst: 288, ctr: 288)] public int _updatePassIndex = -1;
        [FieldAttr(nst: 292, ctr: 292)] public float _cameraAspectRatioMultiplier = 1.0f;
        [FieldAttr(nst: 296, ctr: 296)] public float _viewportRelativeX;
        [FieldAttr(nst: 300, ctr: 300)] public float _viewportRelativeWidth = 1.0f;
        [FieldAttr(nst: 304, ctr: 304)] public float _viewportRelativeY;
        [FieldAttr(nst: 308, ctr: 308)] public float _viewportRelativeHeight = 1.0f;
        [FieldAttr(nst: 312, ctr: 312)] public string? _cameraName = "main";
        [FieldAttr(nst: 320, ctr: 320)] public igHandleMetaField _composeSceneRenderPass = new();
        [FieldAttr(nst: 328, ctr: 328)] public igHandleMetaField _pointLightsHandle = new();
        [FieldAttr(nst: 336, ctr: 336)] public bool _isReflectionPass;
        [FieldAttr(nst: 340, ctr: 340)] public int _unreflectedCameraPassIndex = -1;
        [FieldAttr(nst: 344, ctr: 344)] public EViewportID _viewportID;
        [FieldAttr(nst: 352, ctr: 352)] public igHandleMetaField _cameraSystemInstanceHandle = new();
        [FieldAttr(nst: 360, ctr: 360)] public igRenderCamera? _renderCamera;
        [FieldAttr(nst: 368, ctr: 368)] public igPlane[] _cameraPlanes = new igPlane[6];
        [FieldAttr(nst: 416, ctr: 416)] public igAABox? _cameraNearBox;
        [FieldAttr(nst: 424, ctr: 424)] public igVec3fMetaField _hero1CloudFadePositionNear = new();
        [FieldAttr(nst: 436, ctr: 436)] public igVec3fMetaField _hero2CloudFadePositionNear = new();
        [FieldAttr(nst: 448, ctr: 448)] public igVec3fMetaField _hero1CloudFadePositionFar = new();
        [FieldAttr(nst: 460, ctr: 460)] public igVec3fMetaField _hero2CloudFadePositionFar = new();
        [FieldAttr(ctr: 472)] public int _maxCascadesCount;
        [FieldAttr(nst: 472, ctr: 480)] public igHandleMetaField _cascadeShadowRenderDataHandle = new();
        [FieldAttr(nst: 480, ctr: 488)] public igHandleMetaField _projectiveShadowRenderDataHandle = new();
        [FieldAttr(nst: 488, ctr: 496)] public igRenderAuxiliaryCullingParameters? _auxiliaryCullingParameters;
        [FieldAttr(nst: 496, ctr: 504)] public igRenderLodParameters? _lodParameters;
        [FieldAttr(nst: 504, ctr: 512)] public igHandleMetaField _heroShadowDataHandle = new();
        [FieldAttr(ctr: 520)] public igHandleMetaField _obscuredRenderDataHandle = new();
        [FieldAttr(nst: 512, ctr: 528)] public igRay? _heroShadowRay;
        [FieldAttr(nst: 520)] public igRenderCamera? _hero1ShadowCamera;
        [FieldAttr(nst: 528)] public igRenderCamera? _hero2ShadowCamera;
        [FieldAttr(ctr: 536)] public igRenderCamera? _heroShadowCamera;
        [FieldAttr(nst: 536, ctr: 544)] public igAABox? _heroShadowIntersectionBox;
        [FieldAttr(nst: 544)] public string? _hero1ShadowString = null;
        [FieldAttr(nst: 552)] public string? _hero2ShadowString = null;
        [FieldAttr(ctr: 552)] public string? _heroShadowString;
        [FieldAttr(nst: 560, ctr: 560)] public string? _parametersString = null;
        [FieldAttr(nst: 568, ctr: 568)] public string? _sunString = null;
        [FieldAttr(nst: 576, ctr: 576)] public igSceneRenderPassEnableData? _depthOfFieldEnableData;
        [FieldAttr(nst: 584, ctr: 584)] public igSceneRenderPassEnableData? _toonEnableData;
        [FieldAttr(nst: 592, ctr: 592)] public igSceneRenderPassEnableData? _obscuredEnableData;
        [FieldAttr(nst: 600, ctr: 600)] public igSceneRenderPassEnableData? _waterSimuluationEnableData;
        [FieldAttr(nst: 608, ctr: 608)] public igSceneRenderPassEnableData? _sunshaftEnableData;
        [FieldAttr(nst: 616, ctr: 616)] public igSceneRenderPassEnableData? _highResolutionVfxEnableData;
        [FieldAttr(ctr: 624)] public igSceneRenderPassEnableData? _pauseBlurEnableData;
        [FieldAttr(ctr: 632)] public igSceneRenderPassEnableData? _skyGradientEnableData;
        [FieldAttr(ctr: 640)] public igSceneRenderPassEnableData? _hdrEnableData;
        [FieldAttr(nst: 624, ctr: 648)] public bool _isEnabled = true;
        [FieldAttr(nst: 632, ctr: 656)] public igRenderPassList? _flattenedChildren;
    }
}
