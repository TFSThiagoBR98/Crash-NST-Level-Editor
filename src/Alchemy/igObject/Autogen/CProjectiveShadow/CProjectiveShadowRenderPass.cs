namespace Alchemy
{
    [ObjectAttr(nst: 528, ctr: 528, align: 16)]
    public class CProjectiveShadowRenderPass : igSceneRenderPass
    {
        [FieldAttr(nst: 464, ctr: 464)] public igHandleMetaField _light = new();
        [FieldAttr(nst: 472, ctr: 472)] public igHandleMetaField _params = new();
        [FieldAttr(nst: 480, ctr: 480)] public string? _shadowCameraName = null;
        [FieldAttr(nst: 488)] public string? _sceneCameraName_1 = null;
        [FieldAttr(ctr: 488)] public string? _sceneCameraName2;
        [FieldAttr(nst: 496, ctr: 496)] public CProjectiveShadowParametersBundle? _shadowParameters;
        [FieldAttr(nst: 504, ctr: 504)] public igRenderCamera? _shadowCamera;
        [FieldAttr(nst: 512, ctr: 512)] public int _outputSize = 1024;
    }
}
