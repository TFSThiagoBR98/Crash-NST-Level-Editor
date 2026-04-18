namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class igHandleMetaFieldInstance : igRefMetaFieldInstance
    {
        [FieldAttr(nst: 56, ctr: 48, refCount: false)] public igMemoryRef<igHandleMetaField> _default = new();
        [FieldAttr(nst: 80, ctr: 72, refCount: false)] public igMetaObject? _metaObject;
    }
}
