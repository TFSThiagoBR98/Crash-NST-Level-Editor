using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 192, ctr: 192)]
    public class hkbFootIkControlsModifier : hkbModifier
    {
        public override uint Hash => 0xccea286;

        [FieldAttr(nst: 96, ctr: 96)] public hkbFootIkControlData? _controlData;
        [FieldAttr(nst: 176, ctr: 176)] public hkMemory<hkbFootIkControlsModifierLeg> _legs;
    }
}