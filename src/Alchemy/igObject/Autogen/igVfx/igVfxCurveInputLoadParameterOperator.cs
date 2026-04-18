namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxCurveInputLoadParameterOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public EOperatorCurveOutput _outputParameter = EOperatorCurveOutput.kSetTrackParameter1;
        [FieldAttr(nst: 28, ctr: 20)] public int _index = 1;
    }
}
