namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 4)]
    public class igStencilFunctionAttr : igVisualAttribute
    {
        [FieldAttr(nst: 24, ctr: 20)] public uint _refVal;
        [FieldAttr(nst: 28, ctr: 24)] public EIG_GFX_STENCIL_FUNCTION _func = EIG_GFX_STENCIL_FUNCTION.ALWAYS;
        [FieldAttr(nst: 32, ctr: 28)] public uint _writeMask = 4294967295;
        [FieldAttr(nst: 36, ctr: 32)] public uint _readMask = 4294967295;
        [FieldAttr(nst: 40, ctr: 36)] public EIG_GFX_STENCIL_OPERATION _stenFailOp;
        [FieldAttr(nst: 44, ctr: 40)] public EIG_GFX_STENCIL_OPERATION _stenPassZPassOp;
        [FieldAttr(nst: 48, ctr: 44)] public EIG_GFX_STENCIL_OPERATION _stenPassZFailOp;
    }
}
