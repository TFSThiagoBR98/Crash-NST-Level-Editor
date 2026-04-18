namespace Alchemy
{
    [ObjectAttr(nst: 624, ctr: 624, align: 16)]
    public class CVfxBlendedCombinerMaterial : CVfxBlendedMaterial
    {
        [FieldAttr(nst: 480, ctr: 484)] public float _diffuseColorScale;
        [FieldAttr(nst: 484, ctr: 488)] public CVfxBlendedMaterial.EBlendFormat _diffuseColorMaskAlpha = CVfxBlendedMaterial.EBlendFormat.kFormatOne;
        [FieldAttr(nst: 488, ctr: 492)] public float _diffuseAlphaScale;
        [FieldAttr(nst: 492, ctr: 496)] public float _maskColorScale;
        [FieldAttr(nst: 496, ctr: 500)] public CVfxBlendedMaterial.EBlendFormat _maskColorMaskAlpha = CVfxBlendedMaterial.EBlendFormat.kFormatOne;
        [FieldAttr(nst: 500, ctr: 504)] public float _maskAlphaScale;
        [FieldAttr(nst: 504, ctr: 508)] public float _productColorScale = 1.0f;
        [FieldAttr(nst: 508, ctr: 512)] public float _productAlphaScale = 1.0f;
        [FieldAttr(nst: 512, ctr: 516)] public float _finalColorOffset;
        [FieldAttr(nst: 516, ctr: 520)] public float _finalAlphaOffset;
        [FieldAttr(nst: 528, ctr: 528)] public igVec4fMetaField _diffuseScale = new();
        [FieldAttr(nst: 544, ctr: 544)] public igVec4fMetaField _maskScale = new();
        [FieldAttr(nst: 560, ctr: 560)] public igVec4fMetaField _productScale = new();
        [FieldAttr(nst: 576, ctr: 576)] public igVec4fMetaField _finalOffset = new();
        [FieldAttr(nst: 592, ctr: 592)] public bool _doAdd;
        [FieldAttr(nst: 593, ctr: 593)] public bool _doMul;
        [FieldAttr(nst: 594, ctr: 594)] public bool _calcAlpha;
        [FieldAttr(nst: 608, ctr: 608)] public igVec4fMetaField _alphaParams = new();
    }
}
