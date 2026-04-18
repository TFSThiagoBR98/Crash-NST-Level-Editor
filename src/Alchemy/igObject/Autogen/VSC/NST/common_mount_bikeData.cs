namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_mount_bikeData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_Data = new();
        [FieldAttr(nst: 56)] public bool _Bool;
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point = new();
    }
}
