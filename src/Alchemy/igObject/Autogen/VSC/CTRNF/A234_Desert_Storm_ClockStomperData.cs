namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class A234_Desert_Storm_ClockStomperData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Entity_0x38 = new();
    }
}
