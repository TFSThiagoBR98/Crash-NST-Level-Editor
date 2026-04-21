using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkRootLevelContainerNamedVariant : hkObject
    {
        public override uint Hash => 0xb103a2cd;

        [FieldAttr(nst: 0, ctr: 0)] public string? _name;
        [FieldAttr(nst: 8, ctr: 8)] public string? _className;
        [FieldAttr(nst: 16, ctr: 16)] public hkReferencedObject? _variant;
    }
}