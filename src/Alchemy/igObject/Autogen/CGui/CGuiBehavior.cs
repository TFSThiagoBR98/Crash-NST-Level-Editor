namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 8)]
    public class CGuiBehavior : igGuiBehavior
    {
        public enum ETouchHandlingMode
        {
            eTHM_None = 0,
            eTHM_Focus = 1,
            eTHM_FocusThenSelect = 2,
            eTHM_FocusAndSelect = 3,
        }

        public enum ENetworkSyncWaitMode
        {
            eNSWM_None = 0,
            eNSWM_SyncWait = 1,
            eNSWM_SyncWaitForUi = 2,
        }

        public enum ETouchStatus
        {
            eTS_TouchedWithoutFocus = 0,
            eTS_TouchedWithFocus = 1,
            eTS_Idle = 2,
        }

        [FieldAttr(nst: 16, ctr: 16)] public CGuiBaseSoundContainer? _soundContainer;
        [FieldAttr(nst: 24, ctr: 24)] public CGuiButtonLegendTable? _defaultButtonLegendData;
        [FieldAttr(nst: 32, ctr: 32)] public ETouchHandlingMode _touchHandlingMode = CGuiBehavior.ETouchHandlingMode.eTHM_FocusThenSelect;
        [FieldAttr(nst: 36, ctr: 36)] public igVec2fMetaField _touchPadding = new();
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igGuiPlaceable? _touchFocusPlaceable;
        [FieldAttr(nst: 56)] public bool _shoudFocusOnHover;
        [FieldAttr(nst: 57, ctr: 56)] public bool _logEvents;
        [FieldAttr(nst: 64, ctr: 64)] public string? _networkEventName = null;
        [FieldAttr(nst: 72, ctr: 72)] public ENetworkSyncWaitMode _networkSyncWait;
        [FieldAttr(nst: 76, ctr: 76)] public bool _usesNetworkFeatures;
        [FieldAttr(nst: 80, ctr: 80)] public uint _overrideRenderingMode;
        [FieldAttr(nst: 88, ctr: 88)] public CTimer? _activeTimer;
        [FieldAttr(nst: 96, ctr: 96, refCount: false)] public igGuiPlaceable? _place;
        [FieldAttr(nst: 104, ctr: 104)] public CEGuiMenuSoundList? _soundsPlayed;
        [FieldAttr(nst: 112, ctr: 112)] public ETouchStatus _touchStatus = CGuiBehavior.ETouchStatus.eTS_Idle;
        [FieldAttr(nst: 116, ctr: 116)] public igVec2fMetaField _touchPosition = new();
        [FieldAttr(nst: 124, ctr: 124)] public igGuiInput.EController _touchControl;
        [FieldAttr(nst: 128, ctr: 128)] public CChangeRequest? _syncWaitRequest;
        [FieldAttr(nst: 136)] public igGuiInput.ESignal _touchSignal = igGuiInput.ESignal.kSignalButtonSelect;
        [FieldAttr(nst: 140, ctr: 136)] public bool _updatedOnce;
    }
}
