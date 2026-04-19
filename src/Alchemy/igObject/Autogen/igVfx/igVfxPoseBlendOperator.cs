namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 112, align: 8)]
    public class igVfxPoseBlendOperator : igVfxOperator
    {
        [ObjectAttr(size: 4)]
        public class BlendFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _endpoint1 = EReferenceFrame.eRF_Track1;
            [FieldAttr(offset: 4, size: 4)] public EReferenceFrame _endpoint2 = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 8, size: 1)] public bool _blendOrientation = false;
            [FieldAttr(offset: 9, size: 1)] public bool _blendPosition = false;
        }

        [FieldAttr(nst: 24, ctr: 16)] public BlendFlags _blendFlags = new();
        [FieldAttr(nst: 28, ctr: 20)] public igVfxRangedCurveMetaField _blend = new();
        [FieldAttr(nst: 112, ctr: 104)] public EOperatorCurveInput _blendInput;
    }
}
