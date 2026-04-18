namespace Alchemy
{
    [ObjectAttr(ctr: 336, align: 16)]
    public class CGuiTwoLayerMaterial : igFxMaterial
    {
        [FieldAttr(ctr: 120)] public u8 _bfStorage__0;
        [FieldAttr(ctr: 124)] public uint _GuiTwoLayerMaterialBitfield;
        [FieldAttr(ctr: 128)] public string? _textureName_diffuse;
        [FieldAttr(ctr: 144)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(ctr: 208)] public string? _textureName_mask;
        [FieldAttr(ctr: 224)] public igMatrix44fMetaField _textureTransform2 = new();
        [FieldAttr(ctr: 288)] public ELayerColorAlphaModes _layer1Color;
        [FieldAttr(ctr: 292)] public ELayerColorAlphaModes _layer2Color;
        [FieldAttr(ctr: 296)] public ELayerBlendModes _blendMode;
        [FieldAttr(ctr: 300)] public EInstanceColorModes _instanceColorMode;
        [FieldAttr(ctr: 304)] public EFinalAlphaModes _finalAlphaMode;
        [FieldAttr(ctr: 308)] public float _layer1Alpha;
        [FieldAttr(ctr: 312)] public float _layer2Alpha;
        [FieldAttr(ctr: 316)] public float _blendMode0;
        [FieldAttr(ctr: 320)] public float _blendMode1;
        [FieldAttr(ctr: 324)] public float _instanceColor;
        [FieldAttr(ctr: 328)] public float _alphaBlendMode0;
        [FieldAttr(ctr: 332)] public float _alphaBlendMode1;
    }
}
