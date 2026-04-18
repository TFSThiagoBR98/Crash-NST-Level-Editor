namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class COctanePlayerCountFilter : igObject
    {
        [FieldAttr(ctr: 16)] public string? _filter;
        [FieldAttr(ctr: 24)] public igIntList? _validPlayerCounts;
    }
}
