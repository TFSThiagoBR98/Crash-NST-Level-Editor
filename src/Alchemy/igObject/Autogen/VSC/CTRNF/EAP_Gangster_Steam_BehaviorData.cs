namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class EAP_Gangster_Steam_BehaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity = new();
    }
}
