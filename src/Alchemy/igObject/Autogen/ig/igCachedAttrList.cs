namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igCachedAttrList : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<igAttr> _attrs = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<i16> _cachedValues = new();
    }
}
