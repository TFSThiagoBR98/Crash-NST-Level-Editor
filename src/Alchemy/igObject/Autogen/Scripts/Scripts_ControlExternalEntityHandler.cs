namespace Alchemy
{
    [ObjectAttr(nst: 264, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_ControlExternalEntityHandler : CBehaviorLogic
    {
        public enum ExternalControlMode
        {
            Physics = 0,
            FollowGroundXY = 1,
            Actor = 2,
        }

        [FieldAttr(nst: 80)] public bool CreatingEntity = true;
        [FieldAttr(nst: 81)] public bool AllowAirCreation;
        [FieldAttr(nst: 82)] public bool DespawnCreatedEntity = true;
        [FieldAttr(nst: 84)] public float InitialDistance = 100.0f;
        [FieldAttr(nst: 88)] public CGameEntityData? ControlledEntity;
        [FieldAttr(nst: 96)] public float TimeToTurnToDirection = -1.0f;
        [FieldAttr(nst: 100)] public igEntity.ENetworkSpawnAuthority NetAuthority;
        [FieldAttr(nst: 104)] public bool SendMessagesToControlledEntity;
        [FieldAttr(nst: 105)] public bool SendControlledEntityCreatedMessage;
        [FieldAttr(nst: 106)] public bool SendControlledEntityRemovedMessage;
        [FieldAttr(nst: 107)] public bool SendMaxDistanceReachedMessage;
        [FieldAttr(nst: 108)] public bool SendControlExternalEntityEndMessage;
        [FieldAttr(nst: 109)] public bool SendFailureToCreateMessage;
        [FieldAttr(nst: 110)] public bool SendCreatedEntityEvent;
        [FieldAttr(nst: 112)] public CCustomEvent? StartControllingEntityEvent;
        [FieldAttr(nst: 120)] public CCustomEvent? StopControllingEntityEvent;
        [FieldAttr(nst: 128)] public CCustomEvent? ControlledEntityCreatedEvent;
        [FieldAttr(nst: 136)] public CCustomEvent? ControlledEntityRemovedEvent;
        [FieldAttr(nst: 144)] public CCustomEvent? MaxDistanceReachedEvent;
        [FieldAttr(nst: 152)] public CCustomEvent? ControlExternalEntityEndEvent;
        [FieldAttr(nst: 160)] public CCustomEvent? FailureToCreateEvent;
        [FieldAttr(nst: 168)] public CCustomEventEntity? CreatedEntityEvent;
        [FieldAttr(nst: 176)] public float MaxDistance;
        [FieldAttr(nst: 180)] public float MinDistance;
        [FieldAttr(nst: 184)] public CUpgradeableFloat? SpeedModifierUpgradeable;
        [FieldAttr(nst: 192)] public Vector3? Gravity;
        [FieldAttr(nst: 200)] public ExternalControlMode ControlMode;
        [FieldAttr(nst: 204)] public bool ForceForward;
        [FieldAttr(nst: 205)] public bool ForceFowardFullSpeed;
        [FieldAttr(nst: 206)] public bool AddSpeedWithInputWhenForceForward;
        [FieldAttr(nst: 208)] public float MaxAngleValue = 360.0f;
        [FieldAttr(nst: 212)] public float MaxFollowHeight = 1000.0f;
        [FieldAttr(nst: 216)] public float MinFollowHeight = -400.0f;
        [FieldAttr(nst: 220)] public float ZOffset;
        [FieldAttr(nst: 224)] public float MaxHeightDisplacement = 1000.0f;
        [FieldAttr(nst: 228)] public bool FaceControlledEntity;
        [FieldAttr(nst: 232)] public float TimeToTurn = 0.1f;
        [FieldAttr(nst: 236)] public float FaceDeadZone;
        [FieldAttr(nst: 240)] public string? ExternalControlEndEvent = null;
        [FieldAttr(nst: 248)] public CEntityMessage? ExternalControlEndMessage;
        [FieldAttr(nst: 256)] public bool UseRightStick;
    }
}
