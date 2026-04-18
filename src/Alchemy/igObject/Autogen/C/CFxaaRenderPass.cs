namespace Alchemy
{
    [ObjectAttr(nst: 640, ctr: 592, align: 16)]
    public class CFxaaRenderPass : igFullScreenRenderPass
    {
        [FieldAttr(nst: 592, ctr: 584)] public CFxaaConstantBundle? _shaderParameters;
        [FieldAttr(nst: 600)] public float _sharpness = 2.0f;
        [FieldAttr(nst: 608)] public igHandleMetaField _fxaaLowMaterial = new();
        [FieldAttr(nst: 616)] public igHandleMetaField _fxaaMediumMaterial = new();
        [FieldAttr(nst: 624)] public igHandleMetaField _fxaaHighMaterial = new();
    }
}
