namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CPositionWorldToLocalAccessor : igVscVec3fAccessor
    {
        [FieldAttr(nst: 24)] public igVscObjectAccessor? _target;
        [FieldAttr(nst: 32)] public igVscObjectAccessor? _boltPoint;
        [FieldAttr(nst: 40)] public igVscVec3fAccessor? _vector;
    }
}
