using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 120, ctr: 120)]
    public class hkbStateMachineStateInfo : hkbBindable
    {
        public override uint Hash => 0x39d76713;

        [FieldAttr(nst: 48, ctr: 48)] public hkMemory<hkbStateListener> _listeners;
        [FieldAttr(nst: 64, ctr: 64)] public hkbStateMachineEventPropertyArray? _enterNotifyEvents;
        [FieldAttr(nst: 72, ctr: 72)] public hkbStateMachineEventPropertyArray? _exitNotifyEvents;
        [FieldAttr(nst: 80, ctr: 80)] public hkbStateMachineTransitionInfoArray? _transitions;
        [FieldAttr(nst: 88, ctr: 88)] public hkbGenerator? _generator;
        [FieldAttr(nst: 96, ctr: 96)] public string? _name;
        [FieldAttr(nst: 104, ctr: 104)] public int _stateId;
        [FieldAttr(nst: 108, ctr: 108)] public float _probability;
        [FieldAttr(nst: 112, ctr: 112)] public bool _enable;
        [FieldAttr(nst: 113, ctr: 113)] public bool _hasEventlessTransitions;
    }
}