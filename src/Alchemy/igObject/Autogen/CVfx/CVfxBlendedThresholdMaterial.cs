namespace Alchemy
{
    [ObjectAttr(nst: 832, ctr: 832, align: 16)]
    public class CVfxBlendedThresholdMaterial : CVfxBlendedCombinerMaterial
    {
        [FieldAttr(nst: 624, ctr: 624)] public CVfxBlendedMaterial.EBlendFormat _thresholdDiffuseFactor;
        [FieldAttr(nst: 628, ctr: 628)] public float _thresholdDiffuseScale = 1.0f;
        [FieldAttr(nst: 632, ctr: 632)] public CVfxBlendedMaterial.EBlendFormat _thresholdMaskFactor;
        [FieldAttr(nst: 636, ctr: 636)] public float _thresholdMaskScale = 1.0f;
        [FieldAttr(nst: 640, ctr: 640)] public float _thresholdProductScale;
        [FieldAttr(nst: 644, ctr: 644)] public float _thresholdFactor = 1.0f;
        [FieldAttr(nst: 648, ctr: 648)] public float _thresholdOffset;
        [FieldAttr(nst: 652, ctr: 652)] public float _diffuseColorScale2;
        [FieldAttr(nst: 656, ctr: 656)] public CVfxBlendedMaterial.EBlendFormat _diffuseColorMaskAlpha2 = CVfxBlendedMaterial.EBlendFormat.kFormatOne;
        [FieldAttr(nst: 660, ctr: 660)] public float _diffuseAlphaScale2;
        [FieldAttr(nst: 664, ctr: 664)] public float _maskColorScale2;
        [FieldAttr(nst: 668, ctr: 668)] public CVfxBlendedMaterial.EBlendFormat _maskColorMaskAlpha2 = CVfxBlendedMaterial.EBlendFormat.kFormatOne;
        [FieldAttr(nst: 672, ctr: 672)] public float _maskAlphaScale2;
        [FieldAttr(nst: 676, ctr: 676)] public float _productColorScale2 = 1.0f;
        [FieldAttr(nst: 680, ctr: 680)] public float _productAlphaScale2 = 1.0f;
        [FieldAttr(nst: 684, ctr: 684)] public float _finalColorOffset2;
        [FieldAttr(nst: 688, ctr: 688)] public float _finalAlphaOffset2;
        [FieldAttr(nst: 704, ctr: 704)] public igVec4fMetaField _diffuseScale2 = new();
        [FieldAttr(nst: 720, ctr: 720)] public igVec4fMetaField _maskScale2 = new();
        [FieldAttr(nst: 736, ctr: 736)] public igVec4fMetaField _productScale2 = new();
        [FieldAttr(nst: 752, ctr: 752)] public igVec4fMetaField _finalOffset2 = new();
        [FieldAttr(nst: 768, ctr: 768)] public igVec4fMetaField _alphaParams2 = new();
        [FieldAttr(nst: 784, ctr: 784)] public igVec4fMetaField _thresholdParams = new();
        [FieldAttr(nst: 800, ctr: 800)] public igVec4fMetaField _thresholdParams2 = new();
        [FieldAttr(nst: 816, ctr: 816)] public igVec4fMetaField _thresholdParams3 = new();
    }
}
