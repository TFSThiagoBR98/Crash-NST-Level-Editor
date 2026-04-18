namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 4)]
    public class igBlendFunctionAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public EIG_GFX_BLENDING_FUNCTION _src = EIG_GFX_BLENDING_FUNCTION.SOURCE_ALPHA;
        [FieldAttr(nst: 28, ctr: 24)] public EIG_GFX_BLENDING_FUNCTION _dst = EIG_GFX_BLENDING_FUNCTION.ONE_MINUS_SOURCE_ALPHA;
        [FieldAttr(nst: 32, ctr: 28)] public EIG_GFX_BLENDING_EQUATION _eq;
        [FieldAttr(nst: 36, ctr: 32)] public uint _unused;
        [FieldAttr(nst: 40, ctr: 36)] public u8 _blendConstant;
        [FieldAttr(nst: 42, ctr: 38)] public i16 _blendStage;
        [FieldAttr(nst: 44, ctr: 40)] public uint _blendA;
        [FieldAttr(nst: 48, ctr: 44)] public uint _blendB;
        [FieldAttr(nst: 52, ctr: 48)] public uint _blendC;
        [FieldAttr(nst: 56, ctr: 52)] public uint _blendD;
    }
}
