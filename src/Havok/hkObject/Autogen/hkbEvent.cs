using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkbEvent : hkbEventBase
    {
        public override uint Hash => 0x3e0fd810;

        [FieldAttr(nst: 16, ctr: 16)] public hkbNode? _sender;
    }
}