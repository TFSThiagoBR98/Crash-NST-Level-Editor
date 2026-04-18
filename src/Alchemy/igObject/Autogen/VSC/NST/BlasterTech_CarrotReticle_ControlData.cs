namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 4, metaType: typeof(CVscComponentData))]
    public class BlasterTech_CarrotReticle_ControlData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _CarrotBehaviorStates = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Unnamed_BoltPoint = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _CarrotMissileExplosionDamage = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _CarrotMissileImpactDamage = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _BunnyProjectileEntityData = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _DustBunnyTag = new();
        [FieldAttr(nst: 88)] public float _CarrotMissileImpactRadius;
        [FieldAttr(nst: 92)] public float _CarrotMissileExplosionRadius;
        [FieldAttr(nst: 96)] public igHandleMetaField _BunnyProjectileSpawnData = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _BunnyProjectileTargetsQuery = new();
        [FieldAttr(nst: 112)] public string? _StartControllingCarrotCustomEvent = null;
        [FieldAttr(nst: 120)] public igHandleMetaField _CarrotMissileVfx = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _ReticleVfx = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _CarrotExplosionVfx = new();
    }
}
