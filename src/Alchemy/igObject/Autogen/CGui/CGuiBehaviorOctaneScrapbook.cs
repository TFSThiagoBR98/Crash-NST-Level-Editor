namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CGuiBehaviorOctaneScrapbook : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public CGuiOctaneScrapbookImageList? _imageList;
        [FieldAttr(ctr: 24)] public int _currentIndex;
        [FieldAttr(ctr: 28)] public bool _wrapAround;
    }
}
