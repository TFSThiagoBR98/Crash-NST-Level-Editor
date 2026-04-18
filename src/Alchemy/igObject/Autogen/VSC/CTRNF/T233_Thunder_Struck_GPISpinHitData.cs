namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class T233_Thunder_Struck_GPISpinHitData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float_0x20;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Component_Data = new();
        [FieldAttr(ctr: 48)] public float _Float_0x30;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _Sound_0x48 = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _Sound_0x50 = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Rumble_Data = new();
    }
}
