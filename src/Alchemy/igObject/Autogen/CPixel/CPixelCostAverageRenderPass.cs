namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 120, align: 8)]
    public class CPixelCostAverageRenderPass : igRenderPass
    {
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _inputRenderTarget = new();
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _outputData = new();
        [FieldAttr(nst: 72, ctr: 72)] public igRawRefMetaField[] _scratchTexture = new igRawRefMetaField[3];
        [FieldAttr(nst: 96, ctr: 96)] public bool _initialized;
        [FieldAttr(nst: 100, ctr: 100)] public int _writeIndex;
        [FieldAttr(nst: 104, ctr: 104)] public int _readIndex = 2;
        [FieldAttr(nst: 112, ctr: 112)] public igSortKeyCommandDelegateObject? _passDelegate;
    }
}
