namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CProgressionChallenge : igObject
    {
        [FieldAttr(ctr: 16)] public CProgressionRewardList? _rewards;
    }
}
