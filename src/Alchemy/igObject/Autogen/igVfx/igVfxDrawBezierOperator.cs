namespace Alchemy
{
    [ObjectAttr(nst: 312, ctr: 288, align: 8)]
    public class igVfxDrawBezierOperator : igVfxDrawProcGeometryOperator
    {
        [ObjectAttr(size: 4)]
        public class BezierFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 5)] public int _segmentCount = 17;
            [FieldAttr(offset: 5, size: 1)] public bool _scaleHandles = false;
            [FieldAttr(offset: 6, size: 1)] public bool _scaleChaos = false;
            [FieldAttr(offset: 7, size: 3)] public EigVfxCurveCorrelation _offsetCorrelation;
            [FieldAttr(offset: 10, size: 4)] public EReferenceFrame _endpoint1 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 14, size: 4)] public EReferenceFrame _handleEndpoint1 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 18, size: 4)] public EReferenceFrame _endpoint2 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 22, size: 4)] public EReferenceFrame _handleEndpoint2 = EReferenceFrame.eRF_World;
        }

        [FieldAttr(nst: 80, ctr: 60)] public BezierFlags _bezierFlags = new();
        [FieldAttr(nst: 84, ctr: 64)] public igRangedVectorMetaField _startHandle = new();
        [FieldAttr(nst: 108, ctr: 88)] public igRangedVectorMetaField _endHandle = new();
        [FieldAttr(nst: 132, ctr: 112)] public float _chaos;
        [FieldAttr(nst: 136, ctr: 116)] public igVfxRangedCurveMetaField _startOffset = new();
        [FieldAttr(nst: 220, ctr: 200)] public igVfxRangedCurveMetaField _endOffset = new();
        [FieldAttr(nst: 304, ctr: 284)] public EOperatorCurveInput _offsetInput;
    }
}
