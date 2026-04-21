using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 104, ctr: 104)]
    public class hkbModifierList : hkbModifier
    {
        public override uint Hash => 0xded564c;

        [FieldAttr(nst: 88, ctr: 88)] public hkMemory<hkbModifier> _modifiers;
    }
}