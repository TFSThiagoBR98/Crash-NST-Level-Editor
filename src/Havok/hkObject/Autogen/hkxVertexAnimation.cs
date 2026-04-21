using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 192, ctr: 184)]
    public class hkxVertexAnimation : hkReferencedObject
    {
        public override uint Hash => 0x27678cb3;

        [FieldAttr(nst: 16, ctr: 12)] public float _time;
        [FieldAttr(nst: 24, ctr: 16)] public hkxVertexBuffer? _vertData;
        [FieldAttr(nst: 160, ctr: 152)] public hkMemory<int> _vertexIndexMap;
        [FieldAttr(nst: 176, ctr: 168)] public hkMemory<hkxVertexAnimationUsageMap> _componentMap;
    }
}