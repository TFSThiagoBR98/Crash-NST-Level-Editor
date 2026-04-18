namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 88, align: 8)]
    public class CHeadTrackingHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80, ctr: 64)] public CHeadTrackingTargetList? _targetPriorityList;
        [FieldAttr(nst: 88, ctr: 72)] public float _lookAtAngleLimit = -1.0f;
        [FieldAttr(nst: 92, ctr: 76)] public float _minimumLookAtDuration;
        [FieldAttr(nst: 96, ctr: 80)] public bool _ignorePointOfInterestDistances;
        [FieldAttr(nst: 97, ctr: 81)] public bool _ignoreAngleLimits;
        [FieldAttr(nst: 98, ctr: 82)] public bool _disableProceduralAnimation;
    }
}
