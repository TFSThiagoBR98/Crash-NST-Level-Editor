namespace Alchemy
{
    [ObjectAttr(nst: 136, ctr: 120, align: 8)]
    public class igVfxSizeCurveYZFixedOperator : igVfxSizeBaseOperator
    {
        [FieldAttr(nst: 32, ctr: 20)] public igVfxRangedCurveMetaField _sizeX = new();
        [FieldAttr(nst: 116, ctr: 104)] public float _sizeY = 1.0f;
        [FieldAttr(nst: 120, ctr: 108)] public float _sizeZ = 1.0f;
        [FieldAttr(nst: 124, ctr: 112)] public EOperatorCurveInput _sizeInput;
        [FieldAttr(nst: 128, ctr: 116)] public EigVfxCurveCorrelation _sizeCorrelation = EigVfxCurveCorrelation.kAspectRatio;
    }
}
