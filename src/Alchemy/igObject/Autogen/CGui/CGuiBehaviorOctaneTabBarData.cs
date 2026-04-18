namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CGuiBehaviorOctaneTabBarData : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public CGuiOctaneTabBarDataList? _pagesList;
        [FieldAttr(ctr: 24)] public CGuiListItemPopulatorOctaneTabBar? _tabBarPopulator;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _twoItemsAnim;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _threeItemsAnim;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _fourItemsAnim;
        [FieldAttr(ctr: 56)] public bool _populateOnStart;
    }
}
