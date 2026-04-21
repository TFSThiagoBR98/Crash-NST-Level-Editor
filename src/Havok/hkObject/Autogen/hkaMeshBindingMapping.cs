using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkaMeshBindingMapping : hkObject
    {
        public override uint Hash => 0x48aceb75;

        [FieldAttr(nst: 0, ctr: 0)] public hkMemory<i16> _mapping;
    }
}