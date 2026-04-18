namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Attack_Player_Timed_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsTellLooping;
        [FieldAttr(nst: 41)] public bool _UseTellDelay;
        [FieldAttr(nst: 44)] public float _TellDuration;
        [FieldAttr(nst: 48)] public float _DefaultDelay;
        [FieldAttr(nst: 52)] public float _InitialDelay;
        [FieldAttr(nst: 56)] public float _AttackDelay;
        [FieldAttr(nst: 64)] public string? _Tell = null;
        [FieldAttr(nst: 72)] public string? _Attack = null;
        [FieldAttr(nst: 80)] public string? _Idle = null;
        [FieldAttr(nst: 88)] public string? _CrashDeath = null;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 100)] public float _Float_0x64;
        [FieldAttr(nst: 104)] public bool _Bool;
        [FieldAttr(nst: 108)] public float _Float_0x6c;
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 116)] public float _Float_0x74;
    }
}
