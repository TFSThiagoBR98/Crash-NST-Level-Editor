using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkaSkeletonPartition : hkObject
    {
        public override uint Hash => 0x7c8e6a55;

        [FieldAttr(nst: 0, ctr: 0)] public string? _name;
        [FieldAttr(nst: 8, ctr: 8)] public i16 _startBoneIndex;
        [FieldAttr(nst: 10, ctr: 10)] public i16 _numBones;
    }
}