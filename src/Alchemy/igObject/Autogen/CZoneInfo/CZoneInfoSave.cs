namespace Alchemy
{
    [ObjectAttr(nst: 168, ctr: 168, align: 8)]
    public class CZoneInfoSave : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _zoneName = null;
        [FieldAttr(nst: 24, ctr: 24)] public CZoneInfoUserSession? _savedData;
        [FieldAttr(nst: 32, ctr: 32)] public CZoneInfoUserSession[] _sessionData = new CZoneInfoUserSession[17];
    }
}
