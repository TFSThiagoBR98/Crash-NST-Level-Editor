using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 3, ctr: 3)]
    public class hkcdStaticTreeCodec3Axis : hkObject
    {
        public override uint Hash => 0x4ad23f31;

        [FieldAttr(nst: 0, ctr: 0)] public u8 _xyz_0;
        [FieldAttr(nst: 1, ctr: 1)] public u8 _xyz_1;
        [FieldAttr(nst: 2, ctr: 2)] public u8 _xyz_2;
    }
}