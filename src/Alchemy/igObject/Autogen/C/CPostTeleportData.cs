namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CPostTeleportData : igObject
    {
        [FieldAttr(nst: 16)] public CWaypointHandleList? _destination;
        [FieldAttr(nst: 24)] public CWaypoint? _destinationFallbackRef;
        [FieldAttr(nst: 32)] public bool _stopMomentum;
        [FieldAttr(nst: 33)] public bool _useTeam;
        [FieldAttr(nst: 40)] public igVscDelegateMetaField _onFinished = new();
        [FieldAttr(nst: 56)] public COnTeleportFinishedEventList? _onFinishedList;
    }
}
