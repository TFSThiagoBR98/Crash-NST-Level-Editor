namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CGhostData : igSingleton
    {
        [FieldAttr(ctr: 16)] public CChallengeGhostDataList? _challengeGhosts;
    }
}
