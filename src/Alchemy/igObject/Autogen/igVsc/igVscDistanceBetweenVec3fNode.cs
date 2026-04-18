namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igVscDistanceBetweenVec3fNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscVec3fAccessor? _positionA;
        [FieldAttr(nst: 24, ctr: 24)] public igVscVec3fAccessor? _positionB;
        [FieldAttr(nst: 32, ctr: 32)] public igVscFloatAccessor? _distance;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _out;
    }
}
