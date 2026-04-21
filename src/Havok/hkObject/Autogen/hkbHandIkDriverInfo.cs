using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hkbHandIkDriverInfo : hkReferencedObject
    {
        public override uint Hash => 0x3eab47f1;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkbHandIkDriverInfoHand> _hands;
        [FieldAttr(nst: 32, ctr: 32)] public EBlendCurve _fadeInOutCurve;
    }
}