using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkbCharacterControllerModifierControlData : hkObject
    {
        public override uint Hash => 0xc4e809af;

        [FieldAttr(nst: 0, ctr: 0)] public float _verticalGain;
        [FieldAttr(nst: 4, ctr: 4)] public float _horizontalCatchUpGain;
        [FieldAttr(nst: 8, ctr: 8)] public float _maxVerticalSeparation;
        [FieldAttr(nst: 12, ctr: 12)] public float _maxHorizontalSeparation;
    }
}