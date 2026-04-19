namespace Alchemy
{
    [ObjectAttr(nst: 256, ctr: 256, align: 16)]
    public class CUnlitMaterial : igFxMaterial
    {
        [ObjectAttr(size: 4)]
        public class TextureBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_diffuse = false;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_diffuse = false;
        }

        [FieldAttr(nst: 120, ctr: 120)] public TextureBitfield _textureBitfield = new();
        [FieldAttr(nst: 128, ctr: 128)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 144, ctr: 144)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 208, ctr: 208)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 224, ctr: 224)] public bool _renderObscured;
        [FieldAttr(nst: 225, ctr: 225)] public bool _prepassDepth = true;
        [FieldAttr(nst: 226, ctr: 226)] public bool basic_haze = true;
        [FieldAttr(nst: 227, ctr: 227)] public bool basic_additive_haze;
        [FieldAttr(nst: 228, ctr: 228)] public bool basic_additive;
        [FieldAttr(nst: 229, ctr: 229)] public bool _onlyDrawInTools;
        [FieldAttr(nst: 232, ctr: 232)] public ECastShadows _castShadows = ECastShadows.eCS_Yes;
        [FieldAttr(nst: 236, ctr: 236)] public bool _depthBlendingState;
        [FieldAttr(nst: 240, ctr: 240)] public float _depthBlendingSoftness = 14.0f;
        [FieldAttr(nst: 244, ctr: 244)] public float _depthBlendingSoftnessInverse;
        [FieldAttr(nst: 248, ctr: 248)] public bool _excludeFromDecimation;
    }
}
