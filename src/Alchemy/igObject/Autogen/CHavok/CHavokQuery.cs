namespace Alchemy
{
    [ObjectAttr(nst: 304, align: 16)]
    public class CHavokQuery : igObject
    {
        [FieldAttr(nst: 16)] public uint _cachedCollisionCount = 4294967295;
        [FieldAttr(nst: 24)] public uint _cachedCollision;
        [FieldAttr(nst: 104)] public CObjectBolt? _sourceBolt;
        [FieldAttr(nst: 112)] public CObjectBolt? _targetBolt;
        [FieldAttr(nst: 128)] public uint _sourceOffsetVector;
        [FieldAttr(nst: 144)] public uint _targetOffsetVector;
        [FieldAttr(nst: 160)] public igHandleMetaField _filterEntity = new();
        [FieldAttr(nst: 168)] public uint _collisionFilterInfo = 1092550660;
        [FieldAttr(nst: 172)] public float _radius;
        [FieldAttr(nst: 176)] public bool _useSourceEntityCollisionShape;
        [FieldAttr(nst: 177)] public bool _runOnce = true;
        [FieldAttr(nst: 178)] public bool _ignoreSourceEntityCollision = true;
        [FieldAttr(nst: 179)] public bool _drawDebug;
        [FieldAttr(nst: 180)] public bool _useCaching = true;
        [FieldAttr(nst: 181)] public bool _reverseDirection;
        [FieldAttr(nst: 184)] public uint _shape;
        [FieldAttr(nst: 192)] public bool _useSourceEntityCollisionFiltering;
        [FieldAttr(nst: 193)] public bool _useSourceEntityCollisionFilterAsMask;
        [FieldAttr(nst: 200)] public igHandleMetaField _collisionFilteringSource = new();
        [FieldAttr(nst: 208)] public u64 _poolAllocationID;
        [FieldAttr(nst: 216)] public bool _isPaused;
        [FieldAttr(nst: 217)] public bool _useSourceCenter;
        [FieldAttr(nst: 218)] public bool _useTargetCenter;
        [FieldAttr(nst: 219)] public bool _useSourceBolt;
        [FieldAttr(nst: 220)] public bool _useTargetBolt;
        [FieldAttr(nst: 224)] public igHandleMetaField _sourceBoltPoint = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _targetBoltPoint = new();
        [FieldAttr(nst: 240)] public EHavokQueryType _queryType;
        [FieldAttr(nst: 244)] public EHavokQuerySubType _querySubType;
        [FieldAttr(nst: 248)] public EHavokQueryKillReason _killReason;
        [FieldAttr(nst: 252)] public u8 _resultCount = 1;
        [FieldAttr(nst: 253)] public bool _alwaysFindClosestHit = true;
        [FieldAttr(nst: 254)] public bool _oneHitPerBody;
        [FieldAttr(nst: 256)] public igRawRefMetaField _collisionCallback = new();
        [FieldAttr(nst: 264)] public igHandleMetaField _collisionCallbackUserData = new();
        [FieldAttr(nst: 272)] public igRawRefMetaField _killCallback = new();
        [FieldAttr(nst: 280)] public igHandleMetaField _killCallbackUserData = new();
        [FieldAttr(nst: 288)] public float _pathOffsetMeters;
    }
}
