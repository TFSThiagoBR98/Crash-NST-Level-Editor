namespace Alchemy
{
    [ObjectAttr(ctr: 480, align: 8)]
    public class CGuiBehaviorRaceDifficultySelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 441)] public bool _hasNoAiOption;
        [FieldAttr(ctr: 442)] public bool _hasAiCountLock;
        [FieldAttr(ctr: 448)] public string? _noAiText;
        [FieldAttr(ctr: 456)] public string? _easyText;
        [FieldAttr(ctr: 464)] public string? _mediumText;
        [FieldAttr(ctr: 472)] public string? _hardText;
    }
}
