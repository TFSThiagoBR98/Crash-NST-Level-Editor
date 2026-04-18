namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class igVfxCurveInputLifetimeScaleOperator : igVfxOperator
    {
        [FieldAttr(ctr: 16)] public igVfxRangedCurveMetaField _lifetimeScale = new();
        [FieldAttr(ctr: 100)] public EOperatorCurveInput _inputParameter;
    }
}
