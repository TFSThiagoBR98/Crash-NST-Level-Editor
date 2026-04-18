namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8, meta: true)]
    public class CEntityMessage : Object
    {
        public enum ENetworkSendRestriction
        {
            eNSR_Local = 0,
            eNSR_FromAuthorityToAll = 1,
            eNSR_FromAuthorityToAllReliable = 2,
            eNSR_FromCreatorAuthorityToAll = 3,
            eNSR_FromHostToAll = 4,
            eNSR_FromHostToAllReliable = 5,
            eNSR_Broadcast = 6,
            eNSR_BroadcastReliable = 7,
        }

        [FieldAttr(nst: 32, ctr: 32)] public igHandleMetaField _sender = new();
        [FieldAttr(nst: 40, ctr: 40)] public ENetworkSendRestriction _networkSendRestriction;
        [FieldAttr(nst: 44, ctr: 44)] public bool _networkJoinInProgress;
        [FieldAttr(nst: 48, ctr: 48)] public string? _networkJoinInProgressGroup = "default";
    }
}
