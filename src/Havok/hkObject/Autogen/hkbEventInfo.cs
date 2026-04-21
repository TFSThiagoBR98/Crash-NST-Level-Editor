using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 4, ctr: 4)]
    public class hkbEventInfo : hkObject
    {
        public override uint Hash => 0x5874eed4;

        [FieldAttr(nst: 0, ctr: 0)] public EFlags _flags;
    }
}