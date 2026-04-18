namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscMultiplyVec2fScalarAccessor : igVscVec2fAccessor
    {
        [FieldAttr(nst: 24)] public igVscVec2fAccessor? _a;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _b;
    }
}
