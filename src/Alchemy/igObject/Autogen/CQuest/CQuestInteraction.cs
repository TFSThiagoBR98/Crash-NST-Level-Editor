namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 8)]
    public class CQuestInteraction : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _interactionEntity = new();
        [FieldAttr(ctr: 24)] public CInteractionComponentData? _interactionComponentData;
        [FieldAttr(ctr: 32)] public igHandleMetaField _alertData = new();
        [FieldAttr(ctr: 40)] public bool _automaticallyTriggerInteraction;
        [FieldAttr(ctr: 48)] public string? _description;
        [FieldAttr(ctr: 56)] public string? _notInHubDescription;
        [FieldAttr(ctr: 64)] public igHandleMetaField _image = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _quest = new();
        [FieldAttr(ctr: 80)] public CObjectiveHudData? _objectiveHudData;
    }
}
