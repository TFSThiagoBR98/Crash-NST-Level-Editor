namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CCollectibleTracker : igObject
    {
        [FieldAttr(ctr: 12)] public u8 _maxCollectedCount;
        [FieldAttr(ctr: 13)] public u8 _collectedCount;
        [FieldAttr(ctr: 16)] public CCollectibleTrackerEventDelegate? _onCollectibleTrackerCollected;
        [FieldAttr(ctr: 24)] public CCollectibleTrackerEventList? _onCollectibleTrackerCollectedEventList;
    }
}
