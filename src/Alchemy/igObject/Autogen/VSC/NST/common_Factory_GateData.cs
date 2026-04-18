namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Factory_GateData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _OpenGateTriggerVolume = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _CloseGateTriggerVolume = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _OpenGateTriggerVolume_BackEntrance = new();
        [FieldAttr(nst: 64)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public igHandleMetaField _Sound_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Sound_0x68 = new();
    }
}
