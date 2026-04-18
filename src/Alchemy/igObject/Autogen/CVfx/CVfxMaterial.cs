namespace Alchemy
{
    [ObjectAttr(nst: 272, ctr: 272, align: 16)]
    public class CVfxMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class VfxMaterialBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isSoftParticle;
            [FieldAttr(offset: 1, size: 1)] public bool _softParticlePalettized;
            [FieldAttr(offset: 2, size: 1)] public bool _enableHaze;
            [FieldAttr(offset: 3, size: 1)] public bool _additive;
            [FieldAttr(offset: 4, size: 1)] public bool _premultiplied;
            [FieldAttr(offset: 5, size: 1)] public bool _enableEnvironmentLighting;
            [FieldAttr(offset: 6, size: 1)] public bool _textureCompression_diffuse;
            [FieldAttr(offset: 7, size: 1)] public bool _textureMips_diffuse;
            [FieldAttr(offset: 8, size: 1)] public bool _textureAllowDownsample_diffuse;
            [FieldAttr(offset: 9, size: 1)] public bool _textureCompression_palette;
            [FieldAttr(offset: 10, size: 1)] public bool _textureMips_palette;
            [FieldAttr(offset: 11, size: 1)] public bool _useOriginalTextureName;
        }

        [FieldAttr(nst: 120, ctr: 120)] public u8 _bfStorage__0;
        [FieldAttr(nst: 124, ctr: 124)] public float _sortDepthOffset;
        [FieldAttr(nst: 128, ctr: 128)] public VfxMaterialBitfield _vfxMaterialBitfield = new();
        [FieldAttr(nst: 132, ctr: 132)] public float _particleSoftness = 14.0f;
        [FieldAttr(nst: 136, ctr: 136)] public string? _textureName_diffuse = "textures";
        [FieldAttr(nst: 144, ctr: 144)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 208, ctr: 208)] public string? _textureName_palette = null;
        [FieldAttr(ctr: 216)] public igHandleMetaField _stencilFunctionOverride = new();
        [FieldAttr(nst: 216, ctr: 224)] public float _particleSaturationMultiplier = 1.0f;
        [FieldAttr(nst: 224, ctr: 232)] public string? _textureName = null;
        [FieldAttr(nst: 240, ctr: 240)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 256, ctr: 256)] public float _particleSoftnessInverse;
    }
}
