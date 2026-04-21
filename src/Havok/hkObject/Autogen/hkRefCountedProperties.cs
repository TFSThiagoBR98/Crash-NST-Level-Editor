using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkRefCountedProperties : hkObject
    {
        public override uint Hash => 0x7c574867;

        [FieldAttr(nst: 0, ctr: 0)] public hkMemory<hkRefCountedPropertiesEntry> _entries;
    }
}