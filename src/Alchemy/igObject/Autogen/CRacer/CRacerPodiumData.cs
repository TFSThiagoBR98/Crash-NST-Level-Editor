namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CRacerPodiumData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _name;
        [FieldAttr(ctr: 24)] public CGameEntity? _racerInfo;
        [FieldAttr(ctr: 32)] public string? _lostAnimation;
        [FieldAttr(ctr: 40)] public string? _winAnimation;
    }
}
