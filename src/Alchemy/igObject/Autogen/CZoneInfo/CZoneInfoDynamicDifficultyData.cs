namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CZoneInfoDynamicDifficultyData : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _zoneInfo = new();
        [FieldAttr(ctr: 24)] public int _zoneTargetCombatDuration;
    }
}
