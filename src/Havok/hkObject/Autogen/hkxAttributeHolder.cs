using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 32, ctr: 32)]
    public class hkxAttributeHolder : hkReferencedObject
    {
        public override uint Hash => 0xfc72021b;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkxAttributeGroup> _attributeGroups;
    }
}