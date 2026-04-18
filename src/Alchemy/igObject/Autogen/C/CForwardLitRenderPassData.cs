namespace Alchemy
{
    [ObjectAttr(nst: 384, ctr: 384, align: 16)]
    public class CForwardLitRenderPassData : igForwardLitRenderPassData
    {
        [FieldAttr(nst: 128, ctr: 124)] public float _localShadowInfluence;
        [FieldAttr(nst: 132, ctr: 128)] public igVfxRangedCurveMetaField _diffuseEnvColorRed = new();
        [FieldAttr(nst: 216, ctr: 212)] public igVfxRangedCurveMetaField _diffuseEnvColorGreen = new();
        [FieldAttr(nst: 300, ctr: 296)] public igVfxRangedCurveMetaField _diffuseEnvColorBlue = new();
    }
}
