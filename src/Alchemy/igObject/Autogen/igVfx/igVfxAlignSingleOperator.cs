namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 16)]
    public class igVfxAlignSingleOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class AlignFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _sourceFrame = EReferenceFrame.eRF_Camera;
            [FieldAttr(offset: 4, size: 3)] public ESourceAxis _sourceAxis = ESourceAxis.eSA_XAxis;
            [FieldAttr(offset: 7, size: 1)] public bool _flip1;
        }

        [FieldAttr(nst: 24, ctr: 16)] public AlignFlags _alignFlags = new();
        [FieldAttr(nst: 32, ctr: 32)] public igVec3fAlignedMetaField _axis = new();
    }
}
