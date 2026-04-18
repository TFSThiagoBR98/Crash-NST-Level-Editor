namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CGuiBehaviorOctaneTextPages : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public string? _pageLocString;
        [FieldAttr(ctr: 24)] public igStringRefList? _textPages;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _pagePlaceable;
        [FieldAttr(ctr: 40)] public bool _canSkipToLast;
        [FieldAttr(ctr: 44)] public int _currentPage;
        [FieldAttr(ctr: 48)] public bool _addEULAExtraPage;
        [FieldAttr(ctr: 56)] public igStringRefList? _textPagesToDisplay;
    }
}
