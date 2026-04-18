namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscDivideIntFloatAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24)] public igVscIntAccessor? _a;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _b;
    }
}
