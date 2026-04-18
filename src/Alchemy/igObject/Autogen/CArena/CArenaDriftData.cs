namespace Alchemy
{
    [ObjectAttr(nst: 136, align: 8)]
    public class CArenaDriftData : CDriftData
    {
        [FieldAttr(nst: 72)] public bool _canDriftInAir;
        [FieldAttr(nst: 76)] public float _speedRequiredForArenaDrifting = 1000.0f;
        [FieldAttr(nst: 80)] public float _timeOfNoStickInputToEnd = 0.25f;
        [FieldAttr(nst: 84)] public int _numberOfSpinOutsToCancelDrift = 4;
        [FieldAttr(nst: 88)] public CBoltPoint? _pivot;
        [FieldAttr(nst: 96)] public float _timeToMaxPivot = 0.1f;
        [FieldAttr(nst: 100)] public float _spinOutForwardAngleStartThreshold = 75.0f;
        [FieldAttr(nst: 104)] public float _spinOutAccelerationAngleStartThreshold = 75.0f;
        [FieldAttr(nst: 108)] public float _spinOutForwardAngleStopThreshold = 10.0f;
        [FieldAttr(nst: 112)] public float _spinOutAccelerationAngleStopThreshold = 30.0f;
        [FieldAttr(nst: 116)] public float _minForwardSpeed = 1000.0f;
        [FieldAttr(nst: 120)] public float _maxForceForwardSpeed = 200.0f;
        [FieldAttr(nst: 124)] public float _driftDurationForBoostLevel2 = 0.5f;
        [FieldAttr(nst: 128)] public float _driftDurationForBoostLevel3 = 3.0f;
    }
}
