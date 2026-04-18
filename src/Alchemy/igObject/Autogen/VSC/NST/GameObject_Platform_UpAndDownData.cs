namespace Alchemy
{
    [ObjectAttr(nst: 224, align: 4, metaType: typeof(CVscComponentData))]
    public class GameObject_Platform_UpAndDownData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Start_Lowered;
        [FieldAttr(nst: 41)] public bool _Auto_Oscillate;
        [FieldAttr(nst: 42)] public bool _Start_Raised;
        [FieldAttr(nst: 43)] public bool _RaiseAnimLooping;
        [FieldAttr(nst: 44)] public bool _LowerAnimLooping;
        [FieldAttr(nst: 48)] public EigEaseType _EaseType;
        [FieldAttr(nst: 52)] public EigEaseType _TellEaseType;
        [FieldAttr(nst: 56)] public float _TellBobDuration;
        [FieldAttr(nst: 60)] public float _TellEase;
        [FieldAttr(nst: 64)] public float _EaseDuration;
        [FieldAttr(nst: 68)] public float _Offest;
        [FieldAttr(nst: 72)] public float _DurationUp;
        [FieldAttr(nst: 76)] public float _DurationDown;
        [FieldAttr(nst: 80)] public float _LowerDelay;
        [FieldAttr(nst: 84)] public float _StartDelay;
        [FieldAttr(nst: 88)] public float _RaiseDelay;
        [FieldAttr(nst: 92)] public float _TellDisplacement;
        [FieldAttr(nst: 96)] public igHandleMetaField _TellSound = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _RaiseSound = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _LowerSound = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _LowerEvent001 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _LowerEvent = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _RaiseEvent = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _RaiseEvent001 = new();
        [FieldAttr(nst: 152)] public string? _RaiseAnimation = null;
        [FieldAttr(nst: 160)] public string? _TellAnimation = null;
        [FieldAttr(nst: 168)] public string? _LowerAnimation = null;
        [FieldAttr(nst: 176)] public igHandleMetaField _TellVFX = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _LowerVFX = new();
        [FieldAttr(nst: 192)] public igHandleMetaField _RaiseVFX = new();
        [FieldAttr(nst: 200)] public bool _Bool_0xc8;
        [FieldAttr(nst: 204)] public float _Float_0xcc;
        [FieldAttr(nst: 208)] public float _Float_0xd0;
        [FieldAttr(nst: 212)] public float _Float_0xd4;
        [FieldAttr(nst: 216)] public float _Float_0xd8;
        [FieldAttr(nst: 220)] public bool _Bool_0xdc;
    }
}
