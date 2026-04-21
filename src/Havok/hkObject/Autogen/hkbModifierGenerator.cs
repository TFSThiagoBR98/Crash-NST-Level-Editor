using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 152, ctr: 152)]
    public class hkbModifierGenerator : hkbGenerator
    {
        public override uint Hash => 0xc499fc9e;

        [FieldAttr(nst: 136, ctr: 136)] public hkbModifier? _modifier;
        [FieldAttr(nst: 144, ctr: 144)] public hkbGenerator? _generator;
    }
}