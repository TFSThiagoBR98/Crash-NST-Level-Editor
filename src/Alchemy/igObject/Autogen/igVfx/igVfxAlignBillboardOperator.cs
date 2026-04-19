namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 48, align: 16)]
    public class igVfxAlignBillboardOperator : igVfxFrameOperator
    {
        [ObjectAttr(size: 4)]
        public class AlignFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _axisAligned;
            [FieldAttr(offset: 1, size: 1)] public bool _viewPlaneAligned = false;
        }

        [FieldAttr(nst: 32, ctr: 20)] public AlignFlags _alignFlags = new();
        [FieldAttr(nst: 48, ctr: 32)] public igVec3fAlignedMetaField _axis = new();
    }
}
