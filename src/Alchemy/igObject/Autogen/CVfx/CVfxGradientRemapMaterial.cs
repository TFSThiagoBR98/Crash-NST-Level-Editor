namespace Alchemy
{
    [ObjectAttr(nst: 288, align: 16)]
    public class CVfxGradientRemapMaterial : CVfxMaterial
    {
        [ObjectAttr(size: 4)]
        public class VfxMaterialBitfield2 : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_gradient = true;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_gradient = false;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_gradient = false;
        }

        [FieldAttr(nst: 272)] public VfxMaterialBitfield2 _vfxMaterialBitfield2 = new();
        [FieldAttr(nst: 280)] public string? _textureName_gradient = "textures";
    }
}
