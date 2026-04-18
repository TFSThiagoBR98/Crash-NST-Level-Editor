namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVfxTranslateApplyBoltSizeOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public EReferenceFrame _relativeTo = EReferenceFrame.eRF_Bolt1;
        [FieldAttr(nst: 28, ctr: 20)] public EReferenceFrame _withSizeFrom = EReferenceFrame.eRF_Bolt1;
    }
}
