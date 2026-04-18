namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CGuiBehaviorOctaneTabBar : igGuiBehavior
    {
        [FieldAttr(ctr: 12)] public int _currentPage;
        [FieldAttr(ctr: 16)] public int _pagesCount;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _pagesListPlace;
        [FieldAttr(ctr: 32)] public bool _isVisible;
    }
}
