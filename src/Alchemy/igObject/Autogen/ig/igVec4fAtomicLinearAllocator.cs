namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 16)]
    public class igVec4fAtomicLinearAllocator : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<igVec4fMetaField> _buffer = new();
        [FieldAttr(nst: 48, ctr: 48)] public int _count;
    }
}
