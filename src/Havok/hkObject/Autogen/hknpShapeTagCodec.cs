using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 16)]
    public class hknpShapeTagCodec : hkReferencedObject
    {
        public override uint Hash => 0x85b7c832;

        [FieldAttr(nst: 16, ctr: 12)] public EType _type;
    }
}