namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CQuestSystemData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CQuestTrackList? _questTracks;
        [FieldAttr(nst: 24, ctr: 24)] public CEntityHandleGuiMaterialHashTable? _questNPCObjectiveImageMap;
        [FieldAttr(nst: 32, ctr: 32)] public float _reminderFrequency = 120.0f;
        [FieldAttr(nst: 36, ctr: 36)] public float _newQuestAlertDelay = 8.0f;
        [FieldAttr(nst: 40, ctr: 40)] public float _interactionAlertFrequency = 10.0f;
    }
}
