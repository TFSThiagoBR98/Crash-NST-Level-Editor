using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 136, ctr: 136)]
    public class hkaSkeleton : hkReferencedObject
    {
        public override uint Hash => 0xfec1cedb;

        [FieldAttr(nst: 16, ctr: 16)] public string? _name;
        [FieldAttr(nst: 24, ctr: 24)] public hkMemory<i16> _parentIndices;
        [FieldAttr(nst: 40, ctr: 40)] public hkMemory<hkaBone> _bones;
        [FieldAttr(nst: 56, ctr: 56)] public hkMemory<Matrix3x4> _referencePose;
        [FieldAttr(nst: 72, ctr: 72)] public hkMemory<float> _referenceFloats;
        [FieldAttr(nst: 88, ctr: 88)] public hkMemory<string> _floatSlots;
        [FieldAttr(nst: 104, ctr: 104)] public hkMemory<hkaSkeletonLocalFrameOnBone> _localFrames;
        [FieldAttr(nst: 120, ctr: 120)] public hkMemory<hkaSkeletonPartition> _partitions;
    }
}