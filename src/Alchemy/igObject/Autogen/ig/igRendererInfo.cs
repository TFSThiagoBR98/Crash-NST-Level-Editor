namespace Alchemy
{
    [ObjectAttr(nst: 200, ctr: 200, align: 8)]
    public class igRendererInfo : igInfo
    {
        [FieldAttr(nst: 40, ctr: 40)] public igRenderPass? _rendererDefault;
        [FieldAttr(nst: 48, ctr: 48)] public igRenderPass? _rendererDx9;
        [FieldAttr(nst: 56, ctr: 56)] public igRenderPass? _rendererAspen;
        [FieldAttr(nst: 64, ctr: 64)] public igRenderPass? _rendererIpodTouch3;
        [FieldAttr(nst: 72, ctr: 72)] public igRenderPass? _rendererIpodTouch4;
        [FieldAttr(nst: 80, ctr: 80)] public igRenderPass? _rendererIphone3gs;
        [FieldAttr(nst: 88, ctr: 88)] public igRenderPass? _rendererIphone4;
        [FieldAttr(nst: 96, ctr: 96)] public igRenderPass? _rendererIphone4s;
        [FieldAttr(nst: 104, ctr: 104)] public igRenderPass? _rendererIphone5;
        [FieldAttr(nst: 112, ctr: 112)] public igRenderPass? _rendererIpad;
        [FieldAttr(nst: 120, ctr: 120)] public igRenderPass? _rendererIpad2;
        [FieldAttr(nst: 128, ctr: 128)] public igRenderPass? _rendererIpad3;
        [FieldAttr(nst: 136, ctr: 136)] public igRenderPass? _rendererDurango;
        [FieldAttr(nst: 144, ctr: 144)] public igRenderPass? _rendererPs4;
        [FieldAttr(nst: 152, ctr: 152)] public igRenderPass? _rendererOsx;
        [FieldAttr(nst: 160, ctr: 160)] public igRenderPass? _rendererWgl;
        [FieldAttr(nst: 168, ctr: 168)] public igRenderPass? _rendererDx11;
        [FieldAttr(nst: 176, ctr: 176)] public igRenderPass? _rendererLinux;
        [FieldAttr(nst: 184, ctr: 184)] public igRenderPass? _rendererNull;
        [FieldAttr(nst: 192, ctr: 192)] public igRenderPass? _rendererNx;
    }
}
