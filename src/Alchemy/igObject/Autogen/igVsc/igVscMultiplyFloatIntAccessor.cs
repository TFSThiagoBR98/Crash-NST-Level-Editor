namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscMultiplyFloatIntAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _a;
        [FieldAttr(nst: 32)] public igVscIntAccessor? _b;
    }
}
