namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CFurBlurConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24)] public bool _furBlurState = true;
    }
}
