namespace Alchemy
{
    [ObjectAttr(nst: 608, ctr: 608, align: 16)]
    public class CAmbientOcclusionRenderPass : igFullScreenRenderPass
    {
        [FieldAttr(nst: 592, ctr: 584)] public CAmbientOcclusionShaderConstantBundle? _shaderParameters;
        [FieldAttr(nst: 600, ctr: 592)] public igHandleMetaField _parameters = new();
    }
}
