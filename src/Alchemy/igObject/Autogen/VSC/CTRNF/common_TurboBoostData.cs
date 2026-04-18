namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_TurboBoostData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Sound_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Priority_Dsp_Override_Set = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Vfx_Effect = new();
    }
}
