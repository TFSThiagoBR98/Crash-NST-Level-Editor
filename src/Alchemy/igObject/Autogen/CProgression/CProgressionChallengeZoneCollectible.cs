namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CProgressionChallengeZoneCollectible : CProgressionChallenge
    {
        [FieldAttr(ctr: 24)] public EZoneCollectibleType _collectibleType;
        [FieldAttr(ctr: 28)] public int _collectibleAmount;
    }
}
