namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class T503_September_Spyro_CastleDoor_OpenData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float_0x20;
        [FieldAttr(ctr: 40)] public string? _String = null;
        [FieldAttr(ctr: 48)] public float _Float_0x30;
        [FieldAttr(ctr: 52)] public float _Float_0x34;
        [FieldAttr(ctr: 56)] public igHandleMetaField _Sound = new();
    }
}
