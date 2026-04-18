namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 136, align: 8)]
    public class CCEAcquireCombatTargets : CCombatNodeEvent
    {
        [FieldAttr(nst: 80, ctr: 64)] public EAcquireInsertMethod _insertMethod;
        [FieldAttr(nst: 84, ctr: 68)] public ECombatTargetList _targetList;
        [FieldAttr(nst: 88, ctr: 72)] public CSortEntities? _sortMethod;
        [FieldAttr(nst: 96, ctr: 80)] public CFilterEntities? _filterMethod;
        [FieldAttr(nst: 104, ctr: 88)] public uint _targetType;
        [FieldAttr(nst: 108, ctr: 92)] public float _radius = 100.0f;
        [FieldAttr(nst: 112, ctr: 96)] public float _angle = 90.0f;
        [FieldAttr(nst: 120, ctr: 104)] public CCombatNodeEvent? _successEvent;
        [FieldAttr(nst: 128, ctr: 112)] public CCombatNodeEvent? _failEvent;
        [FieldAttr(nst: 136, ctr: 120)] public bool _useDefaultTarget;
        [FieldAttr(nst: 140, ctr: 124)] public igVec3fMetaField _defaultTargetOffset = new();
    }
}
