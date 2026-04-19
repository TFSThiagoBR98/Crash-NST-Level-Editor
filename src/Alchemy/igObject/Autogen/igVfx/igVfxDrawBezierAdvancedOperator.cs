namespace Alchemy
{
    [ObjectAttr(nst: 848, ctr: 832, align: 16)]
    public class igVfxDrawBezierAdvancedOperator : igVfxDrawProcGeometryOperator
    {
        [ObjectAttr(size: 4)]
        public class BezierFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 5)] public int _segmentCount = 17;
            [FieldAttr(offset: 5, size: 1)] public bool _scaleHandles = false;
            [FieldAttr(offset: 6, size: 4)] public EOperatorCurveInput _offsetInput;
            [FieldAttr(offset: 10, size: 3)] public EigVfxCurveCorrelation _offsetCorrelation;
            [FieldAttr(offset: 13, size: 1)] public bool _isBillboard = false;
            [FieldAttr(offset: 14, size: 4)] public EReferenceFrame _endpoint1 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 18, size: 4)] public EReferenceFrame _handleEndpoint1 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 22, size: 4)] public EReferenceFrame _endpoint2 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 26, size: 4)] public EReferenceFrame _handleEndpoint2 = EReferenceFrame.eRF_World;
        }

        [ObjectAttr(size: 4)]
        public class BezierFlags2 : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EModulation _widthAlongLengthModulation = EModulation.kModulate;
            [FieldAttr(offset: 3, size: 1)] public bool _scaleSideOffset = false;
            [FieldAttr(offset: 4, size: 3)] public EModulation _colorAlongLengthModulation = EModulation.kReplace;
            [FieldAttr(offset: 7, size: 3)] public EModulation _alphaAlongLengthModulation = EModulation.kReplace;
        }

        [FieldAttr(nst: 80, ctr: 60)] public BezierFlags _bezierFlags = new();
        [FieldAttr(nst: 84, ctr: 64)] public BezierFlags2 _bezierFlags2 = new();
        [FieldAttr(nst: 88, ctr: 68)] public igRangedVectorMetaField _startHandle = new();
        [FieldAttr(nst: 112, ctr: 92)] public igRangedVectorMetaField _endHandle = new();
        [FieldAttr(nst: 136, ctr: 116)] public igVfxRangedCurveMetaField _startOffset = new();
        [FieldAttr(nst: 220, ctr: 200)] public igVfxRangedCurveMetaField _endOffset = new();
        [FieldAttr(nst: 304, ctr: 284)] public bool _unhinged;
        [FieldAttr(nst: 308, ctr: 288)] public igVfxRangedCurveMetaField _widthAlongLength = new();
        [FieldAttr(nst: 392, ctr: 372)] public igVfxRangedCurveMetaField _sideOffsetAlongLength = new();
        [FieldAttr(nst: 480, ctr: 464)] public igVfxRgbCurveMetaField _colorAlongLength = new();
        [FieldAttr(nst: 752, ctr: 736)] public igVfxRangedCurveMetaField _alphaAlongLength = new();
    }
}
