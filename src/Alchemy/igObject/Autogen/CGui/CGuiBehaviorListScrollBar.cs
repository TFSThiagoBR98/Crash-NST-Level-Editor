namespace Alchemy
{
    [ObjectAttr(nst: 216, align: 8)]
    public class CGuiBehaviorListScrollBar : CGuiBehavior
    {
        [FieldAttr(nst: 144, refCount: false)] public igGuiList? _associatedList;
        [FieldAttr(nst: 152, refCount: false)] public igGuiPlaceable? _scrollCursorPlaceable;
        [FieldAttr(nst: 160, refCount: false)] public igGuiPlaceable? _scrollBackButton;
        [FieldAttr(nst: 168, refCount: false)] public igGuiPlaceable? _scrollForwardButton;
        [FieldAttr(nst: 176)] public bool _horizontalScroll;
        [FieldAttr(nst: 180)] public float _minScrollPosition;
        [FieldAttr(nst: 184)] public float _maxScrollPosition;
        [FieldAttr(nst: 188)] public float _currentScrollPercentage;
        [FieldAttr(nst: 192)] public float _currentScrollCursorPercentage;
        [FieldAttr(nst: 196)] public bool _isBeingDragged;
        [FieldAttr(nst: 200)] public igGuiInput.EController _touchControl_1;
        [FieldAttr(nst: 208, refCount: false)] public igGuiPlaceable? _focusedPlaceable;
    }
}
