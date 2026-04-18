namespace Alchemy
{
    [ObjectAttr(nst: 256, ctr: 240, align: 8)]
    public class igVfxDrawLineOperator : igVfxDrawProcGeometryOperator
    {
        [ObjectAttr(size: 4)]
        public class LineFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EigVfxCurveCorrelation _offsetCorrelation;
            [FieldAttr(offset: 3, size: 4)] public EReferenceFrame _endpoint1;
            [FieldAttr(offset: 7, size: 4)] public EReferenceFrame _endpoint2;
            [FieldAttr(offset: 11, size: 1)] public bool _fastNormals;
        }

        [FieldAttr(nst: 80, ctr: 60)] public LineFlags _lineFlags = new();
        [FieldAttr(nst: 84, ctr: 64)] public igVfxRangedCurveMetaField _startOffset = new();
        [FieldAttr(nst: 168, ctr: 148)] public igVfxRangedCurveMetaField _endOffset = new();
        [FieldAttr(nst: 252, ctr: 232)] public EOperatorCurveInput _offsetInput;
    }
}
