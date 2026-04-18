namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 8)]
    public class CCEAtkRegion : CCombatNodeIntervalEvent
    {
        [FieldAttr(nst: 88)] public CAttackRegionShapeList? _regions;
        [FieldAttr(nst: 96)] public CCEAtkData? _attackData;
        [FieldAttr(nst: 104)] public bool _allowRepeatedAttacks;
        [FieldAttr(nst: 105)] public bool _detectProjectiles;
        [FieldAttr(nst: 112)] public CDamageData? _damage;
        [FieldAttr(nst: 120)] public bool _allowDamageWhenDead;
        [FieldAttr(nst: 124)] public int _maximumVictims = -1;
    }
}
