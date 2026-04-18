namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrio_PotionThrowHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _LeftThrowProjectileData = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _RightThrowProjectileData = new();
        [FieldAttr(nst: 56)] public float _LeftThrowPlayerDistanceInfluenceMinimum;
        [FieldAttr(nst: 60)] public float _PotionThrowFarStartingRange;
        [FieldAttr(nst: 64)] public igHandleMetaField _LeftThrowProjectileSpawnData = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _RightThrowProjectileSpawnData = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _LeftThrowFarProjectileSpawnData = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _RightThrowFarProjectileSpawnData = new();
    }
}
