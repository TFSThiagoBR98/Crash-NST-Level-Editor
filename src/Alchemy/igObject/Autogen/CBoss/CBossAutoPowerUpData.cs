namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CBossAutoPowerUpData : igObject
    {
        [FieldAttr(ctr: 16)] public CDifficultySpecificRangedFloat? _spawnDelays;
        [FieldAttr(ctr: 24)] public EPowerUpType _powerUpType;
        [FieldAttr(ctr: 28)] public float _powerUpLifetime;
        [FieldAttr(ctr: 32)] public bool _throwBackward;
        [FieldAttr(ctr: 33)] public bool _isJuiced;
        [FieldAttr(ctr: 34)] public bool _bossThrowMultiple;
    }
}
