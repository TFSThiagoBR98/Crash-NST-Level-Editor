namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscEnumFieldAccessor : igVscEnumAccessor
    {
        [FieldAttr(nst: 24, ctr: 16, refCount: false)] public igEnumMetaFieldInstance? _metaField;
    }
}
