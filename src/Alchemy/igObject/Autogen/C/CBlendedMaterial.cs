namespace Alchemy
{
    [ObjectAttr(nst: 560, align: 16)]
    public class CBlendedMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class TextureBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_diffuse = false;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_diffuse = false;
            [FieldAttr(offset: 3, size: 1)] public bool _textureCompression_normal = false;
            [FieldAttr(offset: 4, size: 1)] public bool _textureMips_normal = false;
            [FieldAttr(offset: 5, size: 1)] public bool _textureAllowDownsample_normal = false;
            [FieldAttr(offset: 6, size: 1)] public bool _textureCompression_gloss = false;
            [FieldAttr(offset: 7, size: 1)] public bool _textureMips_gloss = false;
            [FieldAttr(offset: 8, size: 1)] public bool _textureAllowDownsample_gloss = false;
            [FieldAttr(offset: 9, size: 1)] public bool _textureCompression_metal = false;
            [FieldAttr(offset: 10, size: 1)] public bool _textureMips_metal = false;
            [FieldAttr(offset: 11, size: 1)] public bool _textureAllowDownsample_metal = false;
            [FieldAttr(offset: 12, size: 1)] public bool _textureCompression_emissive = false;
            [FieldAttr(offset: 13, size: 1)] public bool _textureMips_emissive = false;
            [FieldAttr(offset: 14, size: 1)] public bool _textureAllowDownsample_emissive = false;
            [FieldAttr(offset: 15, size: 1)] public bool _textureCompression_height = false;
            [FieldAttr(offset: 16, size: 1)] public bool _textureMips_height = false;
            [FieldAttr(offset: 17, size: 1)] public bool _textureCompression_diffuse2 = false;
            [FieldAttr(offset: 18, size: 1)] public bool _textureMips_diffuse2 = false;
            [FieldAttr(offset: 19, size: 1)] public bool _textureAllowDownsample_diffuse2 = false;
            [FieldAttr(offset: 20, size: 1)] public bool _textureCompression_normal2 = false;
            [FieldAttr(offset: 21, size: 1)] public bool _textureMips_normal2 = false;
            [FieldAttr(offset: 22, size: 1)] public bool _textureCompression_gloss2 = false;
            [FieldAttr(offset: 23, size: 1)] public bool _textureMips_gloss2 = false;
            [FieldAttr(offset: 24, size: 1)] public bool _textureAllowDownsample_gloss2 = false;
            [FieldAttr(offset: 25, size: 1)] public bool _textureCompression_metal2 = false;
            [FieldAttr(offset: 26, size: 1)] public bool _textureMips_metal2 = false;
            [FieldAttr(offset: 27, size: 1)] public bool _textureAllowDownsample_metal2 = false;
            [FieldAttr(offset: 28, size: 1)] public bool _textureCompression_emissive2 = false;
            [FieldAttr(offset: 29, size: 1)] public bool _textureMips_emissive2 = false;
            [FieldAttr(offset: 30, size: 1)] public bool _textureAllowDownsample_emissive2 = false;
        }

        [ObjectAttr(size: 4)]
        public class BlendChannelsBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _blendDiffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _blendNormal = false;
            [FieldAttr(offset: 2, size: 1)] public bool _blendGloss = false;
            [FieldAttr(offset: 3, size: 1)] public bool _blendMetal = false;
            [FieldAttr(offset: 4, size: 1)] public bool _blendEmissive = false;
        }

        [ObjectAttr(size: 1)]
        public class BfStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureAllowDownsample_normal2 = true;
        }

        [FieldAttr(nst: 120)] public float _normalMapScale = 1.0f;
        [FieldAttr(nst: 124)] public float _normalMapScale2 = 1.0f;
        [FieldAttr(nst: 128)] public bool _parallaxMapping;
        [FieldAttr(nst: 129)] public bool _additive;
        [FieldAttr(nst: 132)] public igVec2fMetaField _numSteps = new();
        [FieldAttr(nst: 140)] public float _parallaxStrength = 0.02f;
        [FieldAttr(nst: 144)] public bool _heightMapUsesSecondUvChannel;
        [FieldAttr(nst: 145)] public bool _useVertAlphaAsHeight = true;
        [FieldAttr(nst: 146)] public bool _useVertColorAsHeight;
        [FieldAttr(nst: 147)] public bool _flipVertAlphaHeight;
        [FieldAttr(nst: 148)] public bool _parallaxDepth;
        [FieldAttr(nst: 149)] public bool _alphaThreshold;
        [FieldAttr(nst: 152)] public float _thresholdBlend = 0.05f;
        [FieldAttr(nst: 156)] public float _thresholdBias;
        [FieldAttr(nst: 160)] public bool _useTopAlpha = true;
        [FieldAttr(nst: 161)] public bool _invertTopAlpha;
        [FieldAttr(nst: 162)] public bool _useBottomAlpha;
        [FieldAttr(nst: 163)] public bool _invertBottomAlpha;
        [FieldAttr(nst: 164)] public float _thresholdBlendInverse;
        [FieldAttr(nst: 168)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 172)] public bool _directionalBlend;
        [FieldAttr(nst: 173)] public bool _invertDirectionalBlend;
        [FieldAttr(nst: 176)] public igVec2fMetaField _directionalBlendRange = new();
        [FieldAttr(nst: 184)] public igVec2fMetaField _directionalBlendAngles = new();
        [FieldAttr(nst: 192)] public igVec4fMetaField _directionalBlendParams = new();
        [FieldAttr(nst: 208)] public igVec4fMetaField _directionalBlendDirection = new();
        [FieldAttr(nst: 224)] public igVec4fMetaField _alphaParams = new();
        [FieldAttr(nst: 240)] public igVec4fMetaField _parallaxParams = new();
        [FieldAttr(nst: 256)] public BlendChannelsBitfield _blendChannelsBitfield = new();
        [FieldAttr(nst: 272)] public igVec4fMetaField _blendStateParams1 = new();
        [FieldAttr(nst: 288)] public igVec4fMetaField _blendStateParams2 = new();
        [FieldAttr(nst: 304)] public igMatrix44fMetaField _textureMatrix = new();
        [FieldAttr(nst: 368)] public igMatrix44fMetaField _textureMatrix2 = new();
        [FieldAttr(nst: 432)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 448)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 456)] public string? _textureName_normal = null;
        [FieldAttr(nst: 464)] public string? _textureName_gloss = null;
        [FieldAttr(nst: 472)] public string? _textureName_metal = null;
        [FieldAttr(nst: 480)] public string? _textureName_emissive = null;
        [FieldAttr(nst: 488)] public string? _textureName_height = null;
        [FieldAttr(nst: 496)] public string? _textureName_diffuse2 = null;
        [FieldAttr(nst: 504)] public string? _textureName_normal2 = null;
        [FieldAttr(nst: 512)] public BfStorage _bfStorage__0 = new();
        [FieldAttr(nst: 520)] public string? _textureName_gloss2 = null;
        [FieldAttr(nst: 528)] public string? _textureName_metal2 = null;
        [FieldAttr(nst: 536)] public string? _textureName_emissive2 = null;
        [FieldAttr(nst: 544)] public ECastShadows _castShadows = ECastShadows.eCS_Yes;
        [FieldAttr(nst: 548)] public int _paletteIndex;
        [FieldAttr(nst: 552)] public int _paletteIndex2;
    }
}
