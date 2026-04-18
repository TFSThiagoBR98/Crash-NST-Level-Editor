namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class igVfxCurveInputModulateFixedOperator : igVfxOperator
    {
        [FieldAttr(ctr: 16)] public EOperatorCurveInput _inputParameter;
        [FieldAttr(ctr: 20)] public EModulation _modulation;
        [FieldAttr(ctr: 24)] public float _modulationParameter;
        [FieldAttr(ctr: 28)] public EOperatorCurveOutput _outputParameter;
    }
}
