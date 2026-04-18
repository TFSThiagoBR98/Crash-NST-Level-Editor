namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CRaceTrackForkCheckerComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _positionPath = new();
        [FieldAttr(ctr: 24)] public CEntityHandleList? _aiPaths;
    }
}
