namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CAIAttackCoordinatorData : igObject
    {
        [FieldAttr(nst: 16)] public igRangedFloatMetaField _delayBetweenAttacks = new();
        [FieldAttr(nst: 24)] public int _maxActiveAttacks = 10;
        [FieldAttr(nst: 28)] public int _maxPendingAttacks = 100;
    }
}
