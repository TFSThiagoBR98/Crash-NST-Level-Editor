namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscIntFieldAccessor : igVscIntAccessor
    {
        [FieldAttr(nst: 24, ctr: 16, refCount: false)] public igIntMetaFieldInstance? _metaField;
    }
}
