namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 4, metaType: typeof(CVscComponentData))]
    public class Castle_Enemy_Electric_LabAssistant_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _TakeHitDelay;
        [FieldAttr(nst: 44)] public float _Range;
        [FieldAttr(nst: 48)] public float _StartingRatio;
        [FieldAttr(nst: 52)] public float _StartThreshold;
        [FieldAttr(nst: 56)] public igHandleMetaField _SplineAttachBehaviorVariable_id_2bbhj85d_variable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _SplineRotationMoverVariable_id_pbydg16p_variable = new();
        [FieldAttr(nst: 72)] public string? _SpinDeath = null;
        [FieldAttr(nst: 80)] public string? _TakeHit001 = null;
        [FieldAttr(nst: 88)] public string? _Idle = null;
        [FieldAttr(nst: 96)] public string? _Fall001 = null;
        [FieldAttr(nst: 104)] public string? _Walk_0x68 = null;
        [FieldAttr(nst: 112)] public float _FloatVariable;
        [FieldAttr(nst: 120)] public igHandleMetaField _SplineVelocityMover = new();
        [FieldAttr(nst: 128)] public bool _Bool;
        [FieldAttr(nst: 136)] public string? _Walk_0x88 = null;
        [FieldAttr(nst: 144)] public float _Float_0x90;
        [FieldAttr(nst: 148)] public float _Float_0x94;
        [FieldAttr(nst: 152)] public float _Float_0x98;
    }
}
