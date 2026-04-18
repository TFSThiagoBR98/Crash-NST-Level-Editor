namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Collectible_Gem_SpawnedData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _GemCollected = new();
    }
}
