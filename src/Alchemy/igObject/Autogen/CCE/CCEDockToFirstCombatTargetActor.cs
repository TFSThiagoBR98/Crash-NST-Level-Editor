namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 104, align: 8)]
    public class CCEDockToFirstCombatTargetActor : CCombatNodeExecuteIntervalEvent
    {
        [FieldAttr(nst: 88, ctr: 72)] public string? _dockingGeneratorName = null;
        [FieldAttr(nst: 96, ctr: 80)] public CCEAcquireCombatTargets? _acquireTargetsEvent;
        [FieldAttr(nst: 104, ctr: 88)] public float _separationDistance;
        [FieldAttr(nst: 108, ctr: 92)] public float _maxGroundTraceDistance = 250.0f;
        [FieldAttr(nst: 112, ctr: 96)] public bool _allowAerialDocking;
        [FieldAttr(nst: 113, ctr: 97)] public bool _allowRotation = true;
    }
}
