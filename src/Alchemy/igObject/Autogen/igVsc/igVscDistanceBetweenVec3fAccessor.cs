namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVscDistanceBetweenVec3fAccessor : igVscFloatAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVscVec3fAccessor? _positionA;
        [FieldAttr(nst: 32, ctr: 24)] public igVscVec3fAccessor? _positionB;
    }
}
