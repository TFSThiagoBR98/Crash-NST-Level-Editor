namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CProgressionChallengeRelics : CProgressionChallenge
    {
        [FieldAttr(ctr: 24)] public int _relicCount;
    }
}
