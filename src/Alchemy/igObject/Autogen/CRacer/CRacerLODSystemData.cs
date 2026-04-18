namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CRacerLODSystemData : igObject
    {
        [FieldAttr(ctr: 16)] public CPlatformRacerLODSettingsTable? _platformSettingsTable;
    }
}
