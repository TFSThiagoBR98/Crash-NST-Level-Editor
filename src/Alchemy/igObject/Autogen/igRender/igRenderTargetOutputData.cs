namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 8)]
    public class igRenderTargetOutputData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igRenderTargetList? _colorTargets;
        [FieldAttr(nst: 24, ctr: 24)] public igRenderTarget? _depthTarget;
        [FieldAttr(nst: 32, ctr: 32)] public igSizeTypeMetaField[] _colorRenderTargetViews = new igSizeTypeMetaField[8];
        [FieldAttr(nst: 96, ctr: 96)] public igSizeTypeMetaField _depthRenderTargetView = new();
        [FieldAttr(nst: 104, ctr: 104)] public uint _colorRenderTargetViewCount;
        [FieldAttr(nst: 108, ctr: 108)] public bool _outputToBackbufferColorSurface;
        [FieldAttr(nst: 109, ctr: 109)] public bool _outputToBackbufferDepthSurface;
        [FieldAttr(nst: 110, ctr: 110)] public bool _writesToDepth = true;
    }
}
