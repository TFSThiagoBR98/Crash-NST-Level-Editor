namespace Alchemy
{
    [ObjectAttr(nst: 480, ctr: 496, align: 16)]
    public class CVfxBlendedMaterial : igFxMaterial
    {
        public enum EBlendFunction
        {
            kBlendAdd = 0,
            kBlendMultiply = 1,
            kBlendAddMultiply = 2,
            kBlendMultiplyAdd = 3,
            kBlendThreshold = 4,
            kBlendValue = 5,
        }

        public enum EBlendMode
        {
            kDiffuseColor = 0,
            kMaskColor = 1,
            kVertHue = 2,
            kVertColor = 3,
            kDiffuseAlpha = 4,
            kMaskAlpha = 5,
            kVertValue = 6,
            kVertAlpha = 7,
            kZero = 8,
            kOne = 9,
        }

        public enum EBlendFormat
        {
            kFormatNormal = 0,
            kFormatInvert = 1,
            kFormatSigned = 2,
            kFormatInvertDouble = 3,
            kFormatInvertSigned = 4,
            kFormatDouble = 5,
            kFormatBottomHalf = 6,
            kFormatInvertTopHalf = 7,
            kFormatTopHalf = 8,
            kFormatInvertBottomHalf = 9,
            kFormatNegative = 10,
            kFormatNegativeHalf = 11,
            kFormatNegativeDouble = 12,
            kFormatOne = 13,
            kFormatZero = 14,
        }

        [ObjectAttr(size: 4)]
        public class VfxBlendedMaterialBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isSoftParticle;
            [FieldAttr(offset: 1, size: 1)] public bool _enableHaze = false;
            [FieldAttr(offset: 2, size: 1)] public bool _additive;
            [FieldAttr(offset: 3, size: 1)] public bool _premultiplied;
            [FieldAttr(offset: 4, size: 1)] public bool _textureCompression_diffuse = false;
            [FieldAttr(offset: 5, size: 1)] public bool _textureMips_diffuse = false;
            [FieldAttr(offset: 6, size: 1)] public bool _textureAllowDownsample_diffuse = false;
            [FieldAttr(offset: 7, size: 1)] public bool _textureCompression_mask = false;
            [FieldAttr(offset: 8, size: 1)] public bool _textureMips_mask = false;
            [FieldAttr(offset: 9, size: 1)] public bool _textureAllowDownsample_mask = false;
        }

        [FieldAttr(nst: 120, ctr: 120)] public u8 _bfStorage__0;
        [FieldAttr(nst: 124, ctr: 124)] public VfxBlendedMaterialBitfield _vfxBlendedMaterialBitfield = new();
        [FieldAttr(nst: 128, ctr: 128)] public float _sortDepthOffset;
        [FieldAttr(nst: 132, ctr: 132)] public float _particleSoftness = 14.0f;
        [FieldAttr(nst: 144, ctr: 144)] public igMatrix44fMetaField _textureMatrix = new();
        [FieldAttr(nst: 208, ctr: 208)] public string? _textureName_diffuse = "textures";
        [FieldAttr(nst: 224, ctr: 224)] public igMatrix44fMetaField _textureMatrix2 = new();
        [FieldAttr(nst: 288, ctr: 288)] public string? _textureName_mask = "textures";
        [FieldAttr(nst: 296, ctr: 296)] public EBlendFunction _blendFunction;
        [FieldAttr(nst: 300, ctr: 300)] public EBlendMode _diffuseColorBlendFactor = CVfxBlendedMaterial.EBlendMode.kOne;
        [FieldAttr(nst: 304, ctr: 304)] public EBlendFormat _diffuseColorBlendFormat;
        [FieldAttr(nst: 308, ctr: 308)] public EBlendMode _maskColorBlendFactor = CVfxBlendedMaterial.EBlendMode.kZero;
        [FieldAttr(nst: 312, ctr: 312)] public EBlendFormat _maskColorBlendFormat;
        [FieldAttr(nst: 316, ctr: 316)] public EBlendMode _diffuseAlphaBlendFactor = CVfxBlendedMaterial.EBlendMode.kDiffuseAlpha;
        [FieldAttr(nst: 320, ctr: 320)] public EBlendFormat _diffuseAlphaBlendFormat;
        [FieldAttr(nst: 324, ctr: 324)] public EBlendMode _maskAlphaBlendFactor = CVfxBlendedMaterial.EBlendMode.kZero;
        [FieldAttr(nst: 328, ctr: 328)] public EBlendFormat _maskAlphaBlendFormat;
        [FieldAttr(nst: 332, ctr: 332)] public bool _preColor = true;
        [FieldAttr(nst: 333, ctr: 333)] public bool _preHue;
        [FieldAttr(nst: 334, ctr: 334)] public bool _generateMaskAlpha;
        [FieldAttr(nst: 336, ctr: 336)] public float _thresholdBlend = 0.05f;
        [FieldAttr(nst: 340, ctr: 340)] public float _thresholdBias;
        [FieldAttr(nst: 344, ctr: 344)] public EBlendMode _thresholdDiffuseAlphaBlendFactor = CVfxBlendedMaterial.EBlendMode.kDiffuseAlpha;
        [FieldAttr(nst: 348, ctr: 348)] public EBlendFormat _thresholdDiffuseAlphaBlendFormat;
        [FieldAttr(nst: 352, ctr: 352)] public EBlendMode _thresholdMaskAlphaBlendFactor = CVfxBlendedMaterial.EBlendMode.kZero;
        [FieldAttr(nst: 356, ctr: 356)] public EBlendFormat _thresholdMaskAlphaBlendFormat;
        [FieldAttr(ctr: 360)] public igHandleMetaField _stencilFunctionOverride = new();
        [FieldAttr(nst: 360, ctr: 368)] public float _thresholdBlendInverse;
        [FieldAttr(nst: 364, ctr: 372)] public float _particleSoftnessInverse;
        [FieldAttr(nst: 368, ctr: 384)] public igVec4fMetaField _diffuseColorBlendParams = new();
        [FieldAttr(nst: 384, ctr: 400)] public igVec4fMetaField _diffuseAlphaBlendParams = new();
        [FieldAttr(nst: 400, ctr: 416)] public igVec4fMetaField _maskColorBlendParams = new();
        [FieldAttr(nst: 416, ctr: 432)] public igVec4fMetaField _maskAlphaBlendParams = new();
        [FieldAttr(nst: 432, ctr: 448)] public igVec4fMetaField _thresholdDiffuseAlphaBlendParams = new();
        [FieldAttr(nst: 448, ctr: 464)] public igVec4fMetaField _thresholdMaskAlphaBlendParams = new();
        [FieldAttr(nst: 464, ctr: 480)] public bool _blendMode0;
        [FieldAttr(nst: 465, ctr: 481)] public bool _blendMode1;
        [FieldAttr(nst: 466, ctr: 482)] public bool _multiplyColor;
        [FieldAttr(nst: 467, ctr: 483)] public bool _multiplyAlpha;
    }
}
