namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 16)]
    public class igVfxTranslateDistanceCurveOperator : igVfxFrameOperator
    {
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fAlignedMetaField _direction = new();
        [FieldAttr(nst: 48, ctr: 48)] public igVfxRangedCurveMetaField _distance = new();
        [FieldAttr(nst: 132, ctr: 132)] public EOperatorCurveInput _distanceInput;
    }
}
