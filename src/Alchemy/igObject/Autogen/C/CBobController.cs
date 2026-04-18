namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 120, align: 8)]
    public class CBobController : CBaseMovementController
    {
        public enum ETransformSpace
        {
            eTS_World = 0,
            eTS_Local = 1,
        }

        [FieldAttr(nst: 56, ctr: 48)] public igRangedFloatMetaField _amplitudeRange = new();
        [FieldAttr(nst: 64, ctr: 56)] public igRangedFloatMetaField _bobsPerSecondRange = new();
        [FieldAttr(nst: 72, ctr: 64)] public float _damper;
        [FieldAttr(nst: 76, ctr: 68)] public float _duration = -1.0f;
        [FieldAttr(nst: 80, ctr: 72)] public igVec3fMetaField _bobDirection = new();
        [FieldAttr(nst: 92, ctr: 84)] public ETransformSpace _bobDirectionSpace = ETransformSpace.eTS_Local;
        [FieldAttr(nst: 96, ctr: 88)] public bool _resetOnStart;
        [FieldAttr(nst: 100, ctr: 92)] public EBobResetType _resetType = EBobResetType.eBRT_ResetDirection;
        [FieldAttr(nst: 104, ctr: 96)] public float _timeElapsed;
        [FieldAttr(nst: 108, ctr: 100)] public float _lastNetTimeElapsed;
        [FieldAttr(nst: 112, ctr: 104)] public float _previousBounceOffset;
        [FieldAttr(nst: 116, ctr: 108)] public float _amplitude;
        [FieldAttr(nst: 120, ctr: 112)] public float _bobsPerSecond;
    }
}
