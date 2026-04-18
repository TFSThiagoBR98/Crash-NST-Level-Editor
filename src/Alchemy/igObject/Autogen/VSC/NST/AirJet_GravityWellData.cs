namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class AirJet_GravityWellData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Damage = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _RicochetTag = new();
        [FieldAttr(nst: 56)] public float _AutoDetonationDelay;
        [FieldAttr(nst: 60)] public float _Lifetime;
        [FieldAttr(nst: 64)] public igHandleMetaField _InVortexQuery = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _ExplosionSfx = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _ProjectileLoop = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _VortexArea = new();
    }
}
