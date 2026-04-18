namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class T114_Sewer_Speedway_barrel_SFXData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(ctr: 48)] public float _Float_0x30;
        [FieldAttr(ctr: 52)] public float _Float_0x34;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound_0x38 = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _Sound_0x40 = new();
        [FieldAttr(ctr: 72)] public string? _String = null;
    }
}
