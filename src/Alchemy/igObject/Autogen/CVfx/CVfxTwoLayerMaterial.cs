namespace Alchemy
{
    [ObjectAttr(nst: 400, ctr: 400, align: 16)]
    public class CVfxTwoLayerMaterial : igFxMaterial
    {
        public enum ELayerColorAlphaModes
        {
            kLayerUseAlphaMask = 0,
            kLayerNoAlphaMask = 1,
        }

        public enum ELayerBlendModes
        {
            kBlendModeNormal = 0,
            kBlendModeScreenLayer1Layer2 = 1,
            kBlendModeAddLayer1Layer2 = 2,
            kLBlendModeMultiplyLayer1Layer2 = 3,
        }

        public enum EInstanceColorModes
        {
            kInstanceColorMultiplyFinalColor = 0,
            kInstanceColorMultiplyLayer2Color = 1,
        }

        public enum EFinalAlphaModes
        {
            kFinalAlphaLayer1 = 0,
            kFinalAlphaLayer2 = 1,
            kFinalAlphaMultiplyLayer1Layer2 = 2,
            kFinalAlphaScreenLayer1Layer2 = 3,
        }

        [ObjectAttr(size: 4)]
        public class VfxTwoLayerMaterialBitfield : igBitFieldMetaField
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
            [FieldAttr(offset: 9, size: 1)] public bool _textureCompression_mask;
            [FieldAttr(offset: 10, size: 1)] public bool _textureMips_mask;
            [FieldAttr(offset: 11, size: 1)] public bool _textureAllowDownsample_mask;
            [FieldAttr(offset: 12, size: 1)] public bool _textureCompression_palette;
            [FieldAttr(offset: 13, size: 1)] public bool _textureMips_palette;
            [FieldAttr(offset: 14, size: 1)] public bool _useOriginalTextureName;
        }

        [FieldAttr(nst: 120, ctr: 120)] public u8 _bfStorage__0;
        [FieldAttr(nst: 124, ctr: 124)] public VfxTwoLayerMaterialBitfield _vfxTwoLayerMaterialBitfield = new();
        [FieldAttr(nst: 128, ctr: 128)] public float _sortDepthOffset;
        [FieldAttr(nst: 132, ctr: 132)] public float _particleSoftness = 14.0f;
        [FieldAttr(nst: 136, ctr: 136)] public string? _textureName_diffuse = "textures";
        [FieldAttr(nst: 144, ctr: 144)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 208, ctr: 208)] public string? _textureName_mask = "textures";
        [FieldAttr(nst: 224, ctr: 224)] public igMatrix44fMetaField _textureTransform2 = new();
        [FieldAttr(nst: 288, ctr: 288)] public string? _textureName_palette = null;
        [FieldAttr(nst: 296, ctr: 296)] public ELayerColorAlphaModes _layer1Color;
        [FieldAttr(nst: 300, ctr: 300)] public ELayerColorAlphaModes _layer2Color = CVfxTwoLayerMaterial.ELayerColorAlphaModes.kLayerNoAlphaMask;
        [FieldAttr(nst: 304, ctr: 304)] public ELayerBlendModes _blendMode;
        [FieldAttr(nst: 308, ctr: 308)] public EInstanceColorModes _instanceColorMode;
        [FieldAttr(nst: 312, ctr: 312)] public EFinalAlphaModes _finalAlphaMode = CVfxTwoLayerMaterial.EFinalAlphaModes.kFinalAlphaLayer2;
        [FieldAttr(ctr: 320)] public igHandleMetaField _stencilFunctionOverride = new();
        [FieldAttr(nst: 316, ctr: 328)] public float _layer1Alpha;
        [FieldAttr(nst: 320, ctr: 332)] public float _layer2Alpha;
        [FieldAttr(nst: 324, ctr: 336)] public float _blendMode0;
        [FieldAttr(nst: 328, ctr: 340)] public float _blendMode1;
        [FieldAttr(nst: 332, ctr: 344)] public float _instanceColor;
        [FieldAttr(nst: 336, ctr: 348)] public float _alphaBlendMode0;
        [FieldAttr(nst: 340, ctr: 352)] public float _alphaBlendMode1;
        [FieldAttr(nst: 344, ctr: 356)] public float _particleSaturationMultiplier = 1.0f;
        [FieldAttr(nst: 352, ctr: 360)] public string? _textureName = null;
        [FieldAttr(nst: 368, ctr: 368)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 384, ctr: 384)] public float _particleSoftnessInverse;
    }
}
