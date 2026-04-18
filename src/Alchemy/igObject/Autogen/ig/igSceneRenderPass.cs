namespace Alchemy
{
    [ObjectAttr(nst: 464, ctr: 464, align: 16)]
    public class igSceneRenderPass : igBaseRenderPass
    {
        [FieldAttr(nst: 352, ctr: 352, refCount: false)] public igMetaObject? _passStateType = (null);
        [FieldAttr(nst: 360, ctr: 360)] public igCommandStreamEncoderPassState? _passState;
        [FieldAttr(nst: 368, ctr: 368)] public igSortKeyCommandDelegateObject? _passDelegate;
        [FieldAttr(nst: 376, ctr: 376)] public bool _frustCullState = true;
        [FieldAttr(nst: 384, ctr: 384)] public igHandleMetaField _auxiliaryCullingParameters = new();
        [FieldAttr(nst: 392, ctr: 392)] public igHandleMetaField _lodParameters = new();
        [FieldAttr(nst: 400, ctr: 400)] public igStringRefList? _modelClasses;
        [FieldAttr(nst: 408, ctr: 408)] public u64 _modelClassMask;
        [FieldAttr(nst: 416, ctr: 416)] public uint _modelFlags = 1;
        [FieldAttr(nst: 420, ctr: 420)] public bool _renderOpaque = true;
        [FieldAttr(nst: 421, ctr: 421)] public bool _renderAlphaTest = true;
        [FieldAttr(nst: 422, ctr: 422)] public bool _renderTransparent = true;
        [FieldAttr(nst: 423, ctr: 423)] public bool _enableVelocity;
        [FieldAttr(nst: 424, ctr: 424)] public uint _sorterMode = 584;
        [FieldAttr(nst: 428, ctr: 428)] public bool _useZSort;
        [FieldAttr(nst: 429, ctr: 429)] public bool _resetStencilRef;
        [FieldAttr(nst: 432, ctr: 432)] public EigSetStencilRefOperation _stencilRefOperation;
        [FieldAttr(nst: 440, ctr: 440)] public igHandleMetaField _enableData = new();
        [FieldAttr(nst: 448, ctr: 448)] public bool _enabled = true;
        [FieldAttr(nst: 452, ctr: 452)] public int _disableCount;
        [FieldAttr(ctr: 456)] public bool _canBeUnused;
    }
}
