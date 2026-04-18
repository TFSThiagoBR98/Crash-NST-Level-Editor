namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 8)]
    public class igStream : igObject
    {
        [FieldAttr(ctr: 16)] public igStream? _thisPtr;
        [FieldAttr(ctr: 24)] public u8 _head;
        [FieldAttr(ctr: 32)] public u8 _currentHead;
        [FieldAttr(ctr: 40)] public int _chunkSize;
        [FieldAttr(ctr: 48)] public u8 _writeHead;
        [FieldAttr(ctr: 56)] public u8 _writeChunkBegin;
        [FieldAttr(ctr: 64)] public u8 _writeChunkEnd;
        [FieldAttr(ctr: 72)] public u8 _readHead;
        [FieldAttr(ctr: 80)] public u8 _readChunkBegin;
        [FieldAttr(ctr: 88)] public u8 _readChunkEnd;
        [FieldAttr(ctr: 96)] public igRawRefMetaField _heap = new();
        [FieldAttr(ctr: 104)] public igRawRefMetaField _localHeap = new();
        [FieldAttr(ctr: 112)] public bool _outOfMemory;
        [FieldAttr(ctr: 116)] public int _memoryUsedHighWater;
        [FieldAttr(ctr: 120)] public int _memoryAllocatedHighWater;
    }
}
