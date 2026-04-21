using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkaBone : hkObject
    {
        public override uint Hash => 0x35912f8a;

        [FieldAttr(nst: 0, ctr: 0)] public string? _name;
        [FieldAttr(nst: 8, ctr: 8)] public bool _lockTranslation;
    }
}