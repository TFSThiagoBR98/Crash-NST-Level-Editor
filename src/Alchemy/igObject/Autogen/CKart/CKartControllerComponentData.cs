namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CKartControllerComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public string? _jumpEventName;
        [FieldAttr(ctr: 24)] public string? _landEventName;
        [FieldAttr(ctr: 32)] public string? _trickJumpEventName;
        [FieldAttr(ctr: 40)] public float _raycastOffsetGround;
        [FieldAttr(ctr: 44)] public float _onGroundDistance;
        [FieldAttr(ctr: 48)] public float _upSlopeMinGroundAngleProjection;
        [FieldAttr(ctr: 52)] public float _upSlopeMaxKartFacingAngleProjection;
        [FieldAttr(ctr: 56)] public bool _debug;
        [FieldAttr(ctr: 60)] public float _movingFloorJumpVelocityDropoff;
        [FieldAttr(ctr: 64)] public float _mudSinkSpeed;
        [FieldAttr(ctr: 68)] public float _jumpAddedImpulsePerInchesBelowMud;
        [FieldAttr(ctr: 72)] public igHandleMetaField _icyMaterial = new();
    }
}
