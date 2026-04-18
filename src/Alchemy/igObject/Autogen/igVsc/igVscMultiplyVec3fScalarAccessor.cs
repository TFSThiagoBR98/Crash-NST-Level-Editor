namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVscMultiplyVec3fScalarAccessor : igVscVec3fAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVscVec3fAccessor? _a;
        [FieldAttr(nst: 32, ctr: 24)] public igVscFloatAccessor? _b;
    }
}
