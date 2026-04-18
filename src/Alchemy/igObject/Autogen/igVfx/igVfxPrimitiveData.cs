namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 64, align: 8)]
    public class igVfxPrimitiveData : igObject
    {
        public enum ESubframeSpawn
        {
            kIncludeLastFrame = 0,
            kIncludeCurrentFrame = 1,
            kIncludeBothFrames = 2,
            kUseLastFrame = 3,
            kUseCurrentFrame = 4,
        }

        [ObjectAttr(size: 2)]
        public class DeviceLayers : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _deviceLayer1;
            [FieldAttr(offset: 1, size: 1)] public bool _deviceLayer2;
            [FieldAttr(offset: 2, size: 1)] public bool _deviceLayer3;
            [FieldAttr(offset: 3, size: 1)] public bool _deviceLayer4;
            [FieldAttr(offset: 4, size: 1)] public bool _deviceLayer5;
            [FieldAttr(offset: 5, size: 11)] public uint _overheadCost;
        }

        [ObjectAttr(size: 2)]
        public class SpawnLayers : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _spawnLayer1;
            [FieldAttr(offset: 1, size: 1)] public bool _spawnLayer2;
            [FieldAttr(offset: 2, size: 1)] public bool _spawnLayer3;
            [FieldAttr(offset: 3, size: 1)] public bool _spawnLayer4;
            [FieldAttr(offset: 4, size: 1)] public bool _spawnLayer5;
            [FieldAttr(offset: 5, size: 1)] public bool _spawnLayer6;
            [FieldAttr(offset: 6, size: 1)] public bool _spawnLayer7;
            [FieldAttr(offset: 7, size: 1)] public bool _spawnLayer8;
            [FieldAttr(offset: 8, size: 1)] public bool _spawnLayer9;
            [FieldAttr(offset: 9, size: 1)] public bool _spawnLayer10;
            [FieldAttr(offset: 10, size: 1)] public bool _spawnLayer11;
            [FieldAttr(offset: 11, size: 1)] public bool _spawnLayer12;
            [FieldAttr(offset: 12, size: 1)] public bool _spawnLayer13;
            [FieldAttr(offset: 13, size: 1)] public bool _spawnLayer14;
            [FieldAttr(offset: 14, size: 1)] public bool _spawnLayer15;
            [FieldAttr(offset: 15, size: 1)] public bool _spawnLayer16;
        }

        [ObjectAttr(size: 4)]
        public class PrimitiveFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isVisible;
            [FieldAttr(offset: 1, size: 1)] public bool _infiniteInstanceLifeSpan;
            [FieldAttr(offset: 2, size: 1)] public bool _killOnLoopOut;
            [FieldAttr(offset: 3, size: 3)] public igVfxPrimitiveData.ESubframeSpawn _subframeSpawn;
            [FieldAttr(offset: 6, size: 1)] public bool _dataFieldsCached;
            [FieldAttr(offset: 7, size: 12)] public uint _primitiveRefCount;
            [FieldAttr(offset: 19, size: 1)] public bool _forceBoltInputs;
        }

        [FieldAttr(nst: 16, ctr: 16)] public igHandleMetaField _deathFx = new();
        [FieldAttr(nst: 24, ctr: 24)] public igTimeMetaField _spawnTime = new();
        [FieldAttr(nst: 28, ctr: 28)] public float _lifeSpan = 1.0f;
        [FieldAttr(nst: 32, ctr: 32)] public igRangedFloatMetaField _instanceLifeSpan = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVfxSpawnRateData? _spawnRate;
        [FieldAttr(nst: 48, ctr: 48)] public DeviceLayers _deviceLayers = new();
        [FieldAttr(nst: 50, ctr: 50)] public SpawnLayers _spawnLayers = new();
        [FieldAttr(nst: 52, ctr: 52)] public PrimitiveFlags _primitiveFlags = new();
        [FieldAttr(ctr: 56)] public igRangedFloatMetaField _spawnDistanceRange = new();
    }
}
