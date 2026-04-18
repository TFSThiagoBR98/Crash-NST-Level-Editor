namespace Alchemy
{
    [ObjectAttr(nst: 352, ctr: 352, align: 16)]
    public class igBaseRenderPass : igRenderPass
    {
        [FieldAttr(nst: 56, ctr: 56)] public igRenderTargetInputDataList? _inputRenderTargetData;
        [FieldAttr(nst: 64, ctr: 64)] public igImageInputDataList? _inputImageData;
        [FieldAttr(nst: 72, ctr: 72)] public igRenderTargetOutputData? _outputRenderTargetData;
        [FieldAttr(nst: 80, ctr: 80)] public igRenderTargetCustomDataList? _customRenderTargetData;
        [FieldAttr(nst: 88, ctr: 88)] public igAttrList? _defaultRenderState;
        [FieldAttr(nst: 96, ctr: 96)] public igShaderConstantBundleList? _shaderConstantBundles;
        [FieldAttr(nst: 104, ctr: 104)] public int _dynamicConstantBundleCount;
        [FieldAttr(nst: 112, ctr: 112)] public igGraphicsObjectList? _defaultRenderStateObjects;
        [FieldAttr(nst: 120, ctr: 120)] public igMemoryCommandStream? _defaultRenderStateStream;
        [FieldAttr(nst: 128, ctr: 128)] public igGraphicsObjectList? _overrideRenderStateObjects;
        [FieldAttr(nst: 136, ctr: 136)] public igMemoryCommandStream? _overrideRenderStateStream;
        [FieldAttr(nst: 144, ctr: 144)] public igSortKeyCommandDelegateObject? _postPassDelegate;
        [FieldAttr(nst: 152, ctr: 152)] public igAttrList? _overrideRenderState;
        [FieldAttr(nst: 160, ctr: 160)] public uint _clearMode;
        [FieldAttr(nst: 176, ctr: 176)] public igVec4fMetaField _clearColor = new();
        [FieldAttr(nst: 192, ctr: 192)] public float _clearDepth = 1.0f;
        [FieldAttr(nst: 196, ctr: 196)] public uint _clearStencil;
        [FieldAttr(nst: 200, ctr: 200)] public EIG_GFX_HISTENCIL_CLEAR _clearHiStencil = EIG_GFX_HISTENCIL_CLEAR.PASS;
        [FieldAttr(nst: 208, ctr: 208)] public string? _cameraName = "main";
        [FieldAttr(nst: 216, ctr: 216)] public bool _updateProjectionOnSizeChange = true;
        [FieldAttr(nst: 217, ctr: 217)] public bool _updateViewportOnSizeChange = true;
        [FieldAttr(nst: 224, ctr: 224)] public igHandleMetaField _material = new();
        [FieldAttr(nst: 232, ctr: 232)] public bool _overrideMaterial = true;
        [FieldAttr(nst: 240, ctr: 240)] public string? _preferredMaterialTechniqueName = null;
        [FieldAttr(nst: 248, ctr: 248)] public int _preferredMaterialTechniqueGlobalIndex = -1;
        [FieldAttr(nst: 252, ctr: 252)] public bool _useDefaultMaterialTechnique = true;
        [FieldAttr(nst: 253, ctr: 253)] public bool _useDistanceCull;
        [FieldAttr(ctr: 254)] public bool _useHdrGammaCorrect;
        [FieldAttr(nst: 256, ctr: 256)] public float _nearZ;
        [FieldAttr(nst: 260, ctr: 260)] public float _farZ = 1.0f;
        [FieldAttr(nst: 264, ctr: 264)] public bool _flushHiZStencil;
        [FieldAttr(nst: 265, ctr: 265)] public bool _asynchronousHiZFlush;
        [FieldAttr(nst: 266, ctr: 266)] public bool _flushAndSetSCull;
        [FieldAttr(nst: 268, ctr: 268)] public EIG_GFX_STENCIL_FUNCTION _sCullFunction = EIG_GFX_STENCIL_FUNCTION.LESS;
        [FieldAttr(nst: 272, ctr: 272)] public uint _sCullReference = 128;
        [FieldAttr(nst: 276, ctr: 276)] public uint _sCullMask = 255;
        [FieldAttr(nst: 280, ctr: 280)] public string? _sceneCameraName = "main";
        [FieldAttr(nst: 288, ctr: 288)] public bool _enableReconstructionConstants;
        [FieldAttr(ctr: 289)] public bool _ditheringAllowed;
        [FieldAttr(nst: 292, ctr: 292)] public float _reconstructionCameraScale = 1.0f;
        [FieldAttr(nst: 296, ctr: 296)] public igRenderCamera? _camera;
        [FieldAttr(nst: 304, ctr: 304)] public igRenderCamera? _sceneCamera;
        [FieldAttr(nst: 312, ctr: 312)] public igViewPositionReconstructionBundle? _viewPositionReconstructionParameters;
        [FieldAttr(nst: 320, ctr: 320)] public igVectorMetaField<igSizeTypeMetaField> _rasterizerStates = new();
        [FieldAttr(nst: 344, ctr: 344)] public EViewportID _viewportID;
    }
}
