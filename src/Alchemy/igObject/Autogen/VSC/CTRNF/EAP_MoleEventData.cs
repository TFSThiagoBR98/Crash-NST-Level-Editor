namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class EAP_MoleEventData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Vfx_Effect_id_0f05rtkc001 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Bolt_Point_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Bolt_Point_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Bolt_Point_id_vcszxc3j001 = new();
    }
}
