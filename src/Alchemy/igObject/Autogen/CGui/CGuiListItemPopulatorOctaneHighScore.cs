namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CGuiListItemPopulatorOctaneHighScore : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16)] public string? _currentZoneName;
        [FieldAttr(ctr: 24)] public string? _wantedZoneName;
        [FieldAttr(ctr: 32)] public EOctaneRaceModes _currentRaceMode;
        [FieldAttr(ctr: 36)] public EOctaneRaceModes _wantedRaceMode;
        [FieldAttr(ctr: 40)] public int _maxListItemCount;
    }
}
