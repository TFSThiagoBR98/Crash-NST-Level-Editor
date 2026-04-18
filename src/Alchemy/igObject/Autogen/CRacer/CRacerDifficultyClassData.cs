namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CRacerDifficultyClassData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _displayName;
        [FieldAttr(ctr: 24)] public float _speedDisplayRatio;
        [FieldAttr(ctr: 28)] public float _accelDisplayRatio;
        [FieldAttr(ctr: 32)] public float _turnDisplayRatio;
    }
}
