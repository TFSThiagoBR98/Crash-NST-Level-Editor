namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CDebugUpdateChannel : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public bool _enabled;
        [FieldAttr(nst: 32, ctr: 32)] public CDebugUpdateDelegate? _onDebugUpdate;
        [FieldAttr(nst: 40, ctr: 40)] public CDebugUpdateEventList? _onDebugUpdateList;
    }
}
