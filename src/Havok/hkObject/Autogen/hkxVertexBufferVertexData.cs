using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 104, ctr: 104)]
    public class hkxVertexBufferVertexData : hkObject
    {
        public override uint Hash => 0x427c01f4;

        [FieldAttr(nst: 0, ctr: 0)] public hkMemory<float> _vectorData;
        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<float> _floatData;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<uint> _uint32Data;
        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<u16> _uint16Data;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<u8> _uint8Data;
        [FieldAttr(nst: 80, ctr: 80)] public uint _numVerts;
        [FieldAttr(nst: 84, ctr: 84)] public uint _vectorStride;
        [FieldAttr(nst: 88, ctr: 88)] public uint _floatStride;
        [FieldAttr(nst: 92, ctr: 92)] public uint _uint32Stride;
        [FieldAttr(nst: 96, ctr: 96)] public uint _uint16Stride;
        [FieldAttr(nst: 100, ctr: 100)] public uint _uint8Stride;
    }
}