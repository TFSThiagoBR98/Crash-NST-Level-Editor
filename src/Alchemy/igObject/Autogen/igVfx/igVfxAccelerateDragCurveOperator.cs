namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 112, align: 8)]
    public class igVfxAccelerateDragCurveOperator : igVfxAccelerateDragBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _drag = new();
        [FieldAttr(nst: 116, ctr: 104)] public EOperatorCurveInput _dragInput;
    }
}
