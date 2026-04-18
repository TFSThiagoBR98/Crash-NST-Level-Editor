namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CRaceStartComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CWaypointHandleList? _startLinePositions;
        [FieldAttr(ctr: 24)] public CFlagsWaypointHandleListTable? _teamStartPositions;
    }
}
