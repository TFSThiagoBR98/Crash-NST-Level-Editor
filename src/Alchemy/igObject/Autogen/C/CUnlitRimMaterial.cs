namespace Alchemy
{
    [ObjectAttr(nst: 320, ctr: 304, align: 16)]
    public class CUnlitRimMaterial : CUnlitMaterial
    {
        public enum ERampShape
        {
            eRS_ClampFacing = 0,
            eRS_ClampGlancing = 1,
            eRS_ClampPeak = 2,
        }

        [ObjectAttr(size: 4)]
        public class TextureRimBitfield : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _textureCompression_palette;
            [FieldAttr(offset: 1, size: 1)] public bool _textureMips_palette;
            [FieldAttr(offset: 2, size: 1)] public bool _flipFacing;
            [FieldAttr(offset: 3, size: 1)] public bool _wrapToBack;
            [FieldAttr(offset: 4, size: 1)] public bool _facingPalettized;
            [FieldAttr(offset: 5, size: 1)] public bool _palettized;
            [FieldAttr(offset: 6, size: 1)] public bool _depthBlendingPalettized;
        }

        [FieldAttr(nst: 256, ctr: 252)] public TextureRimBitfield _textureRimBitfield = new();
        [FieldAttr(nst: 264, ctr: 256)] public string? _textureName_palette = null;
        [FieldAttr(nst: 272, ctr: 264)] public ERampShape _rampShape = CUnlitRimMaterial.ERampShape.eRS_ClampPeak;
        [FieldAttr(nst: 276, ctr: 268)] public float _facingAngle = 75.0f;
        [FieldAttr(nst: 288, ctr: 272)] public igVec4fMetaField _facingFactors = new();
        [FieldAttr(nst: 304, ctr: 288)] public float _facingCutoff;
    }
}
