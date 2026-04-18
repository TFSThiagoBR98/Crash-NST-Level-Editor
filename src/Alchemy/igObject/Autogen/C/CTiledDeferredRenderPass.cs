namespace Alchemy
{
    [ObjectAttr(nst: 912, ctr: 912, align: 16)]
    public class CTiledDeferredRenderPass : igSceneRenderPass
    {
        [FieldAttr(nst: 464, ctr: 464)] public igHandleMetaField _pointLights = new();
        [FieldAttr(nst: 472, ctr: 472)] public igHandleMetaField _boxLights = new();
        [FieldAttr(nst: 480, ctr: 480)] public igVec4fMetaField _nearPlane = new();
        [FieldAttr(nst: 496, ctr: 496)] public igVec4fMetaField _farPlane = new();
        [FieldAttr(nst: 512, ctr: 512)] public igVectorMetaField<igVec4fMetaField> _horizontalPlanes = new();
        [FieldAttr(nst: 536, ctr: 536)] public igVectorMetaField<igVec4fMetaField> _verticalPlanes = new();
        [FieldAttr(nst: 560, ctr: 560)] public igHandleMetaField _materialHandle = new();
        [FieldAttr(nst: 568, ctr: 568)] public igVectorMetaField<igVec4fMetaField> _pointLightPositions = new();
        [FieldAttr(nst: 592, ctr: 592)] public igVectorMetaField<igVec4fMetaField> _pointLightColors = new();
        [FieldAttr(nst: 616, ctr: 616)] public igVectorMetaField<igVec4fMetaField> _pointLightParameters = new();
        [FieldAttr(nst: 640, ctr: 640)] public igVectorMetaField<igMatrix44fMetaField> _boxLightMatrices = new();
        [FieldAttr(nst: 664, ctr: 664)] public igVectorMetaField<igVec4fMetaField> _boxLightDirections = new();
        [FieldAttr(nst: 688, ctr: 688)] public igVectorMetaField<igVec4fMetaField> _boxLightColors = new();
        [FieldAttr(nst: 712, ctr: 712)] public igVectorMetaField<igVec4fMetaField> _boxLightParameters = new();
        [FieldAttr(nst: 736, ctr: 736)] public igVectorMetaField<igMatrix44fMetaField> _boxUvTransforms = new();
        [FieldAttr(nst: 760, ctr: 760)] public CLightRigConstantBundle[] _globalLightRigs = new CLightRigConstantBundle[2];
        [FieldAttr(nst: 776, ctr: 776)] public int _curLightLists;
        [FieldAttr(nst: 780, ctr: 780)] public int _tileSizeX = 64;
        [FieldAttr(nst: 784, ctr: 784)] public int _tileSizeY = 64;
        [FieldAttr(nst: 788, ctr: 788)] public int _numTilesX = -1;
        [FieldAttr(nst: 792, ctr: 792)] public int _numTilesY = -1;
        [FieldAttr(nst: 800, ctr: 800)] public CTileDeferredRenderPassDebugData? _debuggingData;
        [FieldAttr(nst: 808, ctr: 808)] public float _cachedFov = -1.0f;
        [FieldAttr(nst: 812, ctr: 812)] public float _cachedNear = -1.0f;
        [FieldAttr(nst: 816, ctr: 816)] public float _cachedFar = -1.0f;
        [FieldAttr(nst: 824, ctr: 824)] public igHandleMetaField _sunLightHandle = new();
        [FieldAttr(nst: 832, ctr: 832)] public igHandleMetaField _renderData = new();
        [FieldAttr(nst: 840, ctr: 840)] public igOutdoorLightConstantBundle? _outdoorLightConstantBundle;
        [FieldAttr(nst: 848, ctr: 848)] public igAtmosphericsConstantBundle? _atmosphericsConstantBundle;
        [FieldAttr(nst: 856, ctr: 856)] public CLocalShadowInfluenceConstantBundle? _localShadowInfluenceConstantBundle;
        [FieldAttr(nst: 864, ctr: 864)] public igSizeTypeMetaField _vertexBuffer = new();
        [FieldAttr(nst: 872, ctr: 872)] public igSizeTypeMetaField _vertexFormatResource = new();
        [FieldAttr(nst: 880, ctr: 880)] public igDynamicBuffer? _indexBuffer;
        [FieldAttr(nst: 888, ctr: 888)] public igVertexFormat? _vertexFormat;
        [FieldAttr(nst: 896, ctr: 896)] public CTileDeferredRenderPassDrawCallPool? _drawCallPool;
        [FieldAttr(nst: 904, ctr: 904)] public int _version = 1;
    }
}
