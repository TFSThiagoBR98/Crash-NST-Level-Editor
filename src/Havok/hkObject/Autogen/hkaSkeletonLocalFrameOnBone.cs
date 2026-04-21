using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkaSkeletonLocalFrameOnBone : hkObject
    {
        public override uint Hash => 0xe9151edc;

        [FieldAttr(nst: 0, ctr: 0)] public hkLocalFrame? _localFrame;
        [FieldAttr(nst: 8, ctr: 8)] public i16 _boneIndex;
    }
}