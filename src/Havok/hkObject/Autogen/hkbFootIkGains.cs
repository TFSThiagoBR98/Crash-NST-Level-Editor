using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hkbFootIkGains : hkObject
    {
        public override uint Hash => 0xded7c527;

        [FieldAttr(nst: 0, ctr: 0)] public float _onOffGain;
        [FieldAttr(nst: 4, ctr: 4)] public float _groundAscendingGain;
        [FieldAttr(nst: 8, ctr: 8)] public float _groundDescendingGain;
        [FieldAttr(nst: 12, ctr: 12)] public float _footPlantedGain;
        [FieldAttr(nst: 16, ctr: 16)] public float _footRaisedGain;
        [FieldAttr(nst: 20, ctr: 20)] public float _footLockingGain;
        [FieldAttr(nst: 24, ctr: 24)] public float _worldFromModelFeedbackGain;
        [FieldAttr(nst: 28, ctr: 28)] public float _errorUpDownBias;
        [FieldAttr(nst: 32, ctr: 32)] public float _alignWorldFromModelGain;
        [FieldAttr(nst: 36, ctr: 36)] public float _hipOrientationGain;
    }
}