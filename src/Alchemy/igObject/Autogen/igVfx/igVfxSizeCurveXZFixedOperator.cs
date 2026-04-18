namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 8)]
    public class igVfxSizeCurveXZFixedOperator : igVfxSizeBaseOperator
    {
        [FieldAttr(ctr: 20)] public float _sizeX;
        [FieldAttr(ctr: 24)] public igVfxRangedCurveMetaField _sizeY = new();
        [FieldAttr(ctr: 108)] public float _sizeZ;
        [FieldAttr(ctr: 112)] public EOperatorCurveInput _sizeInput;
        [FieldAttr(ctr: 116)] public EigVfxCurveCorrelation _sizeCorrelation;
    }
}
