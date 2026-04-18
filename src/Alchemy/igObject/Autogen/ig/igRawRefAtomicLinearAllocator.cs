namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 16)]
    public class igRawRefAtomicLinearAllocator : igObject
    {
        [FieldAttr(nst: 16)] public igVectorMetaField<igRawRefMetaField> _buffer = new();
        [FieldAttr(nst: 48)] public int _count;
    }
}
