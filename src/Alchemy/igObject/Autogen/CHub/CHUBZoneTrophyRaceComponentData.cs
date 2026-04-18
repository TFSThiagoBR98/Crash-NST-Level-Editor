namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CHUBZoneTrophyRaceComponentData : CHUBZoneComponentData
    {
        [FieldAttr(ctr: 48)] public bool _isSpecialRace;
        [FieldAttr(ctr: 52)] public int _trophyCountToUnlockRace;
        [FieldAttr(ctr: 56)] public EZoneCollectibleType _challengeRequirementType;
        [FieldAttr(ctr: 60)] public int _challengeRequirementCount;
    }
}
