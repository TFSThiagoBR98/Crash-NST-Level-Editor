namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class mine_cart_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity_Handle_List = new();
    }
}
