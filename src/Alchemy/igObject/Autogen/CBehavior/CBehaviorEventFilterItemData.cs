namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CBehaviorEventFilterItemData : igObject
    {
        public enum EFilterType
        {
            eFT_RemoveEvents = 0,
            eFT_KeepEvents = 1,
        }

        [FieldAttr(nst: 16, ctr: 16)] public igStringIntHashTable? _triggerEvents;
        [FieldAttr(nst: 24, ctr: 24)] public igStringIntHashTable? _eventsToFilter;
        [FieldAttr(nst: 32, ctr: 32)] public EFilterType _filterType;
    }
}
