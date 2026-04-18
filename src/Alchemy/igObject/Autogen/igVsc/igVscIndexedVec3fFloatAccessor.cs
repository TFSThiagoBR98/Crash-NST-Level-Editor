namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVscIndexedVec3fFloatAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVscVec3fAccessor? _vector;
        [FieldAttr(nst: 32, ctr: 24)] public int _index;
    }
}
