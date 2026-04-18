namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class igMouseInputEventHandler : igObject
    {
        [FieldAttr(nst: 16)] public igMouseInputEventHandler? _next;
        [FieldAttr(nst: 24)] public int _priority;
        [FieldAttr(nst: 32, refCount: false)] public igMouseInputDevice? _device;
        [FieldAttr(nst: 40)] public igRawRefMetaField _handler = new();
        [FieldAttr(nst: 48, refCount: false)] public igObject? _owner;
    }
}
