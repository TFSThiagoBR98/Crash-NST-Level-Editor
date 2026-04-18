namespace Alchemy
{
    [ObjectAttr(nst: 1536, ctr: 1560, align: 8)]
    public class igGuiContext : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igRenderer? _renderer;
        [FieldAttr(nst: 24, ctr: 24)] public igVfxManager? _vfxManager;
        [FieldAttr(ctr: 32)] public float _sceneWidthMain;
        [FieldAttr(ctr: 36)] public float _sceneHeightMain;
        [FieldAttr(nst: 32, ctr: 40)] public float _viewerWidthMain;
        [FieldAttr(nst: 36, ctr: 44)] public float _viewerHeightMain;
        [FieldAttr(nst: 40, ctr: 48)] public float _settingWidthMain;
        [FieldAttr(nst: 44, ctr: 52)] public float _settingHeightMain;
        [FieldAttr(nst: 48, ctr: 56)] public float _screenWidthSub;
        [FieldAttr(nst: 52, ctr: 60)] public float _screenHeightSub;
        [FieldAttr(nst: 56, ctr: 64)] public float _expectedScreenWidth;
        [FieldAttr(nst: 60, ctr: 68)] public float _expectedScreenHeight;
        [FieldAttr(nst: 64, ctr: 72)] public bool _toolViewerIsRunning;
        [FieldAttr(nst: 68, ctr: 76)] public float _toolViewerZoomLevel = 1.0f;
        [FieldAttr(ctr: 80)] public bool _toolViewerSimulateRightToLeftLanguage;
        [FieldAttr(nst: 72, ctr: 88)] public igGuiProjectList? _projects;
        [FieldAttr(nst: 80, ctr: 96)] public igGuiProjectList? _temporaryProjectsList;
        [FieldAttr(nst: 88, ctr: 104)] public igGuiProjectList? _updateEnableTemporaryProjectsList;
        [FieldAttr(nst: 96, ctr: 112)] public igGuiProjectList? _queuedProjects;
        [FieldAttr(nst: 104, ctr: 120)] public igGuiInput? _input;
        [FieldAttr(nst: 112, ctr: 128)] public igGuiAnimationCombiner? _animation;
        [FieldAttr(nst: 120, ctr: 136)] public igGuiVisualizer? _visualizer;
        [FieldAttr(nst: 128, ctr: 144)] public igGuiEventTouchPressed? _touchPressedEvent;
        [FieldAttr(nst: 136, ctr: 152)] public igGuiEventTouchReleased? _touchReleasedEvent;
        [FieldAttr(nst: 144, ctr: 160)] public igGuiEventTouchCanceled? _touchCanceledEvent;
        [FieldAttr(nst: 152, ctr: 168)] public igGuiEventProjectInputPressed? _projectInputPressedEvent;
        [FieldAttr(nst: 160, ctr: 176)] public igGuiEventFocusInputPressed? _focusInputPressedEvent;
        [FieldAttr(nst: 168, ctr: 184)] public igGuiEventProjectInputRepeated? _projectInputRepeatedEvent;
        [FieldAttr(nst: 176, ctr: 192)] public igGuiEventFocusInputRepeated? _focusInputRepeatedEvent;
        [FieldAttr(nst: 184, ctr: 200)] public igGuiEventProjectInputReleased? _projectInputReleasedEvent;
        [FieldAttr(nst: 192, ctr: 208)] public igGuiEventFocusInputReleased? _focusInputReleasedEvent;
        [FieldAttr(nst: 200, ctr: 216)] public igMutex? _lock;
        [FieldAttr(nst: 208, ctr: 224)] public bool _disableUpdate;
        [FieldAttr(nst: 209, ctr: 225)] public bool _disableRender;
        [FieldAttr(nst: 210, ctr: 226)] public bool _disableControl;
        [FieldAttr(nst: 216, ctr: 232)] public igHandleMetaField[] _touchFocus = new igHandleMetaField[40];
        [FieldAttr(nst: 536, ctr: 552)] public igVec2fMetaField[] _initialTouchPosition = new igVec2fMetaField[40];
        [FieldAttr(nst: 856, ctr: 872)] public igVec2fMetaField[] _lastTouchPosition = new igVec2fMetaField[40];
        [FieldAttr(nst: 1176, ctr: 1192)] public igHandleMetaField[] _hoverFocus = new igHandleMetaField[40];
        [FieldAttr(nst: 1496, ctr: 1512)] public float _forceScreenWidth;
        [FieldAttr(nst: 1500, ctr: 1516)] public float _forceScreenHeight;
        [FieldAttr(nst: 1504, ctr: 1520)] public float _deltaTime;
        [FieldAttr(nst: 1512)] public igRawRefMetaField _projectOpenedCallback = new();
        [FieldAttr(nst: 1520)] public igRawRefMetaField _projectClosedCallback = new();
        [FieldAttr(nst: 1528, ctr: 1544)] public uint _maxControllers = 8;
        [FieldAttr(ctr: 1552)] public igGuiContextPeachesCallback? _callback;
    }
}
