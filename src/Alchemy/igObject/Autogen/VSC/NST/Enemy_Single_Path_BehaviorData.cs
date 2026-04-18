namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Single_Path_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _JumpWhenStopped;
        [FieldAttr(nst: 41)] public bool _AttachOnStart;
        [FieldAttr(nst: 42)] public bool _SpinWhenStopped;
        [FieldAttr(nst: 43)] public bool _SpinWhenMoving;
        [FieldAttr(nst: 44)] public bool _JumpWhenMoving;
        [FieldAttr(nst: 45)] public bool _TrackPlayerPosition;
        [FieldAttr(nst: 48)] public igHandleMetaField _splineLane = new();
        [FieldAttr(nst: 56)] public float _Speed;
        [FieldAttr(nst: 60)] public float _EndDelay;
        [FieldAttr(nst: 64)] public float _ClampDistance;
        [FieldAttr(nst: 72)] public string? _Despawn = null;
        [FieldAttr(nst: 80)] public string? _WalkForward = null;
        [FieldAttr(nst: 88)] public string? _Spawn = null;
        [FieldAttr(nst: 96)] public igHandleMetaField _PatrolEntity = new();
        [FieldAttr(nst: 104)] public bool _Bool_0x68;
        [FieldAttr(nst: 105)] public bool _Bool_0x69;
    }
}
