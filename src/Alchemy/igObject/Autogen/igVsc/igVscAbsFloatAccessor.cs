namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class igVscAbsFloatAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _input;
    }
}
