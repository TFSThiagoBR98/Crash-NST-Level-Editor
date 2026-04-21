using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 72, ctr: 72)]
    public class hkbStateMachineTransitionInfo : hkObject
    {
        public override uint Hash => 0xcdec8025;

        [FieldAttr(nst: 0, ctr: 0)] public hkbStateMachineTimeInterval? _triggerInterval;
        [FieldAttr(nst: 16, ctr: 16)] public hkbStateMachineTimeInterval? _initiateInterval;
        [FieldAttr(nst: 32, ctr: 32)] public hkbTransitionEffect? _transition;
        [FieldAttr(nst: 40, ctr: 40)] public hkbCondition? _condition;
        [FieldAttr(nst: 48, ctr: 48)] public int _eventId;
        [FieldAttr(nst: 52, ctr: 52)] public int _toStateId;
        [FieldAttr(nst: 56, ctr: 56)] public int _fromNestedStateId;
        [FieldAttr(nst: 60, ctr: 60)] public int _toNestedStateId;
        [FieldAttr(nst: 64, ctr: 64)] public i16 _priority;
        [FieldAttr(nst: 66, ctr: 66)] public ETransitionFlags _flags;
    }
}