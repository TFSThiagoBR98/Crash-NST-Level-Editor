namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CKartDriftTrajectory : igObject
    {
        [FieldAttr(ctr: 16)] public CKartDriftTrajectoryStep? _startStep;
        [FieldAttr(ctr: 24)] public float _startStepHoldTime;
        [FieldAttr(ctr: 28)] public float _startToMidBlendDuration;
        [FieldAttr(ctr: 32)] public CKartDriftTrajectoryStep? _midStep;
        [FieldAttr(ctr: 40)] public float _midStepHoldTime;
        [FieldAttr(ctr: 44)] public float _midToEndBlendDuration;
        [FieldAttr(ctr: 48)] public CKartDriftTrajectoryStep? _endStep;
    }
}
