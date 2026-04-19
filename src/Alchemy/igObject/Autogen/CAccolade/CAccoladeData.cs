namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 104, align: 8)]
    public class CAccoladeData : igNamedObject
    {
        public enum EQuestType
        {
            eQT_Invalid = -1,
            eQT_Generic = 0,
            eQT_Element = 1,
            eQT_Unique = 2,
            eQT_Count = 3,
        }

        [ObjectAttr(size: 1)]
        public class BitfieldStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 3)] public int _starsToAward = 1;
            [FieldAttr(offset: 3, size: 1)] public bool _resetOnRequirementsLost;
            [FieldAttr(offset: 4, size: 1)] public bool _displayProgress = false;
            [FieldAttr(offset: 5, size: 1)] public bool _showAccoladeHud = false;
            [FieldAttr(offset: 6, size: 1)] public bool _displayProgressBar = false;
            [FieldAttr(offset: 7, size: 1)] public bool _showOverCutscene;
        }

        [FieldAttr(nst: 24, ctr: 24)] public CAccoladeRequirementList? _requirements;
        [FieldAttr(nst: 32, ctr: 32)] public CAccoladeGoalDataList? _goals;
        [FieldAttr(nst: 40, ctr: 40)] public EQuestType _questType = CAccoladeData.EQuestType.eQT_Invalid;
        [FieldAttr(nst: 44, ctr: 44)] public EAccoladeGroup _accoladeGroup = EAccoladeGroup.eAG_Invalid;
        [FieldAttr(nst: 48, ctr: 48)] public int _achievementId = -1;
        [FieldAttr(nst: 52, ctr: 52)] public int _trophyId = -1;
        [FieldAttr(nst: 56)] public string? _steamAchievementId = "";
        [FieldAttr(nst: 64, ctr: 56)] public uint _trophyPackServiceLabel;
        [FieldAttr(nst: 72, ctr: 64)] public igHandleMetaField _achievementEvent = new();
        [FieldAttr(nst: 80, ctr: 72)] public igHandleMetaField _prerequisiteBeforeDisplay = new();
        [FieldAttr(nst: 88, ctr: 80)] public string? _shortDescription = null;
        [FieldAttr(nst: 96, ctr: 88)] public float _displayPercentInterval = 0.25f;
        [FieldAttr(nst: 100, ctr: 92)] public int _stardustToAward;
        [FieldAttr(nst: 104, ctr: 96)] public BitfieldStorage _bitfieldStorage = new();
        [FieldAttr(nst: 105, ctr: 97)] public bool _saveGameClip;
        [FieldAttr(nst: 108, ctr: 100)] public float _clipDuration = 10.0f;
    }
}
