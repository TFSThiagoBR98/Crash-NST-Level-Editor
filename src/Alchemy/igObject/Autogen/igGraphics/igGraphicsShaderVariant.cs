namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igGraphicsShaderVariant : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igStringRefList? _shaderConstants;
        [FieldAttr(nst: 32, ctr: 32)] public igIntList? _elementIndices;
        [FieldAttr(nst: 40, ctr: 40)] public igIntList? _variantSizes;
        [FieldAttr(nst: 48, ctr: 48)] public igGraphicsShaderList? _shaders;
        [FieldAttr(nst: 56, ctr: 56)] public igShaderVariant2? _variant;
    }
}
