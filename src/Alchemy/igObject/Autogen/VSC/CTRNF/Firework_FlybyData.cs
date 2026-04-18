namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Firework_FlybyData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Vfx_Effect_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Vfx_Effect_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
    }
}
