namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 8, metaType: typeof(CBehaviorLogic))]
    public class Scripts_ManualMoverWithAccelerationHandler : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public float _speedXY = 750.0f;
        [FieldAttr(nst: 84)] public float _speedXYBoost = 1000.0f;
        [FieldAttr(nst: 88)] public float _accelerationXY = 1000.0f;
        [FieldAttr(nst: 92)] public float _decelerationXY = 1000.0f;
        [FieldAttr(nst: 96)] public bool _zeroVelocityOnExit = true;
        [FieldAttr(nst: 97)] public bool _useAccelerationWhenChangingDirection = true;
        [FieldAttr(nst: 98)] public bool _useActorDirectionNotStick;
        [FieldAttr(nst: 99)] public bool _accelerationDisabled;
        [FieldAttr(nst: 100)] public float _twistSpeed = 90.0f;
        [FieldAttr(nst: 104)] public float _twistThreshold = 20.0f;
    }
}
