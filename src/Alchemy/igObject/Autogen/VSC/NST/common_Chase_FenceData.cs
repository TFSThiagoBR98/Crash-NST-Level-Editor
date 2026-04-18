namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Chase_FenceData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _RequiredTag = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _HitSound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Effect_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
    }
}
