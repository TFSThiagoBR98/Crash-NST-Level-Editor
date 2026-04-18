namespace Alchemy
{
    [ObjectAttr(nst: 624, ctr: 608, align: 16)]
    public class CCombinePostRenderPass : igFullScreenRenderPass
    {
        [FieldAttr(nst: 592, ctr: 584)] public igHandleMetaField _sunLightHandle = new();
        [FieldAttr(nst: 600, ctr: 592)] public igHandleMetaField _renderData = new();
        [FieldAttr(nst: 608, ctr: 600)] public igAtmosphericsConstantBundle? _atmosphericsParameters;
    }
}
