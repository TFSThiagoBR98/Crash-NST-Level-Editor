namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 72, align: 8)]
    public class igRenderPassManager : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _backBufferWidth;
        [FieldAttr(nst: 20, ctr: 16)] public int _backBufferHeight;
        [FieldAttr(nst: 24, ctr: 24)] public igRenderPassList? _passes;
        [FieldAttr(nst: 32, ctr: 32)] public igRenderTargetMemPolicy? _renderTargetTexturePolicy;
        [FieldAttr(nst: 40, ctr: 40)] public igRenderTargetMemPolicy? _renderTargetSurfacePolicy;
        [FieldAttr(nst: 48, ctr: 48)] public bool _rebuildNeeded;
        [FieldAttr(nst: 49, ctr: 49)] public bool _active;
        [FieldAttr(nst: 50)] public bool _retainCachedScene;
        [FieldAttr(ctr: 50)] public bool _ditheringAllowed;
        [FieldAttr(nst: 52, ctr: 52)] public int _renderTargetTotalSize;
        [FieldAttr(nst: 56, ctr: 56)] public int _renderTargetMemoryAllocated;
        [FieldAttr(ctr: 64)] public StringUShortHashTable? _firstPassIdForModelClassCache;
    }
}
