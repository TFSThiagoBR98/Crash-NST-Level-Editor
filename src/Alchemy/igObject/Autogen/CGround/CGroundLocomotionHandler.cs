namespace Alchemy
{
    [ObjectAttr(nst: 184, ctr: 168, align: 8)]
    public class CGroundLocomotionHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80, ctr: 64)] public float _transitionTimeToWalkState = 0.05f;
        [FieldAttr(nst: 84, ctr: 68)] public float _transitionTimeToIdleState = 0.05f;
        [FieldAttr(nst: 88, ctr: 72)] public float _runTimeForStop = 1.0f;
        [FieldAttr(nst: 96, ctr: 80)] public string? _idleEventName = "Idle";
        [FieldAttr(nst: 104, ctr: 88)] public string? _walkEventName = "Walk";
        [FieldAttr(nst: 112, ctr: 96)] public string? _runEventName = "Run";
        [FieldAttr(nst: 120, ctr: 104)] public string? _runStopEventName = "Run_Stop";
        [FieldAttr(nst: 128, ctr: 112)] public string? _idleStateName = "Idle";
        [FieldAttr(nst: 136, ctr: 120)] public string? _walkStateName = "Walk";
        [FieldAttr(nst: 144, ctr: 128)] public string? _runStateName = "Run";
        [FieldAttr(nst: 152, ctr: 136)] public string? _runStopStateName = "Run_Stop";
        [FieldAttr(nst: 160, ctr: 144)] public string? _landStateName = "Land";
        [FieldAttr(nst: 168, ctr: 152)] public string? _landRunningStateName = "Land_Running";
        [FieldAttr(nst: 176, ctr: 160)] public string? _runToIdleStateName = "Run to Idle";
    }
}
