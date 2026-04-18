namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Entity_Remove_On_Attack_AttemptData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 56)] public bool _Bool_0x38;
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 80)] public bool _Bool_0x50;
        [FieldAttr(nst: 88)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 96)] public string? _String_0x60 = null;
        [FieldAttr(nst: 104)] public bool _Bool_0x68;
        [FieldAttr(nst: 108)] public float _Float_0x6c;
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 116)] public float _Float_0x74;
        [FieldAttr(nst: 120)] public float _Float_0x78;
    }
}
