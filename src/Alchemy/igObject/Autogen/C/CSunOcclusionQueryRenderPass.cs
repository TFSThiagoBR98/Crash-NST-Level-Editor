namespace Alchemy
{
    [ObjectAttr(ctr: 512, align: 16)]
    public class CSunOcclusionQueryRenderPass : igSceneRenderPass
    {
        [FieldAttr(ctr: 464)] public igGraphicsProcGeometryBuilder? _pgb;
        [FieldAttr(ctr: 472)] public COcclusionDrawCall[] _drawCall = new COcclusionDrawCall[2];
        [FieldAttr(ctr: 488)] public u16 _firstPassId;
        [FieldAttr(ctr: 496)] public CLensFlareComponent? _component;
    }
}
