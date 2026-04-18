namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 4)]
    public class igVfxCurveInputStepOperator : igVfxOperator
    {
        [FieldAttr(nst: 24)] public int _stepCount = 3;
        [FieldAttr(nst: 28)] public EOperatorCurveInput _input;
        [FieldAttr(nst: 32)] public EOperatorCurveOutput _output = EOperatorCurveOutput.kSetTrackParameter1;
    }
}
