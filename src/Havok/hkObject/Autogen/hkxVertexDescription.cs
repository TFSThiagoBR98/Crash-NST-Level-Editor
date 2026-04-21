using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkxVertexDescription : hkObject
    {
        public override uint Hash => 0x476106c0;

        [FieldAttr(nst: 0, ctr: 0)] public hkMemory<hkxVertexDescriptionElementDecl> _decls;
    }
}