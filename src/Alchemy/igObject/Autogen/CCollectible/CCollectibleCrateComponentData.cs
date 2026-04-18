namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CCollectibleCrateComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _respawnMinimumDelay;
        [FieldAttr(ctr: 20)] public float _respawnAnimationDuration;
        [FieldAttr(ctr: 24)] public ECrateContent _content;
        [FieldAttr(ctr: 28)] public EPowerUpType _powerUpType;
        [FieldAttr(ctr: 32)] public bool _spawnRegardlessOfGamemode;
        [FieldAttr(ctr: 40)] public CQueryFilter? _respawnQuery;
        [FieldAttr(ctr: 48)] public int _quantityMin;
        [FieldAttr(ctr: 52)] public int _quantityMax;
    }
}
