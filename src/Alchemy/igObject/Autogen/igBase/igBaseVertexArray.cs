namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 8)]
    public class igBaseVertexArray : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _cacheFlushSequenceId;
        [FieldAttr(nst: 20, ctr: 16)] public uint _vertexCount;
        [FieldAttr(nst: 24, ctr: 24)] public uint _vertexCountArray = new();
        [FieldAttr(nst: 32, ctr: 32)] public uint _vertexCounts;
        [FieldAttr(nst: 40, ctr: 40)] public igVertexFormat? _format;
        [FieldAttr(nst: 48, ctr: 48)] public EIG_GFX_DRAW _primitiveType;
        [FieldAttr(nst: 56, ctr: 56)] public igMemoryRef<u8> _packData = new();
        [FieldAttr(nst: 72, ctr: 72)] public uint _size;
        [FieldAttr(nst: 80, ctr: 80)] public igVertexBuffer? _buffer;
        [FieldAttr(nst: 88, ctr: 88)] public igRawRefMetaField _platformBuffer = new();
        [FieldAttr(nst: 96, ctr: 96, refCount: false)] public igVertexArray? _softwareBlendedArray;
        [FieldAttr(nst: 104, ctr: 104)] public uint _softwareBlendedSequenceId;
        [FieldAttr(nst: 108, ctr: 108)] public bool _skinned;
        [FieldAttr(nst: 109, ctr: 109)] public bool _transient;
    }
}
