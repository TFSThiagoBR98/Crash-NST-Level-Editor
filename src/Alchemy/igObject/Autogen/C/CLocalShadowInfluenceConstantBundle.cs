namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CLocalShadowInfluenceConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 24, ctr: 24)] public float _localShadowInfluence;
    }
}
