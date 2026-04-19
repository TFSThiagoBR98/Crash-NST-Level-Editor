namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 160, align: 16)]
    public class igModelDrawCallData : igNamedObject
    {
        [ObjectAttr(size: 4)]
        public class PropertiesBitField : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EIG_INDEX_TYPE _indexBufferType = EIG_INDEX_TYPE.INT32;
            [FieldAttr(offset: 3, size: 3)] public EIG_GFX_DRAW _primitiveType = EIG_GFX_DRAW.POINTS;
            [FieldAttr(offset: 6, size: 8)] public u8 _lod = 3;
            [FieldAttr(offset: 14, size: 1)] public bool _enabled = false;
            [FieldAttr(offset: 15, size: 8)] public u8 _instanceShaderConstants;
        }

        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _min = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _max = new();
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _materialHandle = new();
        [FieldAttr(nst: 72, ctr: 72)] public igGraphicsVertexBuffer? _graphicsVertexBuffer;
        [FieldAttr(nst: 80, ctr: 80)] public igGraphicsIndexBuffer? _graphicsIndexBuffer;
        [FieldAttr(nst: 88, ctr: 88)] public igObject? _platformData;
        [FieldAttr(nst: 96, ctr: 96)] public u16 _blendVectorOffset;
        [FieldAttr(nst: 98, ctr: 98)] public u16 _blendVectorCount;
        [FieldAttr(nst: 100, ctr: 100)] public int _morphWeightTransformIndex;
        [FieldAttr(nst: 104, ctr: 104)] public int _primitiveCount;
        [FieldAttr(nst: 108, ctr: 108)] public PropertiesBitField _propertiesBitField = new();
        [FieldAttr(nst: 112, ctr: 112)] public igShaderConstantBundleList? _shaderConstantBundles;
        [FieldAttr(nst: 120, ctr: 120)] public int _bakedBufferOffset = -1;
        [FieldAttr(nst: 124, ctr: 124)] public uint _hash;
        [FieldAttr(nst: 128, ctr: 128)] public igSizeTypeMetaField _vertexBufferResource = new();
        [FieldAttr(nst: 136, ctr: 136)] public igSizeTypeMetaField _vertexBufferFormatResource = new();
        [FieldAttr(nst: 144, ctr: 144)] public igSizeTypeMetaField _indexBufferResource = new();
    }
}
