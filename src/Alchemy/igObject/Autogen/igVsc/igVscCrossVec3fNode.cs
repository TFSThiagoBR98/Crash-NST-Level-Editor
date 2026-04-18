namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscCrossVec3fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _vectorA;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _vectorB;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
