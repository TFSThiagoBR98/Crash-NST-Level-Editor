namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class ambient_rat_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Spline_Event_0x20 = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Spline_Event_0x28 = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Spline_Event_0x30 = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Spline_Event_0x38 = new();
    }
}
