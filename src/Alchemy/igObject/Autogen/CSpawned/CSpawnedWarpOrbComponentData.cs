namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CSpawnedWarpOrbComponentData : CSpawnedPowerUpComponentData
    {
        [FieldAttr(ctr: 20)] public float _deleteTime;
        [FieldAttr(ctr: 24)] public float _speed;
        [FieldAttr(ctr: 28)] public float _closingRange;
        [FieldAttr(ctr: 32)] public igVec3fMetaField _aimOffset = new();
        [FieldAttr(ctr: 44)] public float _hoverHeight;
        [FieldAttr(ctr: 48)] public float _maximumReticleGrowth;
        [FieldAttr(ctr: 56)] public igHandleMetaField _respawnMaterial = new();
        [FieldAttr(ctr: 64)] public float _lifetime;
        [FieldAttr(ctr: 68)] public float _deleteRange;
        [FieldAttr(ctr: 72)] public float _dampingFactor;
    }
}
