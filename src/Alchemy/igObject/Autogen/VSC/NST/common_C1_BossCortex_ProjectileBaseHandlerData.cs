namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class common_C1_BossCortex_ProjectileBaseHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _ReturnProjectileData = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
    }
}
