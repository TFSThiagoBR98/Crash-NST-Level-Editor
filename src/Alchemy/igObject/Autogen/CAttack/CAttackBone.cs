namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CAttackBone : igObject
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _boltPoint = new();
        [FieldAttr(nst: 24)] public igVec3fMetaField _positionOffset = new();
        [FieldAttr(nst: 36)] public igVec3fMetaField _anglesOffset = new();
    }
}
