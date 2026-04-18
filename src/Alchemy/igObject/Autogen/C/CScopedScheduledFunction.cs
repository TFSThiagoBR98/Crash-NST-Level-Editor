namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CScopedScheduledFunction : igObject
    {
        [FieldAttr(nst: 16)] public igRawRefMetaField _scheduledCallback = new();
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _callbackOwner = new();
        [FieldAttr(nst: 32, ctr: 32)] public igObject? _userData;
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _handle = new();
    }
}
