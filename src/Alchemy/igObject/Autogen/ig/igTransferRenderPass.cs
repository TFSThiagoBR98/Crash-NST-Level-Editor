namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 168, align: 8)]
    public class igTransferRenderPass : igRenderPass
    {
        [FieldAttr(ctr: 56)] public igSceneRenderPass? _scenePass;
        [FieldAttr(nst: 56, ctr: 64)] public igRenderTargetInputData? _inputRenderTargetData;
        [FieldAttr(nst: 64, ctr: 72)] public igRenderTargetOutputData? _outputRenderTargetData;
        [FieldAttr(nst: 72, ctr: 80)] public igCommandCopyTextureParametersMetaField _copyCommand = new();
        [FieldAttr(nst: 128, ctr: 136)] public igSortKeyCommandDelegateObject? _passDelegate;
        [FieldAttr(nst: 136, ctr: 144)] public int _sourceX;
        [FieldAttr(nst: 140, ctr: 148)] public int _sourceY;
        [FieldAttr(nst: 144, ctr: 152)] public int _destX;
        [FieldAttr(nst: 148, ctr: 156)] public int _destY;
        [FieldAttr(nst: 152, ctr: 160)] public int _width = -1;
        [FieldAttr(nst: 156, ctr: 164)] public int _height = -1;
    }
}
