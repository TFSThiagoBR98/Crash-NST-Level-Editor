namespace Alchemy
{
    [ObjectAttr(nst: 480, ctr: 480, align: 16)]
    public class igParallaxRenderPass : igSceneRenderPass
    {
        [FieldAttr(nst: 464, ctr: 464)] public igHandleMetaField _params = new();
        [FieldAttr(nst: 472, ctr: 472)] public string? _parallaxCameraName = null;
    }
}
