namespace Alchemy
{
    [ObjectAttr(nst: 1680, ctr: 1664, align: 8)]
    public class CPlayerJumpComponentData : CEntityComponentData
    {
        public enum EPlayerJumpControl
        {
            ePJC_Velocity = 0,
            ePJC_Curve = 1,
        }

        [FieldAttr(nst: 24, ctr: 16)] public EPlayerJumpControl _playerJumpControl;
        [FieldAttr(nst: 28, ctr: 20)] public float _tapJumpBoostPercentage;
        [FieldAttr(nst: 32, ctr: 24)] public float _glitchJumpHeightBoost = 59.0f;
        [FieldAttr(nst: 36, ctr: 28)] public float _glitchJumpRiseTimeBoost = 0.15f;
        [FieldAttr(nst: 40, ctr: 32)] public float _glitchJumpFallTimeBoost = 0.1f;
        [FieldAttr(nst: 44, ctr: 36)] public bool _glitchJumpEnabled;
        [FieldAttr(nst: 48, ctr: 40)] public float _jumpMudScalar = 0.5f;
        [FieldAttr(nst: 52, ctr: 44)] public float _jumpMudXYMovementScalar = 1.0f;
        [FieldAttr(nst: 56, ctr: 48)] public igVfxRangedCurveMetaField _jumpTransitionCurve = new();
        [FieldAttr(nst: 140, ctr: 132)] public igVfxRangedCurveMetaField _jumpPositionCurve = new();
        [FieldAttr(nst: 224, ctr: 216)] public igVfxRangedCurveMetaField _fallingPositionCurve = new();
        [FieldAttr(nst: 308, ctr: 300)] public float _curveJumpHeight = 110.0f;
        [FieldAttr(nst: 312, ctr: 304)] public float _curveJumpRiseTime = 0.2f;
        [FieldAttr(nst: 316, ctr: 308)] public float _curveJumpHeightCrash2 = 110.0f;
        [FieldAttr(nst: 320, ctr: 312)] public float _curveJumpRiseTimeCrash2 = 0.2f;
        [FieldAttr(nst: 324, ctr: 316)] public float _curveJumpHeightCrash3 = 110.0f;
        [FieldAttr(nst: 328, ctr: 320)] public float _curveJumpRiseTimeCrash3 = 0.2f;
        [FieldAttr(nst: 332, ctr: 324)] public float _curveTimeBeforeApexToPlayJumpToFall = 0.1f;
        [FieldAttr(nst: 336, ctr: 328)] public float _curveFallTime = 0.33f;
        [FieldAttr(nst: 340, ctr: 332)] public float _curveFallTimeCrash2 = 0.33f;
        [FieldAttr(nst: 344, ctr: 336)] public float _curveFallTimeCrash3 = 0.33f;
        [FieldAttr(nst: 348, ctr: 340)] public igVfxRangedCurveMetaField _jumpHeldPositionCurve = new();
        [FieldAttr(nst: 432, ctr: 424)] public igVfxRangedCurveMetaField _jumpHeldFallingPositionCurve = new();
        [FieldAttr(nst: 516, ctr: 508)] public float _heldCurveJumpHeight = 185.0f;
        [FieldAttr(nst: 520, ctr: 512)] public float _heldCurveJumpHeightCrash2 = 185.0f;
        [FieldAttr(nst: 524, ctr: 516)] public float _heldCurveJumpHeightCrash3 = 185.0f;
        [FieldAttr(nst: 528, ctr: 520)] public float _heldCurveJumpRiseTime = 0.4f;
        [FieldAttr(nst: 532, ctr: 524)] public float _heldCurveJumpRiseTimeCrash2 = 0.4f;
        [FieldAttr(nst: 536, ctr: 528)] public float _heldCurveJumpRiseTimeCrash3 = 0.4f;
        [FieldAttr(nst: 540, ctr: 532)] public float _heldCurveFallTime = 0.34999999f;
        [FieldAttr(nst: 544, ctr: 536)] public float _heldCurveFallTimeCrash2 = 0.34999999f;
        [FieldAttr(nst: 548, ctr: 540)] public float _heldCurveFallTimeCrash3 = 0.34999999f;
        [FieldAttr(nst: 552, ctr: 544)] public igVfxRangedCurveMetaField _jumpCrouchPositionCurve = new();
        [FieldAttr(nst: 636, ctr: 628)] public igVfxRangedCurveMetaField _jumpCrouchFallingPositionCurve = new();
        [FieldAttr(nst: 720, ctr: 712)] public float _crouchCurveJumpHeight = 166.0f;
        [FieldAttr(nst: 724, ctr: 716)] public float _crouchCurveJumpRiseTime = 0.4f;
        [FieldAttr(nst: 728, ctr: 720)] public float _crouchCurveFallTime = 0.34999999f;
        [FieldAttr(nst: 732, ctr: 724)] public igVfxRangedCurveMetaField _jumpCrouchHeldPositionCurve = new();
        [FieldAttr(nst: 816, ctr: 808)] public igVfxRangedCurveMetaField _jumpCrouchHeldFallingPositionCurve = new();
        [FieldAttr(nst: 900, ctr: 892)] public float _crouchHeldCurveJumpHeight = 166.0f;
        [FieldAttr(nst: 904, ctr: 896)] public float _crouchHeldCurveJumpRiseTime = 0.4f;
        [FieldAttr(nst: 908, ctr: 900)] public float _crouchHeldCurveFallTime = 0.34999999f;
        [FieldAttr(nst: 912, ctr: 904)] public igVfxRangedCurveMetaField _jumpDoublePositionCurve = new();
        [FieldAttr(nst: 996, ctr: 988)] public igVfxRangedCurveMetaField _jumpDoubleFallingPositionCurve = new();
        [FieldAttr(nst: 1080, ctr: 1072)] public float _doubleCurveJumpHeight = 170.0f;
        [FieldAttr(nst: 1084, ctr: 1076)] public float _doubleCurveJumpRiseTime = 0.328f;
        [FieldAttr(nst: 1088, ctr: 1080)] public float _doubleCurveFallTime = 0.25f;
        [FieldAttr(nst: 1092, ctr: 1084)] public igVfxRangedCurveMetaField _jumpDoubleHeldPositionCurve = new();
        [FieldAttr(nst: 1176, ctr: 1168)] public igVfxRangedCurveMetaField _jumpDoubleHeldFallingPositionCurve = new();
        [FieldAttr(nst: 1260, ctr: 1252)] public float _doubleHeldCurveJumpHeight = 190.0f;
        [FieldAttr(nst: 1264, ctr: 1256)] public float _doubleHeldCurveJumpRiseTime = 0.34999999f;
        [FieldAttr(nst: 1268, ctr: 1260)] public float _doubleHeldCurveFallTime = 0.32499999f;
        [FieldAttr(nst: 1272, ctr: 1264)] public float _spinAttackFallRateMultiplier = 1.0f;
        [FieldAttr(nst: 1276, ctr: 1268)] public float _curveTimeBeforeApexToAllowInput;
        [FieldAttr(nst: 1280, ctr: 1272)] public float _jumpInitialVelocity = 1400.0f;
        [FieldAttr(nst: 1284, ctr: 1276)] public float _jumpHoldGravity = -1500.0f;
        [FieldAttr(nst: 1288, ctr: 1280)] public float _jumpReleaseGravity = -1500.0f;
        [FieldAttr(nst: 1292, ctr: 1284)] public float _minJumpHoldTime;
        [FieldAttr(nst: 1296, ctr: 1288)] public bool _jumpAlongUpOfOwner;
        [FieldAttr(nst: 1297, ctr: 1289)] public bool _forceFlatLanding;
        [FieldAttr(nst: 1300, ctr: 1292)] public float _maxFlatLandingSlope = 45.0f;
        [FieldAttr(nst: 1304, ctr: 1296)] public float _flatLandingSupportRadius = 20.0f;
        [FieldAttr(nst: 1308, ctr: 1300)] public bool _forceSmoothWallCollisions;
        [FieldAttr(nst: 1312, ctr: 1304)] public float _minSmoothWallSlope = 50.0f;
        [FieldAttr(nst: 1316, ctr: 1308)] public float _fallGravity = -1350.0f;
        [FieldAttr(nst: 1320, ctr: 1312)] public float _fallMaxSpeed = -830.0f;
        [FieldAttr(nst: 1324, ctr: 1316)] public float _fallMaxSpeedCrash2 = -1400.0f;
        [FieldAttr(nst: 1328, ctr: 1320)] public float _fallMaxSpeedCrash3 = -1400.0f;
        [FieldAttr(nst: 1332, ctr: 1324)] public float _xyMovementSpeed = 460.0f;
        [FieldAttr(nst: 1336)] public float _xyMovementModifier = 50.0f;
        [FieldAttr(nst: 1340)] public float _xyMovementModifierThreshold = 420.0f;
        [FieldAttr(nst: 1344, ctr: 1328)] public float _xyMovementDamping = 0.89999998f;
        [FieldAttr(nst: 1348, ctr: 1332)] public float _forwardCosAngle;
        [FieldAttr(nst: 1352, ctr: 1336)] public bool _blockAirTurn;
        [FieldAttr(nst: 1353, ctr: 1337)] public bool _ignoreBlockingEdges;
        [FieldAttr(nst: 1356, ctr: 1340)] public float _forwardAirMovementInputThrottle = 7.0f;
        [FieldAttr(nst: 1360, ctr: 1344)] public float _backwardAirMovementInputThrottle = 2.0f;
        [FieldAttr(nst: 1364, ctr: 1348)] public float _curveMovementTime = 0.33f;
        [FieldAttr(nst: 1368, ctr: 1352)] public igVfxRangedCurveMetaField _movementControlCurve = new();
        [FieldAttr(nst: 1456, ctr: 1440)] public CActorInputMap? _airInputMap;
        [FieldAttr(nst: 1464, ctr: 1448)] public float _surfaceVelocityFadeTime = 0.5f;
        [FieldAttr(nst: 1468, ctr: 1452)] public bool _useSurfaceVelocity = true;
        [FieldAttr(nst: 1472, ctr: 1456)] public string? _airLocomotionState = "AirLocomotion";
        [FieldAttr(nst: 1480, ctr: 1464)] public string? _interactionsState = "SharedInteractions";
        [FieldAttr(nst: 1488, ctr: 1472)] public string? _knockAwayState = "HitReacts_Knockaway";
        [FieldAttr(nst: 1496, ctr: 1480)] public string? _groundLocomotionState = "GroundLocomotion";
        [FieldAttr(nst: 1504, ctr: 1488)] public string? _spinAttackState = "Attack_SpinMaster";
        [FieldAttr(nst: 1512, ctr: 1496)] public string? _jumpState = "Jump";
        [FieldAttr(nst: 1520, ctr: 1504)] public string? _jumpToFallState = "JumpToFall";
        [FieldAttr(nst: 1528, ctr: 1512)] public string? _fallState = "Falling";
        [FieldAttr(nst: 1536, ctr: 1520)] public string? _bounceState = "WC_Bounce";
        [FieldAttr(nst: 1544, ctr: 1528)] public string? _landState = "Land";
        [FieldAttr(nst: 1552, ctr: 1536)] public string? _landRunState = "LandRun";
        [FieldAttr(nst: 1560, ctr: 1544)] public float _forwardTurnRateScale = 0.5f;
        [FieldAttr(nst: 1564, ctr: 1548)] public float _backwardTurnRateScale = 0.1f;
        [FieldAttr(nst: 1568, ctr: 1552)] public float _crateTurnRateScale = 0.5f;
        [FieldAttr(nst: 1576, ctr: 1560)] public CGameBoolVariable? _doubleJumpEnabled;
        [FieldAttr(nst: 1584, ctr: 1568)] public bool _killXYVelocityOnDoubleJump = true;
        [FieldAttr(nst: 1588, ctr: 1572)] public float _doubleJumpFallWindow = 40.0f;
        [FieldAttr(nst: 1592, ctr: 1576)] public float _doubleJumpBounceRiseWindow = 100.0f;
        [FieldAttr(nst: 1596, ctr: 1580)] public float _bounceHoldActiveDistance = 100.0f;
        [FieldAttr(nst: 1600, ctr: 1584)] public igHandleMetaField _doubleJumpVfx = new();
        [FieldAttr(nst: 1608, ctr: 1592)] public CFallSpeedModifierList? _fallSpeedModifiers;
        [FieldAttr(nst: 1616, ctr: 1600)] public string? _doubleJumpBehaviorSelectorVariable = "HighJumpSelector";
        [FieldAttr(nst: 1624, ctr: 1608)] public int _doubleJumpSelectorEnabledValue = 1;
        [FieldAttr(nst: 1628, ctr: 1612)] public int _doubleJumpSelectorDisabledValue;
        [FieldAttr(nst: 1632, ctr: 1616)] public float _minCeilingDistanceFromFeet = 68.0f;
        [FieldAttr(nst: 1636, ctr: 1620)] public float _landRunSpeedBumpScale = 0.66f;
        [FieldAttr(nst: 1640, ctr: 1624)] public float _experimentalXYMovementDamping = 0.25f;
        [FieldAttr(nst: 1644, ctr: 1628)] public float _experimentalXYBackwardMovementDamping = 0.1f;
        [FieldAttr(nst: 1648, ctr: 1632)] public igHandleMetaField _akuAkuInvincible = new();
        [FieldAttr(nst: 1656, ctr: 1640)] public float _akuAkuXyMovementSpeed = 460.0f;
        [FieldAttr(nst: 1660, ctr: 1644)] public float _akuAkuXyMovementSpeedCrash2 = 520.0f;
        [FieldAttr(nst: 1664, ctr: 1648)] public float _akuAkuXyMovementSpeedCrash3 = 520.0f;
        [FieldAttr(nst: 1668, ctr: 1652)] public float _sprintXyMovementSpeed = 664.29998779f;
        [FieldAttr(nst: 1672, ctr: 1656)] public float _sprintXyMovementSpeedCrash2 = 664.29998779f;
        [FieldAttr(nst: 1676, ctr: 1660)] public float _sprintXyMovementSpeedCrash3 = 664.29998779f;
    }
}
