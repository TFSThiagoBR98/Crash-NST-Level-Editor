namespace Alchemy
{
    [ObjectAttr(ctr: 464, align: 8)]
    public class CGuiBehaviorAiCountSelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 448)] public string? _noAiText;
        [FieldAttr(ctr: 456)] public int _maxRacers;
        [FieldAttr(ctr: 460)] public bool _allowAI;
        [FieldAttr(ctr: 461)] public bool _wantAI;
    }
}
