using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hkbStateMachineTransitionInfoArray : hkReferencedObject
    {
        public override uint Hash => 0x704a19af;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<hkbStateMachineTransitionInfo> _transitions;
        [FieldAttr(nst: 32, ctr: 32)] public bool _hasEventlessTransitions;
        [FieldAttr(nst: 33, ctr: 33)] public bool _hasTimeBoundedTransitions;
    }
}