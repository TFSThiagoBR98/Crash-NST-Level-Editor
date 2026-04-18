namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CChangeRequest : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _manager = new();
        [FieldAttr(nst: 24, ctr: 24)] public bool _requestEnabled;
        [FieldAttr(nst: 32, ctr: 32)] public CScopedScheduledFunction? _scheduledChange;
    }
}
