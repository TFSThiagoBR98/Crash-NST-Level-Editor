namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 104, align: 8)]
    public class igVscIntCounterHelper : igVscPlaceable
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscObjectAccessor? _counter;
        [FieldAttr(nst: 24, ctr: 24)] public igVscIntAccessor? _start;
        [FieldAttr(nst: 32, ctr: 32)] public igVscIntAccessor? _countBy;
        [FieldAttr(nst: 40, ctr: 40)] public igVscIntAccessor? _compare;
        [FieldAttr(nst: 48, ctr: 48)] public igVscIntAccessor? _current;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igVscActionNode? _greaterThan;
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igVscActionNode? _greaterThanOrEqualTo;
        [FieldAttr(nst: 72, ctr: 72, refCount: false)] public igVscActionNode? _equalTo;
        [FieldAttr(nst: 80, ctr: 80, refCount: false)] public igVscActionNode? _notEqualTo;
        [FieldAttr(nst: 88, ctr: 88, refCount: false)] public igVscActionNode? _lessThanOrEqualTo;
        [FieldAttr(nst: 96, ctr: 96, refCount: false)] public igVscActionNode? _lessThan;
    }
}
