namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class T154_Electric_ArcData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _T154_Electric_ArcDatas = new();
    }
}
