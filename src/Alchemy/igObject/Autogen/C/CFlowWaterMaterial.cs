namespace Alchemy
{
    [ObjectAttr(nst: 384, ctr: 384, align: 16)]
    public class CFlowWaterMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class TextureBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_normal;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_normal;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_normal;
        }

        [FieldAttr(nst: 120, ctr: 120)] public string? _shaderName = "FlowWater";
        [FieldAttr(nst: 128, ctr: 128)] public float _normalMapScale = 1.0f;
        [FieldAttr(nst: 132, ctr: 132)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 136, ctr: 136)] public string? _textureName_normal = null;
        [FieldAttr(nst: 144, ctr: 144)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 208, ctr: 208)] public igVec4fMetaField _deepWaterColor = new();
        [FieldAttr(nst: 224, ctr: 224)] public igVec4fMetaField _churnWaterColor = new();
        [FieldAttr(nst: 240, ctr: 240)] public float _invWaveHeightChurnDistance = 0.003f;
        [FieldAttr(nst: 244, ctr: 244)] public float _absorbtion = 2.5f;
        [FieldAttr(nst: 248, ctr: 248)] public float _gloss = 0.34999999f;
        [FieldAttr(nst: 252, ctr: 252)] public float _refractionScale = 0.05f;
        [FieldAttr(nst: 256, ctr: 256)] public float _maxTextureDistortion = 0.33f;
        [FieldAttr(nst: 260, ctr: 260)] public float _flowAnimationRate = 2.0f;
        [FieldAttr(nst: 264, ctr: 264)] public igVec2fMetaField _flowNormalScale = new();
        [FieldAttr(nst: 272, ctr: 272)] public igVec2fMetaField _flowTexcoordOffset = new();
        [FieldAttr(nst: 288, ctr: 288)] public igVec4fMetaField _flowProperties = new();
        [FieldAttr(nst: 304, ctr: 304)] public float _timeScale = 4.0f;
        [FieldAttr(nst: 320, ctr: 320)] public igVec4fMetaField _ambientPrecompute = new();
        [FieldAttr(nst: 336, ctr: 336)] public igVec4fMetaField _lightingPrecompute = new();
        [FieldAttr(nst: 352, ctr: 352)] public bool _enableSoftTransition;
        [FieldAttr(nst: 356, ctr: 356)] public float _softTransitionDistance = 20.0f;
        [FieldAttr(nst: 360, ctr: 360)] public float _invSoftTransitionDistance = 0.05f;
        [FieldAttr(nst: 364, ctr: 364)] public float _mobileConstantDepth = 300.0f;
        [FieldAttr(nst: 368, ctr: 368)] public float _mobileConstantTransmission;
        [FieldAttr(nst: 372, ctr: 372)] public bool _isShallowWater;
        [FieldAttr(nst: 373, ctr: 373)] public bool _isChoppyWater;
        [FieldAttr(nst: 374, ctr: 374)] public bool _enableMotionBlur;
        [FieldAttr(nst: 375, ctr: 375)] public bool _applyWaterSimulationNormals;
        [FieldAttr(nst: 376, ctr: 376)] public bool _enableRefraction = true;
    }
}
