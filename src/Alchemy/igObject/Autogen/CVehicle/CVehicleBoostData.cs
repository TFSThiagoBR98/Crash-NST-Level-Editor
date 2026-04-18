namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 8)]
    public class CVehicleBoostData : igObject
    {
        [FieldAttr(nst: 16)] public float _speed = 3000.0f;
        [FieldAttr(nst: 20)] public float _minimumSpeed;
        [FieldAttr(nst: 24)] public float _maximumSpeed = -1.0f;
        [FieldAttr(nst: 28)] public float _gravityMultiplier;
        [FieldAttr(nst: 32)] public float _boostDelayDuration;
        [FieldAttr(nst: 36)] public float _boostInDuration;
        [FieldAttr(nst: 40)] public float _boostSustainDuration = 1.0f;
        [FieldAttr(nst: 44)] public float _boostOutDuration;
        [FieldAttr(nst: 48)] public bool _allowJumping = true;
        [FieldAttr(nst: 56)] public igHandleMetaField _boostActivatedVfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _vehicleBoostVfx = new();
        [FieldAttr(nst: 72)] public CBoltPoint? _vehicleVfxBoltPoint;
        [FieldAttr(nst: 80)] public igHandleMetaField _boostActivatedSfx = new();
        [FieldAttr(nst: 88)] public float _cameraFovModifier = 0.2f;
        [FieldAttr(nst: 92)] public bool _reorientToDirectionOfBoostEntity;
        [FieldAttr(nst: 96)] public float _reorientMagnitude = 1.0f;
        [FieldAttr(nst: 100)] public float _reorientdecayDelay = 0.5f;
        [FieldAttr(nst: 104)] public float _reorientdecayDuration = 0.5f;
    }
}
