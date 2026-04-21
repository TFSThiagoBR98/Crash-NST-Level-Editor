using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 336, ctr: 328)]
    public class hkbStateMachine : hkbGenerator
    {
        public override uint Hash => 0x1913d1c1;

        [FieldAttr(nst: 136, ctr: 136)] public hkbEvent? _eventToSendWhenStateOrTransitionChanges;
        [FieldAttr(nst: 160, ctr: 160)] public hkbCustomIdSelector? _startStateIdSelector;
        [FieldAttr(nst: 168, ctr: 168)] public int _startStateId;
        [FieldAttr(nst: 172, ctr: 172)] public int _returnToPreviousStateEventId;
        [FieldAttr(nst: 176, ctr: 176)] public int _randomTransitionEventId;
        [FieldAttr(nst: 180, ctr: 180)] public int _transitionToNextHigherStateEventId;
        [FieldAttr(nst: 184, ctr: 184)] public int _transitionToNextLowerStateEventId;
        [FieldAttr(nst: 188, ctr: 188)] public int _syncVariableIndex;
        [FieldAttr(nst: 192, ctr: 192)] public int _currentStateId;
        [FieldAttr(nst: 196, ctr: 196)] public bool _wrapAroundStateId;
        [FieldAttr(nst: 197, ctr: 197)] public i8 _maxSimultaneousTransitions;
        [FieldAttr(nst: 198, ctr: 198)] public EStartStateMode _startStateMode;
        [FieldAttr(nst: 199, ctr: 199)] public EStateMachineSelfTransitionMode _selfTransitionMode;
        [FieldAttr(nst: 200, ctr: 200)] public bool _isActive;
        [FieldAttr(nst: 208, ctr: 208)] public hkMemory<hkbStateMachineStateInfo> _states;
        [FieldAttr(nst: 224, ctr: 224)] public hkbStateMachineTransitionInfoArray? _wildcardTransitions;
        [FieldAttr(nst: 232, ctr: 232)] public uint _stateIdToIndexMap;
        [FieldAttr(nst: 240, ctr: 240)] public hkMemory<uint> _activeTransitions;
        [FieldAttr(nst: 256, ctr: 256)] public hkMemory<u8> _transitionFlags;
        [FieldAttr(nst: 272, ctr: 272)] public hkMemory<u8> _wildcardTransitionFlags;
        [FieldAttr(nst: 288, ctr: 288)] public hkMemory<uint> _delayedTransitions;
        [FieldAttr(nst: 304, ctr: 304)] public float _timeInState;
        [FieldAttr(nst: 308, ctr: 308)] public float _lastLocalTime;
        [FieldAttr(nst: 312, ctr: 312)] public int _previousStateId;
        [FieldAttr(nst: 316, ctr: 316)] public int _nextStartStateIndexOverride;
        [FieldAttr(nst: 320, ctr: 320)] public bool _stateOrTransitionChanged;
        [FieldAttr(nst: 321, ctr: 321)] public bool _echoNextUpdate;
        [FieldAttr(nst: 322, ctr: 322)] public bool _hasEventlessWildcardTransitions;
    }
}