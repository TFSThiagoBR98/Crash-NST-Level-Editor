using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 4, ctr: 4)]
    public class hkcdStaticMeshTreeBasePrimitive : hkObject
    {
        public override uint Hash => 0x56da2f7c;

        [FieldAttr(nst: 0, ctr: 0)] public u8 _indices_0;
        [FieldAttr(nst: 1, ctr: 1)] public u8 _indices_1;
        [FieldAttr(nst: 2, ctr: 2)] public u8 _indices_2;
        [FieldAttr(nst: 3, ctr: 3)] public u8 _indices_3;
    }
}