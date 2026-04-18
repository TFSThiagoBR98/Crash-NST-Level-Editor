namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_teleport_entityData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public bool _Bool_0x20;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(ctr: 56)] public bool _Bool_0x38;
        [FieldAttr(ctr: 64)] public igHandleMetaField _Vfx_Effect = new();
    }
}
