namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscAnglesToDirectionNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _vector;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 32, refCount: false)] public igVscActionNode? _out;
    }
}
