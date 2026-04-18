namespace Alchemy
{
    [ObjectAttr(nst: 416, ctr: 480, align: 16)]
    public class igModelScene : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<InstanceDataMetaField> _instances = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<u16> _passLists = new();
        [FieldAttr(nst: 64, ctr: 64)] public bool _fullRefilter = true;
        [FieldAttr(nst: 72, ctr: 72)] public igRawRefMetaField _deferredFilterList = new();
        [FieldAttr(nst: 80, ctr: 80)] public igUnsignedIntUnsignedIntHashTable? _passListLookup;
        [FieldAttr(nst: 88, ctr: 88)] public igObjectIntHashTable? _instanceToDataTable;
        [FieldAttr(nst: 96, ctr: 96)] public int _maxNumberWorkers;
        [FieldAttr(nst: 104, ctr: 104)] public igVectorMetaField<igPtrMemoryPool> _drawCallPools = new();
        [FieldAttr(nst: 128, ctr: 128)] public igRawRefMetaField _batchParams = new();
        [FieldAttr(nst: 136, ctr: 136)] public igRawRefMetaField _batchSizes = new();
        [FieldAttr(nst: 144, ctr: 144)] public igRawRefMetaField _batchEndIndices = new();
        [FieldAttr(nst: 152, ctr: 152)] public igRawRefMetaField _heap = new();
        [FieldAttr(nst: 160, ctr: 160)] public igModelDrawCall? _defaultModelDrawCall;
        [FieldAttr(nst: 168, ctr: 168)] public igSkinnedModelDrawCall? _defaultSkinnedModelDrawCall;
        [FieldAttr(nst: 176, ctr: 176)] public igVectorMetaField<igPtrMemoryPool>[] _bufferedDataPools = new igVectorMetaField<igPtrMemoryPool>[3];
        [FieldAttr(nst: 248, ctr: 248)] public uint _bufferedWriteIndex;
        [FieldAttr(nst: 252, ctr: 252)] public uint _frame;
        [FieldAttr(nst: 256, ctr: 256)] public int _bufferedDataPoolChunkSize = 32768;
        [FieldAttr(nst: 264, ctr: 264)] public igVectorMetaField<CameraMetaField> _cameras = new();
        [FieldAttr(nst: 288, ctr: 288)] public igVectorMetaField<PassFilterMetaField> _passFilters = new();
        [FieldAttr(nst: 320, ctr: 320)] public int _jobCounter;
        [FieldAttr(nst: 328, ctr: 328, refCount: false)] public igRawRefMetaField _result = new();
        [FieldAttr(nst: 336, ctr: 336)] public igTimeMetaField _time = new();
        [FieldAttr(nst: 340, ctr: 340)] public bool _threaded;
        [FieldAttr(nst: 344, ctr: 344)] public int _viewportCount = 2;
        [FieldAttr(nst: 348, ctr: 352)] public u64[] _viewportMasks = new u64[4];
        [FieldAttr(nst: 356, ctr: 384)] public u64[] _distanceCullCameraMasks = new u64[4];
        [FieldAttr(nst: 364)] public uint _cameraEnableMask;
        [FieldAttr(ctr: 416)] public u64 _cameraEnabledMask;
        [FieldAttr(nst: 368, ctr: 424)] public igMutex? _instancesMutex;
        [FieldAttr(nst: 376, ctr: 432)] public igHandleMetaField _traverseTimeStat = new();
        [FieldAttr(nst: 380, ctr: 436)] public igHandleMetaField _drawCallMemoryUsedStat = new();
        [FieldAttr(nst: 384, ctr: 440)] public igHandleMetaField _bufferedMemoryUsedStat = new();
        [FieldAttr(nst: 388, ctr: 444)] public igHandleMetaField _filterTimeStat = new();
        [FieldAttr(nst: 392, ctr: 448)] public igHandleMetaField _filterCountStat = new();
        [FieldAttr(nst: 396, ctr: 452)] public igHandleMetaField _heapMemoryUsedState = new();
        [FieldAttr(nst: 400, ctr: 456)] public igHandleMetaField _heapBlocksUsedState = new();
        [FieldAttr(nst: 408, ctr: 464, refCount: false)] public igModelInstance? _isolateModel;
    }
}
