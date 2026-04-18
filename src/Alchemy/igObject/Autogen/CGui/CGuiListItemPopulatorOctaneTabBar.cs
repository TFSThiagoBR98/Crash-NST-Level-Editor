namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiListItemPopulatorOctaneTabBar : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 16)] public CGuiOctaneTabBarDataList? _projectList;
        [FieldAttr(ctr: 24)] public int _initialIndex;
    }
}
