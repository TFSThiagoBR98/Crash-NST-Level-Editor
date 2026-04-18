namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igVscAccessListHelper : igVscPlaceable
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscObjectAccessor? _list;
        [FieldAttr(nst: 24, ctr: 24)] public igVscIntAccessor? _index;
        [FieldAttr(nst: 32, ctr: 32)] public igVscAccessor? _item;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igMetaObject? _listMetaObject;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igMetaObject? _listBaseMetaObject;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igVscActionNode? _out;
    }
}
