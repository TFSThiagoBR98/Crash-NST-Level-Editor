namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 8)]
    public class CAEAchievementParam : igObject
    {
        [FieldAttr(ctr: 12)] public igTimeOfDayMetaField _periodStart = new();
        [FieldAttr(ctr: 40)] public igTimeOfDayMetaField _periodEnd = new();
        [FieldAttr(ctr: 72)] public igStringRefList? _trackList;
        [FieldAttr(ctr: 80)] public igStringRefList? _characterList;
        [FieldAttr(ctr: 88)] public igStringRefList? _kartList;
        [FieldAttr(ctr: 96)] public igStringRefList? _skinList;
        [FieldAttr(ctr: 104)] public string? _powerupName;
        [FieldAttr(ctr: 112)] public string? _cupName;
        [FieldAttr(ctr: 120)] public float _xValue;
        [FieldAttr(ctr: 124)] public float _yValue;
        [FieldAttr(ctr: 128)] public int _progressTarget;
    }
}
