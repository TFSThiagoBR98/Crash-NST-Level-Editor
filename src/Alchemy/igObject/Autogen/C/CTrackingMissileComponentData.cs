namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CTrackingMissileComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CGameEntity? _trackingMissileInfo;
        [FieldAttr(ctr: 32)] public CGameEntity? _juicedTrackingMissileInfo;
        [FieldAttr(ctr: 40)] public float _spawnOffsetAbove;
        [FieldAttr(ctr: 44)] public float _spawnOffsetForward;
    }
}
