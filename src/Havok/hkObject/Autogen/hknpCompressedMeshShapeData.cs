using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 208, ctr: 208)]
    public class hknpCompressedMeshShapeData : hkReferencedObject
    {
        public override uint Hash => 0xa2bdfc59;

        [FieldAttr(nst: 16, ctr: 16)] public hknpCompressedMeshShapeTree? _meshTree;
        [FieldAttr(nst: 176, ctr: 176)] public hkcdSimdTree? _simdTree;
    }
}