namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CRotationWorldToLocalNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscObjectAccessor? _target;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _rotation;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _result;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
