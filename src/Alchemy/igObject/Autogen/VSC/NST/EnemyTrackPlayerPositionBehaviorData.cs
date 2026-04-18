namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 4, metaType: typeof(CVscComponentData))]
    public class EnemyTrackPlayerPositionBehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _HurtPlayerWhileFlipped;
        [FieldAttr(nst: 41)] public bool _HurtPlayerAfterFlipped;
        [FieldAttr(nst: 48)] public igHandleMetaField _splineLane = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _PatrolEntity = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _TriggerVolumeEntity = new();
        [FieldAttr(nst: 72)] public float _ClampDistance;
        [FieldAttr(nst: 76)] public float _FlippedTimer;
        [FieldAttr(nst: 80)] public float _PatrolDelay;
        [FieldAttr(nst: 88)] public string? _WalkBack = null;
        [FieldAttr(nst: 96)] public string? _TurnForwardToBack = null;
        [FieldAttr(nst: 104)] public string? _TurnBackToFront = null;
        [FieldAttr(nst: 112)] public string? _BounceInitial = null;
        [FieldAttr(nst: 120)] public string? _WalkForward = null;
        [FieldAttr(nst: 128)] public string? _JumpBounce = null;
        [FieldAttr(nst: 136)] public string? _BounceRecover = null;
        [FieldAttr(nst: 144)] public string? _BounceIdle = null;
        [FieldAttr(nst: 152)] public string? _BounceRecoverTell = null;
        [FieldAttr(nst: 160)] public float _Float;
        [FieldAttr(nst: 168)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xa8 = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0xb0 = new();
        [FieldAttr(nst: 184)] public bool _Bool_0xb8;
        [FieldAttr(nst: 185)] public bool _Bool_0xb9;
        [FieldAttr(nst: 186)] public bool _Bool_0xba;
        [FieldAttr(nst: 187)] public bool _Bool_0xbb;
    }
}
