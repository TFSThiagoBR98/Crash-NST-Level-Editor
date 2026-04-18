namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CQuestStep : igObject
    {
        [FieldAttr(ctr: 16)] public CObjective? _objective;
        [FieldAttr(ctr: 24)] public CQuestInteraction? _inProgressInteraction;
        [FieldAttr(ctr: 32)] public CQuestInteraction? _stepOutroInteraction;
        [FieldAttr(ctr: 40)] public bool _cancelObjectiveOnLevelLoad;
        [FieldAttr(ctr: 48)] public igHandleMetaField _quest = new();
        [FieldAttr(ctr: 56)] public EState _state;
    }
}
