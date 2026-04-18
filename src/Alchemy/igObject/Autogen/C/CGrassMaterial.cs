namespace Alchemy
{
    [ObjectAttr(nst: 304, align: 16)]
    public class CGrassMaterial : igFxMaterial
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
            [FieldAttr(offset: 12, size: 1)] public bool _textureCompression_backscatter = false;
            [FieldAttr(offset: 13, size: 1)] public bool _textureMips_backscatter = false;
            [FieldAttr(offset: 14, size: 1)] public bool _textureAllowDownsample_backscatter = false;
        }

        [FieldAttr(nst: 120)] public float _normalMapScale = 1.0f;
        [FieldAttr(nst: 124)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 128)] public bool _hasNormalMap = true;
        [FieldAttr(nst: 129)] public bool _hasPackMap = true;
        [FieldAttr(nst: 136)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 144)] public string? _textureName_normal = null;
        [FieldAttr(nst: 152)] public string? _textureName_gloss = null;
        [FieldAttr(nst: 160)] public string? _textureName_metal = null;
        [FieldAttr(nst: 168)] public string? _textureName_backscatter = null;
        [FieldAttr(nst: 176)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 240)] public float _emissive;
        [FieldAttr(nst: 256)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 272)] public bool grass_animation_state = true;
        [FieldAttr(nst: 276)] public float grass_animation_rate = 1.0f;
        [FieldAttr(nst: 280)] public float grass_calm_distance = 5.0f;
        [FieldAttr(nst: 284)] public float grass_windy_distance = 10.0f;
        [FieldAttr(nst: 288)] public bool grass_interactive;
        [FieldAttr(nst: 289)] public bool _billboard;
        [FieldAttr(nst: 290)] public bool _useBillboardOriginForPivot = true;
        [FieldAttr(nst: 291)] public bool _useCameraDirectionForBillboard;
        [FieldAttr(nst: 292)] public ECastShadows _castShadows = ECastShadows.eCS_Yes;
    }
}
