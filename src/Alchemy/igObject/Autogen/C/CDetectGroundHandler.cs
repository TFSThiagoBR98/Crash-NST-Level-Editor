namespace Alchemy
{
    [ObjectAttr(nst: 160, ctr: 144, align: 8)]
    public class CDetectGroundHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80, ctr: 64)] public bool _enableFallEvent = true;
        [FieldAttr(nst: 84, ctr: 68)] public float _noGroundFallTime = 0.1f;
        [FieldAttr(nst: 88, ctr: 72)] public float _noGroundFallTimeWhenAttacking;
        [FieldAttr(nst: 92, ctr: 76)] public float _maxGroundDistance = 15.0f;
        [FieldAttr(nst: 96, ctr: 80)] public float _minGroundDistance = -12.0f;
        [FieldAttr(nst: 100, ctr: 84)] public float _enableJumpBufferingGroundDistance = 15.0f;
        [FieldAttr(nst: 104, ctr: 88)] public float _traceDistance = 400.0f;
        [FieldAttr(nst: 108, ctr: 92)] public float _fallInitialVelocity = 1400.0f;
        [FieldAttr(nst: 112, ctr: 96)] public float _supportRadius = 16.0f;
        [FieldAttr(nst: 116, ctr: 100)] public float _groundSlideSpeed = 300.0f;
        [FieldAttr(nst: 120, ctr: 104)] public float _airSlideSpeed = 100.0f;
        [FieldAttr(nst: 128, ctr: 112)] public string? _locomotionState = "Locomotion";
        [FieldAttr(nst: 136, ctr: 120)] public string? _airLocomotionState = "AirLocomotion";
        [FieldAttr(nst: 144, ctr: 128)] public string? _landState = "Land";
        [FieldAttr(nst: 152, ctr: 136)] public float _ledgeDistance = 50.0f;
        [FieldAttr(nst: 156, ctr: 140)] public float _blockerHeightThreshold = 25.0f;
    }
}
