namespace Alchemy
{
    [ObjectAttr(nst: 448, ctr: 448, align: 8)]
    public class CRenderConstantBundles : CRenderBaseConstantBundles
    {
        [FieldAttr(nst: 128, ctr: 128)] public CVelocityConstantBundle[] _velocityConstantBundle = new CVelocityConstantBundle[2];
        [FieldAttr(nst: 144, ctr: 144)] public CObscuredConstantBundle[] _obscuredConstantBundle = new CObscuredConstantBundle[2];
        [FieldAttr(nst: 160, ctr: 160)] public CSkyboxConstantBundle[] _skyboxConstantBundle = new CSkyboxConstantBundle[2];
        [FieldAttr(nst: 176, ctr: 176)] public CBloomConstantBundle[] _bloomConstantBundle = new CBloomConstantBundle[2];
        [FieldAttr(nst: 192, ctr: 192)] public CPixelCostConstantBundle[] _pixelCostConstantBundle = new CPixelCostConstantBundle[2];
        [FieldAttr(nst: 208, ctr: 208)] public CHeroShadowsFullscreenBundle[] _heroShadowsFullscreenBundle = new CHeroShadowsFullscreenBundle[2];
        [FieldAttr(nst: 224, ctr: 224)] public CSceneShadowBundle[] _sceneShadowBundle = new CSceneShadowBundle[2];
        [FieldAttr(nst: 240, ctr: 240)] public CRenderTimeBundle[] _timeBundle = new CRenderTimeBundle[2];
        [FieldAttr(nst: 256, ctr: 256)] public CDefocusConstantBundle[] _defocusConstantBundle = new CDefocusConstantBundle[2];
        [FieldAttr(nst: 272, ctr: 272)] public igDepthEncodingBundle[] _depthEncodingBundle = new igDepthEncodingBundle[2];
        [FieldAttr(nst: 288, ctr: 288)] public CCloudShadingBundle[] _cloudShadingBundle = new CCloudShadingBundle[2];
        [FieldAttr(nst: 304, ctr: 304)] public CGlobalNormalMapScaleBundle[] _globalNormalMapScale = new CGlobalNormalMapScaleBundle[2];
        [FieldAttr(nst: 320, ctr: 320)] public CLinearDepthConstantBundle[] _linearDepthBundle = new CLinearDepthConstantBundle[2];
        [FieldAttr(nst: 336, ctr: 336)] public CSceneViewInverseBundle[] _sceneViewInverseBundle = new CSceneViewInverseBundle[2];
        [FieldAttr(nst: 352, ctr: 352)] public CBilateralDepthToleranceBundle[] _bilateralDepthToleranceBundle = new CBilateralDepthToleranceBundle[2];
        [FieldAttr(nst: 368, ctr: 368)] public CAmbientBakeInfluenceBundle[] _ambientBakeInfluenceBundle = new CAmbientBakeInfluenceBundle[2];
        [FieldAttr(nst: 384, ctr: 384)] public CToonConstantBundle[] _toonBundle = new CToonConstantBundle[2];
        [FieldAttr(nst: 400, ctr: 400)] public CVfxQualityBundle[] _vfxQualityBundle = new CVfxQualityBundle[2];
        [FieldAttr(nst: 416, ctr: 416)] public CLightRigConstantBundle[] _mobileLightRig = new CLightRigConstantBundle[2];
        [FieldAttr(nst: 432)] public igObject[] _furBlurConstantBundle = new igObject[2];
        [FieldAttr(ctr: 432)] public igScreenSpaceReflectionsConstantBundle[] _ssrBundle = new igScreenSpaceReflectionsConstantBundle[2];
    }
}
