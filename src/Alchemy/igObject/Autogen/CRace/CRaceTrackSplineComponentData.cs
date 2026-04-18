namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CRaceTrackSplineComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _start = new();
        [FieldAttr(ctr: 24)] public igHandleMetaField _end = new();
        [FieldAttr(ctr: 32)] public EPathDifficulty _pathDifficulty;
        [FieldAttr(ctr: 40)] public CPlayerStartEntityHandleList? _respawnPoints;
        [FieldAttr(ctr: 48)] public bool _isShortcut;
        [FieldAttr(ctr: 49)] public bool _isHazardous;
    }
}
