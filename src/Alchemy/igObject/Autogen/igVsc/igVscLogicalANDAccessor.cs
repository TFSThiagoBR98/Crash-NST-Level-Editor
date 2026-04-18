namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscLogicalANDAccessor : igVscBoolAccessor
    {
        [FieldAttr(nst: 24)] public igVscBoolAccessor? _a;
        [FieldAttr(nst: 32)] public igVscBoolAccessor? _b;
    }
}
