using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkxVertexDescriptionElementDecl : hkObject
    {
        public override uint Hash => 0x865bf29f;

        [FieldAttr(nst: 0, ctr: 0)] public uint _byteOffset;
        [FieldAttr(nst: 4, ctr: 4)] public EDataType _type;
        [FieldAttr(nst: 6, ctr: 6)] public EDataUsage _usage;
        [FieldAttr(nst: 8, ctr: 8)] public uint _byteStride;
        [FieldAttr(nst: 12, ctr: 12)] public u8 _numElements;
        [FieldAttr(nst: 16, ctr: 16)] public string? _channelID;
    }
}