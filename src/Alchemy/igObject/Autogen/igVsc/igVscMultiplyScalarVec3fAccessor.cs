namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscMultiplyScalarVec3fAccessor : igVscVec3fAccessor
    {
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _a;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _b;
    }
}
