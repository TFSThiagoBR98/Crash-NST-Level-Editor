namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CBeakerComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CGameEntity? _beakerInfo;
        [FieldAttr(ctr: 32)] public CGameEntity? _juicedBeakerInfo;
        [FieldAttr(ctr: 40)] public CGameEntity? _thrownBeakerInfo;
        [FieldAttr(ctr: 48)] public CGameEntity? _juicedThrownBeakerInfo;
        [FieldAttr(ctr: 56)] public float _dropSpawnOffsetAbove;
        [FieldAttr(ctr: 60)] public float _dropSpawnOffsetForward;
        [FieldAttr(ctr: 64)] public float _throwSpawnOffsetAbove;
        [FieldAttr(ctr: 68)] public float _throwSpawnOffsetForward;
        [FieldAttr(ctr: 72)] public igHandleMetaField _respawnMaterial = new();
    }
}
