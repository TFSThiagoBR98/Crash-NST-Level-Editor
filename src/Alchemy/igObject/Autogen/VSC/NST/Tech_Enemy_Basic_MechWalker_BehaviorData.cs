namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 4, metaType: typeof(CVscComponentData))]
    public class Tech_Enemy_Basic_MechWalker_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
        [FieldAttr(nst: 80)] public igHandleMetaField _Entity_Data = new();
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public string? _String_0x60 = null;
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
        [FieldAttr(nst: 112)] public string? _String_0x70 = null;
        [FieldAttr(nst: 120)] public float _Float_0x78;
        [FieldAttr(nst: 124)] public igVec3fMetaField _Vec_3F_0x7c = new();
        [FieldAttr(nst: 136)] public igVec3fMetaField _Vec_3F_0x88 = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _Bolt_Point_0xa0 = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Bolt_Point_0xa8 = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _Bolt_Point_0xb8 = new();
    }
}
