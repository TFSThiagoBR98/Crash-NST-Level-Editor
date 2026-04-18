namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class common_TrafficConeData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Sound = new();
    }
}
