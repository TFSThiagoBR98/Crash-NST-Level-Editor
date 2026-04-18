namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 8)]
    public class CMotorcycleDetectGroundHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public float _noGroundFallTime = 0.1f;
        [FieldAttr(nst: 84)] public float _maxGroundDistance = 15.0f;
        [FieldAttr(nst: 88)] public float _minGroundDistance = -12.0f;
        [FieldAttr(nst: 92)] public float _traceDistance = 400.0f;
        [FieldAttr(nst: 96)] public float _fallGravity = -100.0f;
        [FieldAttr(nst: 104)] public CMotorcycleLandEntityMessage? _landedMessage;
        [FieldAttr(nst: 112)] public CMotorcycleLeftGroundEntityMessage? _leftGroundMessage;
    }
}
