using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkbStateMachineTimeInterval : hkObject
    {
        public override uint Hash => 0x60a881e5;

        [FieldAttr(nst: 0, ctr: 0)] public int _enterEventId;
        [FieldAttr(nst: 4, ctr: 4)] public int _exitEventId;
        [FieldAttr(nst: 8, ctr: 8)] public float _enterTime;
        [FieldAttr(nst: 12, ctr: 12)] public float _exitTime;
    }
}