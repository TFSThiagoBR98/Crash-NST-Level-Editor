using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 5, ctr: 5)]
    public class hkcdStaticTreeCodec3Axis5 : hkcdStaticTreeCodec3Axis
    {
        public override uint Hash => 0x12d67453;

        [FieldAttr(nst: 3, ctr: 3)] public u8 _hiData;
        [FieldAttr(nst: 4, ctr: 4)] public u8 _loData;
    }
}