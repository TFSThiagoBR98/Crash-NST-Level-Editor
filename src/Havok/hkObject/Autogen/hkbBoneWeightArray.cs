using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 64)]
    public class hkbBoneWeightArray : hkbBindable
    {
        public override uint Hash => 0x2c9b5751;

        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<float> _boneWeights;
    }
}