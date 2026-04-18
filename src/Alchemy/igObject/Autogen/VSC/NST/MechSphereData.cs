namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class MechSphereData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bool;
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(nst: 56)] public float _Float;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
        [FieldAttr(nst: 80)] public igHandleMetaField _Bolt_Point_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _igEntity = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Bolt_Point_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Vfx_Effect_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Bolt_Point_0x78 = new();
    }
}
