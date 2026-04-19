namespace Alchemy
{
    [ObjectAttr(nst: 400, ctr: 416, align: 16)]
    public class CBlendedDecalMaterial : igFxMaterial
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
        }

        [ObjectAttr(size: 4)]
        public class BlendChannelsBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _blendDiffuse;
            [FieldAttr(offset: 1, size: 1)] public bool _blendNormal;
            [FieldAttr(offset: 2, size: 1)] public bool _blendGloss;
            [FieldAttr(offset: 3, size: 1)] public bool _blendMetal;
            [FieldAttr(offset: 4, size: 1)] public bool _blendEmissive;
        }

        [FieldAttr(nst: 120, ctr: 120)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 128, ctr: 128)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 136, ctr: 136)] public string? _textureName_normal = null;
        [FieldAttr(nst: 144, ctr: 144)] public string? _textureName_gloss = null;
        [FieldAttr(nst: 152, ctr: 152)] public string? _textureName_metal = null;
        [FieldAttr(nst: 160, ctr: 160)] public string? _textureName_emissive = null;
        [FieldAttr(nst: 168, ctr: 168)] public string? _textureName_height = null;
        [FieldAttr(nst: 176, ctr: 176)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 240, ctr: 240)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 256, ctr: 256)] public float _normalMapScale = 1.0f;
        [FieldAttr(nst: 260, ctr: 260)] public bool _parallaxMapping;
        [FieldAttr(nst: 264, ctr: 264)] public igVec2fMetaField _numSteps = new();
        [FieldAttr(nst: 272, ctr: 272)] public float _parallaxStrength = 0.02f;
        [FieldAttr(nst: 276, ctr: 276)] public bool _useVertAlphaAsHeight = true;
        [FieldAttr(nst: 277, ctr: 277)] public bool _useVertColorAsHeight;
        [FieldAttr(nst: 278, ctr: 278)] public bool _flipVertAlphaHeight;
        [FieldAttr(nst: 288, ctr: 288)] public igVec4fMetaField _parallaxParams = new();
        [FieldAttr(nst: 304, ctr: 304)] public BlendChannelsBitfield _blendChannelsBitfield = new();
        [FieldAttr(nst: 308, ctr: 308)] public bool _alphaThreshold;
        [FieldAttr(nst: 312, ctr: 312)] public float _thresholdBlend = 0.05f;
        [FieldAttr(nst: 316, ctr: 316)] public float _thresholdBias;
        [FieldAttr(nst: 320, ctr: 320)] public bool _useAlpha = true;
        [FieldAttr(nst: 321, ctr: 321)] public bool _invertAlpha;
        [FieldAttr(nst: 322, ctr: 322)] public bool _applyWaterSimulationNormals;
        [FieldAttr(nst: 324, ctr: 324)] public float _thresholdBlendInverse;
        [FieldAttr(nst: 328, ctr: 328)] public bool _directionalBlend;
        [FieldAttr(nst: 329, ctr: 329)] public bool _invertDirectionalBlend;
        [FieldAttr(nst: 332, ctr: 332)] public igVec2fMetaField _directionalBlendRange = new();
        [FieldAttr(nst: 340, ctr: 340)] public igVec2fMetaField _directionalBlendAngles = new();
        [FieldAttr(nst: 352, ctr: 352)] public igVec4fMetaField _directionalBlendParams = new();
        [FieldAttr(nst: 368, ctr: 368)] public igVec4fMetaField _directionalBlendDirection = new();
        [FieldAttr(nst: 384, ctr: 384)] public igVec4fMetaField _alphaParams = new();
        [FieldAttr(ctr: 400)] public uint _customizationOverride;
    }
}
