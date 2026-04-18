namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 4)]
    public class igDepthFunctionAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public EIG_GFX_DEPTH_TEST_FUNCTION _func = EIG_GFX_DEPTH_TEST_FUNCTION.LEQUAL;
    }
}
