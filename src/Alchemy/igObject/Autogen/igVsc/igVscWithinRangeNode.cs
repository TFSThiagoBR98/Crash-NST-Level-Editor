namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class igVscWithinRangeNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _input;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _rangeLow;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _rangeHigh;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _yes;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _no;
        [FieldAttr(nst: 56, refCount: false)] public igVscActionNode? _out;
    }
}
