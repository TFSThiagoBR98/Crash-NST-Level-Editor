namespace Alchemy
{
    [ObjectAttr(nst: 176, ctr: 184, align: 8)]
    public class CPlayerStartEntity : CEntity
    {
        [FieldAttr(nst: 144, ctr: 144)] public bool _zoneStart;
        [FieldAttr(nst: 152, ctr: 152)] public CWaypointList? _spawnLocations;
        [FieldAttr(nst: 160, ctr: 160)] public CCameraBase? _camera;
        [FieldAttr(ctr: 168)] public CCameraBase? _verticalSplitCamera;
        [FieldAttr(nst: 168, ctr: 176)] public CWaypointList? _processedSpawnPoints;
    }
}
