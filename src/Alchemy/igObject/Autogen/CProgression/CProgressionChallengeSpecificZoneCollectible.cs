namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CProgressionChallengeSpecificZoneCollectible : CProgressionChallenge
    {
        [FieldAttr(ctr: 24)] public string? _zoneName;
        [FieldAttr(ctr: 32)] public EZoneCollectibleType _collectibleType;
    }
}
