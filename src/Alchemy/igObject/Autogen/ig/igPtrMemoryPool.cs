namespace Alchemy
{
    [ObjectAttr(nst: 96, ctr: 96, align: 16)]
    public class igPtrMemoryPool : igObject
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igPtrMemoryPool? _thisPtr;
        [FieldAttr(nst: 24, ctr: 24)] public u8 _head = new();
        [FieldAttr(nst: 32, ctr: 32)] public uint _chunkSize;
        [FieldAttr(nst: 40, ctr: 40)] public u8 _stackCurrent = new();
        [FieldAttr(nst: 48, ctr: 48)] public u8 _stackBegin = new();
        [FieldAttr(nst: 56, ctr: 56)] public u8 _stackEnd = new();
        [FieldAttr(nst: 64, ctr: 64)] public igRawRefMetaField _heap = new();
        [FieldAttr(nst: 72, ctr: 72)] public igRawRefMetaField _localHeap = new();
        [FieldAttr(nst: 80, ctr: 80)] public bool _outOfMemory;
    }
}
