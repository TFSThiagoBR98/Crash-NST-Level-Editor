namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Offset_Attack_OnEnter_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _UseTellDelay;
        [FieldAttr(nst: 41)] public bool _ResetOnExit;
        [FieldAttr(nst: 42)] public bool _IsTellLooping;
        [FieldAttr(nst: 43)] public bool _ResetAfterAttack;
        [FieldAttr(nst: 44)] public float _TellDuration;
        [FieldAttr(nst: 48)] public float _ResetDuration;
        [FieldAttr(nst: 52)] public float _MoveToOriginDuration;
        [FieldAttr(nst: 56)] public float _ExitResetDelay;
        [FieldAttr(nst: 60)] public float _RotateDelay;
        [FieldAttr(nst: 64)] public float _AttackResetDelay;
        [FieldAttr(nst: 72)] public string? _Tell = null;
        [FieldAttr(nst: 80)] public string? _Attack_0x50 = null;
        [FieldAttr(nst: 88)] public string? _Idle = null;
        [FieldAttr(nst: 96)] public string? _Ascending = null;
        [FieldAttr(nst: 104)] public igVec3fMetaField _Offset_Vector3 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Tell_Vfx_Effect = new();
        [FieldAttr(nst: 128)] public bool _Bool_0x80;
        [FieldAttr(nst: 136)] public string? _Attack_0x88 = null;
        [FieldAttr(nst: 144)] public bool _Bool_0x90;
        [FieldAttr(nst: 148)] public float _Float_0x94;
        [FieldAttr(nst: 152)] public float _Float_0x98;
        [FieldAttr(nst: 156)] public bool _Bool_0x9c;
    }
}
