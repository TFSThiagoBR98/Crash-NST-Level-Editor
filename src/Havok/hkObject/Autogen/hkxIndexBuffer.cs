using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 56)]
    public class hkxIndexBuffer : hkReferencedObject
    {
        public override uint Hash => 0x81d1cd6e;

        [FieldAttr(nst: 16, ctr: 12)] public EIndexType _indexType;
        [FieldAttr(nst: 24, ctr: 16)] public hkMemory<u16> _indices16;
        [FieldAttr(nst: 40, ctr: 32)] public hkMemory<uint> _indices32;
        [FieldAttr(nst: 56, ctr: 48)] public uint _vertexBaseOffset;
        [FieldAttr(nst: 60, ctr: 52)] public uint _length;
    }
}