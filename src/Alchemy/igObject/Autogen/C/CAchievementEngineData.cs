namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CAchievementEngineData : igObject
    {
        [FieldAttr(ctr: 16)] public CAEKindList? _achievementEngineKinds;
        [FieldAttr(ctr: 24)] public CAEAchievementList? _achievementEngineAchievements;
        [FieldAttr(ctr: 32)] public CAEEventList? _achievementEngineEvents;
        [FieldAttr(ctr: 40)] public CAEAchievementParamListList? _achievementsParamList;
        [FieldAttr(ctr: 48)] public CAEAchievementMetadata? _metadata;
    }
}
