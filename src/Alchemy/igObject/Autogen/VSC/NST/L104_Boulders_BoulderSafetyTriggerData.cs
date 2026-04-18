namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class L104_Boulders_BoulderSafetyTriggerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Spline_Event = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound = new();
    }
}
