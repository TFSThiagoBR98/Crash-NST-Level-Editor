namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CHUBZoneCupComponentData : CHUBZoneComponentData
    {
        [FieldAttr(ctr: 48)] public EZoneCollectibleType _cupRequirementType;
        [FieldAttr(ctr: 52)] public int _cupRequirementCount;
        [FieldAttr(ctr: 56)] public string? _cupName;
        [FieldAttr(ctr: 64)] public EZoneCollectibleType _cupReward;
        [FieldAttr(ctr: 72)] public igHandleMetaField _cupData = new();
    }
}
