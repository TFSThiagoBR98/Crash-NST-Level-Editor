namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class ambient_lizard_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Spline_Event = new();
    }
}
