namespace Alchemy
{
    [ObjectAttr(nst: 296, ctr: 280, align: 8)]
    public class igVfxSizeCurveOperator : igVfxSizeBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _sizeX = new();
        [FieldAttr(nst: 116, ctr: 104)] public igVfxRangedCurveMetaField _sizeY = new();
        [FieldAttr(nst: 200, ctr: 188)] public igVfxRangedCurveMetaField _sizeZ = new();
        [FieldAttr(nst: 284, ctr: 272)] public EOperatorCurveInput _sizeInput;
        [FieldAttr(nst: 288, ctr: 276)] public EigVfxCurveCorrelation _sizeCorrelation = EigVfxCurveCorrelation.kAspectRatio;
    }
}
