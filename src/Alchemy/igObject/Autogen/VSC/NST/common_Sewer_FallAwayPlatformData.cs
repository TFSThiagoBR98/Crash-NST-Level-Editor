namespace Alchemy
{
    [ObjectAttr(nst: 248, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Sewer_FallAwayPlatformData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Reset_0x28;
        [FieldAttr(nst: 44)] public float _TellEase;
        [FieldAttr(nst: 48)] public bool _UseTrigger;
        [FieldAttr(nst: 56)] public igHandleMetaField _TellSound = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _TellVFX = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _DropVFX = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _DropSound = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _ResetSound = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _ResetVFX = new();
        [FieldAttr(nst: 104)] public float _ResetDelay;
        [FieldAttr(nst: 108)] public float _DurationUp;
        [FieldAttr(nst: 112)] public string? _TellAnimation = null;
        [FieldAttr(nst: 120)] public string? _IdleAnimation = null;
        [FieldAttr(nst: 128)] public float _EaseDuration;
        [FieldAttr(nst: 132)] public float _DropOffest;
        [FieldAttr(nst: 136)] public string? _DropAnimation = null;
        [FieldAttr(nst: 144)] public string? _ResetAnimation = null;
        [FieldAttr(nst: 152)] public float _DurationDown;
        [FieldAttr(nst: 156)] public float _JumpVFXDelay;
        [FieldAttr(nst: 160)] public bool _Bool_0xa0;
        [FieldAttr(nst: 161)] public bool _HideOnDropFinish_0xa1;
        [FieldAttr(nst: 164)] public float _TellBobDuration;
        [FieldAttr(nst: 168)] public bool _HideOnDropFinish_0xa8;
        [FieldAttr(nst: 169)] public bool _DropAnimLooping;
        [FieldAttr(nst: 172)] public float _TellDisplacement;
        [FieldAttr(nst: 176)] public bool _ResetAnimLooping;
        [FieldAttr(nst: 180)] public float _Float_0xb4;
        [FieldAttr(nst: 184)] public float _DurationBeforeFall;
        [FieldAttr(nst: 188)] public EigEaseType _EaseType;
        [FieldAttr(nst: 192)] public bool _Bool_0xc0;
        [FieldAttr(nst: 196)] public EigEaseType _TellEaseType;
        [FieldAttr(nst: 200)] public igHandleMetaField _JumpContact_Vfx_Effect = new();
        [FieldAttr(nst: 208)] public bool _Reset_0xd0;
        [FieldAttr(nst: 209)] public bool _Bool_0xd1;
        [FieldAttr(nst: 212)] public float _Float_0xd4;
        [FieldAttr(nst: 216)] public float _Float_0xd8;
        [FieldAttr(nst: 224)] public igHandleMetaField _Spline_Event_0xe0 = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _Spline_Event_0xe8 = new();
        [FieldAttr(nst: 240)] public bool _Bool_0xf0;
        [FieldAttr(nst: 244)] public float _Float_0xf4;
    }
}
