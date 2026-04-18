namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class igAtomicHeapCommandStream : igCommandStream
    {
        [FieldAttr(nst: 64, ctr: 64)] public u8 _head = new();
        [FieldAttr(nst: 72, ctr: 72)] public int _chunkSize;
        [FieldAttr(nst: 80, ctr: 80)] public igRawRefMetaField _heap = new();
    }
}
