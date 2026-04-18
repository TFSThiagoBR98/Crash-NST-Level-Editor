namespace Alchemy
{
    [ObjectAttr(nst: 352, align: 16)]
    public class CVfxDecalMaterial : igFxMaterial
    {
        [ObjectAttr(size: 1)]
        public class VfxDecalMaterialBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_diffuse = true;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_diffuse = false;
            [FieldAttr(offset: 2, size: 1)] public bool _textureAllowDownsample_diffuse = false;
            [FieldAttr(offset: 3, size: 1)] public bool _useOriginalTextureName;
        }

        [FieldAttr(nst: 120)] public u8 _bfStorage__0;
        [FieldAttr(nst: 128)] public igMatrix44fMetaField _textureTransform = new();
        [FieldAttr(nst: 192)] public VfxDecalMaterialBitfield _vfxDecalMaterialBitfield = new();
        [FieldAttr(nst: 200)] public string? _textureName_diffuse = null;
        [FieldAttr(nst: 208)] public string? _textureName = null;
        [FieldAttr(nst: 224)] public igVec4fMetaField _color = new();
        [FieldAttr(nst: 240)] public bool _enableFadeAngle;
        [FieldAttr(nst: 244)] public float _fadeStartAngle = 45.0f;
        [FieldAttr(nst: 248)] public float _fadeEndAngle = 60.0f;
        [FieldAttr(nst: 256)] public igVec4fMetaField _alphaScaleOffset = new();
        [FieldAttr(nst: 272)] public bool _enableEdgeFade;
        [FieldAttr(nst: 288)] public igVec4fMetaField _edgeFadeDistances = new();
        [FieldAttr(nst: 304)] public igVec4fMetaField _edgeFadeOffset = new();
        [FieldAttr(nst: 320)] public igVec4fMetaField _edgeFadeScale = new();
        [FieldAttr(nst: 336)] public bool _showOnWater;
        [FieldAttr(nst: 337)] public bool _shadowDecal;
    }
}
