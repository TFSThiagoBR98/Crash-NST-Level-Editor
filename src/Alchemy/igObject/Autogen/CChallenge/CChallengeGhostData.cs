namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CChallengeGhostData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _levelName;
        [FieldAttr(ctr: 24)] public float _unlockChallengeGhostsTime;
        [FieldAttr(ctr: 32)] public CGhostHeaderDataList? _ghosts;
    }
}
