namespace Alchemy
{
    [ObjectAttr(nst: 200, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_HeldButtonListenerHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public EXBUTTON Button;
        [FieldAttr(nst: 84)] public EXBUTTON SecondaryButton;
        [FieldAttr(nst: 88)] public bool MustTriggerButton;
        [FieldAttr(nst: 89)] public bool ThresholdOnce;
        [FieldAttr(nst: 96)] public igHandleMetaField InfiniteDurationSkillUpgrade = new();
        [FieldAttr(nst: 104)] public float MaxHeldTime;
        [FieldAttr(nst: 108)] public float HeldThresholdTime;
        [FieldAttr(nst: 112)] public float MinimumHeldTime;
        [FieldAttr(nst: 120)] public string? StartBehaviorEvent = null;
        [FieldAttr(nst: 128)] public string? EndBehaviorEvent = null;
        [FieldAttr(nst: 136)] public string? ThresholdBehaviorEvent = null;
        [FieldAttr(nst: 144)] public string? ThresholdEndBehaviorEvent = null;
        [FieldAttr(nst: 152)] public CEntityMessage.ENetworkSendRestriction NetworkEventRestriction;
        [FieldAttr(nst: 156)] public bool AuthorityOnly;
        [FieldAttr(nst: 160)] public CEntityMessage? StartMessage;
        [FieldAttr(nst: 168)] public CEntityMessage? EndMessage;
        [FieldAttr(nst: 176)] public CEntityMessage? ThresholdMessage;
        [FieldAttr(nst: 184)] public CEntityMessage? ThresholdEndMessage;
        [FieldAttr(nst: 192)] public Dictionary_2? _instances;
    }
}
