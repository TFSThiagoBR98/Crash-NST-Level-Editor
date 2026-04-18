namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 136, align: 8)]
    public class igVertexArray : igBaseVertexArray
    {
        [FieldAttr(nst: 112)] public igRawRefMetaField[] _dxVertexBuffer = new igRawRefMetaField[4];
        [FieldAttr(nst: 144)] public int _streamCount;
        [FieldAttr(nst: 148)] public bool _dirty = true;
        [FieldAttr(ctr: 112)] public igVectorMetaField<u64> _buffers = new();
    }
}
