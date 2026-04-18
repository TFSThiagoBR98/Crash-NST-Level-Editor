namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiBehaviorLeaderboardList : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _legendProject = new();
        [FieldAttr(ctr: 24)] public bool _gamercardButtonVisible;
    }
}
