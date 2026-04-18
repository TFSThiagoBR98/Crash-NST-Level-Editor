namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Hub_OxideFaceTurnerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Component_Data = new();
    }
}
