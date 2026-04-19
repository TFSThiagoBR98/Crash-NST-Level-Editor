namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxAlignDualOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class AlignFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 2)] public ETargetAxis _targetAxis1 = ETargetAxis.eTA_ZAxis;
            [FieldAttr(offset: 2, size: 4)] public EReferenceFrame _sourceFrame1 = EReferenceFrame.eRF_Camera;
            [FieldAttr(offset: 6, size: 3)] public ESourceAxis _sourceAxis1 = ESourceAxis.eSA_XAxis;
            [FieldAttr(offset: 9, size: 1)] public bool _flip1;
            [FieldAttr(offset: 10, size: 2)] public ETargetAxis _targetAxis2 = ETargetAxis.eTA_XAxis;
            [FieldAttr(offset: 12, size: 4)] public EReferenceFrame _sourceFrame2 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 16, size: 3)] public ESourceAxis _sourceAxis2 = ESourceAxis.eSA_XAxis;
            [FieldAttr(offset: 19, size: 1)] public bool _flip2;
            [FieldAttr(offset: 20, size: 1)] public bool _secondAxisPriority;
        }

        [FieldAttr(nst: 24, ctr: 16)] public AlignFlags _alignFlags = new();
    }
}
