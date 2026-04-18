namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 32, align: 8)]
    public class igVfxCurveInputByVelocityOperator : igVfxFrameOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public EOperatorCurveOutput _outputParameter = EOperatorCurveOutput.kSetTrackParameter1;
        [FieldAttr(nst: 36, ctr: 24)] public float _minVelocity;
        [FieldAttr(nst: 40, ctr: 28)] public float _maxVelocity = 100.0f;
    }
}
