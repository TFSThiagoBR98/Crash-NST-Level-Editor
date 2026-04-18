namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CLargeBowlingBombComponentData : CBasePowerUpComponentData
    {
        [FieldAttr(ctr: 24)] public CPhysicalEntity? _bowlingBombInfo;
        [FieldAttr(ctr: 32)] public CPhysicalEntity? _juicedBowlingBombInfo;
        [FieldAttr(ctr: 40)] public CPhysicalEntity? _backwardsBowlingBombInfo;
        [FieldAttr(ctr: 48)] public CPhysicalEntity? _juicedBackwardsBowlingBombInfo;
        [FieldAttr(ctr: 56)] public float _spawnOffset;
        [FieldAttr(ctr: 60)] public float _spawnHeightOffset;
    }
}
