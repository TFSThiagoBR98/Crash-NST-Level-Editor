using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkbShapeSetup : hkObject
    {
        public override uint Hash => 0xd7ff86be;

        [FieldAttr(nst: 0, ctr: 0)] public float _capsuleHeight;
        [FieldAttr(nst: 4, ctr: 4)] public float _capsuleRadius;
        [FieldAttr(nst: 8, ctr: 8)] public string? _fileName;
        [FieldAttr(nst: 16, ctr: 16)] public EType _type;
    }
}