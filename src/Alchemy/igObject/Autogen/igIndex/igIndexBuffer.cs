namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 88, align: 8)]
    public class igIndexBuffer : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _indexCount;
        [FieldAttr(nst: 24, ctr: 16)] public igMemoryRef<uint> _indexCountArray = new();
        [FieldAttr(nst: 40, ctr: 32)] public igMemoryRef<u8> _data = new();
        [FieldAttr(nst: 56, ctr: 48)] public igIndexFormat? _format;
        [FieldAttr(nst: 64, ctr: 56)] public EIG_GFX_DRAW _primitiveType;
        [FieldAttr(nst: 72, ctr: 64)] public igVertexFormat? _vertexFormat;
        [FieldAttr(nst: 80, ctr: 72, refCount: false)] public igIndexArray2? _indexArray;
        [FieldAttr(nst: 88, ctr: 80)] public int _indexArrayRefCount;
    }
}
