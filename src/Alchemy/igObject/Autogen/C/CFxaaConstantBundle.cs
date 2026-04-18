namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 48, align: 16)]
    public class CFxaaConstantBundle : igShaderConstantBundle
    {
        [FieldAttr(nst: 32)] public igVec4fMetaField _fxaaQualityRcpFrame = new();
        [FieldAttr(nst: 48)] public igVec4fMetaField _fxaaConsoleRcpFrameOpt = new();
        [FieldAttr(nst: 64)] public igVec4fMetaField _fxaaConsoleRcpFrameOpt2 = new();
        [FieldAttr(nst: 80)] public igVec4fMetaField _fxaaConsole360RcpFrameOpt2 = new();
        [FieldAttr(nst: 96)] public float _fxaaQualitySubpix = 0.75f;
        [FieldAttr(nst: 100)] public float _fxaaQualityEdgeThreshold = 0.16599999f;
        [FieldAttr(nst: 104)] public float _fxaaQualityEdgeThresholdMin = 0.0833f;
        [FieldAttr(nst: 108)] public float _fxaaConsoleEdgeSharpness = 8.0f;
        [FieldAttr(nst: 112)] public float _fxaaConsoleEdgeThreshold = 0.125f;
        [FieldAttr(nst: 116)] public float _fxaaConsoleEdgeThresholdMin = 0.05f;
        [FieldAttr(nst: 128)] public igVec4fMetaField _fxaaConsole360ConstDir = new();
        [FieldAttr(nst: 144)] public bool _fxaaState = true;
        [FieldAttr(ctr: 32)] public igVec4fMetaField _rcpFrame = new();
    }
}
