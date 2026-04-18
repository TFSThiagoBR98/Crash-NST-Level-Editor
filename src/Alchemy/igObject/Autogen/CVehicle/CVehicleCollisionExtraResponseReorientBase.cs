namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class CVehicleCollisionExtraResponseReorientBase : CVehicleCollisionExtraResponseBase
    {
        [FieldAttr(nst: 32, ctr: 28)] public float _reorientFactor = 1.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _reorientSteeringMagnitude;
        [FieldAttr(nst: 40, ctr: 36)] public float _reorientSteeringDecayDelay = 0.1f;
        [FieldAttr(nst: 44, ctr: 40)] public float _reorientSteeringDecayDuration = 0.1f;
        [FieldAttr(nst: 48, ctr: 44)] public igVec3fMetaField _reorientAngularFactor = new();
    }
}
