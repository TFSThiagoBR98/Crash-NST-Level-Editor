namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class CArenaTargetingComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public CQueryFilter? _targetQuery;
        [FieldAttr(nst: 32, ctr: 24)] public CQueryFilter? _noInputTargetQuery;
        [FieldAttr(nst: 40, ctr: 32)] public CFilterByVision.EFacing _facing;
        [FieldAttr(nst: 44, ctr: 36)] public float _maxAcceptableTargetAngle = 20.0f;
        [FieldAttr(nst: 48, ctr: 40)] public float _subFilterAngleWeight = 8.0f;
        [FieldAttr(nst: 52, ctr: 44)] public float _subFilterDistanceWeight = 1.0f;
        [FieldAttr(nst: 56, ctr: 48)] public float _subFilterMaxDistance = 5000.0f;
        [FieldAttr(nst: 60, ctr: 52)] public ECombatTargetList _targetList;
        [FieldAttr(nst: 64, ctr: 56)] public float _targetDropTime = -1.0f;
        [FieldAttr(nst: 68, ctr: 60)] public float _targetDropDistance = -1.0f;
        [FieldAttr(nst: 72, ctr: 64)] public float _targetDropAngle;
        [FieldAttr(nst: 76, ctr: 68)] public bool _targetDropWhenOffscreen = true;
        [FieldAttr(nst: 77, ctr: 69)] public bool _prioritizeLockedActorOverNewNonActorTarget = true;
        [FieldAttr(nst: 80, ctr: 72)] public float _noInputTargetingResetTime = 2.0f;
        [FieldAttr(nst: 84, ctr: 76)] public bool _passengerTargeting;
        [FieldAttr(nst: 85, ctr: 77)] public bool _gunnerAutoDetect = true;
    }
}
