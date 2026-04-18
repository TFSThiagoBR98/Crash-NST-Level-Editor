namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igVscClampIntNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscIntAccessor? _value;
        [FieldAttr(nst: 24)] public igVscIntAccessor? _minValue;
        [FieldAttr(nst: 32)] public igVscIntAccessor? _maxValue;
        [FieldAttr(nst: 40)] public igVscIntAccessor? _result;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
