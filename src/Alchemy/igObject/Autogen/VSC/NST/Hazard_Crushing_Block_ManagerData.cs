namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Crushing_Block_ManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _CameraShake;
        [FieldAttr(nst: 44)] public float _ShakeMagnitude;
        [FieldAttr(nst: 48)] public float _ShakeDuration;
        [FieldAttr(nst: 52)] public float _ShakeSpeed;
        [FieldAttr(nst: 56)] public string? _DeathState = null;
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_0x48 = new();
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public bool _Bool_0x54;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public igHandleMetaField _Entity_0x60 = new();
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 112)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 136)] public bool _Bool_0x88;
    }
}
