namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igGuiEventListVisibleUpdate : igGuiEvent
    {
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiPlaceable? _list;
        [FieldAttr(nst: 32, ctr: 32)] public float _scrollSize;
        [FieldAttr(nst: 36, ctr: 36)] public int _visibleStartIndex;
        [FieldAttr(nst: 40, ctr: 40)] public int _visibleEndIndex;
        [FieldAttr(nst: 44, ctr: 44)] public bool _limitUp;
        [FieldAttr(nst: 45, ctr: 45)] public bool _limitDown;
        [FieldAttr(nst: 46, ctr: 46)] public bool _limitLeft;
        [FieldAttr(nst: 47, ctr: 47)] public bool _limitRight;
    }
}
