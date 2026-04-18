namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class igVscMultiplyVec3fAccessor : igVscVec3fAccessor
    {
        [FieldAttr(ctr: 16)] public igVscVec3fAccessor? _a;
        [FieldAttr(ctr: 24)] public igVscVec3fAccessor? _b;
    }
}
