namespace Alchemy
{
    [ObjectAttr(nst: 192, ctr: 192, align: 16)]
    public class CColorAdjustmentBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _colorAdjustment = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _colorTint = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _hueAdjustment1 = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _hueAdjustment2 = new();
        [FieldAttr(nst: 96, ctr: 96)] public igVec4fMetaField _saturationAdjustment1 = new();
        [FieldAttr(nst: 112, ctr: 112)] public igVec4fMetaField _saturationAdjustment2 = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _tonemapParameters = new();
        [FieldAttr(nst: 144, ctr: 144)] public igVec4fMetaField _vignetteParameters1 = new();
        [FieldAttr(nst: 160, ctr: 160)] public igVec4fMetaField _vignetteParameters2 = new();
        [FieldAttr(nst: 176, ctr: 176)] public igVec4fMetaField _mobileColorAdjustment = new();
    }
}
