namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 8)]
    public class CVfxDistortionMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class VfxDistortionMaterialBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_normal = true;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_normal = false;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_normal = false;
            [FieldAttr(offset: 3, size: 1)] public bool _textureCompression_mask = false;
            [FieldAttr(offset: 4, size: 1)] public bool _textureMips_mask = false;
            [FieldAttr(offset: 5, size: 1)] public bool _textureAllowDownsample_mask = false;
        }

        [FieldAttr(nst: 120)] public string? _textureName_normal = "textures";
        [FieldAttr(nst: 128)] public string? _textureName_mask = "textures";
        [FieldAttr(nst: 136)] public string? _normalTexture = null;
        [FieldAttr(nst: 144)] public string? _maskTexture = null;
        [FieldAttr(nst: 152)] public VfxDistortionMaterialBitfield _vfxDistortionMaterialBitfield = new();
    }
}
