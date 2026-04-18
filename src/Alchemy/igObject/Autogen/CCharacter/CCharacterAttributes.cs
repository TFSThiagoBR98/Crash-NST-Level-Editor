namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class CCharacterAttributes : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _maximumHealth;
        [FieldAttr(nst: 20, ctr: 16)] public float _baseResistance = 100.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _meleeResistance;
        [FieldAttr(nst: 28, ctr: 24)] public float _rangedResistance;
        [FieldAttr(nst: 32, ctr: 28)] public float _baseStrength = 100.0f;
        [FieldAttr(nst: 36, ctr: 32)] public float _meleeStrength;
        [FieldAttr(nst: 40, ctr: 36)] public float _rangedStrength;
        [FieldAttr(nst: 44, ctr: 40)] public float _speed;
        [FieldAttr(nst: 48, ctr: 44)] public float _speedCrash2 = 130.0f;
        [FieldAttr(nst: 52, ctr: 48)] public float _speedCrash3 = 130.0f;
        [FieldAttr(nst: 56, ctr: 52)] public float _movementSpeed = 100.0f;
        [FieldAttr(nst: 60, ctr: 56)] public float _attackSpeed = 100.0f;
        [FieldAttr(nst: 64, ctr: 60)] public float _criticalHitChance;
        [FieldAttr(nst: 68, ctr: 64)] public float _criticalHitMultiplier;
        [FieldAttr(nst: 72, ctr: 72)] public CCharacterAttributeMultiplierList? _multipliers;
    }
}
