using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hknpConstraintCinfo : hkObject
    {
        public override uint Hash => 0x67ea986d;

        [FieldAttr(nst: 0, ctr: 0)] public hkpConstraintData? _constraintData;
        [FieldAttr(nst: 8, ctr: 8)] public uint _bodyA;
        [FieldAttr(nst: 12, ctr: 12)] public uint _bodyB;
        [FieldAttr(nst: 16, ctr: 16)] public uint _flags;
    }
}