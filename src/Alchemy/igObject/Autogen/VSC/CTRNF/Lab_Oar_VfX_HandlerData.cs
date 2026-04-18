namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Lab_Oar_VfX_HandlerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound = new();
    }
}
