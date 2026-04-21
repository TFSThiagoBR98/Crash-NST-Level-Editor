using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 4, ctr: 4)]
    public class hkxVertexAnimationUsageMap : hkObject
    {
        public override uint Hash => 0x46f9168e;

        [FieldAttr(nst: 0, ctr: 0)] public EDataUsage _use;
        [FieldAttr(nst: 2, ctr: 2)] public u8 _useIndexOrig;
        [FieldAttr(nst: 3, ctr: 3)] public u8 _useIndexLocal;
    }
}