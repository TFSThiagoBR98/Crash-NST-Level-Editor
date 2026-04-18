namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class common_ChaseActivated_FallAwayPlatformsData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 48)] public float _TellBobDuration;
        [FieldAttr(nst: 52)] public float _TellDisplacement;
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public EigEaseType _TellEaseType;
        [FieldAttr(nst: 64)] public float _TellEase;
        [FieldAttr(nst: 72)] public igHandleMetaField _TellSound = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _TellVFX = new();
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 112)] public float _DurationDown;
        [FieldAttr(nst: 116)] public EigEaseType _EaseType;
        [FieldAttr(nst: 120)] public float _EaseDuration;
        [FieldAttr(nst: 124)] public float _DropOffest;
    }
}
