using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 4, ctr: 4)]
    public class hkcdStaticTreeCodec3Axis4 : hkcdStaticTreeCodec3Axis
    {
        public override uint Hash => 0xd168bc2f;

        [FieldAttr(nst: 3, ctr: 3)] public u8 _data;
    }
}