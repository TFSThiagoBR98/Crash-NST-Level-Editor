namespace Alchemy
{
    [ObjectAttr(nst: 240, align: 16)]
    public class CButtonPromptMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class TextureBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_diffuse = false;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_diffuse = false;
        }

        [FieldAttr(nst: 120)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 128)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 144)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 208)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 224)] public bool _tonemap = true;
    }
}
