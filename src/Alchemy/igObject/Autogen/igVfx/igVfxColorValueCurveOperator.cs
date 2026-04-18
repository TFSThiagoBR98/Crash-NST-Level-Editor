namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class igVfxColorValueCurveOperator : igVfxColorValueBaseOperator
    {
        [FieldAttr(ctr: 24)] public igVfxRangedCurveMetaField _amount = new();
        [FieldAttr(ctr: 108)] public EOperatorCurveInput _inputParameter;
    }
}
