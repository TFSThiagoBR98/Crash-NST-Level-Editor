namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 16)]
    public class CDefocusConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec4fMetaField _focusPlanes = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVec4fMetaField _focusPlanesDx11 = new();
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _focusParameters = new();
        [FieldAttr(nst: 80, ctr: 80)] public bool _nearFieldDefocus;
        [FieldAttr(nst: 84, ctr: 84)] public float _nearNormalize = 1.0f;
        [FieldAttr(nst: 88, ctr: 88)] public float _farNormalize = 1.0f;
        [FieldAttr(nst: 92, ctr: 92)] public int _maxCoCRadiusPixels = 5;
        [FieldAttr(nst: 96, ctr: 96)] public int _nearBlurRadiusPixels = 5;
        [FieldAttr(nst: 100, ctr: 100)] public float _invNearBlurRadiusPixels = 0.2f;
        [FieldAttr(nst: 104, ctr: 104)] public float _fade;
        [FieldAttr(nst: 108, ctr: 108)] public float _nearBlurRadiusFraction = 0.005f;
        [FieldAttr(nst: 112, ctr: 112)] public float _farBlurRadiusFraction = 0.005f;
    }
}
