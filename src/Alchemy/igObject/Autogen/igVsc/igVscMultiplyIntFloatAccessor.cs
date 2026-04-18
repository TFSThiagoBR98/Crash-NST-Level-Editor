namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class igVscMultiplyIntFloatAccessor : igVscFloatAccessor
    {
        [FieldAttr(ctr: 16)] public igVscIntAccessor? _a;
        [FieldAttr(ctr: 24)] public igVscFloatAccessor? _b;
    }
}
