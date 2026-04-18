namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxFrameOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public EReferenceFrame _frame = EReferenceFrame.eRF_Instance;
    }
}
