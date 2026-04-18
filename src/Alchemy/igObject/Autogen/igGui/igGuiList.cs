namespace Alchemy
{
    [ObjectAttr(nst: 848, ctr: 848, align: 16)]
    public class igGuiList : igGuiControl
    {
        public enum EAlignmentMode
        {
            kAlignmentLeftToRight = 0,
            kAlignmentRightToLeft = 1,
        }

        public enum ESortMode
        {
            kSortByAlignment = 0,
            kSortByDistanceFromCenter = 1,
        }

        public enum EListFocusScrollMode
        {
            kFocusScrollNone = 0,
            kFocusScrollToFit = 1,
            kFocusScrollCentered = 2,
        }

        public enum EListTouchScrollMode
        {
            kTouchScrollNone = 0,
            kTouchScrollDragWithBounce = 1,
        }

        public enum EigTouchInputState
        {
            kTouchStateIdle = 0,
            kTouchStatePressed = 1,
            kTouchStateDragging = 2,
        }

        [FieldAttr(nst: 32, ctr: 32)] public igGuiPlaceable? _templateItem;
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _toolTemplateItem = new();
        [FieldAttr(nst: 48, ctr: 48)] public igGuiListItemPopulator? _listItemPopulator;
        [FieldAttr(nst: 56, ctr: 56)] public igGuiListItemConverter? _listItemConverter;
        [FieldAttr(nst: 64, ctr: 64)] public igVec4fMetaField _margin = new();
        [FieldAttr(nst: 80, ctr: 80)] public igVec4fMetaField _padding = new();
        [FieldAttr(nst: 96, ctr: 96)] public float _itemShiftSpeed = 500.0f;
        [FieldAttr(nst: 100, ctr: 100)] public float _scrollSpeed = 500.0f;
        [FieldAttr(nst: 104, ctr: 104)] public bool _horizontalScroll;
        [FieldAttr(nst: 105, ctr: 105)] public bool _listWrap = true;
        [FieldAttr(nst: 106, ctr: 106)] public bool _acceptDpadInput = true;
        [FieldAttr(nst: 108, ctr: 108)] public EAlignmentMode _alignmentMode;
        [FieldAttr(nst: 112)] public bool _centerAfterAlign;
        [FieldAttr(nst: 116, ctr: 112)] public ESortMode _sortMode;
        [FieldAttr(nst: 120, ctr: 116)] public EListFocusScrollMode _focusScrollMode = igGuiList.EListFocusScrollMode.kFocusScrollToFit;
        [FieldAttr(nst: 124, ctr: 120)] public EListTouchScrollMode _touchScrollMode;
        [FieldAttr(nst: 128, ctr: 124)] public bool _scissorListBounds = true;
        [FieldAttr(nst: 129, ctr: 125)] public bool _alwaysCreatePlaceables = true;
        [FieldAttr(nst: 130, ctr: 126)] public bool _unifyFocus;
        [FieldAttr(nst: 132, ctr: 128)] public float _touchScrollingBuffer = 10.0f;
        [FieldAttr(nst: 136, ctr: 132)] public float _touchScrollingDampening = 2.0f;
        [FieldAttr(nst: 140, ctr: 136)] public float _touchScrollingDampeningRebound = 5.0f;
        [FieldAttr(nst: 144, ctr: 140)] public EigGuiDeviceAutoScaleMode _itemAutoScaleMode;
        [FieldAttr(nst: 148, ctr: 144)] public int _previewListItemCount = 10;
        [FieldAttr(nst: 152, ctr: 148)] public float _scrollPercentage;
        [FieldAttr(nst: 156, ctr: 152)] public float _visiblePercentage;
        [FieldAttr(nst: 160, ctr: 156)] public float _lastScrollPercentage;
        [FieldAttr(nst: 164, ctr: 160)] public float _touchScrollingVelocity;
        [FieldAttr(nst: 168, ctr: 164)] public igVec2fMetaField _lastTouchPosition = new();
        [FieldAttr(nst: 176, ctr: 172)] public EigTouchInputState _touchState;
        [FieldAttr(nst: 180, ctr: 176)] public igGuiInput.EController _touchControl;
        [FieldAttr(nst: 184, ctr: 180)] public igGuiInput.ESignal _touchSignal;
        [FieldAttr(nst: 192, ctr: 184, refCount: false)] public igGuiPlaceable? _touchFocus;
        [FieldAttr(nst: 200, ctr: 192)] public igGuiPlaceable? _rootPlaceable;
        [FieldAttr(nst: 208, ctr: 200)] public igGuiPlaceable? _scrollPlaceable;
        [FieldAttr(nst: 216, ctr: 208)] public igGuiListItemList? _items;
        [FieldAttr(nst: 224, ctr: 216)] public igGuiListItemList? _sortedItems;
        [FieldAttr(nst: 232, ctr: 224)] public igGuiListItemList? _visibleItems;
        [FieldAttr(nst: 240, ctr: 232)] public igGuiListItemList? _cachedItems;
        [FieldAttr(nst: 248, ctr: 240)] public igVec2fMetaField[] _cursor = new igVec2fMetaField[8];
        [FieldAttr(nst: 312, ctr: 304)] public igGuiListItem[] _focusItem = new igGuiListItem[8];
        [FieldAttr(nst: 376, ctr: 368)] public igGuiListItem[] _forcedFocusItem = new igGuiListItem[8];
        [FieldAttr(nst: 440, ctr: 432)] public igHandleMetaField[] _hoverFocus = new igHandleMetaField[40];
        [FieldAttr(nst: 760, ctr: 752)] public bool[] _hasFocus = new bool[8];
        [FieldAttr(nst: 768, ctr: 760)] public bool[] _hasHover = new bool[40];
        [FieldAttr(ctr: 800)] public uint _unifiedControl;
        [FieldAttr(nst: 808, ctr: 804)] public float _scrollSize;
        [FieldAttr(nst: 812, ctr: 808)] public bool _unboundedFocusScroll = true;
        [FieldAttr(nst: 813, ctr: 809)] public bool _updateFocusScroll = true;
        [FieldAttr(nst: 814, ctr: 810)] public bool _placeablesDirty = true;
        [FieldAttr(nst: 816, ctr: 816)] public igGuiEventListVisibleUpdate? _visibleItemsEvent;
        [FieldAttr(nst: 824, ctr: 824)] public igGuiEventPlaceableGainHover? _gainHoverEvent;
        [FieldAttr(nst: 832, ctr: 832)] public igGuiEventPlaceableLoseHover? _loseHoverEvent;
    }
}
