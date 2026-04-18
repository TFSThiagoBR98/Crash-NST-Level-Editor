namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class BlasterTech_DustBunnyMainData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Unnamed_BoltPoint = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _SlowDebuffComponentData = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _DustBunnyEnterDamage = new();
        [FieldAttr(nst: 64)] public float _BunnyLifeTime;
        [FieldAttr(nst: 68)] public float _BunnyMaxLifeTime;
        [FieldAttr(nst: 72)] public igHandleMetaField _DeathVfx = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _LoopVfx = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _SuckedVfx = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _SpawnSoundVfx = new();
    }
}
