namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class AirJet_ProjectileData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _RicochetBonusLife;
        [FieldAttr(nst: 44)] public int _MaxBounces;
        [FieldAttr(nst: 48)] public igHandleMetaField _RicochetFilter = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _LeftMuzzleVfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _RightMuzzleVfx = new();
    }
}
