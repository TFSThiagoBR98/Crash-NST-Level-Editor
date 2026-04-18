namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class igAlphaBlendFunctionAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public EIG_GFX_BLENDING_FUNCTION _source = EIG_GFX_BLENDING_FUNCTION.SOURCE_ALPHA;
        [FieldAttr(nst: 28, ctr: 24)] public EIG_GFX_BLENDING_FUNCTION _destination = EIG_GFX_BLENDING_FUNCTION.ONE_MINUS_SOURCE_ALPHA;
        [FieldAttr(nst: 32, ctr: 28)] public EIG_GFX_BLENDING_EQUATION _equation;
    }
}
