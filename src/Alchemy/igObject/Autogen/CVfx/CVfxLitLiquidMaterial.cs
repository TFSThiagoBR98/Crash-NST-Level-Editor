namespace Alchemy
{
    [ObjectAttr(nst: 304, ctr: 304, align: 16)]
    public class CVfxLitLiquidMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class VfxMaterialBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isSoftParticle;
            [FieldAttr(offset: 1, size: 1)] public bool _enableHaze = false;
            [FieldAttr(offset: 2, size: 1)] public bool _additive;
            [FieldAttr(offset: 3, size: 1)] public bool _textureCompression_diffuse = false;
            [FieldAttr(offset: 4, size: 1)] public bool _textureMips_diffuse = false;
            [FieldAttr(offset: 5, size: 1)] public bool _textureAllowDownsample_diffuse = false;
            [FieldAttr(offset: 6, size: 1)] public bool _textureCompression_mask = false;
            [FieldAttr(offset: 7, size: 1)] public bool _textureMips_mask = false;
            [FieldAttr(offset: 8, size: 1)] public bool _textureAllowDownsample_mask = false;
            [FieldAttr(offset: 9, size: 1)] public bool _textureCompression_normal = false;
            [FieldAttr(offset: 10, size: 1)] public bool _textureMips_normal = false;
            [FieldAttr(offset: 11, size: 1)] public bool _textureAllowDownsample_normal = false;
        }

        [FieldAttr(nst: 120, ctr: 120)] public u8 _bfStorage__0;
        [FieldAttr(nst: 124, ctr: 124)] public float _sortDepthOffset;
        [FieldAttr(nst: 128, ctr: 128)] public VfxMaterialBitfield _vfxMaterialBitfield = new();
        [FieldAttr(nst: 132, ctr: 132)] public float _particleSoftness = 14.0f;
        [FieldAttr(nst: 136, ctr: 136)] public bool _enableThreshold = true;
        [FieldAttr(nst: 137, ctr: 137)] public bool _enableAlphaThreshold;
        [FieldAttr(nst: 144, ctr: 144)] public string? _textureName_diffuse = "textures";
        [FieldAttr(nst: 152, ctr: 152)] public string? _textureName_mask = "textures";
        [FieldAttr(nst: 160, ctr: 160)] public string? _textureName_normal = "textures";
        [FieldAttr(nst: 176, ctr: 176)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 240, ctr: 240)] public float _particleSoftnessInverse;
        [FieldAttr(nst: 244, ctr: 244)] public float _normalBendScale;
        [FieldAttr(nst: 248, ctr: 248)] public float _gloss = 0.8f;
        [FieldAttr(nst: 252, ctr: 252)] public float _lightWrap = 0.75f;
        [FieldAttr(nst: 256, ctr: 256)] public float _specularAlphaBoost;
        [FieldAttr(nst: 260, ctr: 260)] public float _thresholdSize = 0.5f;
        [FieldAttr(ctr: 264)] public igHandleMetaField _stencilFunctionOverride = new();
        [FieldAttr(nst: 272, ctr: 272)] public igVec4fMetaField _specParameters = new();
        [FieldAttr(nst: 288, ctr: 288)] public igVec4fMetaField _lightWrapParameters = new();
    }
}
