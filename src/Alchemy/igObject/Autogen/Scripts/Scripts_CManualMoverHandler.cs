namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_CManualMoverHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public float _stickThreshold = 0.3f;
        [FieldAttr(nst: 84)] public float _movementSpeed = 750.0f;
        [FieldAttr(nst: 88)] public float _fallGravity = 500.0f;
        [FieldAttr(nst: 92)] public bool _setVelocityDirectly = true;
        [FieldAttr(nst: 93)] public bool _useActorDirection;
        [FieldAttr(nst: 94)] public bool _resetVelocityEachFrame = true;
        [FieldAttr(nst: 95)] public bool _enableDeceleration;
        [FieldAttr(nst: 96)] public bool _onlyDecelerateWhileMoving = true;
        [FieldAttr(nst: 100)] public float _decelerationMinSpeed;
        [FieldAttr(nst: 104)] public float _decelerationRate = 300.0f;
        [FieldAttr(nst: 108)] public float _decelerationDelay;
        [FieldAttr(nst: 112)] public float _maxDuration;
        [FieldAttr(nst: 120)] public string? _cancelEvent = null;
    }
}
