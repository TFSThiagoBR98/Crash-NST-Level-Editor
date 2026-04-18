namespace Alchemy
{
    [ObjectAttr(nst: 624, ctr: 608, align: 16)]
    public class igCheckerboardResolvePass : igFullScreenRenderPass
    {
        [FieldAttr(nst: 592, ctr: 584)] public igCheckerboardConstantBundle? _checkerboardParameters;
        [FieldAttr(nst: 600, ctr: 592)] public igSizeTypeMetaField _historyTexture = new();
        [FieldAttr(nst: 608, ctr: 600)] public igCheckerboardSetupCall? _setupCall;
    }
}
