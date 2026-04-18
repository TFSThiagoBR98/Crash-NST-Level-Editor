namespace Alchemy
{
    [ObjectAttr(nst: 208, align: 16)]
    public class CSpeedTreeMaterial : igFxMaterial
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
        [FieldAttr(nst: 128)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 136)] public string? _textureName_normal = null;
        [FieldAttr(nst: 144)] public string? _textureName_gloss = null;
        [FieldAttr(nst: 152)] public string? _textureName_metal = null;
        [FieldAttr(nst: 160)] public string? _textureName_backscatter = null;
        [FieldAttr(nst: 176)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 192)] public ECastShadows _castShadows = ECastShadows.eCS_Yes;
        [FieldAttr(nst: 196)] public bool _flipBackfaceNormals = true;
    }
}
