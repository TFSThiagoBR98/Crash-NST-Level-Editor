namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 8)]
    public class CCollectibleTrackerSystemData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CCollectibleTrackerListList? _collectibles;
    }
}
