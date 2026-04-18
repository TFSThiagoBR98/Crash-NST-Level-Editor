namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class igVscModifyListHelper : igVscPlaceable
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscObjectAccessor? _sourceList;
        [FieldAttr(nst: 24, ctr: 24)] public igVscAccessor? _item;
        [FieldAttr(nst: 32, ctr: 32)] public igVscObjectAccessor? _modifiedList;
        [FieldAttr(nst: 40, ctr: 40)] public igVscIntAccessor? _size;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igMetaObject? _listMetaObject;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igMetaObject? _listBaseMetaObject;
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igVscActionNode? _out;
    }
}
