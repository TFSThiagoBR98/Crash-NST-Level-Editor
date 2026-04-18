namespace Alchemy
{
    [ObjectAttr(nst: 592, ctr: 592, align: 16)]
    public class igFullScreenRenderPass : igSceneRenderPass
    {
        [FieldAttr(nst: 464, ctr: 460)] public int _tileWidth = 2147483647;
        [FieldAttr(nst: 468, ctr: 464)] public int _tileHeight = 2147483647;
        [FieldAttr(nst: 472, ctr: 468)] public bool _enableDepthTest;
        [FieldAttr(nst: 473, ctr: 469)] public bool _enableDepthWrite;
        [FieldAttr(nst: 476, ctr: 472)] public int _texCoordCountOverride = -1;
        [FieldAttr(nst: 480, ctr: 480)] public igRawRefMetaField _pixelShaderBinary = new();
        [FieldAttr(nst: 488, ctr: 488)] public int _pixelShaderBinarySize;
        [FieldAttr(nst: 496, ctr: 496)] public string? _pixelShaderStates = null;
        [FieldAttr(nst: 504, ctr: 504)] public bool _pixelShaderNull;
        [FieldAttr(nst: 512, ctr: 512)] public igRawRefMetaField _vertexShaderBinary = new();
        [FieldAttr(nst: 520, ctr: 520)] public int _vertexShaderBinarySize;
        [FieldAttr(nst: 528, ctr: 528)] public string? _vertexShaderStates = null;
        [FieldAttr(nst: 536, ctr: 536)] public igShaderParametersAttr? _shaderParams;
        [FieldAttr(nst: 544, ctr: 544)] public igFullScreenQuadDrawCall? _drawCall;
        [FieldAttr(nst: 552, ctr: 552)] public uint _sizeChangeCallback = new();
        [FieldAttr(nst: 560, ctr: 560)] public igRawRefMetaField _sizeChangeCallbackArg = new();
        [FieldAttr(nst: 568, ctr: 568)] public bool _flipUVs;
        [FieldAttr(nst: 572, ctr: 572)] public igVec2fMetaField _texelOffset = new();
    }
}
