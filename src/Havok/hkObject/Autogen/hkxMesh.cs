using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 48, ctr: 48)]
    public class hkxMesh : hkReferencedObject
    {
        public override uint Hash => 0xc0dafc2f;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkxMeshSection> _sections;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<hkxMeshUserChannelInfo> _userChannelInfos;
    }
}