namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 96, align: 8)]
    public class CCEQueryCombatTargets : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, ctr: 64)] public CQueryFilter? _query;
        [FieldAttr(nst: 88, ctr: 72)] public ECombatTargetList _targetList;
        [FieldAttr(nst: 96, ctr: 80)] public CCombatNodeEvent? _successEvent;
        [FieldAttr(nst: 104, ctr: 88)] public CCombatNodeEvent? _failEvent;
    }
}
