namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxAlignLineBillboardOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class AlignFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _endpoint1;
            [FieldAttr(offset: 4, size: 4)] public EReferenceFrame _endpoint2;
            [FieldAttr(offset: 8, size: 1)] public bool _axisAligned;
            [FieldAttr(offset: 9, size: 1)] public bool _viewPlaneAligned;
        }

        [FieldAttr(nst: 24, ctr: 16)] public AlignFlags _alignFlags = new();
    }
}
