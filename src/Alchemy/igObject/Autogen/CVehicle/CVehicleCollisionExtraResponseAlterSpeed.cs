namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class CVehicleCollisionExtraResponseAlterSpeed : CVehicleCollisionExtraResponseReorientBase
    {
        [FieldAttr(nst: 64, ctr: 56)] public igVec3fMetaField _alterSpeedFactor = new();
    }
}
