namespace Alchemy
{
    [ObjectAttr(nst: 288, ctr: 288, align: 16)]
    public class CPreRenderUpdatePassBase : igRenderPass
    {
        [FieldAttr(nst: 56, ctr: 56)] public igShaderConstantBundleList? _bundlesToApply;
        [FieldAttr(nst: 64, ctr: 64)] public igShaderConstantBundleList? _dynamicBundlesToApply;
        [FieldAttr(nst: 72, ctr: 72)] public int _bundleWriteIndex;
        [FieldAttr(nst: 80, ctr: 80)] public CRenderConstantBundles? _renderBundles;
        [FieldAttr(nst: 88, ctr: 88)] public igSortKeyCommandDelegateObject? _passDelegate;
        [FieldAttr(nst: 96, ctr: 96)] public CForwardLitRenderPassData? _globalLightingData;
        [FieldAttr(nst: 104, ctr: 104)] public igRenderDirectionalLight? _sunLight;
        [FieldAttr(nst: 112, ctr: 112)] public CSkyRenderPassData? _nearSkyLightingData;
        [FieldAttr(nst: 120, ctr: 120)] public CSkyRenderPassData? _farSkyLightingData;
        [FieldAttr(nst: 128, ctr: 128)] public CSkyboxRenderPassData? _skyboxData;
        [FieldAttr(nst: 136, ctr: 136)] public igHandleMetaField _ambientAtmosphereEffect = new();
        [FieldAttr(nst: 144, ctr: 144)] public igHandleMetaField _nearParallaxDataHandle = new();
        [FieldAttr(nst: 160, ctr: 160)] public igMatrix44fMetaField _viewPrevious = new();
        [FieldAttr(nst: 224, ctr: 224)] public igMatrix44fMetaField _viewInversePrevious = new();
    }
}
