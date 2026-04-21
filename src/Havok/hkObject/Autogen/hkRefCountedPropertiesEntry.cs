using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkRefCountedPropertiesEntry : hkObject
    {
        public override uint Hash => 0x28ef93ed;

        [FieldAttr(nst: 0, ctr: 0)] public hkReferencedObject? _object;
        [FieldAttr(nst: 8, ctr: 8)] public u16 _key;
        [FieldAttr(nst: 10, ctr: 10)] public u16 _flags;
    }
}