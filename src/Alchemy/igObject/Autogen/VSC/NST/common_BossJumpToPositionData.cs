namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 4, metaType: typeof(CVscComponentData))]
    public class common_BossJumpToPositionData : CVscComponentData
    {
        public enum ENewEnum7_id_i6t67tyq
        {
            None = 0,
            OnGraphEvent = 1,
            OnCustomEvent = 2,
        }

        [FieldAttr(nst: 40)] public bool _IsFallLandGroundCastOn;
        [FieldAttr(nst: 44)] public EigEaseType _JumpToZPositionEaseType;
        [FieldAttr(nst: 48)] public EigEaseType _FallToZPositionEaseType;
        [FieldAttr(nst: 52)] public EigEaseType _JumpToXYPositionEaseType;
        [FieldAttr(nst: 56)] public EigEaseType _TurnEaseType;
        [FieldAttr(nst: 60)] public float _TurnEaseRatioIn;
        [FieldAttr(nst: 64)] public float _TurnEaseRatioOut;
        [FieldAttr(nst: 68)] public float _JumpToZPositionEaseRatioIn;
        [FieldAttr(nst: 72)] public float _JumpToZPositionEaseRatioOut;
        [FieldAttr(nst: 76)] public float _JumpToXYPositionEaseRatioIn;
        [FieldAttr(nst: 80)] public float _JumpToXYPositionEaseRatioOut;
        [FieldAttr(nst: 84)] public float _FallToZPositionEaseRatioIn;
        [FieldAttr(nst: 88)] public float _FallToZPositionEaseRatioOut;
        [FieldAttr(nst: 96)] public string? _BehaviorEventJumpStart = null;
        [FieldAttr(nst: 104)] public string? _BehaviorEventFallStart = null;
        [FieldAttr(nst: 112)] public string? _BehaviorEventFallLand = null;
        [FieldAttr(nst: 120)] public string? _BehaviorStateMachineJump = null;
        [FieldAttr(nst: 128)] public string? _BehaviorStateJumpStart = null;
        [FieldAttr(nst: 136)] public string? _BehaviorStateFall = null;
        [FieldAttr(nst: 144)] public string? _String = null;
        [FieldAttr(nst: 152)] public ENewEnum7_id_i6t67tyq _NewEnum7_id_i6t67tyq;
    }
}
