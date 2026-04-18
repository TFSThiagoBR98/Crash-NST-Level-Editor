namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CProgressionChallengeAdventureProgress : CProgressionChallenge
    {
        [FieldAttr(ctr: 24)] public int _progressPercent;
    }
}
