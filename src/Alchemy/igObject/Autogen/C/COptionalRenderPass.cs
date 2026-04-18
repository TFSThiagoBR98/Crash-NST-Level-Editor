namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class COptionalRenderPass : igRenderPass
    {
        [FieldAttr(nst: 56, ctr: 56)] public COptionalRenderPassEnabledDataHandleList? _enabledDataList;
    }
}
