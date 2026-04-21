using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 80, ctr: 80)]
    public class hkbBlenderGeneratorChild : hkbBindable
    {
        public override uint Hash => 0xb35bbfd3;

        [FieldAttr(nst: 48, ctr: 48)] public hkbGenerator? _generator;
        [FieldAttr(nst: 56, ctr: 56)] public hkbBoneWeightArray? _boneWeights;
        [FieldAttr(nst: 64, ctr: 64)] public float _weight;
        [FieldAttr(nst: 68, ctr: 68)] public float _worldFromModelWeight;
    }
}