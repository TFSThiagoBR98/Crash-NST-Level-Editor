namespace Alchemy
{
    [ObjectAttr(ctr: 144, align: 8)]
    public class CObjective : igObject
    {
        [FieldAttr(ctr: 12)] public EObjectiveType _type;
        [FieldAttr(ctr: 16)] public string? _description;
        [FieldAttr(ctr: 24)] public igHandleMetaField _image = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _objectiveEntity = new();
        [FieldAttr(ctr: 40)] public bool _isStarted;
        [FieldAttr(ctr: 44)] public EPriority _guiPriority;
        [FieldAttr(ctr: 48)] public bool _hasProgressed;
        [FieldAttr(ctr: 56)] public string? _questTitle;
        [FieldAttr(ctr: 64)] public bool _isAuthoritative;
        [FieldAttr(ctr: 72)] public CObjectiveHudData? _objectiveHudData;
        [FieldAttr(ctr: 80)] public CObjectiveEventDelegate? _onObjectiveStart;
        [FieldAttr(ctr: 88)] public CObjectiveEventList? _onObjectiveStartEventList;
        [FieldAttr(ctr: 96)] public CObjectiveEventDelegate? _onObjectiveCancel;
        [FieldAttr(ctr: 104)] public CObjectiveEventList? _onObjectiveCancelEventList;
        [FieldAttr(ctr: 112)] public CObjectiveEventDelegate? _onObjectiveComplete;
        [FieldAttr(ctr: 120)] public CObjectiveEventList? _onObjectiveCompleteEventList;
        [FieldAttr(ctr: 128)] public CObjectiveEventDelegate? _onObjectiveIncrement;
        [FieldAttr(ctr: 136)] public CObjectiveEventList? _onObjectiveIncrementEventList;
    }
}
