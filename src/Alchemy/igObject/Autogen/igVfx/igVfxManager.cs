namespace Alchemy
{
    [ObjectAttr(nst: 2704, ctr: 3888, align: 16)]
    public class igVfxManager : igObject
    {
        public enum ESpawnGroup
        {
            kSpawnGroupInherit = -1,
            kSpawnGroup0 = 0,
            kSpawnGroupDefault = 0,
            kSpawnGroup1 = 1,
            kSpawnGroup2 = 2,
            kSpawnGroup3 = 3,
            kSpawnGroup4 = 4,
            kSpawnGroup5 = 5,
            kSpawnGroup6 = 6,
            kSpawnGroup7 = 7,
            kMaxSpawnGroupCount = 8,
        }

        public enum EffectKillType
        {
            kSoftKill = 0,
            kHardKill = 1,
        }

        public enum EUpdatePhase
        {
            kPostUpdate = 0,
            kEarlyPreUpdate = 1,
            kLatePreUpdate = 2,
        }

        public enum EDebugVisualizationLevel
        {
            kNone = 0,
            kPrimitive = 1,
            kEffect = 2,
            kAll = 3,
        }

        public enum EVfxCamera
        {
            kVfxCamera0 = 0,
            kVfxCamera1 = 1,
            kVfxCameraGUI = 2,
            kVfxCameraCount = 3,
        }

        [FieldAttr(nst: 16)] public igRawRefMetaField _stackUpdateFunction = new();
        [FieldAttr(nst: 24, ctr: 24)] public bool _metricSystemUnits;
        [FieldAttr(nst: 25, ctr: 25)] public bool _activated;
        [FieldAttr(nst: 26, ctr: 26)] public bool _skipCulling;
        [FieldAttr(nst: 27, ctr: 27)] public bool _doSkipCulling;
        [FieldAttr(nst: 28, ctr: 28)] public bool _highQualityTrails;
        [FieldAttr(nst: 32, ctr: 32)] public igMetaObjectPrimitiveInfoHashTable? _primitiveInfoTable;
        [FieldAttr(nst: 40, ctr: 40)] public igMetaObjectVfxRuntimeObjectInfoHashTable? _spawnRateInfoTable;
        [FieldAttr(nst: 48, ctr: 48)] public igMetaObjectVfxRuntimeObjectInfoHashTable? _spawnLocationInfoTable;
        [FieldAttr(nst: 56, ctr: 56)] public igMetaObjectVfxRuntimeObjectInfoHashTable? _boltInfoTable;
        [FieldAttr(nst: 64, ctr: 64)] public igMetaObjectVfxRuntimeObjectInfoHashTable? _dataBlockInfoTable;
        [FieldAttr(nst: 72, ctr: 72)] public igVfxNonRefCountedPrimitiveInfoList? _primitiveInfoList;
        [FieldAttr(nst: 80, ctr: 80, refCount: false)] public igVfxPrimitiveInfo? _primitiveInfo;
        [FieldAttr(nst: 88, ctr: 88)] public igVfxRuntimeObjectInfo[] _operatorStorageInfo = new igVfxRuntimeObjectInfo[3];
        [FieldAttr(nst: 112, ctr: 112)] public igVfxBolt? _sharedIntervalBolt;
        [FieldAttr(nst: 120, ctr: 120)] public igObjectPool? _spawnedEffectPool;
        [FieldAttr(nst: 128, ctr: 128)] public igVfxSpawnedEffectList[] _effects = new igVfxSpawnedEffectList[2];
        [FieldAttr(nst: 144, ctr: 144)] public igVfxNonRefCountedSpawnedEffectList[] _effectsByPriority = new igVfxNonRefCountedSpawnedEffectList[2];
        [FieldAttr(nst: 160, ctr: 160)] public bool[] _priorityRebalance = new bool[2];
        [FieldAttr(nst: 162, ctr: 162)] public bool _queuedForSpawnDirty;
        [FieldAttr(nst: 168, ctr: 168)] public igVfxSpawnedEffectHandleList? _queuedForSpawn;
        [FieldAttr(nst: 176, ctr: 176)] public igVfxSpawnedEffectHandleList[] _windupEffects = new igVfxSpawnedEffectHandleList[2];
        [FieldAttr(nst: 192, ctr: 192)] public float _parentWindupTime;
        [FieldAttr(nst: 196, ctr: 196)] public igRandomMetaField _rng = new();
        [FieldAttr(nst: 204, ctr: 204)] public float _frameDelta;
        [FieldAttr(nst: 208, ctr: 208)] public igTimer? _spawnTimer;
        [FieldAttr(nst: 216, ctr: 216)] public igVec3fMetaField _wind = new();
        [FieldAttr(nst: 232, ctr: 232)] public igVectorMetaField<igVfxSpawnGroupPassInfo> _spawnGroupPassInfoList = new();
        [FieldAttr(nst: 256, ctr: 256)] public igVectorMetaField<igStringSpawnGroupPassDataHashTable> _spawnGroupPassInfoTableList = new();
        [FieldAttr(nst: 280, ctr: 280)] public igVectorMetaField<igProcGeometryBuilder> _pgbs = new();
        [FieldAttr(nst: 304, ctr: 304)] public igVectorMetaField<uint> _pgbFlags = new();
        [FieldAttr(nst: 328, ctr: 328)] public igVectorMetaField<int> _pgbVertSizes = new();
        [FieldAttr(nst: 352, ctr: 352)] public igDynamicBuffer? _procGeometryBuffer;
        [FieldAttr(nst: 360, ctr: 360)] public igProcGeometryHelperPool? _pghPool;
        [FieldAttr(nst: 368, ctr: 368, refCount: false)] public igRawRefMetaField _sortKeyAllocator = new();
        [FieldAttr(nst: 376, ctr: 376)] public igAtomicSortKeyValueListMetaField _sortKeyList = new();
        [FieldAttr(nst: 400, ctr: 400)] public igVfxDrawCallPool? _vfxDrawCallPool;
        [FieldAttr(nst: 408, ctr: 408)] public igVfxDecalDrawCallPool? _vfxDecalDrawCallPool;
        [FieldAttr(nst: 416, ctr: 416)] public igObjectPool? _decalMatrixConstantBundlePool;
        [FieldAttr(nst: 424, ctr: 424)] public igModelInstancePool? _modelInstancePool;
        [FieldAttr(nst: 432, ctr: 432)] public igObjectPool? _colorConstantBundlePool;
        [FieldAttr(nst: 440, ctr: 440)] public igObjectPool? _timeTransformPool;
        [FieldAttr(nst: 448, ctr: 448)] public igStreamPool? _streamPool;
        [FieldAttr(nst: 456, ctr: 456)] public bool _ownedPoolsFixed;
        [FieldAttr(nst: 457, ctr: 457)] public bool _outOfMemory;
        [FieldAttr(nst: 464, ctr: 464)] public string? _outOfMemoryCallSite = null;
        [FieldAttr(nst: 472, ctr: 472)] public bool _reportOutOfMemory;
        [FieldAttr(nst: 476, ctr: 476)] public int _maxProcVertexCount = -1;
        [FieldAttr(nst: 480, ctr: 480)] public uint _pghPoolSize = 32;
        [FieldAttr(nst: 484, ctr: 484)] public uint _boundingBoxPoolSize = 32;
        [FieldAttr(nst: 488, ctr: 488)] public uint _geoAndMaterialPoolSize = 32;
        [FieldAttr(nst: 492, ctr: 492)] public uint _spawnedEffectPoolCapacity = 32;
        [FieldAttr(nst: 496, ctr: 496)] public uint _emitterCapacity = 32;
        [FieldAttr(nst: 500, ctr: 500)] public uint _instanceCapacity = 32;
        [FieldAttr(nst: 504, ctr: 504)] public uint _decalPoolCount = 32;
        [FieldAttr(nst: 508, ctr: 508)] public uint _modelPoolCount = 32;
        [FieldAttr(nst: 512, ctr: 512)] public u8 _spawnGroupCount = 1;
        [FieldAttr(nst: 528, ctr: 528)] public igVfxManagerCameraDataMetaField[] _cameraData = new igVfxManagerCameraDataMetaField[5];
        [FieldAttr(nst: 2304, ctr: 3488)] public uint _activeCameras = 1;
        [FieldAttr(nst: 2308, ctr: 3492)] public uint _viewChanged = 4294967295;
        [FieldAttr(nst: 2320, ctr: 3504)] public igVec3fAlignedMetaField _worldForward = new();
        [FieldAttr(nst: 2336, ctr: 3520)] public igVec3fAlignedMetaField _worldRight = new();
        [FieldAttr(nst: 2352, ctr: 3536)] public igVec3fAlignedMetaField _worldUp = new();
        [FieldAttr(nst: 2368, ctr: 3552)] public igMatrix44fMetaField _invWorldMatrix = new();
        [FieldAttr(nst: 2432, ctr: 3616)] public igVec3fAlignedMetaField _gravity = new();
        [FieldAttr(nst: 2448, ctr: 3632)] public igVertexFormat? _decalVertexFormat;
        [FieldAttr(nst: 2456, ctr: 3640)] public igSizeTypeMetaField _decalVertexFormatResource = new();
        [FieldAttr(nst: 2464, ctr: 3648)] public igSizeTypeMetaField _decalVertexBufferResource = new();
        [FieldAttr(nst: 2472, ctr: 3656)] public igSizeTypeMetaField _decalIndexBufferResource = new();
        [FieldAttr(nst: 2480, ctr: 3664)] public bool _effectCullingEnabled = true;
        [FieldAttr(nst: 2481, ctr: 3665)] public bool _useOverrideCullDistance;
        [FieldAttr(nst: 2484, ctr: 3668)] public float _overrideCullDistance = 3.0f;
        [FieldAttr(nst: 2488, ctr: 3672)] public float _maxProcGeometryRadius = 1000.0f;
        [FieldAttr(nst: 2492, ctr: 3676)] public int _debugMaxProcVertCount = -1;
        [FieldAttr(nst: 2496, ctr: 3680)] public bool _expandPghLists;
        [FieldAttr(nst: 2500, ctr: 3684)] public EUpdatePhase _updatePhase;
        [FieldAttr(nst: 2504, ctr: 3688)] public bool _killAllSpawnedEffectsQueued;
        [FieldAttr(nst: 2512, ctr: 3696, refCount: false)] public igThread? _owner;
        [FieldAttr(nst: 2520, ctr: 3704)] public bool _bypassJobQueue;
        [FieldAttr(nst: 2524, ctr: 3708)] public EDebugVisualizationLevel _debugVisualizationLevel;
        [FieldAttr(nst: 2528, ctr: 3712)] public bool _visibility = true;
        [FieldAttr(nst: 2536, ctr: 3720)] public igVfxDebugData? _debugData;
        [FieldAttr(nst: 2544, ctr: 3728)] public igHandleMetaField _selectedEffect = new();
        [FieldAttr(nst: 2552, ctr: 3736)] public igHandleMetaField _selectedPrimitive = new();
        [FieldAttr(nst: 2560, ctr: 3744)] public bool _magicMomentHack;
        [FieldAttr(nst: 2564, ctr: 3748)] public float[] _cameraCullDistance = new float[5];
        [FieldAttr(nst: 2576, ctr: 3768)] public bool _cullZeroTimeScaleEffects;
        [FieldAttr(nst: 2584, ctr: 3776, refCount: false)] public igVfxSpawnedEffect? _updatingEffect;
        [FieldAttr(nst: 2592, ctr: 3784, refCount: false)] public igVfxPrimitive? _updatingPrimitive;
        [FieldAttr(nst: 2600, ctr: 3792)] public bool _enablePriorities = true;
        [FieldAttr(nst: 2604, ctr: 3796)] public igHandleMetaField _statHandleDeprioritised = new();
        [FieldAttr(nst: 2608, ctr: 3800)] public igHandleMetaField _statHandlePaused = new();
        [FieldAttr(nst: 2612, ctr: 3804)] public igHandleMetaField _statHandleEmpty = new();
        [FieldAttr(nst: 2616, ctr: 3808)] public igHandleMetaField _statHandleActive = new();
        [FieldAttr(nst: 2620, ctr: 3812)] public uint _currentFrame;
        [FieldAttr(nst: 2624, ctr: 3816)] public igMemoryRef<u8> _streamHeapMemory = new();
        [FieldAttr(nst: 2640, ctr: 3832)] public igMemoryRef<u8> _streamHeapLevelData = new();
        [FieldAttr(nst: 2656, ctr: 3848)] public int _streamBlockSize = 128;
        [FieldAttr(nst: 2660, ctr: 3852)] public int _streamBlockCount = 512;
        [FieldAttr(nst: 2664, ctr: 3856)] public igRawRefMetaField _streamHeap = new();
        [FieldAttr(nst: 2672, ctr: 3864)] public u16 _deviceClass = 65535;
        [FieldAttr(nst: 2676, ctr: 3868)] public igHandleMetaField _jqUpdateStatHandle = new();
        [FieldAttr(nst: 2680, ctr: 3872)] public bool _skipFrame;
        [FieldAttr(nst: 2684, ctr: 3876)] public float _averageFinishProcGeoTime;
        [FieldAttr(nst: 2688, ctr: 3880)] public float _averageStreamResetTime;
        [FieldAttr(nst: 2692, ctr: 3884)] public float _averageFinishCommandTime;
    }
}
