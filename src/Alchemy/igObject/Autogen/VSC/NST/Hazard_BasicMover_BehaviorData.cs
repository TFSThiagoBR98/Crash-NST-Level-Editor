namespace Alchemy
{
    [ObjectAttr(nst: 256, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_BasicMover_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _UseSoftPosReset;
        [FieldAttr(nst: 41)] public bool _UseSpline;
        [FieldAttr(nst: 42)] public bool _UseInitDelay;
        [FieldAttr(nst: 43)] public bool _isLooping_0x2b;
        [FieldAttr(nst: 44)] public float _ReturnEaseIn;
        [FieldAttr(nst: 48)] public float _ReturnDuration;
        [FieldAttr(nst: 52)] public float _ReturnEaseOut;
        [FieldAttr(nst: 56)] public float _MovementDuration;
        [FieldAttr(nst: 60)] public float _EaseOut;
        [FieldAttr(nst: 64)] public float _ReturnDelay;
        [FieldAttr(nst: 68)] public float _InitialDelay;
        [FieldAttr(nst: 72)] public float _WarningDuration;
        [FieldAttr(nst: 76)] public float _EaseIn;
        [FieldAttr(nst: 80)] public float _IdleDuration;
        [FieldAttr(nst: 88)] public igHandleMetaField _Return_Sfx = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Idle_Sfx = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Warning_Sfx = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Movement_Sfx = new();
        [FieldAttr(nst: 120)] public string? _Settle = null;
        [FieldAttr(nst: 128)] public string? _Warning = null;
        [FieldAttr(nst: 136)] public string? _Return = null;
        [FieldAttr(nst: 144)] public string? _Movement = null;
        [FieldAttr(nst: 152)] public igVec3fMetaField _MovementOffset = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Return_Vfx = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Movement_Vfx = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _Warning_Vfx_0xb8 = new();
        [FieldAttr(nst: 192)] public igHandleMetaField _Idle_Vfx = new();
        [FieldAttr(nst: 200)] public bool _Bool_0xc8;
        [FieldAttr(nst: 208)] public igHandleMetaField _Warning_Vfx_0xd0 = new();
        [FieldAttr(nst: 216)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 224)] public bool _isLooping_0xe0;
        [FieldAttr(nst: 225)] public bool _Bool_0xe1;
        [FieldAttr(nst: 232)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 240)] public bool _Bool_0xf0;
        [FieldAttr(nst: 248)] public igHandleMetaField _Vfx_Effect = new();
    }
}
