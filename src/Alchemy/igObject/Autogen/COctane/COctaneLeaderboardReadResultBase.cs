namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class COctaneLeaderboardReadResultBase : igObject
    {
        [FieldAttr(ctr: 12)] public EigResult _status;
        [FieldAttr(ctr: 16)] public bool _reachedEnd;
    }
}
