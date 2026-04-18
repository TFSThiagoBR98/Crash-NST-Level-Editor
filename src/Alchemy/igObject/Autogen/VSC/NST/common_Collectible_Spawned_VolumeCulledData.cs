namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Collectible_Spawned_VolumeCulledData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _PlayerDied = new();
    }
}
