namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class Plane_Enemy_Blimp_CharacterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Vfx_Effect_0x28 = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Vfx_Effect_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect_0x58 = new();
    }
}
