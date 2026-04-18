namespace Alchemy
{
    [ObjectAttr(nst: 184, align: 4, metaType: typeof(CVscComponentData))]
    public class Common_Enemy_Shooting_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _LookAtTarget;
        [FieldAttr(nst: 48)] public igHandleMetaField _ProjectileData = new();
        [FieldAttr(nst: 56)] public float _FireRate;
        [FieldAttr(nst: 60)] public float _AttackDuration;
        [FieldAttr(nst: 64)] public float _LookAtTime;
        [FieldAttr(nst: 68)] public float _InitialDelay;
        [FieldAttr(nst: 72)] public float _AttackRange;
        [FieldAttr(nst: 76)] public int _FiringPoints;
        [FieldAttr(nst: 80)] public string? _Attack = null;
        [FieldAttr(nst: 88)] public string? _TauntStart = null;
        [FieldAttr(nst: 96)] public string? _TauntLoop = null;
        [FieldAttr(nst: 104)] public string? _TauntEnd = null;
        [FieldAttr(nst: 112)] public igVec3fMetaField _FiringPosition2 = new();
        [FieldAttr(nst: 124)] public igVec3fMetaField _FiringPosition1 = new();
        [FieldAttr(nst: 136)] public string? _String_0x88 = null;
        [FieldAttr(nst: 144)] public string? _String_0x90 = null;
        [FieldAttr(nst: 152)] public bool _Bool;
        [FieldAttr(nst: 160)] public igHandleMetaField _Bolt_Point_0xa0 = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Bolt_Point_0xa8 = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Vfx_Effect = new();
    }
}
