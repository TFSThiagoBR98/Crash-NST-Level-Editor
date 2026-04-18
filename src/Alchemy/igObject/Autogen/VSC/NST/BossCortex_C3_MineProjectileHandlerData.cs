namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class BossCortex_C3_MineProjectileHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
    }
}
