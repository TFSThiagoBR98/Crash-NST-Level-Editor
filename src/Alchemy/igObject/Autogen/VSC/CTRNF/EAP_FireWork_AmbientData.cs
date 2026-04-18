namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class EAP_FireWork_AmbientData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound = new();
    }
}
