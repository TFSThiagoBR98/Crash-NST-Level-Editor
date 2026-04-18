namespace Alchemy
{
    [ObjectAttr(ctr: 464, align: 8)]
    public class CGuiBehaviorHighScoreMapSelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 444)] public EOctaneRaceModes _selectedMode;
        [FieldAttr(ctr: 448)] public int _currentAreaIndex;
        [FieldAttr(ctr: 456)] public igStringRefList? _levelNameList;
    }
}
