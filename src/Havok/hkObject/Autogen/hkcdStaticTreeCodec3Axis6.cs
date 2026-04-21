using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 6, ctr: 6)]
    public class hkcdStaticTreeCodec3Axis6 : hkcdStaticTreeCodec3Axis
    {
        public override uint Hash => 0x569b5d82;

        [FieldAttr(nst: 3, ctr: 3)] public u8 _hiData;
        [FieldAttr(nst: 4, ctr: 4)] public u16 _loData;
    }
}