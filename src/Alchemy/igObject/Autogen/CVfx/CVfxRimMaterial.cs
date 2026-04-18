namespace Alchemy
{
    [ObjectAttr(nst: 320, align: 16)]
    public class CVfxRimMaterial : CVfxMaterial
    {
        public enum ERampShape
        {
            eRS_ClampFacing = 0,
            eRS_ClampGlancing = 1,
            eRS_ClampPeak = 2,
        }

        [ObjectAttr(size: 4)]
        public class VfxRimMaterialBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _facingPalettized;
            [FieldAttr(offset: 1, size: 1)] public bool _flipFacing;
        }

        [FieldAttr(nst: 272)] public VfxRimMaterialBitfield _vfxRimMaterialBitfield = new();
        [FieldAttr(nst: 276)] public ERampShape _rampShape = CVfxRimMaterial.ERampShape.eRS_ClampPeak;
        [FieldAttr(nst: 280)] public float _facingAngle = 75.0f;
        [FieldAttr(nst: 288)] public igVec4fMetaField _facingFactors = new();
        [FieldAttr(nst: 304)] public float _facingCutoff;
    }
}
