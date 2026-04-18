namespace Alchemy
{
    [ObjectAttr(nst: 320, ctr: 320, align: 16)]
    public class CSkyboxRenderPassData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igVfxRangedCurveMetaField _skyGradientColorRed = new();
        [FieldAttr(nst: 100, ctr: 96)] public igVfxRangedCurveMetaField _skyGradientColorGreen = new();
        [FieldAttr(nst: 184, ctr: 180)] public igVfxRangedCurveMetaField _skyGradientColorBlue = new();
        [FieldAttr(nst: 268, ctr: 264)] public float _skyIntensity = 1.0f;
        [FieldAttr(nst: 272, ctr: 268)] public float _sunIntensity = 10.0f;
        [FieldAttr(nst: 276, ctr: 272)] public float _sunSize = 0.15f;
        [FieldAttr(nst: 288, ctr: 288)] public igVec4fMetaField _sunshaftColor = new();
        [FieldAttr(nst: 304, ctr: 304)] public float _sunshaftDecay = 0.98f;
        [FieldAttr(nst: 308, ctr: 308)] public float _sunshaftDensity = 1.0f;
        [FieldAttr(nst: 312, ctr: 312)] public float _sunshaftIntensity = 1.0f;
    }
}
