namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igVscDirectionVec3fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _fromPosition;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _toPosition;
        [FieldAttr(nst: 32)] public igVscBoolAccessor? _normalize;
        [FieldAttr(nst: 40)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
