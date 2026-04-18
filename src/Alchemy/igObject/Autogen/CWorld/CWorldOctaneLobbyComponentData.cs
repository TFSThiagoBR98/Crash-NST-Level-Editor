namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CWorldOctaneLobbyComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CWaypointList? _spawnPositions;
        [FieldAttr(ctr: 24)] public igHandleMetaField _overrideCamera = new();
        [FieldAttr(ctr: 32)] public CCutsceneCameraHandleList? _lobbyCameras;
    }
}
