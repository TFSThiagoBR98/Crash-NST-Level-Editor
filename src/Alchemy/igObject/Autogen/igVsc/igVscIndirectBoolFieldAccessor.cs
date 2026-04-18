namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVscIndirectBoolFieldAccessor : igVscBoolAccessor
    {
        [FieldAttr(nst: 24, ctr: 16, refCount: false)] public igBoolMetaFieldInstance? _metaField;
        [FieldAttr(nst: 32, ctr: 24)] public igVscObjectAccessor? _object;
    }
}
