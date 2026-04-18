namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_OrientCameraSwitchData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Camera_Base_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Camera_Base_0x30 = new();
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
    }
}
