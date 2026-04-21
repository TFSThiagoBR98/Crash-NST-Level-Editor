using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkpConstraintData : hkReferencedObject
    {
        public override uint Hash => 0x57339dd7;

        [FieldAttr(nst: 16, ctr: 16)] public u64 _userData;
    }
}