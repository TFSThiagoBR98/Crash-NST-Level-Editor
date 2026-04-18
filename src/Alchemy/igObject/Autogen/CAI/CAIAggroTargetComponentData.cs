namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CAIAggroTargetComponentData : CEntityComponentData
    {
        public enum EAttackerArrangement
        {
            eAT_Auto = 0,
            eAT_Circle = 1,
            eAT_Line = 2,
        }

        [FieldAttr(nst: 24, ctr: 16)] public float _aggroPerDamageDone;
        [FieldAttr(nst: 28, ctr: 20)] public float _maxDamageAggro = 600.0f;
        [FieldAttr(nst: 32, ctr: 24)] public float _damageAggroDecayRate = 200.0f;
        [FieldAttr(nst: 36, ctr: 28)] public float _damageAggroMaxDistance = 500.0f;
        [FieldAttr(nst: 40, ctr: 32)] public float _damageAggroMultiplierMinDistance = 300.0f;
        [FieldAttr(nst: 44, ctr: 36)] public float _damageAggroMultiplierAtMinDistance = 1.0f;
        [FieldAttr(nst: 48, ctr: 40)] public float _damageAggroMultiplierAtMaxDistance;
        [FieldAttr(nst: 52, ctr: 44)] public float _minDurationBetweenAttacks;
        [FieldAttr(nst: 56, ctr: 48)] public int _maxSimultaneousAttacks = -1;
        [FieldAttr(nst: 60, ctr: 52)] public int _maxMeleeAttackers = -1;
        [FieldAttr(nst: 64, ctr: 56)] public EAttackerArrangement _attackerArrangement;
    }
}
