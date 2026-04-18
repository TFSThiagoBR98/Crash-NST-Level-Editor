namespace Alchemy
{
    [ObjectAttr(ctr: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class GPI_CortexCastle_SpiderData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Vfx_Effect_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Vfx_Effect_0x50 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Rumble_Data_0x60 = new();
        [FieldAttr(ctr: 104)] public igHandleMetaField _Rumble_Data_0x68 = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _Sound_0x70 = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _Sound_0x78 = new();
    }
}
