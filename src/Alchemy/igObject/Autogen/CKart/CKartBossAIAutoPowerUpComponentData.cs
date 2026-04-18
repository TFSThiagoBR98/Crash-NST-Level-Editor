namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CKartBossAIAutoPowerUpComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CBossAutoPowerUpData? _bossAutoPowerUp;
        [FieldAttr(ctr: 24)] public CDifficultySpecificFloat? _firstSpawnDelays;
        [FieldAttr(ctr: 32)] public CBossAutoPowerUpData? _bossReplaceAutoPowerUp;
    }
}
