namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctaneRacerAnimPodiumComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public string? _victoryAnimName;
        [FieldAttr(ctr: 24)] public string? _loseAnimName;
    }
}
