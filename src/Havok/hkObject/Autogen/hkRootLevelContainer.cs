using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkRootLevelContainer : hkObject
    {
        public override uint Hash => 0x2772c11e;

        [FieldAttr(nst: 0, ctr: 0)] public hkMemory<hkRootLevelContainerNamedVariant> _namedVariants;
    }
}