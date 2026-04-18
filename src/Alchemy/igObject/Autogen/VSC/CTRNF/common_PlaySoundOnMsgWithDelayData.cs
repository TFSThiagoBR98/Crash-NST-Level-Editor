namespace Alchemy
{
    [ObjectAttr(ctr: 144, align: 4, metaType: typeof(CVscComponentData))]
    public class common_PlaySoundOnMsgWithDelayData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float_0x20;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Sound_0x28 = new();
        [FieldAttr(ctr: 48)] public float _Float_0x30;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(ctr: 64)] public float _Float_0x40;
        [FieldAttr(ctr: 72)] public igHandleMetaField _Sound_0x48 = new();
        [FieldAttr(ctr: 80)] public float _Float_0x50;
        [FieldAttr(ctr: 88)] public igHandleMetaField _Sound_0x58 = new();
        [FieldAttr(ctr: 96)] public float _Float_0x60;
        [FieldAttr(ctr: 104)] public igHandleMetaField _Sound_0x68 = new();
        [FieldAttr(ctr: 112)] public string? _String = null;
        [FieldAttr(ctr: 120)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(ctr: 128)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 136)] public bool _Bool;
    }
}
