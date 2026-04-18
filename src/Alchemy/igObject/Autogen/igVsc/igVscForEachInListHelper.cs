namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igVscForEachInListHelper : igVscPlaceable
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscObjectAccessor? _list;
        [FieldAttr(nst: 24, ctr: 24)] public igVscAccessor? _current;
        [FieldAttr(nst: 32, ctr: 32)] public igVscIntAccessor? _internalCounter;
        [FieldAttr(nst: 40, ctr: 40)] public igVscIntAccessor? _index;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igMetaObject? _listMetaObject;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igMetaObject? _listBaseMetaObject;
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igVscActionNode? _iteration;
        [FieldAttr(nst: 72, ctr: 72, refCount: false)] public igVscActionNode? _done;
    }
}
