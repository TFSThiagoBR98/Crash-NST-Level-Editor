namespace Alchemy
{
    [ObjectAttr(nst: 232, ctr: 232, align: 8)]
    public class igGuiProject : igObject
    {
        [ObjectAttr(size: 1)]
        public class BitfieldStorage : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _canHaveFocus = true;
            [FieldAttr(offset: 1, size: 1)] public bool _renderWhenDisabled;
            [FieldAttr(offset: 2, size: 1)] public bool _updateWhenDisabled;
            [FieldAttr(offset: 3, size: 1)] public bool _onSubScreen;
            [FieldAttr(offset: 4, size: 1)] public bool _deactivated;
            [FieldAttr(offset: 5, size: 1)] public bool _isEnabled;
            [FieldAttr(offset: 6, size: 1)] public bool _allowTouchInput;
        }

        [FieldAttr(nst: 16, ctr: 16)] public igGuiPlaceable? _rootPlaceable;
        [FieldAttr(nst: 24, ctr: 24)] public igGuiAssetList? _assets;
        [FieldAttr(nst: 32, ctr: 32)] public int _priority;
        [FieldAttr(nst: 36, ctr: 36)] public int _disableUnder;
        [FieldAttr(nst: 40, ctr: 40)] public uint _updateFrequency = 1;
        [FieldAttr(nst: 44, ctr: 44)] public uint _frameCount;
        [FieldAttr(nst: 48, ctr: 48)] public float _timeSinceLastUpdate;
        [FieldAttr(nst: 52, ctr: 52)] public BitfieldStorage _bitfieldStorage = new();
        [FieldAttr(nst: 56, ctr: 56)] public igUpdater? _updater;
        [FieldAttr(nst: 64, ctr: 64)] public igGuiProjectParameters.EQueueType _queueBehavior;
        [FieldAttr(nst: 68, ctr: 68)] public igGuiInput.EController _control;
        [FieldAttr(nst: 72, ctr: 72)] public int _controlDisableCount;
        [FieldAttr(nst: 80, ctr: 80)] public igGuiPlaceable[] _focusPlaceable = new igGuiPlaceable[8];
        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igGuiContext? _context;
        [FieldAttr(nst: 152, ctr: 152, refCount: false)] public igGuiProject? _sourceProject;
        [FieldAttr(nst: 160, ctr: 160)] public igGuiInstanceMap? _instanceMap;
        [FieldAttr(nst: 168, ctr: 168)] public igObject? _gameData;
        [FieldAttr(nst: 176, ctr: 176)] public igVectorMetaField<igGuiAction> _activeActions = new();
        [FieldAttr(nst: 200, ctr: 200)] public float _authoredScreenWidth;
        [FieldAttr(nst: 204, ctr: 204)] public float _authoredScreenHeight;
        [FieldAttr(nst: 208, ctr: 208)] public igVectorMetaField<igHandleMetaFieldInstance> _runtimePlaceables = new();
    }
}
