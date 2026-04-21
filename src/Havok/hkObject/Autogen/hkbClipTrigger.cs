using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 32, ctr: 32)]
    public class hkbClipTrigger : hkObject
    {
        public override uint Hash => 0x7eb45cea;

        [FieldAttr(nst: 0, ctr: 0)] public float _localTime;
        [FieldAttr(nst: 8, ctr: 8)] public hkbEventProperty? _event;
        [FieldAttr(nst: 24, ctr: 24)] public bool _relativeToEndOfClip;
        [FieldAttr(nst: 25, ctr: 25)] public bool _acyclic;
        [FieldAttr(nst: 26, ctr: 26)] public bool _isAnnotation;
    }
}