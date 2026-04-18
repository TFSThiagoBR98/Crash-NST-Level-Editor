namespace Alchemy
{
    [ObjectAttr(nst: 152, ctr: 136, align: 8)]
    public class CButtonListenerHandler : CBehaviorLogic
    {
        public enum EButtonState
        {
            eBS_Down = 0,
            eBS_Up = 1,
            eBS_Triggered = 2,
            eBS_Released = 3,
        }

        public enum ECooldownType
        {
            eCType_TriggerOnStart = 0,
            eCType_TriggerOnEnd = 1,
        }

        [FieldAttr(nst: 80, ctr: 64)] public EXBUTTON _button;
        [FieldAttr(nst: 84, ctr: 68)] public EButtonState _buttonStateToFireEvent = CButtonListenerHandler.EButtonState.eBS_Triggered;
        [FieldAttr(nst: 88, ctr: 72)] public string? _behaviorEvent = null;
        [FieldAttr(nst: 96, ctr: 80)] public CEntityMessage.ENetworkSendRestriction _networkEventRestriction;
        [FieldAttr(nst: 100, ctr: 84)] public bool _authorityOnly;
        [FieldAttr(nst: 104, ctr: 88)] public CEntityMessage? _message;
        [FieldAttr(nst: 112, ctr: 96)] public float _cooldownTime;
        [FieldAttr(nst: 120, ctr: 104)] public string? _attackState = null;
        [FieldAttr(nst: 128, ctr: 112)] public ECooldownType _cooldownType = CButtonListenerHandler.ECooldownType.eCType_TriggerOnEnd;
        [FieldAttr(nst: 132, ctr: 116)] public bool _checkExtraButtons;
        [FieldAttr(nst: 136, ctr: 120)] public EXBUTTON _extraButton1 = EXBUTTON.MAX;
        [FieldAttr(nst: 140, ctr: 124)] public EXBUTTON _extraButton2 = EXBUTTON.MAX;
        [FieldAttr(nst: 144, ctr: 128)] public CButtonListenerInstanceTable? _instances;
    }
}
