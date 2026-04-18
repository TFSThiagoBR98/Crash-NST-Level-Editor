namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 8)]
    public class CVehicleRiderData : igObject
    {
        [FieldAttr(nst: 16)] public CBoltPoint? _boltPoint;
        [FieldAttr(nst: 24)] public CBoltPoint? _transformationBoltPoint;
        [FieldAttr(nst: 32)] public bool _hideRider;
        [FieldAttr(nst: 40)] public igHandleMetaField _teleportToDrivingVfx = new();
        [FieldAttr(nst: 48)] public string? _enterEvent = "DrivingVehicle_Enter";
        [FieldAttr(nst: 56)] public string? _secondaryEnterEvent = "";
        [FieldAttr(nst: 64)] public string? _exitEvent = "Locomotion";
        [FieldAttr(nst: 72)] public string? _secondaryExitEvent = "";
        [FieldAttr(nst: 80)] public string? _exitModEvent = "CharacterModFadeOut";
        [FieldAttr(nst: 88)] public string? _idleEvent = "Drive_Idle";
        [FieldAttr(nst: 96)] public string? _idleState = "Drive_Idle";
        [FieldAttr(nst: 104)] public string? _movingEvent = "Drive_Run";
        [FieldAttr(nst: 112)] public string? _movingState = "Drive_Run";
        [FieldAttr(nst: 120)] public float _movingSpeedThreshold = 300.0f;
        [FieldAttr(nst: 128)] public string? _impactEvent = "Drive_Impact";
        [FieldAttr(nst: 136)] public float _impactSpeedThreshold = 300.0f;
        [FieldAttr(nst: 140)] public float _impactCooldown = 2.0f;
    }
}
