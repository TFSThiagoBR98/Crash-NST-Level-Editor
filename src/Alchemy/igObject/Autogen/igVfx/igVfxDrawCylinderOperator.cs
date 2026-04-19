namespace Alchemy
{
    [ObjectAttr(nst: 432, ctr: 408, align: 8)]
    public class igVfxDrawCylinderOperator : igVfxDrawProcGeometryOperator
    {
        [ObjectAttr(size: 4)]
        public class CylinderFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public EigVfxCurveCorrelation _offsetCorrelation;
            [FieldAttr(offset: 3, size: 4)] public EReferenceFrame _endpoint1 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 7, size: 4)] public EReferenceFrame _endpoint2 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 11, size: 1)] public bool _alignNormalsToCap;
        }

        [FieldAttr(nst: 80, ctr: 60)] public CylinderFlags _cylinderFlags = new();
        [FieldAttr(nst: 84, ctr: 64)] public igVfxRangedCurveMetaField _startOffset = new();
        [FieldAttr(nst: 168, ctr: 148)] public igVfxRangedCurveMetaField _endOffset = new();
        [FieldAttr(nst: 252, ctr: 232)] public EOperatorCurveInput _offsetInput;
        [FieldAttr(nst: 256, ctr: 236)] public igVfxRangedCurveMetaField _startArcAngle = new();
        [FieldAttr(nst: 340, ctr: 320)] public igVfxRangedCurveMetaField _endArcAngle = new();
        [FieldAttr(nst: 424, ctr: 404)] public EOperatorCurveInput _arcAngleInput;
    }
}
