namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class T501_July_World_Tour_Snake_BehaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Sound = new();
    }
}
