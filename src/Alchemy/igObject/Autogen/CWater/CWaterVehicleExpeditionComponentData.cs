namespace Alchemy
{
    [ObjectAttr(nst: 216, align: 8)]
    public class CWaterVehicleExpeditionComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public EXBUTTON _ascendButton = EXBUTTON.JUMP;
        [FieldAttr(nst: 28)] public bool _useStickForMoveForward = true;
        [FieldAttr(nst: 29)] public bool _useButtonForMoveForward;
        [FieldAttr(nst: 32)] public EXBUTTON _moveForwardButton = EXBUTTON.R2;
        [FieldAttr(nst: 36)] public float _maxAngle = 37.0f;
        [FieldAttr(nst: 40)] public float _yawTurnRate = 90.0f;
        [FieldAttr(nst: 44)] public float _stickThreshold = 0.3f;
        [FieldAttr(nst: 48)] public float _maxHorizontalMovement = 400.0f;
        [FieldAttr(nst: 52)] public float _horizontalAcceleration = 600.0f;
        [FieldAttr(nst: 56)] public float _horizontalDeacceleration = 300.0f;
        [FieldAttr(nst: 60)] public float _maxVerticalMovement = 400.0f;
        [FieldAttr(nst: 64)] public float _verticalAcceleration = 600.0f;
        [FieldAttr(nst: 72)] public CSliderData? _verticalSliderData;
        [FieldAttr(nst: 80)] public float _verticalDeacceleration = 300.0f;
        [FieldAttr(nst: 84)] public float _runThreshold = 5.0f;
        [FieldAttr(nst: 88)] public string? _enterBehaviorState = "Expedition_Enter";
        [FieldAttr(nst: 96)] public string? _enterBehaviorEvent = "Expedition_Enter";
        [FieldAttr(nst: 104)] public string? _idleBehaviorState = "Expedition_Idle";
        [FieldAttr(nst: 112)] public string? _idleBehaviorEvent = "Expedition_Idle";
        [FieldAttr(nst: 120)] public string? _riseBehaviorState = "Expedition_Rise";
        [FieldAttr(nst: 128)] public string? _riseBehaviorEvent = "Expedition_Rise";
        [FieldAttr(nst: 136)] public string? _diveBehaviorState = "Expedition_Dive";
        [FieldAttr(nst: 144)] public string? _diveBehaviorEvent = "Expedition_Dive";
        [FieldAttr(nst: 152)] public string? _runBehaviorState = "Expedition_Run";
        [FieldAttr(nst: 160)] public string? _runBehaviorEvent = "Expedition_Run";
        [FieldAttr(nst: 168)] public igRangedFloatMetaField _raycastRange = new();
        [FieldAttr(nst: 176)] public float _groundDistance = 40.0f;
        [FieldAttr(nst: 180)] public float _groundDistanceTolerance = 40.0f;
        [FieldAttr(nst: 184)] public float _groundToleranceSpringConstant = 0.01f;
        [FieldAttr(nst: 188)] public float _groundToleranceDampingConstant = 0.1f;
        [FieldAttr(nst: 192)] public bool _hoverWhileAttacking = true;
        [FieldAttr(nst: 196)] public float _hoverAttackDistanceTolerance = 10.0f;
        [FieldAttr(nst: 200)] public float _hoverAttackSpringConstant = 0.01f;
        [FieldAttr(nst: 204)] public float _hoverAttackDampingConstant = 0.1f;
        [FieldAttr(nst: 208)] public igHandleMetaField _jumpVfx = new();
    }
}
