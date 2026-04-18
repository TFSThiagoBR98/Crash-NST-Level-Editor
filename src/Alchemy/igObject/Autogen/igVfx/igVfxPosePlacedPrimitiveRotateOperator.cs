namespace Alchemy
{
    [ObjectAttr(nst: 272, ctr: 256, align: 8)]
    public class igVfxPosePlacedPrimitiveRotateOperator : igVfxPosePlacedPrimitiveRotateOperatorBase
    {
        [FieldAttr(nst: 104, ctr: 84)] public igVfxRangedCurveMetaField _rotationAngle = new();
        [FieldAttr(nst: 188, ctr: 168)] public igVfxRangedCurveMetaField _rotationRadius = new();
    }
}
