using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkxAttributeGroup : hkObject
    {
        public override uint Hash => 0x345ca95d;

        [FieldAttr(nst: 0, ctr: 0)] public string? _name;
        [FieldAttr(nst: 8, ctr: 8)] public hkMemory<hkxAttribute> _attributes;
    }
}