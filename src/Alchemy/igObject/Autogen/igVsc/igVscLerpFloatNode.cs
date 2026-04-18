namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igVscLerpFloatNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscFloatAccessor? _from;
        [FieldAttr(nst: 24)] public igVscFloatAccessor? _to;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _percent;
        [FieldAttr(nst: 40)] public igVscFloatAccessor? _result;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
