namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igVscClampVec2fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec2fAccessor? _value;
        [FieldAttr(nst: 24)] public igVscVec2fAccessor? _minValue;
        [FieldAttr(nst: 32)] public igVscVec2fAccessor? _maxValue;
        [FieldAttr(nst: 40)] public igVscVec2fAccessor? _result;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
