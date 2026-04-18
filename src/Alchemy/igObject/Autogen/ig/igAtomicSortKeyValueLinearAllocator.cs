namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 16)]
    public class igAtomicSortKeyValueLinearAllocator : igObject
    {
        [FieldAttr(nst: 16)] public igVectorMetaField<igSortKeyValuePairMetaField> _buffer = new();
        [FieldAttr(nst: 48)] public int _count;
    }
}
