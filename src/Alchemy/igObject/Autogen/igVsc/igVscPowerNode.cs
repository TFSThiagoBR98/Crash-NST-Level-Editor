namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscPowerNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _value;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _power;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _result;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
