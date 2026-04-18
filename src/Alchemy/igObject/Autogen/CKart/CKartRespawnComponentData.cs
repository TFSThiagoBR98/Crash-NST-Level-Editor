namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CKartRespawnComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _timeBeforeFall;
        [FieldAttr(ctr: 20)] public float _fallingMaxSpeed;
        [FieldAttr(ctr: 24)] public float _timeBeforeReachMaxSpeed;
        [FieldAttr(ctr: 28)] public float _timeBeforeTeleport;
        [FieldAttr(ctr: 32)] public float _upwardSpeed;
        [FieldAttr(ctr: 36)] public float _teleportHeight;
        [FieldAttr(ctr: 40)] public float _timeBeforeGround;
        [FieldAttr(ctr: 44)] public float _maskLingerTime;
        [FieldAttr(ctr: 48)] public float _maskSpeed;
        [FieldAttr(ctr: 52)] public igVec3fMetaField _maskSpawnOffset = new();
        [FieldAttr(ctr: 64)] public CGameEntity? _mask;
        [FieldAttr(ctr: 72)] public CCollisionMaterial? _respawnMaterial;
        [FieldAttr(ctr: 80)] public float _lookUpDistance;
        [FieldAttr(ctr: 84)] public float _lookDownDistance;
        [FieldAttr(ctr: 88)] public float _shortFallDistance;
        [FieldAttr(ctr: 92)] public float _lookDownDistanceGround;
        [FieldAttr(ctr: 96)] public int _maxSmokeTestRespawnsAllowed;
    }
}
