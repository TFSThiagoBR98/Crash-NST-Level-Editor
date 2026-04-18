namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 128, align: 8)]
    public class igVfxPrimitive : igVfxRuntimeObject
    {
        [ObjectAttr(size: 4)]
        public class PrimitiveFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isCulled;
            [FieldAttr(offset: 1, size: 1)] public bool _isAlive;
            [FieldAttr(offset: 2, size: 1)] public bool _isPaused;
            [FieldAttr(offset: 3, size: 1)] public bool _lateUpdate;
            [FieldAttr(offset: 4, size: 13)] public int _instanceCount;
            [FieldAttr(offset: 17, size: 8)] public u8 _spawnGroup;
            [FieldAttr(offset: 25, size: 2)] public u8 _cameraIndex;
            [FieldAttr(offset: 27, size: 1)] public bool _wasCulled;
        }

        [FieldAttr(ctr: 12)] public float _procGeoUpdateTime;
        [FieldAttr(ctr: 16)] public float _streamUpdateTime;
        [FieldAttr(ctr: 20)] public float _jobQueueUpdateTime;
        [FieldAttr(ctr: 24)] public int[] _counters = new int[4];
        [FieldAttr(nst: 16, ctr: 40)] public igVfxPrimitiveData? _source;
        [FieldAttr(nst: 24, ctr: 48)] public igRawRefMetaField _instanceHead = new();
        [FieldAttr(nst: 32, ctr: 56)] public igRawRefMetaField _instanceTail = new();
        [FieldAttr(nst: 40, ctr: 64, refCount: false)] public igVfxPrimitive? _primNext;
        [FieldAttr(nst: 48, ctr: 72)] public PrimitiveFlags _primitiveFlags = new();
        [FieldAttr(nst: 52, ctr: 76)] public igHandleMetaField _instanceCountStat = new();
        [FieldAttr(nst: 56, ctr: 80)] public igHandleMetaField _primitiveCountStat = new();
        [FieldAttr(nst: 60, ctr: 84)] public float _timeScale = 1.0f;
        [FieldAttr(nst: 64, ctr: 88)] public float _budgetScale;
        [FieldAttr(nst: 72, ctr: 96, refCount: false)] public igVfxPrimitive? _dependency;
        [FieldAttr(nst: 80, ctr: 104)] public uint _lastUpdateFrame;
        [FieldAttr(nst: 84, ctr: 108)] public u16 _layer = 65535;
        [FieldAttr(nst: 88, ctr: 112)] public igRandomMetaField _rng = new();
        [FieldAttr(nst: 96, ctr: 120, refCount: false)] public igVfxSpawnRate? _spawnRate;
    }
}
