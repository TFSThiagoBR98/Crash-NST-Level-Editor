namespace Alchemy
{
    [ObjectAttr(ctr: 456, align: 8)]
    public class CGuiBehaviorLeaderboardPopulationSelector : CGuiBehaviorBaseSettingSelector
    {
        [FieldAttr(ctr: 448)] public COctaneLeaderboardPopulationTypeList? _populationList;
    }
}
