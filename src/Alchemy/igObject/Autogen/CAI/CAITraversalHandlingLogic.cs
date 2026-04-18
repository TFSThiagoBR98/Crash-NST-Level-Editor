namespace Alchemy
{
    [ObjectAttr(nst: 184, align: 8)]
    public class CAITraversalHandlingLogic : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public float _turnRate = 360.0f;
        [FieldAttr(nst: 84)] public float _turnRateStopped = 360.0f;
        [FieldAttr(nst: 88)] public float _minAnimatedTurnAngle = 10.0f;
        [FieldAttr(nst: 92)] public float _runStickThreshold = 0.4f;
        [FieldAttr(nst: 96)] public float _walkStickThreshold;
        [FieldAttr(nst: 100)] public float _turnStickThreshold;
        [FieldAttr(nst: 104)] public string? _runEvent = "Run";
        [FieldAttr(nst: 112)] public string? _walkEvent = "Walk";
        [FieldAttr(nst: 120)] public string? _idleEvent = "Idle";
        [FieldAttr(nst: 128)] public string? _turnInPlaceClockwiseEvent = "Turn_InPlaceCW";
        [FieldAttr(nst: 136)] public string? _turnInPlaceCounterClockwiseEvent = "Turn_InPlaceCCW";
        [FieldAttr(nst: 144)] public string? _runState = "Run";
        [FieldAttr(nst: 152)] public string? _walkState = "Walk";
        [FieldAttr(nst: 160)] public string? _idleState = "Idle";
        [FieldAttr(nst: 168)] public string? _turnInPlaceClockwiseState = "Turn_InPlaceCW";
        [FieldAttr(nst: 176)] public string? _turnInPlaceCounterClockwiseState = "Turn_InPlaceCCW";
    }
}
