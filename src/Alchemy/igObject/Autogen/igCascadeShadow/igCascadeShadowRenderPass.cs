namespace Alchemy
{
    [ObjectAttr(nst: 1280, ctr: 1168, align: 16)]
    public class igCascadeShadowRenderPass : igSceneRenderPass
    {
        [FieldAttr(ctr: 464)] public igRenderCamera? _debugSceneCamera;
        [FieldAttr(nst: 464, ctr: 472)] public igHandleMetaField _light = new();
        [FieldAttr(nst: 472, ctr: 480)] public igHandleMetaField _params = new();
        [FieldAttr(nst: 480, ctr: 488)] public int _shadowMapSize = -1;
        [FieldAttr(nst: 484, ctr: 492)] public int _numSplits = -1;
        [FieldAttr(ctr: 496)] public int _fullShadowMapSize;
        [FieldAttr(ctr: 500)] public int _maxNumSplits;
        [FieldAttr(nst: 488, ctr: 504)] public igCascadeShadowParametersBundle? _shadowParameters;
        [FieldAttr(nst: 496, ctr: 512)] public igMatrix44fMetaField _lightViewMatrix = new();
        [FieldAttr(nst: 560, ctr: 576)] public igMatrix44fMetaField[] _splitProjectionMatrices = new igMatrix44fMetaField[4];
        [FieldAttr(nst: 816, ctr: 832)] public igVec4fMetaField[] _splitBoundsMin = new igVec4fMetaField[4];
        [FieldAttr(nst: 880, ctr: 896)] public igVec4fMetaField[] _splitBoundsMax = new igVec4fMetaField[4];
        [FieldAttr(nst: 944)] public igVec4fMetaField[] _frustumCorners = new igVec4fMetaField[8];
        [FieldAttr(nst: 1072, ctr: 960)] public igRenderCameraList? _splitCameras;
        [FieldAttr(nst: 1080, ctr: 968)] public igPlane[] _frustumPlanes = new igPlane[10];
        [FieldAttr(nst: 1160, ctr: 1048)] public igRay? _ray;
        [FieldAttr(nst: 1168, ctr: 1056)] public igRawRefMetaField _pixelShaderBinary = new();
        [FieldAttr(nst: 1176, ctr: 1064)] public int _pixelShaderBinarySize;
        [FieldAttr(nst: 1184, ctr: 1072)] public string? _pixelShaderStates = null;
        [FieldAttr(nst: 1192, ctr: 1080)] public igRawRefMetaField _vertexShaderBinary = new();
        [FieldAttr(nst: 1200, ctr: 1088)] public int _vertexShaderBinarySize;
        [FieldAttr(nst: 1208, ctr: 1096)] public string? _vertexShaderStates = null;
        [FieldAttr(nst: 1216, ctr: 1104)] public igCommandStreamEncoderPassState[] _splitPassState = new igCommandStreamEncoderPassState[4];
        [FieldAttr(nst: 1248, ctr: 1136)] public string[] _splitCameraName = new string[4];
    }
}
