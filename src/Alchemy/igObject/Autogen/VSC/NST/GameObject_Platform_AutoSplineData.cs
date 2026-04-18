namespace Alchemy
{
    [ObjectAttr(nst: 176, align: 4, metaType: typeof(CVscComponentData))]
    public class GameObject_Platform_AutoSplineData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _StartSplineForward;
        [FieldAttr(nst: 41)] public bool _KillOnFinish;
        [FieldAttr(nst: 42)] public bool _AutoLoopSpline;
        [FieldAttr(nst: 43)] public bool _MoveAnimLooping;
        [FieldAttr(nst: 44)] public bool _PlaySplineOnContact;
        [FieldAttr(nst: 48)] public EigEaseType _TellEaseType;
        [FieldAttr(nst: 52)] public float _TellEase;
        [FieldAttr(nst: 56)] public float _TellBobDuration;
        [FieldAttr(nst: 60)] public float _StartingRatio;
        [FieldAttr(nst: 64)] public float _TellDisplacement;
        [FieldAttr(nst: 68)] public float _TurnDelay;
        [FieldAttr(nst: 72)] public float _TellDelay;
        [FieldAttr(nst: 80)] public igHandleMetaField _Turn_Delay_Float_List = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _MoveSound = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _IdleSound = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _TellSound = new();
        [FieldAttr(nst: 112)] public string? _TellAnimation = null;
        [FieldAttr(nst: 120)] public string? _MoveAnimation = null;
        [FieldAttr(nst: 128)] public string? _IdleAnimation = null;
        [FieldAttr(nst: 136)] public igHandleMetaField _MoveVFX = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _IdleVFX = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _TellVFX = new();
        [FieldAttr(nst: 160)] public bool _Bool_0xa0;
        [FieldAttr(nst: 164)] public float _Float;
        [FieldAttr(nst: 168)] public bool _Bool_0xa8;
    }
}
