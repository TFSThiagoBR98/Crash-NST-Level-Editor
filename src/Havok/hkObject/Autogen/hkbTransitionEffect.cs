using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 168, ctr: 160)]
    public class hkbTransitionEffect : hkbGenerator
    {
        public override uint Hash => 0xeca9d564;

        [FieldAttr(nst: 136, ctr: 132)] public ESelfTransitionMode _selfTransitionMode;
        [FieldAttr(nst: 137, ctr: 133)] public EEventMode _eventMode;
        [FieldAttr(nst: 138, ctr: 134)] public EEventMode _defaultEventMode;
        [FieldAttr(nst: 144, ctr: 136)] public hkReferencedObject? _patchedBindingInfo;
        [FieldAttr(nst: 152, ctr: 144)] public hkbGenerator? _fromGenerator;
        [FieldAttr(nst: 160, ctr: 152)] public hkbGenerator? _toGenerator;
    }
}