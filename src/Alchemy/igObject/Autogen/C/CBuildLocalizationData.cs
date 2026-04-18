namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CBuildLocalizationData : igObject
    {
        [FieldAttr(ctr: 16)] public igIntList? _languages;
        [FieldAttr(ctr: 24)] public string? _region;
        [FieldAttr(ctr: 32)] public string? _skuName;
    }
}
