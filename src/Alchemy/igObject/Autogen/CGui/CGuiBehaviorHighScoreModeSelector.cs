namespace Alchemy
{
    [ObjectAttr(ctr: 456, align: 8)]
    public class CGuiBehaviorHighScoreModeSelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 448)] public COctaneRaceModesList? _modesList;
    }
}
