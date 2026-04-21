using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkxAttribute : hkObject
    {
        public override uint Hash => 0x7375cae3;

        [FieldAttr(nst: 0, ctr: 0)] public string? _name;
        [FieldAttr(nst: 8, ctr: 8)] public hkReferencedObject? _value;
    }
}