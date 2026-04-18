namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igVscLerpVec2fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec2fAccessor? _from;
        [FieldAttr(nst: 24)] public igVscVec2fAccessor? _to;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _percent;
        [FieldAttr(nst: 40)] public igVscVec2fAccessor? _result;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
