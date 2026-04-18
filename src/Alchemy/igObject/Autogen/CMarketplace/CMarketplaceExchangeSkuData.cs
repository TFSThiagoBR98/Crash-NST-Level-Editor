namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CMarketplaceExchangeSkuData : igObject
    {
        [FieldAttr(ctr: 12)] public uint _exchangeSkuID;
        [FieldAttr(ctr: 16)] public igHandleMetaField _product = new();
        [FieldAttr(ctr: 24)] public u16 _bitfield;
        [FieldAttr(ctr: 32)] public string? _platform;
        [FieldAttr(ctr: 40)] public igStringStringHashTable? _platformData;
    }
}
