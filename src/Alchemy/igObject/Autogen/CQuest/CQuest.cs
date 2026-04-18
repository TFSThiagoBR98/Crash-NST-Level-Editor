namespace Alchemy
{
    [ObjectAttr(ctr: 176, align: 8)]
    public class CQuest : igObject
    {
        [FieldAttr(ctr: 16)] public string? _title;
        [FieldAttr(ctr: 24)] public EQuestPriority _priority;
        [FieldAttr(ctr: 32)] public igHandleMetaField _prerequisite = new();
        [FieldAttr(ctr: 40)] public CQuestRequirement? _requirement;
        [FieldAttr(ctr: 48)] public CQuestInteraction? _introInteraction;
        [FieldAttr(ctr: 56)] public CQuestStepList? _questSteps;
        [FieldAttr(ctr: 64)] public CQuestInteraction? _outroInteraction;
        [FieldAttr(ctr: 72)] public bool _isRepeatable;
        [FieldAttr(ctr: 76)] public int _questDuration;
        [FieldAttr(ctr: 80)] public int kOutroIndex;
        [FieldAttr(ctr: 84)] public int kRewardIndex;
        [FieldAttr(ctr: 88)] public int kResolvedIndex;
        [FieldAttr(ctr: 92)] public bool _isActive;
        [FieldAttr(ctr: 96)] public int _currentStepIndex;
        [FieldAttr(ctr: 104)] public u64 _lastInteractedTimestamp;
        [FieldAttr(ctr: 112)] public CQuestInteraction? _currentInteraction;
        [FieldAttr(ctr: 120)] public CQuestEventDelegate? _onQuestStart;
        [FieldAttr(ctr: 128)] public CQuestStartEventList? _onQuestStartEventList;
        [FieldAttr(ctr: 136)] public uint _dayQuestStarted;
        [FieldAttr(ctr: 144)] public CQuestEventList? _onQuestCompleteList;
        [FieldAttr(ctr: 152)] public uint _replicatedQuestBitfield;
        [FieldAttr(ctr: 160)] public CQuestSaveData? _replicatedSaveData;
        [FieldAttr(ctr: 168)] public bool _rewardSequenceComplete;
    }
}
