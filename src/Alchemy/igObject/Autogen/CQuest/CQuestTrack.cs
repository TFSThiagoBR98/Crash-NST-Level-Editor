namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CQuestTrack : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _netNextActiveQuest = new();
        [FieldAttr(ctr: 24)] public bool _netForceNoActiveQuest;
        [FieldAttr(ctr: 32)] public string? _name;
        [FieldAttr(ctr: 40)] public CQuestList? _quests;
        [FieldAttr(ctr: 48)] public igHandleMetaField _prerequisiteQuest = new();
        [FieldAttr(ctr: 56)] public int _maxQuestsPerDay;
        [FieldAttr(ctr: 64)] public CAchievementEvent? _achievementEvent;
        [FieldAttr(ctr: 72)] public bool _isReplicated;
        [FieldAttr(ctr: 80)] public igHandleMetaField _activeQuest = new();
        [FieldAttr(ctr: 88)] public int _questsToday;
        [FieldAttr(ctr: 92)] public uint _day;
        [FieldAttr(ctr: 96)] public int _questsCompleted;
    }
}
