namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8)]
    public class igVscLerpLoopedNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _from;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _to;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _rangeLow;
        [FieldAttr(nst: 40)] public igVscFloatAccessor? _rangeHigh;
        [FieldAttr(nst: 48)] public igVscFloatAccessor? _percent;
        [FieldAttr(nst: 56)] public igVscFloatAccessor? _result;
        [FieldAttr(nst: 64, refCount: false)] public igVscActionNode? _out;
    }
}
