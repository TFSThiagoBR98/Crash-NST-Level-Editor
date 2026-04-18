namespace Alchemy
{
    [ObjectAttr(nst: 272, ctr: 272, align: 16)]
    public class igModelInstance : igNamedObject
    {
        public enum EViewportFlag
        {
            kViewportFlagNone = 0,
            kViewportFlag0 = 1,
            kViewportFlag1 = 2,
            kViewportFlagAll = 3,
        }

        [ObjectAttr(size: 4)]
        public class Bitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 16)] public uint _flags;
            [FieldAttr(offset: 16, size: 1)] public bool _allowFrustumCulling;
            [FieldAttr(offset: 17, size: 3)] public EDistanceCullImportance _distanceCullImportance;
        }

        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igModelInstance? _parent;
        [FieldAttr(nst: 32, ctr: 32)] public u8 _forceCullFlags;
        [FieldAttr(nst: 33, ctr: 33)] public u8 _forceViewportDisableFlags;
        [FieldAttr(nst: 34, ctr: 34)] public u8 _visibleDebug = 2;
        [FieldAttr(nst: 35, ctr: 35)] public u8 _classIndex = 1;
        [FieldAttr(nst: 36, ctr: 36)] public i16 _stencilRef = -1;
        [FieldAttr(nst: 48, ctr: 48)] public igMatrix44fMetaField _transform = new();
        [FieldAttr(nst: 112, ctr: 112)] public igVec4fMetaField _min = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _max = new();
        [FieldAttr(nst: 144, ctr: 144)] public uint _parentTransformIndex;
        [FieldAttr(nst: 148, ctr: 148)] public uint _parentBoneIndex = 4294967295;
        [FieldAttr(nst: 152, ctr: 152)] public igTimeTransform2? _timeTransform;
        [FieldAttr(nst: 160, ctr: 160)] public igMatrix44fMetaField _blendMatrices = new();
        [FieldAttr(nst: 168, ctr: 168)] public uint _blendMatrixCount;
        [FieldAttr(nst: 176, ctr: 176)] public igMatrix44fMetaField _boneMatrices = new();
        [FieldAttr(nst: 184, ctr: 184)] public uint _boneMatrixCount;
        [FieldAttr(nst: 192, ctr: 192)] public igModelData? _data;
        [FieldAttr(nst: 200, ctr: 200)] public Bitfield _bitfield = new();
        [FieldAttr(nst: 204, ctr: 204)] public uint _filterId;
        [FieldAttr(nst: 208, ctr: 208)] public string? _class = "main";
        [FieldAttr(nst: 216, ctr: 216)] public igModelMaterialRedirectTable? _materialRedirectTable;
        [FieldAttr(nst: 224, ctr: 224)] public igShaderConstantBundleList? _shaderConstantBundles;
        [FieldAttr(nst: 232, ctr: 232)] public int _dynamicConstantBundleCount;
        [FieldAttr(nst: 240, ctr: 240)] public igSizeTypeMetaField _bakedVertexBufferResource = new();
        [FieldAttr(nst: 248, ctr: 248)] public igSizeTypeMetaField _bakedVertexFormatResource = new();
        [FieldAttr(nst: 256, ctr: 256)] public int _bakedVertexDataBaseOffset = -1;
        [FieldAttr(ctr: 260)] public u8 _environmentMapIndex;
    }
}
