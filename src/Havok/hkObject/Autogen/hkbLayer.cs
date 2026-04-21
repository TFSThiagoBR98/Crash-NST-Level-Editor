using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 96, ctr: 96)]
    public class hkbLayer : hkbBindable
    {
        public override uint Hash => 0x2916a243;

        [FieldAttr(nst: 48, ctr: 48)] public hkbGenerator? _generator;
        [FieldAttr(nst: 56, ctr: 56)] public float _weight;
        [FieldAttr(nst: 64, ctr: 64)] public hkbBoneWeightArray? _boneWeights;
        [FieldAttr(nst: 72, ctr: 72)] public float _fadeInDuration;
        [FieldAttr(nst: 76, ctr: 76)] public float _fadeOutDuration;
        [FieldAttr(nst: 80, ctr: 80)] public int _onEventId;
        [FieldAttr(nst: 84, ctr: 84)] public int _offEventId;
        [FieldAttr(nst: 88, ctr: 88)] public bool _onByDefault;
        [FieldAttr(nst: 89, ctr: 89)] public bool _useMotion;
        [FieldAttr(nst: 90, ctr: 90)] public bool _forceFullFadeDurations;
    }
}