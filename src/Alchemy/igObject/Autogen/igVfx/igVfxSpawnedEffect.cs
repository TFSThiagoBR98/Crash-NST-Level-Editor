namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 8)]
    public class igVfxSpawnedEffect : igObject
    {
        [ObjectAttr(size: 4)]
        public class FlagStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public uint _cameraMask;
            [FieldAttr(offset: 4, size: 3)] public int _priorityClass;
            [FieldAttr(offset: 7, size: 1)] public bool _isSoftKilled;
            [FieldAttr(offset: 8, size: 1)] public bool _isHardKilled;
            [FieldAttr(offset: 9, size: 1)] public bool _isPaused;
            [FieldAttr(offset: 10, size: 1)] public bool _isHardCulled;
            [FieldAttr(offset: 11, size: 1)] public bool _isIsolateCulled;
            [FieldAttr(offset: 12, size: 1)] public bool _isSoftCulled;
            [FieldAttr(offset: 13, size: 1)] public bool _primitivesSetup;
            [FieldAttr(offset: 14, size: 1)] public bool _lateUpdate;
            [FieldAttr(offset: 15, size: 1)] public bool _isPriorityPaused;
            [FieldAttr(offset: 16, size: 1)] public bool _isSubEffect;
            [FieldAttr(offset: 17, size: 1)] public bool _zeroTimeScale;
            [FieldAttr(offset: 18, size: 8)] public uint _loopCount;
        }

        [FieldAttr(ctr: 12)] public float _effectUpdateTime;
        [FieldAttr(nst: 16, ctr: 16)] public igVfxEffect? _source;
        [FieldAttr(nst: 24, ctr: 24)] public igTimeMetaField _age = new();
        [FieldAttr(nst: 28, ctr: 28)] public float _totalWindupTime;
        [FieldAttr(nst: 32, ctr: 32)] public float _elapsedWindupTime;
        [FieldAttr(nst: 36, ctr: 36)] public float _hardCullPauseCountdown;
        [FieldAttr(nst: 40, ctr: 40)] public float _timeScale = 1.0f;
        [FieldAttr(nst: 48, ctr: 48)] public igVfxBolt? _bolt1;
        [FieldAttr(nst: 56, ctr: 56)] public igVfxBolt? _bolt2;
        [FieldAttr(nst: 64, ctr: 64)] public igVfxBolt? _groundBolt;
        [FieldAttr(nst: 72, ctr: 72)] public igVfxBaseVariable? _variables;
        [FieldAttr(nst: 80, ctr: 80)] public i8 _spawnGroupAtSpawn;
        [FieldAttr(nst: 81, ctr: 81)] public u8 _spawnGroup;
        [FieldAttr(nst: 84, ctr: 84)] public FlagStorage _flagStorage = new();
        [FieldAttr(nst: 88, ctr: 88)] public u16 _spawnLayers;
        [FieldAttr(nst: 90, ctr: 90)] public u16 _layer = 65535;
        [FieldAttr(nst: 92, ctr: 92)] public float _priority;
        [FieldAttr(nst: 96, ctr: 96)] public int _priorityFailureMask;
        [FieldAttr(nst: 100, ctr: 100)] public float _maxBudgetFraction;
        [FieldAttr(nst: 104, ctr: 104, refCount: false)] public igVfxPrimitive? _dependency;
        [FieldAttr(nst: 112, ctr: 112)] public uint _seed;
        [FieldAttr(nst: 120, ctr: 120, refCount: false)] public igVfxPrimitive? _headPrimitive;
    }
}
