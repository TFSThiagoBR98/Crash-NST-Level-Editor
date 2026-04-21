using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 16)]
    public class hknpCollisionFilter : hkReferencedObject
    {
        public override uint Hash => 0x1c7179c4;

        [FieldAttr(nst: 16, ctr: 12)] public EType _type;
    }
}