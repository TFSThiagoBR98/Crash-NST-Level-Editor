namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CPhysicsForceUpdater : igUpdateable
    {
        [FieldAttr(nst: 32)] public igHandleMetaField _updater = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _entity = new();
        [FieldAttr(nst: 48)] public igVec3fMetaField _force = new();
    }
}
