using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 160, ctr: 160)]
    public class hknpCompressedMeshShapeTreeDataRunStaticMeshTreeCommonConfig : hkcdStaticMeshTreeBase
    {
        public override uint Hash => 0x1da85e02;

        [FieldAttr(nst: 112, ctr: 112)] public hkMemory<uint> _packedVertices;
        [FieldAttr(nst: 128, ctr: 128)] public hkMemory<u64> _sharedVertices;
        [FieldAttr(nst: 144, ctr: 144)] public hkMemory<hknpCompressedMeshShapeTreeDataRun> _primitiveDataRuns;
    }
}