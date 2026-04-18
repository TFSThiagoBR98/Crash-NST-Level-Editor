namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CChallengeGhostHeaderData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _kartName;
        [FieldAttr(ctr: 24)] public string? _driverName;
        [FieldAttr(ctr: 32)] public float _time;
        [FieldAttr(ctr: 40)] public string? _ghostFile;
    }
}
