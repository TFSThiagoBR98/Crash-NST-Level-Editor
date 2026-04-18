namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class Seal_BehaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Spline_Event = new();
    }
}
