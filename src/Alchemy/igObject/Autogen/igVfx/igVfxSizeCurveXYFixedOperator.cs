namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 8)]
    public class igVfxSizeCurveXYFixedOperator : igVfxSizeBaseOperator
    {
        [FieldAttr(ctr: 20)] public float _sizeX;
        [FieldAttr(ctr: 24)] public float _sizeY;
        [FieldAttr(ctr: 28)] public igVfxRangedCurveMetaField _sizeZ = new();
        [FieldAttr(ctr: 112)] public EOperatorCurveInput _sizeInput;
        [FieldAttr(ctr: 116)] public EigVfxCurveCorrelation _sizeCorrelation;
    }
}
