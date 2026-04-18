namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class common_C3_IntroSequenceData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _BehaviorEventCrashIntro = null;
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 68)] public bool _Bool;
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_0x50 = new();
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 92)] public float _Float_0x5c;
        [FieldAttr(nst: 96)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Game_Int_Variable = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Entity_0x70 = new();
        [FieldAttr(nst: 120)] public float _Float_0x78;
    }
}
