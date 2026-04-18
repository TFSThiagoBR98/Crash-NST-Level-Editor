namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Bolt_On_HazardData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public bool _Bool_0x48;
        [FieldAttr(nst: 73)] public bool _Bool_0x49;
        [FieldAttr(nst: 74)] public bool _Bool_0x4a;
        [FieldAttr(nst: 75)] public bool _Bool_0x4b;
    }
}
