namespace Alchemy
{
    [ObjectAttr(nst: 176, ctr: 176, align: 16)]
    public class CVelocityConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32, ctr: 32)] public igMatrix44fMetaField _viewProjPrevious = new();
        [FieldAttr(nst: 96, ctr: 96)] public float _exposureTime = 0.25f;
        [FieldAttr(nst: 112, ctr: 112)] public igVec4fMetaField _exposureParams = new();
        [FieldAttr(nst: 128, ctr: 128)] public igVec4fMetaField _tileParams = new();
        [FieldAttr(nst: 144, ctr: 144)] public igVec4fMetaField _radiusParams = new();
        [FieldAttr(nst: 160)] public bool _motionBlurState = true;
        [FieldAttr(ctr: 160)] public bool _performanceOverrideParam;
    }
}
