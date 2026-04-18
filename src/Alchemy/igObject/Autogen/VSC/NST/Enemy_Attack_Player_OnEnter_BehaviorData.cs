namespace Alchemy
{
    [ObjectAttr(nst: 176, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Attack_Player_OnEnter_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsTellLooping;
        [FieldAttr(nst: 41)] public bool _UseTellDelay;
        [FieldAttr(nst: 44)] public float _TellDuration;
        [FieldAttr(nst: 48)] public float _AttackDelay;
        [FieldAttr(nst: 56)] public string? _Tell = null;
        [FieldAttr(nst: 64)] public string? _Attack_0x40 = null;
        [FieldAttr(nst: 72)] public string? _Idle = null;
        [FieldAttr(nst: 80)] public string? _CrashDeath = null;
        [FieldAttr(nst: 88)] public bool _Bool_0x58;
        [FieldAttr(nst: 92)] public float _Float_0x5c;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 104)] public string? _Attack_0x68 = null;
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 116)] public float _Float_0x74;
        [FieldAttr(nst: 120)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 136)] public bool _Bool_0x88;
        [FieldAttr(nst: 137)] public bool _Bool_0x89;
        [FieldAttr(nst: 140)] public float _FloatVariable_id_jgwd7fvw_variable;
        [FieldAttr(nst: 144)] public bool _Bool_0x90;
        [FieldAttr(nst: 152)] public string? _String_0x98 = null;
        [FieldAttr(nst: 160)] public string? _String_0xa0 = null;
        [FieldAttr(nst: 168)] public string? _String_0xa8 = null;
    }
}
