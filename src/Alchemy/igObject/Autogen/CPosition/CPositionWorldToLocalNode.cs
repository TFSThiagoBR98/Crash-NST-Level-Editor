namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CPositionWorldToLocalNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscObjectAccessor? _target;
        [FieldAttr(nst: 24)] public igVscObjectAccessor? _boltPoint;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _vector;
        [FieldAttr(nst: 40)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
