namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class T502_Back_In_Time_GPI_GeiserData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Vfx_Effect_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(ctr: 48)] public float _Float;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Vfx_Effect_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Sound = new();
    }
}
