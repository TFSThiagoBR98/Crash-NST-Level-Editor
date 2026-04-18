namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class igPool : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _fixed;
        [FieldAttr(nst: 17, ctr: 13)] public bool _autoRefCount;
        [FieldAttr(nst: 20, ctr: 16)] public uint _capacity;
        [FieldAttr(nst: 24, ctr: 20)] public uint _peakAllocatedCount;
        [FieldAttr(nst: 32, ctr: 24)] public igPoolBucket? _bucket;
        [FieldAttr(nst: 40, ctr: 32)] public igIndexPool? _indices;
        [FieldAttr(nst: 48, ctr: 40, refCount: false)] public igMemoryPool? _dataPool;
        [FieldAttr(nst: 56, ctr: 48)] public u16 _elementSize;
        [FieldAttr(nst: 58, ctr: 50)] public u16 _elementAlignment;
        [FieldAttr(nst: 64, ctr: 56)] public igMutex? _lock;
        [FieldAttr(nst: 72, ctr: 64)] public igMetaObject? _typeOverride;
    }
}
