namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Factory_Gate_RaisingData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _OpenGateTriggerVolume = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _CloseGateTriggerVolume = new();
        [FieldAttr(nst: 56)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 68)] public float _Float_0x44;
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 80)] public igHandleMetaField _Sound_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Sound_0x58 = new();
    }
}
