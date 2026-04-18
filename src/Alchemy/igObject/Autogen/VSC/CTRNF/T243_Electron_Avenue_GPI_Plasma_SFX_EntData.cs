namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class T243_Electron_Avenue_GPI_Plasma_SFX_EntData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Component_Data = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Sound_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
    }
}
