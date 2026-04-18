namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 112, align: 8)]
    public class CAudioGraphDriverModeRubberBurning : CAudioGraphDriverModeTargetBased
    {
        [FieldAttr(nst: 56, ctr: 64)] public float _idleEngineValue;
        [FieldAttr(ctr: 68)] public float _idleGraphInputChangePerSecond;
        [FieldAttr(nst: 60, ctr: 72)] public float _failedEngineValue = 0.3f;
        [FieldAttr(ctr: 76)] public float _decreaseGraphInputChangePerSecond;
        [FieldAttr(nst: 64, ctr: 80)] public float _successEngineValue = 0.8f;
        [FieldAttr(ctr: 84)] public float _increaseGraphInputChangePerSecond;
        [FieldAttr(ctr: 88)] public igHandleMetaField _meterFailOneShot = new();
        [FieldAttr(nst: 68, ctr: 96)] public igRangedFloatMetaField _engineRange = new();
        [FieldAttr(ctr: 104)] public bool _wasInBackfire;
    }
}
