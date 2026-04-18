namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igVscGateHelper : igVscPlaceable
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscObjectAccessor? _gate;
        [FieldAttr(nst: 24, ctr: 24)] public igVscBoolAccessor? _startOpen;
        [FieldAttr(nst: 32, ctr: 32)] public igVscIntAccessor? _autoCloseCount;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igVscActionNode? _isOpen;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igVscActionNode? _isClosed;
    }
}
