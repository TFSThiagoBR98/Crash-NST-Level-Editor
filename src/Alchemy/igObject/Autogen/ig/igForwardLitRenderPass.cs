namespace Alchemy
{
    [ObjectAttr(nst: 528, ctr: 528, align: 16)]
    public class igForwardLitRenderPass : igParallaxRenderPass
    {
        [FieldAttr(nst: 480, ctr: 480)] public igHandleMetaField _sunLightHandle = new();
        [FieldAttr(nst: 488, ctr: 488)] public igHandleMetaField _renderData = new();
        [FieldAttr(nst: 496, ctr: 496)] public bool _lightingEnabled = true;
        [FieldAttr(nst: 497, ctr: 497)] public bool _enablePrepassDepth;
        [FieldAttr(nst: 504, ctr: 504)] public igOutdoorLightConstantBundle? _outdoorLightConstantBundle;
        [FieldAttr(nst: 512, ctr: 512)] public igAtmosphericsConstantBundle? _atmosphericsConstantBundle;
    }
}
