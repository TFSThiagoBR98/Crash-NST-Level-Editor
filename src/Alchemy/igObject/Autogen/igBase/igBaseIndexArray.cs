namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class igBaseIndexArray : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _indexCount;
        [FieldAttr(nst: 24, ctr: 16)] public uint _indexCountArray = new();
        [FieldAttr(nst: 32, ctr: 24)] public uint _indexCounts;
        [FieldAttr(nst: 40, ctr: 32)] public igIndexFormat? _format;
        [FieldAttr(nst: 48, ctr: 40)] public EIG_GFX_DRAW _primitiveType;
        [FieldAttr(nst: 52, ctr: 44)] public uint _size;
        [FieldAttr(nst: 56, ctr: 48)] public igIndexBuffer? _buffer;
        [FieldAttr(nst: 64, ctr: 56)] public igRawRefMetaField _platformBuffer = new();
        [FieldAttr(nst: 72, ctr: 64)] public igVertexFormat? _vertexFormat;
    }
}
