namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class common_BonusRoundEndData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _StartEntity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _AnimTarget = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _CollectibleToSpawn = new();
        [FieldAttr(nst: 64)] public float _CollectibleSpawnDelay;
        [FieldAttr(nst: 72)] public string? _IdleAnim = null;
        [FieldAttr(nst: 80)] public string? _TriggeredAnim_0x50 = null;
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 96)] public string? _TriggeredAnim_0x60 = null;
        [FieldAttr(nst: 104)] public string? _TriggeredAnim_0x68 = null;
        [FieldAttr(nst: 112)] public float _Float;
        [FieldAttr(nst: 116)] public EZoneCollectibleType _E_Zone_Collectible_Type;
        [FieldAttr(nst: 120)] public igHandleMetaField _Sound = new();
    }
}
