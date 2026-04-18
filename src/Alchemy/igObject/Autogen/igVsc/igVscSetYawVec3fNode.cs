namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igVscSetYawVec3fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _position;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _relativeTo;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _yaw;
        [FieldAttr(nst: 40)] public igVscVec3fAccessor? _adjustedPosition;
        [FieldAttr(nst: 48, refCount: false)] public igVscActionNode? _out;
    }
}
