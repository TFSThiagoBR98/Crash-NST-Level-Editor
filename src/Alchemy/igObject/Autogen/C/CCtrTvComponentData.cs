namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CCtrTvComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public string? _CtrTvIntroName;
        [FieldAttr(ctr: 24)] public string? _CtrTvGPName;
    }
}
