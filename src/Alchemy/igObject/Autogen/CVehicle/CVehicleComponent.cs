namespace Alchemy
{
    [ObjectAttr(nst: 288, align: 8)]
    public class CVehicleComponent : CEntityComponent
    {
        public enum EVehicleMode
        {
            eVM_None = 0,
            eVM_Arena = 1,
            eVM_Linear = 2,
            eVM_Classic = 3,
            eVM_Expedition = 4,
        }

        public enum EVehicleForm
        {
            eVF_None = -1,
            eVF_Invisible = 0,
            eVF_Spawning = 1,
            eVF_Parked = 2,
            eVF_UnDocking = 3,
            eVF_Driving = 4,
            eVF_Docking = 5,
            eVF_Disembarking = 6,
            eVF_ExitingTrack = 7,
        }

        public enum EVehicleSplineState
        {
            eVSS_None = -1,
            eVSS_BasicSpline = 0,
            eVSS_HalfPipe = 1,
        }

        [FieldAttr(nst: 48)] public EVehicleForm _form = CVehicleComponent.EVehicleForm.eVF_None;
        [FieldAttr(nst: 52)] public EVehicleMode _mode;
        [FieldAttr(nst: 56)] public EPlayerId _driverId = EPlayerId.EPLAYERID_NONE;
        [FieldAttr(nst: 60)] public EPlayerId _passengerId = EPlayerId.EPLAYERID_NONE;
        [FieldAttr(nst: 64)] public EVehicleId _vehicleId = EVehicleId.EVEHICLEID_NONE;
        [FieldAttr(nst: 72)] public igHandleMetaField _driverPlayer = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _passengerPlayer = new();
        [FieldAttr(nst: 88)] public igVec3fMetaField _passengerExitPoint = new();
        [FieldAttr(nst: 100)] public EVehicleMode _pendingMode;
        [FieldAttr(nst: 104)] public EVehicleForm _pendingForm = CVehicleComponent.EVehicleForm.eVF_None;
        [FieldAttr(nst: 112)] public CEntityComponentHandleList? _modeSpecificComponents;
        [FieldAttr(nst: 120)] public CEntityComponentHandleList? _arenaModeSpecificComponents;
        [FieldAttr(nst: 128)] public CEntityComponentHandleList? _linearModeSpecificComponents;
        [FieldAttr(nst: 136)] public CEntityComponentHandleList? _classicModeSpecificComponents;
        [FieldAttr(nst: 144)] public CEntityComponentHandleList? _expeditionModeSpecificComponents;
        [FieldAttr(nst: 152)] public COnFormChangeDelegate? _onFormChange;
        [FieldAttr(nst: 160)] public COnFormChangeEventList? _onFormChangeEventList;
        [FieldAttr(nst: 168)] public COnModeChangeDelegate? _onModeChange;
        [FieldAttr(nst: 176)] public COnModeChangeEventList? _onModeChangeEventList;
        [FieldAttr(nst: 184)] public COnVehiclePlayerChangeDelegate? _onVehiclePlayerChange;
        [FieldAttr(nst: 192)] public COnVehiclePlayerChangeEventList? _onVehiclePlayerChangeEventList;
        [FieldAttr(nst: 200)] public COnLockChangeEventList? _onLockChangeEventList;
        [FieldAttr(nst: 208)] public igHandleMetaField _transitionVfx = new();
        [FieldAttr(nst: 216)] public EVehicleMode _startingMode;
        [FieldAttr(nst: 220)] public bool _isVehicleTargetingStarted;
        [FieldAttr(nst: 221)] public bool _magicMomentDisabled;
        [FieldAttr(nst: 224, refCount: false)] public CVehicleBoostData? _transformBoostData;
        [FieldAttr(nst: 232)] public bool _initialized;
        [FieldAttr(nst: 233)] public bool _forwardTransformMomentumActive;
        [FieldAttr(nst: 234)] public bool _forwardTransformMomentumUseAlt;
        [FieldAttr(nst: 236)] public float _forwardTransformMomentum;
        [FieldAttr(nst: 240)] public float _forwardTransformMomentumAlt;
        [FieldAttr(nst: 248)] public CChangeRequestList? _changeRequests;
        [FieldAttr(nst: 256)] public bool _vehicleCombatEnabled = true;
        [FieldAttr(nst: 257)] public bool _vehicleHavokEnabled = true;
        [FieldAttr(nst: 258)] public bool _vehicleMovementEnabled = true;
        [FieldAttr(nst: 259)] public bool _vehicleBoltedToDock;
        [FieldAttr(nst: 264)] public igHandleMetaField _vehicleBolter = new();
        [FieldAttr(nst: 272)] public EVehicleSplineState _vehicleSplineState = CVehicleComponent.EVehicleSplineState.eVSS_None;
        [FieldAttr(nst: 276)] public bool _locked;
        [FieldAttr(nst: 280)] public EVehicleMode _lockedMode;
        [FieldAttr(nst: 284)] public bool _allowFiringModeEnterEvents;
    }
}
