namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BlasterTech_MainProjectile_SpawnDustBunniesData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Unnamed_BoltPoint = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _DustBunnyEntityData = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _LoopingVfx = new();
    }
}
