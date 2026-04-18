namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Animation_GateData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _CloseGateTriggerVolume = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _OpenGateTriggerVolume_0x30 = new();
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _OpenGateTriggerVolume_0x48 = new();
        [FieldAttr(nst: 80)] public bool _Bool;
        [FieldAttr(nst: 88)] public igHandleMetaField _Sound_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Sound_0x60 = new();
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
    }
}
