namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CChangeRequestManager : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _requestCounter;
        [FieldAttr(nst: 24, ctr: 16)] public COnChangeDelegate? _onChange;
        [FieldAttr(nst: 32, ctr: 24)] public COnChangeEventList? _onChangeEventList;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _owner = new();
        [FieldAttr(nst: 48, ctr: 40)] public uint _nonScopedRequests;
    }
}
