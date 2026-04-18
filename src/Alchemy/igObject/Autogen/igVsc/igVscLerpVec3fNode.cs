namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igVscLerpVec3fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _from;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _to;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _percent;
        [FieldAttr(nst: 40)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
