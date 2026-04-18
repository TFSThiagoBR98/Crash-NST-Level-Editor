namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxCurveInputRandomOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public EOperatorCurveOutput _output = EOperatorCurveOutput.kSetTrackParameter1;
    }
}
