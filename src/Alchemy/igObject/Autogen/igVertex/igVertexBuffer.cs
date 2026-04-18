namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 96, align: 8)]
    public class igVertexBuffer : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _vertexCount;
        [FieldAttr(nst: 24, ctr: 16)] public igMemoryRef<uint> _vertexCountArray = new();
        [FieldAttr(nst: 40, ctr: 32)] public igMemoryRef<u8> _data = new();
        [FieldAttr(nst: 56, ctr: 48)] public igVertexFormat? _format;
        [FieldAttr(nst: 64, ctr: 56)] public EIG_GFX_DRAW _primitiveType;
        [FieldAttr(nst: 72, ctr: 64)] public igMemoryRef<u8> _packData = new();
        [FieldAttr(nst: 88, ctr: 80, refCount: false)] public igVertexArray? _vertexArray;
        [FieldAttr(nst: 96, ctr: 88)] public int _vertexArrayRefCount;
    }
}
