namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class igVscNegateBoolAccessor : igVscBoolAccessor
    {
        [FieldAttr(nst: 24)] public igVscBoolAccessor? _value;
    }
}
