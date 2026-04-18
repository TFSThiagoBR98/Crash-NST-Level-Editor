namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igVscHorizontalDistanceVec3fNode : igVscActionNode
    {
        [FieldAttr(nst: 16)] public igVscVec3fAccessor? _position;
        [FieldAttr(nst: 24)] public igVscVec3fAccessor? _relativeTo;
        [FieldAttr(nst: 32)] public igVscFloatAccessor? _horizontalDistance;
        [FieldAttr(nst: 40, refCount: false)] public igVscActionNode? _out;
    }
}
