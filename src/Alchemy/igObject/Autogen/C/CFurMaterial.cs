namespace Alchemy
{
    [ObjectAttr(nst: 400, align: 16)]
    public class CFurMaterial : igFxMaterial
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
            [FieldAttr(offset: 15, size: 1)] public bool _textureCompression_backscatter = false;
            [FieldAttr(offset: 16, size: 1)] public bool _textureMips_backscatter = false;
            [FieldAttr(offset: 17, size: 1)] public bool _textureAllowDownsample_backscatter = false;
            [FieldAttr(offset: 18, size: 1)] public bool _textureCompression_height = false;
            [FieldAttr(offset: 19, size: 1)] public bool _textureMips_height = false;
            [FieldAttr(offset: 20, size: 1)] public bool _textureCompression_fiber;
            [FieldAttr(offset: 21, size: 1)] public bool _textureMips_fiber = false;
        }

        [FieldAttr(nst: 120)] public float _normalMapScale = 1.0f;
        [FieldAttr(nst: 124)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 128)] public bool _hasEmissiveMap = true;
        [FieldAttr(nst: 129)] public bool _hasNormalMap = true;
        [FieldAttr(nst: 136)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 144)] public string? _textureName_normal = null;
        [FieldAttr(nst: 152)] public string? _textureName_gloss = null;
        [FieldAttr(nst: 160)] public string? _textureName_metal = null;
        [FieldAttr(nst: 168)] public string? _textureName_emissive = null;
        [FieldAttr(nst: 176)] public string? _textureName_backscatter = null;
        [FieldAttr(nst: 184)] public string? _textureName_height = null;
        [FieldAttr(nst: 192)] public string? _textureName_fiber = null;
        [FieldAttr(nst: 208)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 272)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 288)] public bool _renderObscured;
        [FieldAttr(nst: 289)] public bool _onlyRenderObscured;
        [FieldAttr(nst: 292)] public ECastShadows _castShadows = ECastShadows.eCS_Yes;
        [FieldAttr(nst: 296)] public float _shellMinThickness;
        [FieldAttr(nst: 300)] public float _shellThickness = 4.0f;
        [FieldAttr(nst: 304)] public int _shellCount = 4;
        [FieldAttr(nst: 308)] public float _fiberDensity = 1.0f;
        [FieldAttr(nst: 312)] public float _fiberAspectRatio = 1.0f;
        [FieldAttr(nst: 320)] public igVec4fMetaField _fiberDistribution = new();
        [FieldAttr(nst: 336)] public float _fiberRadius = 1.0f;
        [FieldAttr(nst: 340)] public float _furSoftness;
        [FieldAttr(nst: 344)] public float _fiberFlex = 25.0f;
        [FieldAttr(nst: 348)] public float _fiberProfile;
        [FieldAttr(nst: 352)] public float _maxFiberDarkening = 0.25f;
        [FieldAttr(nst: 356)] public float _furHighlightBaseWidth = 0.6f;
        [FieldAttr(nst: 360)] public float _furHighlightMapWidth = 0.4f;
        [FieldAttr(nst: 364)] public float _furHighlightBaseIntensity = 0.6f;
        [FieldAttr(nst: 368)] public float _furHighlightMapIntensity = 0.4f;
        [FieldAttr(nst: 372)] public float _shellLODDistance = 500.0f;
        [FieldAttr(nst: 384)] public igVec4fMetaField _furShape = new();
    }
}
