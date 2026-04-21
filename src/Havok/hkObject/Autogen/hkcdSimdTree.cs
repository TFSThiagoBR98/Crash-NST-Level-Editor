using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkcdSimdTree : hkObject
    {
        public override uint Hash => 0x84c43960;

        [FieldAttr(nst: 8, ctr: 8)] public hkMemory<hkcdSimdTreeNode> _nodes;
    }
}