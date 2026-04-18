namespace Alchemy
{
    [ObjectAttr(nst: 4128, align: 16)]
    public class CPixelShaderVariantCostConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32)] public igVec4fMetaField[] _variantCost = new igVec4fMetaField[256];
    }
}
