namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 72, align: 8)]
    public class igEnumMetaFieldInstance : igMetaFieldInstance
    {
        [FieldAttr(nst: 56, ctr: 48, refCount: false)] public InlinedMemoryRef<igEnumMetaField> _default = new();
        [FieldAttr(nst: 72, ctr: 64)] public igMetaEnum? _metaEnum;
    }
}
