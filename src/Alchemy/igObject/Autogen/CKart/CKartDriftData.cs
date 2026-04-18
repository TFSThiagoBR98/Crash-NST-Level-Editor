namespace Alchemy
{
    [ObjectAttr(ctr: 240, align: 8)]
    public class CKartDriftData : igObject
    {
        [FieldAttr(ctr: 12)] public float _groundDistanceActivation;
        [FieldAttr(ctr: 16)] public float _minDriftActivationVelocityRatio;
        [FieldAttr(ctr: 20)] public float _driftStickMinDeflection;
        [FieldAttr(ctr: 24)] public float _maxCorneringTime;
        [FieldAttr(ctr: 28)] public float _maxCounterTime;
        [FieldAttr(ctr: 32)] public float _driftBoostGaugeFillTime;
        [FieldAttr(ctr: 36)] public float _driftBoostAvailableRatio;
        [FieldAttr(ctr: 40)] public CKartDriftBoostList? _driftBoostList;
        [FieldAttr(ctr: 48)] public CKartDriftTrajectory? _trajectory;
        [FieldAttr(ctr: 56)] public float _maxTurnAngularOffset;
        [FieldAttr(ctr: 60)] public float _turnOffsetFadeInDuration;
        [FieldAttr(ctr: 64)] public igVfxRangedCurveMetaField _turnOffsetFadeInCurve = new();
        [FieldAttr(ctr: 148)] public float _turnOffsetFadeOutDuration;
        [FieldAttr(ctr: 152)] public igVfxRangedCurveMetaField _turnOffsetFadeOutCurve = new();
        [FieldAttr(ctr: 236)] public float _driftOutForwardRotateFactor;
    }
}
