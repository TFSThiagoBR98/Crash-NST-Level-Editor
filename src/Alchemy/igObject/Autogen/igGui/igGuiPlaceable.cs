namespace Alchemy
{
    [ObjectAttr(nst: 272, ctr: 288, align: 16)]
    public class igGuiPlaceable : igObject
    {
        public enum EUpdateWhenHiddenMode
        {
            kUseParentValue = 0,
            kEnable = 1,
            kDisable = 2,
        }

        [ObjectAttr(size: 4)]
        public class BitfieldStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _automaticBound = true;
            [FieldAttr(offset: 1, size: 1)] public bool _scissorToBound;
            [FieldAttr(offset: 2, size: 2)] public igGuiPlaceable.EUpdateWhenHiddenMode _updateWhenHiddenMode;
            [FieldAttr(offset: 4, size: 1)] public bool _xExtentRelativeToParent;
            [FieldAttr(offset: 5, size: 1)] public bool _yExtentRelativeToParent;
            [FieldAttr(offset: 6, size: 1)] public bool _xExtentEqualsScreenWidth;
            [FieldAttr(offset: 7, size: 1)] public bool _yExtentEqualsScreenHeight;
            [FieldAttr(offset: 8, size: 1)] public bool _hidden;
            [FieldAttr(offset: 9, size: 1)] public bool _allowTouchInput;
            [FieldAttr(offset: 10, size: 1)] public bool _dirty = false;
            [FieldAttr(offset: 11, size: 1)] public bool _finalHidden;
            [FieldAttr(offset: 12, size: 1)] public bool _updateWhenHidden;
            [FieldAttr(offset: 13, size: 1)] public bool _finalScissorToBound;
            [FieldAttr(offset: 14, size: 1)] public bool _deactivated;
            [FieldAttr(offset: 15, size: 1)] public bool _focusable = false;
            [FieldAttr(offset: 16, size: 1)] public bool _respectParentFocusability;
            [FieldAttr(offset: 17, size: 1)] public bool _unknown;
            [FieldAttr(offset: 18, size: 1)] public bool _unknown1;
            [FieldAttr(offset: 19, size: 1)] public bool _unknown2;
            [FieldAttr(offset: 20, size: 1)] public bool _unknown3;
            [FieldAttr(offset: 21, size: 1)] public bool _unknown4;
            [FieldAttr(offset: 22, size: 1)] public bool _unknown5;
        }

        [FieldAttr(nst: 16, ctr: 12)] public BitfieldStorage _bitfieldStorage = new();
        [FieldAttr(nst: 24, ctr: 16)] public igGuiInstanceMap? _instanceMap;
        [FieldAttr(nst: 32, ctr: 24, refCount: false)] public igGuiPlaceable? _sourcePlaceable;
        [FieldAttr(nst: 40, ctr: 32, refCount: false)] public igGuiProject? _project;
        [FieldAttr(nst: 48, ctr: 40)] public string? _name = null;
        [FieldAttr(nst: 56, ctr: 48)] public string? _displayText = null;
        [FieldAttr(nst: 64, ctr: 56)] public igHandleMetaField _asset = new();
        [FieldAttr(nst: 72, ctr: 64, refCount: false)] public igGuiPlaceable? _parent;
        [FieldAttr(nst: 80, ctr: 72)] public igGuiPlaceableTable? _children;
        [FieldAttr(nst: 88, ctr: 80, refCount: false)] public igGuiPlaceable? _sortPrevious;
        [FieldAttr(nst: 96, ctr: 88, refCount: false)] public igGuiPlaceable? _sortNext;
        [FieldAttr(nst: 104, ctr: 96)] public igVec3fMetaField _position = new();
        [FieldAttr(nst: 116, ctr: 108)] public igVec3fMetaField _pivot = new();
        [FieldAttr(nst: 128, ctr: 120)] public igVec3fMetaField _rotation = new();
        [FieldAttr(nst: 140, ctr: 132)] public igVec3fMetaField _scale = new();
        [FieldAttr(nst: 152, ctr: 144)] public igVec3fMetaField _extent = new();
        [FieldAttr(nst: 164, ctr: 156)] public EigGuiDeviceAutoScaleMode _autoScaleMode;
        [FieldAttr(nst: 168, ctr: 160)] public EigGuiAnchorTargetX _xAnchor = EigGuiAnchorTargetX.kXAnchorCenter;
        [FieldAttr(nst: 172, ctr: 164)] public EigGuiAnchorTargetY _yAnchor = EigGuiAnchorTargetY.kYAnchorCenter;
        [FieldAttr(nst: 176, ctr: 168)] public igVec2fMetaField _texCoordMin = new();
        [FieldAttr(nst: 184, ctr: 176)] public igVec2fMetaField _texCoordMax = new();
        [FieldAttr(nst: 192, ctr: 192)] public igVec4fMetaField _color = new();
        [FieldAttr(ctr: 208)] public igVec4fMetaField _viewport = new();
        [FieldAttr(nst: 208, ctr: 224)] public float _alpha = 1.0f;
        [FieldAttr(nst: 216, ctr: 232)] public igGuiBehaviorList? _behaviors;
        [FieldAttr(nst: 224, ctr: 240)] public igGuiAnimationTable? _animations;
        [FieldAttr(nst: 232, ctr: 248)] public igGuiEventActionTable? _eventActionTable;
        [FieldAttr(nst: 240, ctr: 256)] public igRawRefMetaField _state = new();
        [FieldAttr(nst: 248, ctr: 264)] public igGuiEventTable? _onEventTable;
        [FieldAttr(nst: 256, ctr: 272)] public igGuiDelegateTable? _delegateTable;
    }
}
