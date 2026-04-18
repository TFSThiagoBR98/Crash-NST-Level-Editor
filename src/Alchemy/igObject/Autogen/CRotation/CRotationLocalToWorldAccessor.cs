namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CRotationLocalToWorldAccessor : igVscVec3fAccessor
    {
        [FieldAttr(nst: 24)] public igVscObjectAccessor? _target;
        [FieldAttr(nst: 32)] public igVscVec3fAccessor? _rotation;
    }
}
