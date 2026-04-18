namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CMarketplaceFeaturedSkuCalendar : igObject
    {
        [FieldAttr(ctr: 12)] public igTimeOfDayMetaField _startDate = new();
        [FieldAttr(ctr: 40)] public CMarketplaceSkuListList? _featuredSkus;
    }
}
