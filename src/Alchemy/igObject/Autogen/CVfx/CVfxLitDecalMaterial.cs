namespace Alchemy
{
    [ObjectAttr(nst: 368, align: 16)]
    public class CVfxLitDecalMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class TextureBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_diffuse = false;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_diffuse = false;
            [FieldAttr(offset: 3, size: 1)] public bool _textureCompression_normal = false;
            [FieldAttr(offset: 4, size: 1)] public bool _textureMips_normal = false;
            [FieldAttr(offset: 5, size: 1)] public bool _textureCompression_gloss = false;
            [FieldAttr(offset: 6, size: 1)] public bool _textureMips_gloss = false;
            [FieldAttr(offset: 7, size: 1)] public bool _textureAllowDownsample_gloss = false;
            [FieldAttr(offset: 8, size: 1)] public bool _textureCompression_metal = false;
            [FieldAttr(offset: 9, size: 1)] public bool _textureMips_metal = false;
            [FieldAttr(offset: 10, size: 1)] public bool _textureAllowDownsample_metal = false;
            [FieldAttr(offset: 11, size: 1)] public bool _textureCompression_emissive = false;
            [FieldAttr(offset: 12, size: 1)] public bool _textureMips_emissive = false;
            [FieldAttr(offset: 13, size: 1)] public bool _textureAllowDownsample_emissive = false;
        }

        [ObjectAttr(size: 1)]
        public class BfStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureAllowDownsample_normal = true;
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

        [FieldAttr(nst: 120)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 128)] public string? _textureName_diffuse = "textures";
        [FieldAttr(nst: 136)] public string? _textureName_normal = "textures";
        [FieldAttr(nst: 144)] public BfStorage _bfStorage__0 = new();
        [FieldAttr(nst: 152)] public string? _textureName_gloss = "textures";
        [FieldAttr(nst: 160)] public string? _textureName_metal = "textures";
        [FieldAttr(nst: 168)] public string? _textureName_emissive = "textures";
        [FieldAttr(nst: 176)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 240)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 256)] public bool _enableFadeAngle;
        [FieldAttr(nst: 260)] public float _fadeStartAngle = 45.0f;
        [FieldAttr(nst: 264)] public float _fadeEndAngle = 60.0f;
        [FieldAttr(nst: 272)] public igVec4fMetaField _alphaScaleOffset = new();
        [FieldAttr(nst: 288)] public bool _enableEdgeFade;
        [FieldAttr(nst: 304)] public igVec4fMetaField _edgeFadeDistances = new();
        [FieldAttr(nst: 320)] public igVec4fMetaField _edgeFadeOffset = new();
        [FieldAttr(nst: 336)] public igVec4fMetaField _edgeFadeScale = new();
        [FieldAttr(nst: 352)] public BlendChannelsBitfield _blendChannelsBitfield = new();
    }
}
