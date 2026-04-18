namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CZoneInfoUserSession : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _storyModeRecordStarsMask;
        [FieldAttr(nst: 20, ctr: 16)] public int _storyModeRecordPercentComplete;
        [FieldAttr(nst: 24, ctr: 20)] public EDifficultyLevel _storyModeHighestDifficulty = EDifficultyLevel.eDL_Invalid;
        [FieldAttr(nst: 28, ctr: 24)] public int _storyModeLevelCompletions;
        [FieldAttr(nst: 32, ctr: 28)] public int _storyModeHighScore;
        [FieldAttr(nst: 36, ctr: 32)] public int _timeTrialFirstPlaceTime;
        [FieldAttr(nst: 40, ctr: 36)] public int _timeTrialSecondPlaceTime;
        [FieldAttr(nst: 44, ctr: 40)] public int _timeTrialThirdPlaceTime;
        [FieldAttr(nst: 48, ctr: 48)] public string? _timeTrialFirstPlaceInitials = "---";
        [FieldAttr(nst: 56, ctr: 56)] public string? _timeTrialSecondPlaceInitials = "---";
        [FieldAttr(nst: 64, ctr: 64)] public string? _timeTrialThirdPlaceInitials = "---";
        [FieldAttr(nst: 72, ctr: 72)] public int _timeTrialRelicCompleted;
        [FieldAttr(nst: 76, ctr: 76)] public bool _powerCrystalCollected;
        [FieldAttr(nst: 80, ctr: 80)] public uint _collectiblesRewarded;
        [FieldAttr(nst: 84, ctr: 84)] public bool _timeTrialDataSentToLeaderboards;
    }
}
