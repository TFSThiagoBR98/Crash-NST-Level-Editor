namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscDirectionToAnglesNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _vector;
        [FieldAttr(nst: 24)] public igVscBoolAccessor? _normalize;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
