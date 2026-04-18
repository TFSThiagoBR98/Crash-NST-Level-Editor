namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class T151_NGin_Labs_EAP_Mine_BarrellData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float_0x20;
        [FieldAttr(ctr: 36)] public bool _Bool;
        [FieldAttr(ctr: 40)] public string? _String_0x28 = null;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Sound = new();
        [FieldAttr(ctr: 56)] public float _Float_0x38;
        [FieldAttr(ctr: 64)] public string? _String_0x40 = null;
        [FieldAttr(ctr: 72)] public float _Float_0x48;
        [FieldAttr(ctr: 76)] public float _Float_0x4c;
        [FieldAttr(ctr: 80)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _Bolt_Point = new();
    }
}
