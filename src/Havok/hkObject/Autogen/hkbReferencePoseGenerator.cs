using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 144, ctr: 144)]
    public class hkbReferencePoseGenerator : hkbGenerator
    {
        public override uint Hash => 0xbc1536ee;

        [FieldAttr(nst: 136, ctr: 136)] public hkaSkeleton? _skeleton;
    }
}