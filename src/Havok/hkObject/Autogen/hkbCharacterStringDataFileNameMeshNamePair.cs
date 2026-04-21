using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkbCharacterStringDataFileNameMeshNamePair : hkObject
    {
        public override uint Hash => 0x26c3a96;

        [FieldAttr(nst: 0, ctr: 0)] public string? _fileName;
        [FieldAttr(nst: 8, ctr: 8)] public string? _meshName;
    }
}