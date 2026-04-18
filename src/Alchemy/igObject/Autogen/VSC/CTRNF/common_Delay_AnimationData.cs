namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Delay_AnimationData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float_0x20;
        [FieldAttr(ctr: 36)] public bool _Bool_0x24;
        [FieldAttr(ctr: 40)] public float _Float_0x28;
        [FieldAttr(ctr: 44)] public float _Float_0x2c;
        [FieldAttr(ctr: 48)] public string? _String_0x30 = null;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 64)] public string? _String_0x40 = null;
        [FieldAttr(ctr: 72)] public float _Float_0x48;
        [FieldAttr(ctr: 76)] public bool _Bool_0x4c;
    }
}
