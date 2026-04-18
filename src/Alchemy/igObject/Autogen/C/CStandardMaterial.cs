namespace Alchemy
{
    [ObjectAttr(nst: 352, align: 16)]
    public class CStandardMaterial : igFxMaterial
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
        }

        [FieldAttr(nst: 120)] public float _normalMapScale = 1.0f;
        [FieldAttr(nst: 124)] public bool _parallaxMapping;
        [FieldAttr(nst: 125)] public bool _additive;
        [FieldAttr(nst: 128)] public igVec2fMetaField _numSteps = new();
        [FieldAttr(nst: 136)] public float _parallaxStrength = 0.02f;
        [FieldAttr(nst: 140)] public bool _useVertAlphaAsHeight = true;
        [FieldAttr(nst: 141)] public bool _useVertColorAsHeight;
        [FieldAttr(nst: 142)] public bool _flipVertAlphaHeight;
        [FieldAttr(nst: 143)] public bool _parallaxDepth;
        [FieldAttr(nst: 144)] public igVec4fMetaField _parallaxParams = new();
        [FieldAttr(nst: 160)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 164)] public bool _hasEmissiveMap = true;
        [FieldAttr(nst: 165)] public bool _hasNormalMap = true;
        [FieldAttr(nst: 166)] public bool _mobileUseNormalMap = true;
        [FieldAttr(nst: 168)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 176)] public string? _textureName_normal = null;
        [FieldAttr(nst: 184)] public string? _textureName_gloss = null;
        [FieldAttr(nst: 192)] public string? _textureName_metal = null;
        [FieldAttr(nst: 200)] public string? _textureName_emissive = null;
        [FieldAttr(nst: 208)] public string? _textureName_backscatter = null;
        [FieldAttr(nst: 216)] public string? _textureName_height = null;
        [FieldAttr(nst: 224)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 288)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 304)] public bool _renderObscured;
        [FieldAttr(nst: 305)] public bool _onlyRenderObscured;
        [FieldAttr(nst: 306)] public bool _anisotropicShading;
        [FieldAttr(nst: 307)] public bool _iridescentShading;
        [FieldAttr(nst: 308)] public bool _iridescentEnabled;
        [FieldAttr(nst: 312)] public CIridescentMaterialFeature? _iridescentProperties;
        [FieldAttr(nst: 320)] public ECastShadows _castShadows = ECastShadows.eCS_Yes;
        [FieldAttr(nst: 328)] public CVertexWibbleMaterialFeature? _vertexWibble;
        [FieldAttr(nst: 336)] public bool _vertexWibbleEnabled;
        [FieldAttr(nst: 340)] public int _paletteIndex;
        [FieldAttr(nst: 344)] public bool _excludeFromDecimation;
        [FieldAttr(nst: 345)] public bool _enableReflections;
    }
}
