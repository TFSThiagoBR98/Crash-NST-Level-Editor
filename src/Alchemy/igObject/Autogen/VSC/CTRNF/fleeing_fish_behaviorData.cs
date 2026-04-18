namespace Alchemy
{
    [ObjectAttr(ctr: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class fleeing_fish_behaviorData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public float _Float_0x20;
        [FieldAttr(ctr: 36)] public float _Float_0x24;
        [FieldAttr(ctr: 40)] public bool _Bool_0x28;
        [FieldAttr(ctr: 44)] public float _Float_0x2c;
        [FieldAttr(ctr: 48)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Spline_Event_0x38 = new();
        [FieldAttr(ctr: 64)] public string? _String_0x40 = null;
        [FieldAttr(ctr: 72)] public float _Float_0x48;
        [FieldAttr(ctr: 76)] public bool _Bool_0x4c;
        [FieldAttr(ctr: 80)] public float _Float_0x50;
        [FieldAttr(ctr: 88)] public igHandleMetaField _Spline_Event_0x58 = new();
        [FieldAttr(ctr: 96)] public string? _String_0x60 = null;
        [FieldAttr(ctr: 104)] public igHandleMetaField _Spline_Event_0x68 = new();
        [FieldAttr(ctr: 112)] public string? _String_0x70 = null;
    }
}
