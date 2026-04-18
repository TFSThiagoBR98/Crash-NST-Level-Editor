namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 8)]
    public class igShaderVariant2 : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<igSizeTypeMetaField> _resources = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<igSizeTypeMetaField> _constants = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVectorMetaField<int> _variantSizes = new();
        [FieldAttr(nst: 88, ctr: 88)] public igVectorMetaField<int> _elementIndices = new();
    }
}
