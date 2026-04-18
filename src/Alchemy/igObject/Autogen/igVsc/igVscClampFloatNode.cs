namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igVscClampFloatNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscFloatAccessor? _value;
        [FieldAttr(nst: 24, ctr: 24)] public igVscFloatAccessor? _minValue;
        [FieldAttr(nst: 32, ctr: 32)] public igVscFloatAccessor? _maxValue;
        [FieldAttr(nst: 40, ctr: 40)] public igVscFloatAccessor? _result;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igVscActionNode? _out;
    }
}
