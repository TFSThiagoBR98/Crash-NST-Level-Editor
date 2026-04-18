namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CVariantIdentifierFilter : igObject
    {
        public enum EVariantIdentifierFilterType
        {
            eVIFT_VariantRequiredAsActive = 0,
            eVIFT_VariantRequiredAsInactive = 1,
        }

        [FieldAttr(nst: 16, ctr: 12)] public EVariantIdentifierFilterType _variantIdentifierFilterType;
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _variantIdentifier = new();
        [FieldAttr(nst: 32, ctr: 24)] public bool _onlyCompareDecoId;
    }
}
