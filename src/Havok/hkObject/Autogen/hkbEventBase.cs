using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkbEventBase : hkObject
    {
        public override uint Hash => 0x76bddb31;

        [FieldAttr(nst: 0, ctr: 0)] public int _id;
        [FieldAttr(nst: 8, ctr: 8)] public hkbEventPayload? _payload;
    }
}