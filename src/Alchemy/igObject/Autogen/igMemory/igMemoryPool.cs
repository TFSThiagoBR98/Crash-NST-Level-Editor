namespace Alchemy
{
    [ObjectAttr(nst: 168, ctr: 168, align: 8)]
    public class igMemoryPool : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igMutex? _lock;
        [FieldAttr(nst: 24, ctr: 24)] public bool _active;
        [FieldAttr(nst: 28, ctr: 28)] public int _poolIndex = -1;
        [FieldAttr(nst: 32, ctr: 32)] public igRawRefMetaField _address = new();
        [FieldAttr(nst: 40, ctr: 40)] public igSizeTypeMetaField _size = new();
        [FieldAttr(nst: 48, ctr: 48)] public uint _alignment;
        [FieldAttr(nst: 52, ctr: 52)] public uint _userFlags;
        [FieldAttr(nst: 56, ctr: 56)] public bool _lockOnOperation;
        [FieldAttr(nst: 57, ctr: 57)] public bool _isThreadSafe;
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igThread? _owner;
        [FieldAttr(nst: 72, ctr: 72)] public bool _reportThreadSafety = true;
        [FieldAttr(nst: 73, ctr: 73)] public bool _alchemyMemory = true;
        [FieldAttr(nst: 74, ctr: 74)] public bool _reportOnFailure = true;
        [FieldAttr(nst: 75, ctr: 75)] public bool _useSentinels;
        [FieldAttr(nst: 76, ctr: 76)] public bool _fillMemory;
        [FieldAttr(nst: 77, ctr: 77)] public bool _checkIntegrity;
        [FieldAttr(nst: 80, ctr: 80)] public igSizeTypeMetaField _blocksAllocated = new();
        [FieldAttr(nst: 88, ctr: 88)] public igSizeTypeMetaField _peakBlocksAllocated = new();
        [FieldAttr(nst: 96, ctr: 96)] public igSizeTypeMetaField _userAllocated = new();
        [FieldAttr(nst: 104, ctr: 104)] public igSizeTypeMetaField _peakUserAllocated = new();
        [FieldAttr(nst: 112, ctr: 112)] public igSizeTypeMetaField _totalAllocated = new();
        [FieldAttr(nst: 120, ctr: 120)] public igSizeTypeMetaField _peakTotalAllocated = new();
        [FieldAttr(nst: 128, ctr: 128)] public int _ordinal;
        [FieldAttr(nst: 136, ctr: 136)] public string? _name = null;
        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igMemoryPool? _parentPool;
        [FieldAttr(nst: 152, ctr: 152)] public igSizeTypeMetaField _largestFreeBlockSizeMinimum = new();
        [FieldAttr(nst: 160, ctr: 160)] public bool _initializedForTag;
        [FieldAttr(ctr: 161)] public bool _isDebugPool;
    }
}
