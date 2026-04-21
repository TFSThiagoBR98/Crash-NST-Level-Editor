using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 64)]
    public class hkbMirroredSkeletonInfo : hkReferencedObject
    {
        public override uint Hash => 0x9f13052e;

        [FieldAttr(nst: 16, ctr: 16)] public Vector4 _mirrorAxis;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<i16> _bonePairMap;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<i16> _partitionPairMap;
    }
}