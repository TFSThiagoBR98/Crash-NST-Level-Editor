namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctaneTimeTrialData : igObject
    {
        [FieldAttr(ctr: 12)] public float _timeInSeconds;
        [FieldAttr(ctr: 16)] public string? _driverName;
        [FieldAttr(ctr: 24)] public string? _userName;
    }
}
