namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CKartBossAIRubberBandComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public CDifficultySpecificBossTTR? _bossTTRs;
        [FieldAttr(ctr: 24)] public CDifficultySpecificFloat? _bossRubberBandStartDistances;
        [FieldAttr(ctr: 32)] public bool _bossCheatsRaceStart;
        [FieldAttr(ctr: 33)] public bool _bossCanDrift;
    }
}
