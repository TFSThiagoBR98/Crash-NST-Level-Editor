namespace Alchemy
{
    [ObjectAttr(nst: 368, ctr: 368, align: 16)]
    public class igCommandStreamEncoderPassState : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igMatrix44fMetaField _viewMatrix = new();
        [FieldAttr(nst: 80, ctr: 80)] public igMatrix44fMetaField _previousViewMatrix = new();
        [FieldAttr(nst: 144, ctr: 144)] public igMatrix44fMetaField _projMatrix = new();
        [FieldAttr(nst: 208, ctr: 208)] public igMatrix44fMetaField _viewProjMatrix = new();
        [FieldAttr(nst: 272, ctr: 272)] public uint _techniqueGlobalIndex;
        [FieldAttr(nst: 276, ctr: 276)] public bool _useDefaultTechnique;
        [FieldAttr(nst: 277, ctr: 277)] public u8 _flags;
        [FieldAttr(nst: 278, ctr: 278)] public bool _useDistanceCull;
        [FieldAttr(nst: 280, ctr: 280)] public int _viewportId;
        [FieldAttr(nst: 284, ctr: 284)] public int _stencilRef = -1;
        [FieldAttr(nst: 288, ctr: 288)] public EigSetStencilRefOperation _stencilRefOperation;
        [FieldAttr(nst: 296, ctr: 296)] public igMemoryCommandStream? _overrideState;
        [FieldAttr(nst: 304, ctr: 304)] public igHandleMetaField _overrideEffect = new();
        [FieldAttr(nst: 312, ctr: 312)] public igTimeMetaField _time = new();
        [FieldAttr(ctr: 316)] public igTimeMetaField _systemTime = new();
        [FieldAttr(nst: 320, ctr: 320)] public igPickablePointLightDataList? _pointLights;
        [FieldAttr(nst: 328, ctr: 328)] public igVec4fAtomicLinearAllocator? _pointLightAllocator;
        [FieldAttr(nst: 336, ctr: 336)] public float _shaderLodDistance = -1.0f;
        [FieldAttr(nst: 340, ctr: 340)] public float _shaderLodFadeScaleBias;
        [FieldAttr(nst: 344, ctr: 344)] public igRawRefMetaField _projectiveShadowFrustum = new();
        [FieldAttr(nst: 352, ctr: 352)] public bool _resetStencilRef;
        [FieldAttr(nst: 353, ctr: 353)] public bool _enabled = true;
    }
}
