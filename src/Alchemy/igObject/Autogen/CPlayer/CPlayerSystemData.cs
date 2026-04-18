namespace Alchemy
{
    [ObjectAttr(nst: 176, ctr: 176, align: 8)]
    public class CPlayerSystemData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _resistanceConstant = 100.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _strengthConstant = 100.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _speedConstantCoef = 2.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _speedConstantOffset = 170.0f;
        [FieldAttr(nst: 32, ctr: 28)] public float _stickSpeedLimit = 2.0f;
        [FieldAttr(nst: 40, ctr: 32)] public CActorInputMap? _controllerInputMap;
        [FieldAttr(nst: 48, ctr: 40)] public CActorInputMap? _virtualControllerInputMap;
        [FieldAttr(nst: 56, ctr: 48)] public float _lowHealthThreshold = 20.0f;
        [FieldAttr(nst: 64, ctr: 56)] public igHandleMetaField _lowHealthVfx = new();
        [FieldAttr(nst: 72, ctr: 64)] public igHandleMetaField _lowHealthVfxBoltPoint = new();
        [FieldAttr(nst: 80, ctr: 72)] public float _criticalHealthThreshold = 20.0f;
        [FieldAttr(nst: 88, ctr: 80)] public igHandleMetaField _criticalHealthVfx = new();
        [FieldAttr(nst: 96, ctr: 88)] public igHandleMetaField _coopTetherVfx = new();
        [FieldAttr(nst: 104, ctr: 96)] public igHandleMetaField _coopTetherRespawnVfx = new();
        [FieldAttr(nst: 112, ctr: 104)] public float _heightOfPlayerCollisionEnds = 25.0f;
        [FieldAttr(nst: 120, ctr: 112)] public CButtonAliasMapping? _buttonAliasMapping;
        [FieldAttr(nst: 128, ctr: 120)] public float _maxGroundSlopeCosine = 0.70710683f;
        [FieldAttr(nst: 132, ctr: 124)] public float _maxCeilingSlopeCosine = 0.70710683f;
        [FieldAttr(nst: 136, ctr: 128)] public float _landDistance = 4.0f;
        [FieldAttr(nst: 140, ctr: 132)] public float _maxVelocityForFlattenedLanding = 8.0f;
        [FieldAttr(nst: 144, ctr: 136)] public float _capsuleRadius = 24.0f;
        [FieldAttr(nst: 148, ctr: 140)] public float _stuckFallingDistanceThreshold = 20.0f;
        [FieldAttr(nst: 152, ctr: 144)] public float _stuckFallingTime = 3.0f;
        [FieldAttr(nst: 160, ctr: 152)] public string? _defaultCharacterName = "TemplateLegacy";
        [FieldAttr(nst: 168, ctr: 160)] public CCameraTargetComponentData? _defaultCameraTargetComponent;
        [FieldAttr(ctr: 168)] public int _maxUndockedLocalPlayerCount;
    }
}
