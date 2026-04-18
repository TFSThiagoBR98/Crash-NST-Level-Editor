namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Fireball_Handler_GraphData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float_0x20;
        [FieldAttr(ctr: 36)] public float _Float_0x24;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Spline_Event = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Vfx_Effect_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Vfx_Effect_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Sound_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Sound_0x50 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _Entity = new();
    }
}
