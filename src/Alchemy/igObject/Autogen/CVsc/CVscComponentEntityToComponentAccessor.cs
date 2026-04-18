namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CVscComponentEntityToComponentAccessor : igVscObjectAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVscObjectAccessor? _accessor;
        [FieldAttr(nst: 32, ctr: 24, refCount: false)] public igMetaObject? _componentMeta;
    }
}
