using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 136, ctr: 136)]
    public class hkxVertexBuffer : hkReferencedObject
    {
        public override uint Hash => 0xc7213b44;

        [FieldAttr(nst: 16, ctr: 16)] public hkxVertexBufferVertexData? _data;
        [FieldAttr(nst: 120, ctr: 120)] public hkxVertexDescription? _desc;
    }
}