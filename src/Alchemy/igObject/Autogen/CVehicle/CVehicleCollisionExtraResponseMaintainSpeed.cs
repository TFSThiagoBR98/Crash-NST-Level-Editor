namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CVehicleCollisionExtraResponseMaintainSpeed : CVehicleCollisionExtraResponseReorientBase
    {
        [FieldAttr(nst: 64, ctr: 56)] public igVec3fMetaField _projectedVelocityFactor = new();
        [FieldAttr(nst: 76, ctr: 68)] public bool _useCurrentRigidBodySpeed;
    }
}
