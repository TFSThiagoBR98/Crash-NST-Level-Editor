namespace Alchemy
{
    [ObjectAttr(nst: 496, ctr: 496, align: 16)]
    public class CWaterMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class TextureBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_surface = true;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_surface = false;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_surface = false;
            [FieldAttr(offset: 3, size: 1)] public bool _textureCompression_normal = false;
            [FieldAttr(offset: 4, size: 1)] public bool _textureMips_normal = false;
            [FieldAttr(offset: 5, size: 1)] public bool _textureAllowDownsample_normal = false;
            [FieldAttr(offset: 6, size: 1)] public bool _textureCompression_normal2 = false;
            [FieldAttr(offset: 7, size: 1)] public bool _textureMips_normal2 = false;
            [FieldAttr(offset: 8, size: 1)] public bool _textureAllowDownsample_normal2 = false;
        }

        [FieldAttr(nst: 120, ctr: 120)] public string? _shaderName = "Water";
        [FieldAttr(nst: 128, ctr: 128)] public float _normalMapScale = 1.0f;
        [FieldAttr(nst: 132, ctr: 132)] public float _normalMapScale2 = 1.0f;
        [FieldAttr(nst: 136, ctr: 136)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 144, ctr: 144)] public string? _textureName_surface = null;
        [FieldAttr(nst: 152, ctr: 152)] public string? _textureName_normal = null;
        [FieldAttr(nst: 160, ctr: 160)] public string? _textureName_normal2 = null;
        [FieldAttr(nst: 176, ctr: 176)] public igMatrix44fMetaField _surfaceTransform = new();
        [FieldAttr(nst: 240, ctr: 240)] public igMatrix44fMetaField _normalTransform = new();
        [FieldAttr(nst: 304, ctr: 304)] public igMatrix44fMetaField _normal2Transform = new();
        [FieldAttr(nst: 368, ctr: 368)] public igVec4fMetaField _deepWaterColor = new();
        [FieldAttr(nst: 384, ctr: 384)] public float _absorbtion = 2.5f;
        [FieldAttr(nst: 388, ctr: 388)] public float _gloss = 0.34999999f;
        [FieldAttr(nst: 392, ctr: 392)] public float _specularLevel = 0.06f;
        [FieldAttr(nst: 396, ctr: 396)] public float _surfaceGloss = 0.34999999f;
        [FieldAttr(nst: 400, ctr: 400)] public float _surfaceSpecularLevel = 0.06f;
        [FieldAttr(nst: 404, ctr: 404)] public float _refractionScale = 0.05f;
        [FieldAttr(nst: 408, ctr: 408)] public float _mobileConstantDepth = 300.0f;
        [FieldAttr(nst: 412, ctr: 412)] public float _mobileConstantTransmission;
        [FieldAttr(nst: 416, ctr: 416)] public bool _enableMotionBlur;
        [FieldAttr(nst: 417, ctr: 417)] public bool _applyWaterSimulationNormals;
        [FieldAttr(nst: 418, ctr: 418)] public bool _enableScreenSpaceReflections;
        [FieldAttr(nst: 419, ctr: 419)] public bool _enableRefraction = true;
        [FieldAttr(nst: 420, ctr: 420)] public bool _invisible;
        [FieldAttr(nst: 432, ctr: 432)] public igVec4fMetaField _ambientPrecompute = new();
        [FieldAttr(nst: 448, ctr: 448)] public igVec4fMetaField _lightingPrecompute = new();
        [FieldAttr(nst: 464, ctr: 464)] public igVec4fMetaField _ambientPrecomputeSurface = new();
        [FieldAttr(nst: 480, ctr: 480)] public igVec4fMetaField _lightingPrecomputeSurface = new();
    }
}
