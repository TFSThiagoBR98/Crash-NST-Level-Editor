using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 112, ctr: 112)]
    public class hkxMeshSection : hkReferencedObject
    {
        public override uint Hash => 0x54533691;

        [FieldAttr(nst: 16, ctr: 16)] public hkxVertexBuffer? _vertexBuffer;
        [FieldAttr(nst: 24, ctr: 24)] public hkMemory<hkxIndexBuffer> _indexBuffers;
        [FieldAttr(nst: 40, ctr: 40)] public hkxMaterial? _material;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<hkReferencedObject> _userChannels;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<hkxVertexAnimation> _vertexAnimations;
        [FieldAttr(nst: 80, ctr: 80)] public hkMemory<float> _linearKeyFrameHints;
        [FieldAttr(nst: 96, ctr: 96)] public hkMemory<hkMeshBoneIndexMapping> _boneMatrixMap;
    }
}