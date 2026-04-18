namespace Alchemy
{
    [ObjectAttr(nst: 232, ctr: 240, align: 8)]
    public class CGuiBehaviorSetPrimaryController : CGuiBehavior
    {
        public enum EState
        {
            eS_DelayingPressStart = 0,
            eS_WaitingForStartPress = 1,
            eS_LoadingSlotsAndOptions = 2,
            eS_NeedSpaceVerification = 3,
            eS_SavingOptionsFile = 4,
            eS_InstallingTrophies = 5,
            eS_LoadingGame = 6,
            eS_DelayingSaveSlots = 7,
            eS_Finished = 8,
        }

        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igGuiPlaceable? _pressStartPlaceable;
        [FieldAttr(nst: 152, ctr: 152)] public igHandleMetaField _pressedStartSound = new();
        [FieldAttr(nst: 160, ctr: 160)] public igHandleMetaField _effectKilledSound = new();
        [FieldAttr(nst: 168, ctr: 168)] public float _pressStartDelay;
        [FieldAttr(nst: 172, ctr: 172)] public float _saveSlotsDelay;
        [FieldAttr(nst: 176, ctr: 176)] public bool _allowOverridePrimaryController;
        [FieldAttr(nst: 180, ctr: 180)] public int _loadSaveSlot = -1;
        [FieldAttr(nst: 184, ctr: 184)] public CTimer? _timer;
        [FieldAttr(nst: 192, ctr: 192)] public EState _state;
        [FieldAttr(nst: 200, ctr: 200)] public string? _pressStartString = null;
        [FieldAttr(nst: 208, ctr: 208)] public igHandleMetaField _licenseProject = new();
        [FieldAttr(nst: 216, ctr: 216)] public igHandleMetaField _iCloudDialog = new();
        [FieldAttr(nst: 224, ctr: 224)] public EState _farthestState;
        [FieldAttr(ctr: 232)] public igHandleMetaField _configDownloadDialog = new();
    }
}
