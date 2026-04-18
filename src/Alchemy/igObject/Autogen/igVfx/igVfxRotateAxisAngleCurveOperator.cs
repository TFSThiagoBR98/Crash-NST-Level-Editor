namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 16)]
    public class igVfxRotateAxisAngleCurveOperator : igVfxRotateAxisAngleBaseOperator
    {
        [FieldAttr(nst: 48, ctr: 48)] public igVfxRangedCurveMetaField _angle = new();
        [FieldAttr(nst: 132, ctr: 132)] public EOperatorCurveInput _angleInput;
    }
}
