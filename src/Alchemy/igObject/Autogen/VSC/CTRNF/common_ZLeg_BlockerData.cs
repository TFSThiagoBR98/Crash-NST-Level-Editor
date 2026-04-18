namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 4, metaType: typeof(CVscComponentData))]
    public class common_ZLeg_BlockerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Level_Chunk_Info_List = new();
    }
}
