namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxAlignLineBillboardOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class AlignFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _endpoint1 = EReferenceFrame.eRF_Track1;
            [FieldAttr(offset: 4, size: 4)] public EReferenceFrame _endpoint2 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 8, size: 1)] public bool _axisAligned = false;
            [FieldAttr(offset: 9, size: 1)] public bool _viewPlaneAligned = false;
        }

        [FieldAttr(nst: 24, ctr: 16)] public AlignFlags _alignFlags = new();
    }
}
